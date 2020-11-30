using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher
{
    public class School
    {
        public string Type { get; set; }
        public string SchoolName { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }

        public string GetInfo()
        {
            return $"{Type},{SchoolName},{PostalCode},{Address},{Telephone},{Lat},{Lon}";
        }
    }
}
