using SysmumDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysmumDataAccessLibrary
{
    public class PositionData : IPositionData
    {
        private readonly IDataAccess _db;
        private int counter = 0;
        public PositionData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<PositionModel>> GetPositions()
        {
            string sql = "SELECT * FROM dbo.Position";

            return _db.LoadData<PositionModel, dynamic>(sql, new { });
        }

        public Task InsertPosition(PositionModel position)
        {
            string sql = @"INSERT INTO dbo.Position (id, latitude, longitude)
                           VALUES (@id, @latitude, @longitude);";
            counter++;

            return _db.SaveData(sql, position);
        }
        public int GetPositionId()
        {
            return counter;
        }
        public void IncrementPositionId()
        {
            counter++;
        }
    }
}
