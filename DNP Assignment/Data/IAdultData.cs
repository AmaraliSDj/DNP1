using System.Collections.Generic;
using Models;

namespace DNP_Assignment.Data
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();

        void AddAdults(Adult adult);

        void RemoveAdults(int adultId);

        void Update(Adult adult);

        Adult Get(int id);








    }
}