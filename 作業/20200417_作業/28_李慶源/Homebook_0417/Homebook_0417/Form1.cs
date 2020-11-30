using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homebook_0417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GetSart()        //清空listbox
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
        }

        void Getaddress(List<SchoolSoruce> soruce)      //button2的code
        {
            foreach (SchoolSoruce item in soruce)           //跑迴圈抓資料
            {
                if (item.address != textBox1.Text && textBox1.Text == string.Empty)
                {
                    MessageBox.Show("輸入錯誤! 請重新輸入");
                    break;
                }
                if (item.address.Contains(textBox1.Text))
                {

                    listBox1.Items.Add(item.GetInfo());
                }
            }

        }

        void Getnumber(List<SchoolSoruce> soruce)       //button3的code
        {
            foreach (SchoolSoruce item in soruce)         //跑迴圈抓資料
            {
                if (item.telephone == textBox2.Text)      //判斷textbox2是否這門號
                {

                    listBox1.Items.Add(item.GetInfo());
                }
                if (item.telephone != textBox2.Text && textBox2.Text == string.Empty)  //空白或沒有這門號跳出錯誤訊息
                {
                    MessageBox.Show("輸入錯誤! 請重新輸入");
                    break;
                }
            }
        }

        void Getpostal_code(List<SchoolSoruce> soruce)   //button4的code
        {
            List<string> newList = new List<string>();
            foreach (SchoolSoruce item in soruce)
            {
                if (item.address.Contains("中正區"))
                {
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_中正區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("大同區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_大同區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("中山區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_中山區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("松山區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_松山區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("大安區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_大安區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("萬華區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_萬華區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("信義區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_信義區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("士林區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_士林區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("北投區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_北投區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("內湖區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_內湖區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("南港區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_南港區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("文山區"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_文山區.csv", newList, Encoding.UTF8);
                }
                else if (item.address.Contains("八德路"))
                {
                    newList.Clear();
                    newList.Add($"{item.School},{item.School_Name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");
                    File.AppendAllLines("1080416臺北市各級學校分布圖_八德路.csv", newList, Encoding.UTF8);
                }
                else { }

            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            GetSart();         //清空listbox 內的資料
            List<SchoolSoruce> newsoruce = School.GetSchoolSoruces();    //用自訂類別取資料
            foreach (SchoolSoruce item in newsoruce)       //跑迴圈抓資料
            {
                if (item.School == comboBox1.Text)
                {

                    listBox1.Items.Add(item.GetInfo());

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetSart();   //清空listbox 內的資料
            List<SchoolSoruce> newsoruce = School.GetSchoolSoruces();    //用自訂類別取資料
            Getaddress(newsoruce);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetSart();         //清空listbox 內的資料
            List<SchoolSoruce> newsoruce = School.GetSchoolSoruces();      //用自訂類別取資料
            Getnumber(newsoruce);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<SchoolSoruce> newsoruce = School.GetSchoolSoruces();
            Getpostal_code(newsoruce);
        }
    }

    class SchoolSoruce
    {
        public string School;   //學校
        public string School_Name;  //學校名稱
        public string postal_code;  //郵政編碼
        public string address;   //地址
        public string telephone;  //電話號碼
        public string lat;   //經緯度
        public string lon;

        public string GetInfo()
        {
            return $"{School},{School_Name},{postal_code},{address},{telephone},{lat},{ lon}";
        }

    }
    static class School
    {
        public static List<SchoolSoruce> GetSchoolSoruces()
        {
            List<string> soruce = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();
            soruce.RemoveAt(0);  //刪除表頭

            List<SchoolSoruce> newsoruce = new List<SchoolSoruce>(); //產出新物件集合

            foreach (string item in soruce)
            {
                string.Join(",", soruce[0]);
                List<string> itemList = item.Split(',').ToList();  //字串轉集合

                newsoruce.Add(
                    new SchoolSoruce()
                    {
                        School = itemList[0],
                        School_Name = itemList[1],
                        postal_code = itemList[2],
                        address = itemList[3],
                        telephone = itemList[4],
                        lat = itemList[5],
                        lon = itemList[6]
                    });
            }
            return newsoruce;
        }
    }


}
