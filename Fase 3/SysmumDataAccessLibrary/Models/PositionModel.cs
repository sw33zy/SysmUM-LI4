using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysmumDataAccessLibrary.Models
{
    public class PositionModel
    {
        public int id { get; set; }
        
        public float latitude { get; set; }
        
        public float longitude { get; set; }
    }
}
