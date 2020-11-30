using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw
{
    public class school
    {
        public string Type;
        public string SchoolName;
        public string Postal;
        public string Address;
        public string Telephone;
        public string Lat;
        public string Lon;

        public string GetInfo()
        {
            return $"{Type}, {SchoolName}, {Postal}, {Address}, {Telephone}, {Lat}, {Lon}";
        }
    }
}
