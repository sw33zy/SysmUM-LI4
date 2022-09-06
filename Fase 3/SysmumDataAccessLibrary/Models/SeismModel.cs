using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysmumDataAccessLibrary.Models
{
        public class SeismModel
        {
            public float? magnitude { get; set; } = 0;
            public string place { get; set; } = "";
            public string id { get; set; } = "";
            public float? radius { get; set; } = 0;
            public int significance { get; set; } = 0;
            public float latitude { get; set; } = 0;
            public float longitude { get; set; } = 0;
            public long time { get; set; } = 0;
            public DateTime dateSeism { get; set; }
    }
}
