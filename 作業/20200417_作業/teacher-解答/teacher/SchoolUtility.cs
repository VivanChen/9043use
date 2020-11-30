using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher
{
    public static class SchoolUtility
    {
        public static List<School> GetAllSchool()
        {
            List<string> strSchoolList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();
            strSchoolList.RemoveAt(0);

            List<School> newSchoolList = new List<School>();

            foreach (string item in strSchoolList)
            {
                string[] itemArray = item.Split(',');

                newSchoolList.Add(new School()
                {
                    Type = itemArray[0],
                    SchoolName = itemArray[1],
                    PostalCode = itemArray[2],
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
