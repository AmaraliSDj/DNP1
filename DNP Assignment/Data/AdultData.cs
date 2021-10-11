using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace DNP_Assignment.Data
{
    public class AdultData : IAdultData
    {

      
        private FileContext adultFileContext;

        public AdultData()
        {

            adultFileContext = new FileContext();

        }

       

        public IList<Adult> GetAdults()
        {
           
            return adultFileContext.Adults;
            
        }

        public void AddAdults(Adult adult)
        {
            int max = adultFileContext.Adults.Max(adult => adult.Id);
            adult.Id =(++max);
            adultFileContext.Adults.Add(adult);
            adultFileContext.SaveChanges();
        }

        public void RemoveAdults(int adultId)
        {
            
            Adult toRemove = adultFileContext.Adults.First(a => a.Id == adultId);
            adultFileContext.Adults.Remove(toRemove);
            adultFileContext.SaveChanges();
        }

        public void Update(Adult adult)
        {
            adultFileContext.Update(adult);
        }

        public Adult Get(int id)
        {
            return adultFileContext.Adults.FirstOrDefault(a => a.Id == id);
        }
    }
}