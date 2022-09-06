using SysmumDataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SysmumDataAccessLibrary
{
    public interface IPositionData
    {
        int GetPositionId();
        void IncrementPositionId();
        Task<List<PositionModel>> GetPositions();
        Task InsertPosition(PositionModel position);
    }
}