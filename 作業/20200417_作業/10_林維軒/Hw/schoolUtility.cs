using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw
{
    public static class schoolUtility
    {
        public static List<school> GetAllSchool()//還沒打完
        {
            List<string> StrSchoolList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();
            StrSchoolList.RemoveAt(0);

            List<school> newSchoolList = new List<school>();

            foreach (string item in StrSchoolList)
            {
                string[] itemArray = item.Split(',');

                newSchoolList.Add(new school()
                {
                    Type = itemArray[0],
                    SchoolName = itemArray[1],
                    Postal = itemArray[2],
                    Address = itemArray[3],
                    Telephone = itemArray[4],
                    Lat = itemArray[5],
                    Lon = itemArray[6]
                });
            }
            return newSchoolList;
        }
    }
}
