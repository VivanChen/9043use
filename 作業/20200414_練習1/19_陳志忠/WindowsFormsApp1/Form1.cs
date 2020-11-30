using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            listBox1.Items.Clear();

            Random ran = new Random();

            List<int> list1 = new List<int>();

            do
            {
                int a = ran.Next(1, 49);

                    if (list1.Contains(a)!= true)
                    {
                        list1.Add(a);
                    }
                
            } while (list1.Count<=6);



            //listBox1.Items.Add(a);
            list1.Sort();


            foreach (int item in list1)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
