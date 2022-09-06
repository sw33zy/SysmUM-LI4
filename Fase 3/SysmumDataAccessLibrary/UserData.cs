using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysmumDataAccessLibrary.Models;

namespace SysmumDataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly IDataAccess _db;
        public UserData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<UserSysmumModel>> getUser(UserSysmumModel user)
        {
            string sql = "SELECT * FROM dbo.UserSysmum WHERE username = @username";

            return _db.LoadData<UserSysmumModel, dynamic>(sql, user);
        }

        public Task InsertUser(UserSysmumModel user)
        {
            string sql = @"INSERT INTO dbo.UserSysmum (username, password, name, email, alarmRadius, alarmMagnitude, latitude, longitude)
                           VALUES (@username, @password, @name, @email, 0, 0, 0, 0)";

            return _db.SaveData(sql, user);
        }

        public Task UpdateUser(UserSysmumModel user)
        {
            string sql = @"UPDATE dbo.UserSysmum SET password = @password, name = @name, email = @email, 
                            latitude = @latitude, longitude = @longitude, alarmMagnitude = @alarmMagnitude, alarmRadius = @alarmRadius
                            WHERE username = @username;";

            return _db.SaveData(sql, user);
        }


    }
}
