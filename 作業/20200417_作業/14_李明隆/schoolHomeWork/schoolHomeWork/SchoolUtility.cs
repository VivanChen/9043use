using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolHomeWork
{
    static class SchoolUtility
    {
        public delegate void SendStr(string s);
        public static SendStr SendStrDel;

        public static List<SchoolInfo> GetSchools()
        {
            List<string> readCsv = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();
            readCsv.RemoveAt(0);
            List<SchoolInfo> schoolList = new List<SchoolInfo>();

            foreach (string item in readCsv)
            {
                string[] csvSplit = item.Split(',');
                string strS = csvSplit[0];
                string strSN = csvSplit[1];
                string strPC = csvSplit[2];
                string strAdd = csvSplit[3];
                string strTel = csvSplit[4];
                string strLat = csvSplit[5];
                string strLon = csvSplit[6];

                schoolList.Add(new SchoolInfo(strS, strSN, strPC, strAdd, strTel, strLat, strLon));
            }
            return schoolList;
        }

        public static void GetSchoolInfoOrExport(SchoolInfo info, string region)
        {
            string s = $"{info.School},{info.SchoolName},{info.PostalCode},{info.Address},{info.Telephone},{info.Lat},{info.Lon}\r\n";

            if (region != "")
            {
                File.AppendAllText($"{region}.csv", s, Encoding.UTF8);
            }
            else
            {
                SendStrDel(s);
            }
        }
    }
}
