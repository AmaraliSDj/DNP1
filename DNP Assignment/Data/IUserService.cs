
using System.Threading.Tasks;

namespace DNP_Assignment.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string Password);
    }
}