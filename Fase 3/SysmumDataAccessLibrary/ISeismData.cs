using System.Threading.Tasks;
using SysmumDataAccessLibrary.Models;

namespace SysmumDataAccessLibrary
{
    public interface ISeismData
    {
        Task<System.Collections.Generic.List<SeismModel>> GetSeisms();
        Task InsertSeism(SeismModel seism);
    }
}