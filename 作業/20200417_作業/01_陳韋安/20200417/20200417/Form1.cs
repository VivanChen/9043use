using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolClass;


namespace _20200417
{
    public partial class Form1 : Form
    {
        List<SchoolInformation> schoolList = new List<SchoolInformation>();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Clear();
                string searchKey = comboBox1.SelectedItem.ToString();

                //從schoolList找出學校的群組後轉成集合
                var query = schoolList.GroupBy(g => g.School).Select(g => g.ToList());

                //從query的每一個群組裡尋找使用者所選擇的學校類型資料，之後將群組中符合的SchoolInfo傳給GetSchoolInfoOrExport方法來取得資料
                foreach (List<SchoolInformation> list in query)
                {
                    if (list[0].School == searchKey)
                    {
                        foreach (SchoolInformation item in list)
                        {
                            SchoolUtility.GetSchoolInfoOrExport(item, "");
                        }
                        comboBox1.SelectedItem = null;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇類型！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string region = textBox1.Text.Trim();
            bool found = false;
            //從schoolList找出區域的群後轉成集合
            var query = schoolList.GroupBy(g => g.PostalCode).Select(g => g.ToList());

            //從query的每一個群組裡將地址分析使用者輸入的資料是否一樣，之後將群組中符合的SchoolInfo傳給GetSchoolInfoOrExport方法來取得資料
            foreach (List<SchoolInformation> list in query)
            {
                string strRegion = list[0].Address.Substring(3, 3);

                if (region == strRegion)
                {
                    foreach (SchoolInformation item in list)
                    {
                        SchoolUtility.GetSchoolInfoOrExport(item, "");
                    }
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                MessageBox.Show("查無區域，請重新輸入！");
            }
            textBox1.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string phone = textBox2.Text;
            string patte = @"^02-[0-9]{4}-[0-9]{4}";
            bool check = Regex.IsMatch(phone, patte);
            bool found = false;

            //檢查使用輸入的電話格式是否正確
            if (check)
            {
                //檢查schoolList是否存在使用者所輸入的電話，之後將符合的SchoolInfo傳給GetSchoolInfoOrExport方法來取得資料
                foreach (SchoolInformation item in schoolList)
                {
                    if (item.Telephone == phone)
                    {
                        found = true;
                        SchoolUtility.GetSchoolInfoOrExport(item, "");
                        break;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("查無此號碼，請重新輸入");
                }
            }
            else
            {
                MessageBox.Show("電話號碼格式錯誤！範例：02-1234-5678");
            }
            textBox2.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            schoolList = SchoolUtility.GetSchools();

            var query1 = from s in schoolList
                         group s by s.School into sclGroup
                         select sclGroup;

            //從schoolList找出學校的群組
            var query = schoolList.GroupBy(g => g.School).Select(g => g.Key);

            //將查詢結果放入comboBox，即可看到下拉選單的學校
            foreach (var item in query)
            {
                comboBox1.Items.Add(item);
            }
            //將方法ShowText註冊委派
            SchoolUtility.SendStrDel = ShowText;


        }
        public void ShowText(string s)
        {
            listBox1.Items.Add(s);
        }


    }
}
