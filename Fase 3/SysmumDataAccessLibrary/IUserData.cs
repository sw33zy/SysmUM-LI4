using System.Collections.Generic;
using System.Threading.Tasks;
using SysmumDataAccessLibrary.Models;

namespace SysmumDataAccessLibrary
{
    public interface IUserData
    {
        Task<List<UserSysmumModel>> getUser(UserSysmumModel useraname);
        Task InsertUser(UserSysmumModel user);

        Task UpdateUser(UserSysmumModel user);
    }
}