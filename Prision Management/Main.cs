using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prision_Management
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //listView1.Items.Add("No Data found!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.Add("Andhra man clubs 90-year-old wife to death over Rs 2,200 pension");
            listView1.Items.Add("Losing job during lockdown, Maharashtra woman marries 3 men in 3 months, flees with jewellery");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                return;
            }
            ListViewItem item = new ListViewItem(textBox1.Text);
            item.SubItems.Add(textBox2.Text);
            item.SubItems.Add(textBox3.Text);
            item.SubItems.Add(textBox4.Text);
            listView1.Items.Add(item);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            string date = item.SubItems[0].Text;
            string type = item.SubItems[1].Text;
            string location = item.SubItems[2].Text;
            string person = item.SubItems[3].Text;
            //MessageBox.Show(date+"\n" + type +"\n"+ location+ "\n" + person+ "\n");
            Form2 form2 = new Form2(date, type, location, person);
            form2.Show();
            Hide();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageComplaint manageComplaint = new ManageComplaint();
            manageComplaint.Show();
            Hide();
        }
    }
}
