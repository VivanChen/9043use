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

namespace schoolHomeWork
{
    public partial class Form1 : Form
    {
        List<SchoolInfo> schoolList = new List<SchoolInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //讀CSVd檔
            schoolList = SchoolUtility.GetSchools();

            //var query1 = from s in schoolList
            //            group s by s.School into sclGroup
            //            select sclGroup;

            //從schoolList找出學校的群組
            var query = schoolList.GroupBy(g => g.School).Select(g => g.Key);

            //將查詢結果放入comboBox，即可看到下拉選單的學校
            foreach (var item in query)
            {
                comboBox_Education.Items.Add(item);
            }
            //將方法ShowText註冊委派
            SchoolUtility.SendStrDel = ShowText;
        }


        public void ShowText(string s)
        {
            listBox_Show.Items.Add(s);
        }

        private void button_Education_Click(object sender, EventArgs e)
        {
            if (comboBox_Education.SelectedItem != null)
            {
                listBox_Show.Items.Clear();
                string searchKey = comboBox_Education.SelectedItem.ToString();

                //從schoolList找出學校的群組後轉成集合
                var query = schoolList.GroupBy(g => g.School).Select(g => g.ToList());

                //從query的每一個群組裡尋找使用者所選擇的學校類型資料，之後將群組中符合的SchoolInfo傳給GetSchoolInfoOrExport方法來取得資料
                foreach (List<SchoolInfo> list in query)
                {
                    if (list[0].School == searchKey)
                    {
                        foreach (SchoolInfo item in list)
                        {
                            SchoolUtility.GetSchoolInfoOrExport(item, "");
                        }
                        comboBox_Education.SelectedItem = null;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇類型！");
            }
        }

        private void button_Region_Click(object sender, EventArgs e)
        {
            listBox_Show.Items.Clear();

            string region = textBox_Region.Text.Trim();
            bool found = false;
            //從schoolList找出區域的群後轉成集合
            var query = schoolList.GroupBy(g => g.PostalCode).Select(g => g.ToList());

            //從query的每一個群組裡將地址分析使用者輸入的資料是否一樣，之後將群組中符合的SchoolInfo傳給GetSchoolInfoOrExport方法來取得資料
            foreach (List<SchoolInfo> list in query)
            {
                string strRegion = list[0].Address.Substring(3, 3);

                if (region == strRegion)
                {
                    foreach (SchoolInfo item in list)
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
            textBox_Region.ResetText();
        }

        private void button_Tel_Click(object sender, EventArgs e)
        {
            listBox_Show.Items.Clear();
            string phone = textBox_Tel.Text;
            string patte = @"^02-[0-9]{4}-[0-9]{4}";
            bool check = Regex.IsMatch(phone, patte);
            bool found = false;

            //檢查使用輸入的電話格式是否正確
            if (check)
            {
                //檢查schoolList是否存在使用者所輸入的電話，之後將符合的SchoolInfo傳給GetSchoolInfoOrExport方法來取得資料
                foreach (SchoolInfo item in schoolList)
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
            textBox_Tel.ResetText();
        }

        private void button_Output_Click(object sender, EventArgs e)
        {
            //從schoolList找出區域群組後轉成集合
            var query = schoolList.GroupBy(p => p.PostalCode).Select(p => p.ToList());

            //將每個區域的群組輸出CSV檔
            foreach (List<SchoolInfo> list in query)
            {
                foreach (SchoolInfo info in list)
                {
                    string strRegion = info.Address.Substring(3, 3);

                    SchoolUtility.GetSchoolInfoOrExport(info, strRegion);
                }
            }
        }
    }

}
