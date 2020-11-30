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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<School> schoolList = SchoolUntility.GetSchool();

            //foreach (型別 item in 集合or陣列)
            //類別也是一種型別
            foreach (School item in schoolList)
            {
                if (item.Classification.Contains(comboBox1.Text))//Contains(值) 回傳bool值
                {
                    listBox1.Items.Add(item.GetInfo());//item.GetInfo()取類別內的值

                }
            }
            //listBox1.Items.Add(comboBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //查符合關鍵字資料

            List<School> schoolList = SchoolUntility.GetSchool();
            listBox1.DataSource = null;
            listBox1.Items.Clear();//清空list

            string a = textBox1.Text;

            //schoolList每個值放進item
            //foreach (型別 item in 集合or陣列)
            foreach (School item in schoolList)
            {
                string region = item.Address.Substring(3, 3);//Substring(第四個字的索引值, 長度)

                if (a==region)
                {
                    listBox1.Items.Add(item.GetInfo());//item.GetInfo()取類別內的值
                }
                else
                {
                    MessageBox.Show("資料輸入錯誤");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //查電話

            List<School> schoolList = SchoolUntility.GetSchool();//無需建立new，加了會被擋住
            listBox1.DataSource = null;
            listBox1.Items.Clear();//清空list

            //schoolList每個值放進item
            foreach (School item in schoolList)
            {
                if (item.Telephone == textBox2.Text)
                {
                    listBox1.Items.Add(item.GetInfo());//取類別內的值
                }
                else
                {
                    MessageBox.Show("資料輸入錯誤");
                }
                
            }
        }
    }

    public class School
    {
        //public 所有程式皆可存取
        public string Classification;//在School類別中宣告一個名為Classification、型別為字串
        public string SchoolName;
        public int PostalCode;//在School類別中宣告一個名為PostalCode、型別為數值
        public string Address;
        public string Telephone;
        public string Lat;
        public string Lon;
       

        public string GetInfo()//類別內的方法
        {
            return $"{Classification},{SchoolName},{PostalCode},{Address}, {Telephone},{Lat},{Lon}";
              
        }
    }

    static class SchoolUntility
    //宣告類別
    //static 靜態類別 
    //類別名稱:Pascal Case 首字大寫
    {
        public static List<School> GetSchool() 
        {
            List<string> strSchoolList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();//讀csv檔
            strSchoolList.RemoveAt(0);  //去除表頭
            

            List<School> schoolList = new List<School>(); //準備正式的School物件集合

            foreach (string item in strSchoolList) //取出每一個產品的字串 => "國小,國立北教大實小,106,臺北市大安區龍淵里和平東路2段94號,02-2735-6186,25.0250425,121.540946"
            {
                List<string> tempList = item.Split(',').ToList();  //把每一個字串("國小,國立北教大實小,106,臺北市大安區龍淵里和平東路2段94號,02-2735-6186,25.0250425,121.540946") 
                                                                   //拆成集合
                                                                   //schoolList[0] => school
                                                                   //schoolList[1] => school_name
                                                                   //schoolList[2] => postal_code
                                                                   //schoolList[3] => address
                                                                   //schoolList[4] => telephone
                                                                   //schoolList[5] => lat
                                                                   //schoolList[6] => lon
                                                                  

                //把拆出來的字串集合成員，透過類別物件初始設定式來建立school物件實體,並且放到物件集合
                schoolList.Add(new School
                {
                    Classification = tempList[0],
                    SchoolName = tempList[1],
                    PostalCode = Convert.ToInt32(tempList[2]),
                    Address = tempList[3],
                    Telephone = tempList[4],
                    Lat = tempList[5],
                    Lon = tempList[6]
                   
                });

            }
            return schoolList;

        }
    }
}
