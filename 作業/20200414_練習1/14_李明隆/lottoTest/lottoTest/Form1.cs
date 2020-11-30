using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottoTest
{
    public partial class Form1 : Form
    {
        List<int> lottoNmb = new List<int>();
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lottoNmb.Clear();
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //while (lottoNmb.Count < 6)
            //{
            //    int rdNmb = ran.Next(1, 50);

            //    if (lottoNmb.Contains(rdNmb) == false)
            //    {
            //        lottoNmb.Add(rdNmb);
            //    }

            //}
            //lottoNmb.Sort();

            //listBox1.DataSource = lottoNmb;


            int ranNumber = ran.Next(1, 50);
            lottoNmb.Add(ranNumber);

            while (lottoNmb.Count < 6)
            {
                ranNumber = ran.Next(1, 50);

                if (!NumberExist(ranNumber))
                {
                    lottoNmb.Add(ranNumber);
                }
            }

            lottoNmb.Sort();

            listBox1.DataSource = lottoNmb;

        }

        public bool NumberExist(int number)
        {
            for (int i = 0; i < lottoNmb.Count; i++)
            {
                if (lottoNmb[i] == number)
                {
                    return true;
                }            
            }
            return false;
        }


    }
}
