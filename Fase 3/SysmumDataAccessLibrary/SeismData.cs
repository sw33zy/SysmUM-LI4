using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysmumDataAccessLibrary.Models;

namespace SysmumDataAccessLibrary
{
    public class SeismData : ISeismData
    {
        private readonly IDataAccess _db;
        public SeismData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<SeismModel>> GetSeisms()
        {
            string sql = "SELECT * FROM dbo.Seism ORDER BY dateSeism DESC";

            return _db.LoadData<SeismModel, dynamic>(sql, new { });
        }

        public Task InsertSeism(SeismModel seism)
        {
            string sql = @"IF NOT EXISTS (SELECT * FROM dbo.Seism WHERE id = @id)
                            BEGIN
                            INSERT INTO dbo.Seism (id, place, magnitude,radius,significance, latitude, longitude,dateSeism)
                           VALUES (@id, @place, @magnitude, @radius,@significance,@latitude,@longitude,@dateSeism)
                            END";

            return _db.SaveData(sql, seism);
        }

    }
}