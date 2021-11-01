using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace DNP_Assignment.Data
{
    public interface IAdultData
    {
        Task<IList<Adult>> GetAdults();

        Task<Adult> AddAdults(Adult adult);

        Task RemoveAdults(int adultId);

        Task<Adult> Update(Adult adult);

        Task<Adult> Get(int id);








    }
}