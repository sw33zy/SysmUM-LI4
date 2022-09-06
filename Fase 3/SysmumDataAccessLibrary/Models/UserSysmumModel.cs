using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SysmumDataAccessLibrary.Models
{
    public class UserSysmumModel
    {
        public string username { get; set; }

        public string password { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public float alarmRadius { get; set; }

        public float alarmMagnitude { get; set; }

        public float latitude { get; set; }
        public float longitude { get; set; }
    }
}
