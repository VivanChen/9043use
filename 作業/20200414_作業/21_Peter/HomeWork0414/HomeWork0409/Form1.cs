using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork0409
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Value 
            string txtBox1 = textBox1.Text;
            string txtBox2 = textBox2.Text;
            string txtBox3 = textBox3.Text;
            string headString = "產品名稱" + "," + "價格" + "," + "數量" + "," + "總價";
            #endregion
            StringBuilder sb = new StringBuilder();

            if (!File.Exists("Product.csv"))
            {

                File.WriteAllText("Product.csv", headString + "\r\n", Encoding.UTF8);
            }
            else
            {
                sb.AppendLine("File: Product.txt exit~!");
                sb.AppendLine("Processing add new Data");
                MessageBox.Show(sb.ToString());
                AppenData();
            }

            void AppenData()
            {
                #region Input Data Identify
                string errorMes = "Error~!" + "Please follow list below:";
                string errTp1 = "Can't empty";
                string errTp2 = "Can't space";
                string errTp3 = "Have to bigger than 0";


                if (txtBox1.Length == 0 || String.IsNullOrEmpty(txtBox1) || txtBox1.Trim() == "")
                {
                    MessageBox.Show(errorMes + "\r\n" + errTp1 + "\r\n" + errTp2);
                }
                else if (txtBox2.Length == 0 || String.IsNullOrEmpty(txtBox2) || txtBox2.Trim() == "")
                {
                    MessageBox.Show(errorMes + "\r\n" + errTp1 + "\r\n" + errTp2);
                }
                else if (txtBox3.Length == 0 || String.IsNullOrEmpty(txtBox3) || txtBox3.Trim() == "")
                {
                    MessageBox.Show(errorMes + "\r\n" + errTp1 + "\r\n" + errTp2);
                }
                else
                {
                    double valueBox2 = Convert.ToDouble(textBox2.Text);
                    double valueBox3 = Convert.ToDouble(textBox3.Text);
                    if (valueBox2 > 0 && valueBox3 > 0)
                    {
                        double total = valueBox2 * valueBox3;
                        string outputText = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + total + "\r\n";
                        File.AppendAllText("Product.csv", outputText);
                    }
                    else
                    {
                        MessageBox.Show(errorMes + errTp3);
                    }

                }

                #endregion

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogionFormcs loginForm = new LogionFormcs();
            loginForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> txtOfFile = File.ReadAllLines("Product.csv").ToList();
            List<string> inputContent = new List<string>();
            for (int i = 1; i < txtOfFile.Count; i++)
            {
                inputContent.Add(txtOfFile[i]);
            }
            foreach (var item in inputContent)
            {
                listBox1.Items.Add(item);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> txtOfFile = File.ReadAllLines("Product.csv").ToList();
            List<string> inputContent = new List<string>();
            for (int i = 1; i < txtOfFile.Count; i++)
            {
                inputContent.Add(txtOfFile[i]);
            }

            int serachItem = Convert.ToInt32(textBox4.Text);
            listBox1.Items.Add(inputContent[serachItem - 1]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> txtOfFile = File.ReadAllLines("Product.csv").ToList();
            txtOfFile.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (string item in txtOfFile)
            {
                if (item.Contains(textBox5.Text))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> txtOfFile = File.ReadAllLines("Product.csv").ToList();
            txtOfFile.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (string item in txtOfFile)
            {
                List<string> produceList = item.Split(',').ToList();
                if (produceList[0] == textBox6.Text)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            List<string> txtOfFile = File.ReadAllLines("Product.csv").ToList();
            txtOfFile.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //txtOfFile.Contains()
            foreach (string txtItem in txtOfFile)
            {
                if (txtItem.Contains(textBox7.Text))
                {
                    List<string> produceList = txtItem.Split(',').ToList();
                    foreach (string item in produceList)
                    {
                        listBox1.Items.Add(item);
                    }
                }
                /*
                if (txtItem.ToString().Equals(textBox7.Text))
                {
                    List<string> produceList = txtItem.Split(',').ToList();
                    foreach (string item in produceList)
                    {
                        listBox1.Items.Add(item);
                    }
                }
                */
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> txtOfFile = File.ReadAllLines("Product.csv").ToList();
            txtOfFile.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (string txtItem in txtOfFile)
            {
                List<string> produceList = txtItem.Split(',').ToList();
                //listBox1.Items.Add(produceList[1]);
                if (Convert.ToInt32(produceList[1]) > Convert.ToInt32(textBox8.Text))
                {
                    listBox1.Items.Add(txtItem);
                }


            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> txtOfFile = File.ReadAllLines("Product.csv").ToList();
            txtOfFile.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (string txtItem in txtOfFile)
            {
                List<string> produceList = txtItem.Split(',').ToList();
                listBox1.Items.Add($"Name {produceList[0]} Price: {produceList[1]}");
                //listBox1.Items.Add("Name" + produceList[0] + "Price: " + produceList[1]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> txtOfFile = File.ReadAllLines("Product.csv").ToList();
            //txtOfFile.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (string txtItem in txtOfFile)
            {
                List<string> produceList = txtItem.Split(',').ToList();
                if (produceList.Contains(textBox9.Text))
                {
                    //listBox1.Items.Add(txtOfFile.IndexOf(txtItem));
                    txtOfFile.RemoveAt(txtOfFile.IndexOf(txtItem));

                    break;
                }

            }
            foreach (string txtItem in txtOfFile)
            {
                listBox1.Items.Add(txtItem);
            }
            File.WriteAllLines("Product.csv", txtOfFile, Encoding.UTF8);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*Since all code is inside Event "button10_Click"  or Function
             * if directly add new data to listBox will "Not changed".
             * Thus after add new line have to "write that data to File"
             * =>Read New File 
             */
            List<string> txtOfFile = File.ReadAllLines("Product.csv").ToList();
            List<string> outResult = new List<string>();
            //txtOfFile.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            string editText = null;

            foreach (string txtItem in txtOfFile)
            {
                List<string> produceList = txtItem.Split(',').ToList();
                if (produceList.Contains(textBox10.Text))
                {
                    txtOfFile.RemoveAt(txtOfFile.IndexOf(txtItem));
                    double total = Convert.ToInt32(textBox11.Text) * Convert.ToInt32(textBox12.Text);
                    editText = $"{textBox10.Text},{textBox11.Text},{textBox12.Text},{total}";
                    txtOfFile.Add(editText);//Add New row of data in here
                    break;
                }
            }

            File.WriteAllLines("Product.csv", txtOfFile, Encoding.UTF8);//Second Prameter have to "List<string>"

            #region Read the File again
            List<string> readNewFile = File.ReadAllLines("Product.csv").ToList();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (string item in readNewFile)
            {
                listBox1.Items.Add(item);
            }
            #endregion


        }
    }

    
}
