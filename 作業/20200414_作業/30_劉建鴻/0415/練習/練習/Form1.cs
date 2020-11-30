using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace 練習
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("product.txt", "\r\n", Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Price = Convert.ToInt32(textBox2.Text);
            int Count = Convert.ToInt32(textBox3.Text);
            int Total = Price * Count;

            String outputString = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text;

            File.AppendAllText("product.txt", outputString + "," + Convert.ToString(Total) + "\r\n");

            MessageBox.Show(textBox1.Text + "恭喜完成");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            List<string> mylist = File.ReadAllLines("product.txt").ToList();

            listBox1.DataSource = mylist;
            //全部產品
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            
            listBox1.Items.Clear();
            //清除
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //查詢資料
            listBox1.Items.Clear();

            List<string> Product= File.ReadAllLines("product.txt").ToList();
            int name = Convert.ToInt32(textBox4.Text);

            listBox1.Items.Add(Product[name]);
   
        }

        private void Button5_Click(object sender, EventArgs e)
        {    
            listBox1.Items.Clear();

            List<string> Product
             = File.ReadAllLines("product.txt").ToList();

            
            for (int i = 0; i < Product.Count; i++)
            {
                if (Product[i].Contains(textBox5.Text))
                {
                    listBox1.Items.Add(Product[i]);
                }
                        
            }
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //查詢所有產品

            listBox1.Items.Clear();
            List<string> product = File.ReadAllLines("product.txt").ToList();
          
           

            foreach (string Name in product)

            {
                List<string> product1 = Name.Split(',').ToList(); 
                

                if (product1[0] == textBox6.Text)
                {
                    listBox1.Items.Add(Name);
                }
               
            }
            
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
           
            List<string> product = File.ReadAllLines("product.txt").ToList();
            //product.RemoveAt[0];
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            
            foreach (string Name in product)
                
            {
                
                List<string> product1 = Name.Split(',').ToList();
                int product2 = Convert.ToInt32(product1[1]);

                if (product2>=Convert.ToInt32(textBox7.Text))
                {
                    listBox1.Items.Add(Name);
                }

            }

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            
      
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> mylist = File.ReadAllLines("product.txt").ToList();

            foreach (string name in mylist)
            {
                List<string> product1 = name.Split(',').ToList();  //
                string a =  $"名稱:{product1[0]}價格:{product1[1]}";  //string a= product 1[0]+product 1[1]；
        
                listBox1.Items.Add(a);
       
             }
         
        }
        
        private void Button10_Click(object sender, EventArgs e)
        {
            
            List<string> Nmylist = new List<string>();
            List<string> mylist = File.ReadAllLines("product.txt").ToList();
            //List<string> product1 = new List<string>();
            Nmylist = mylist.ToList();   //To list 就是把mylist固定

            foreach (string dele in mylist)
            {
                List<string> product1 = dele.Split(',').ToList();

                if (product1[0] == textBox8.Text)
                {
                    Nmylist.Remove(dele);
                }

            }
            //mylist.Remove(str);
            File.WriteAllLines("product.txt", Nmylist);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            List<string> Nmylist = new List<string>();
            List<string> mylist = File.ReadAllLines("product.txt").ToList();  //固定不能修改
            string name = textBox9.Text;
            int Price = Convert.ToInt32(textBox10.Text);
            int Count = Convert.ToInt32(textBox11.Text);
            int Total = Price * Count;
            string chg;
            
            foreach (string name1 in mylist)
            {
                string[] product1 = name1.Split(',');
                if (product1[0] == name)
                {
                    //product1[1] = Convert.ToString(Price);
                    //product1[2] = Convert.ToString(Count);
                    //product1[3] = Convert.ToString(Total);
                    chg= $"{product1[0]},{Price},{Count},{Total}";
                    Nmylist.Add(chg);
                }
                else
                {
                    Nmylist.Add(name1);
                } 

            }
            //File.WriteAllText("product.txt", "\r\n", Encoding.UTF8);
            File.WriteAllLines("product.txt", Nmylist);
        }
    }
}
