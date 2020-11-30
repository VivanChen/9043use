using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolHomeWork
{
    class SchoolInfo
    {
        public string School, SchoolName, PostalCode, Address, Telephone, Lat, Lon;

        public SchoolInfo(string s, string sn, string pc, string add, string tel, string lat, string lon)
        {
            School = s;
            SchoolName = sn;
            PostalCode = pc;
            Address = add;
            Telephone = tel;
            Lat = lat;
            Lon = lon;
        }
    }
}
