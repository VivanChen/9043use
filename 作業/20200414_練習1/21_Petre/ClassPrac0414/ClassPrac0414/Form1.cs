using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassPrac0414
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> result = new List<int>();
            
            Random random = new Random();
            //Op2
            while (true)
            {
                int number = random.Next(1, 50);//1~49
                if (result.Contains(number) == false) //Not Exist
                {
                    result.Add(number);
                }
                if (result.Count == 6)
                {
                    break;
                }
            }

            //OP1
            /*
            while (result.Count <6)
            {
                int number = random.Next(1, 50);//1~49
                if (result.Contains(number) == false) //Not Exist
                {
                    result.Add(number);
                }
            }
            */
            result.Sort();
            //Option 2 
            //資料細節
            listBox1.DataSource = result;

            /* 
            // Option1
            foreach (int item in result)
            {
                listBox1.Items.Add(item);
            }
            */
            /*
            for (int i = 0; i < 6; i++)
            {
                int number = random.Next(1, 50);
                result.Add(number);
                //listBox1.Items.Add(number);
            }
            
            for (int i = 0; i < result.Count -1; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (i != j && result[i] == result[j])
                    {
                        result[j] = 0;
                    }
                }
            }
            */

        }
    }
}
