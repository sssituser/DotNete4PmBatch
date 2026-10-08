using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            for(int i = 18; i <= 30; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            string finame = textBox1.Text;
            string fname = textBox2.Text;
            string age = comboBox1.SelectedItem.ToString();
            string gen = string.Empty;
            if (radioButton1.Checked)
            {
                gen = "Male";
            }
            else if (radioButton2.Checked)
            {
                gen = "Female";
            }
            string dob = dateTimePicker1.Text;
            string hob = string.Empty;
            if (checkBox1.Checked)
            {
                hob += checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                hob += checkBox2.Text;
            }

            label7.Text = $"FirstName : {finame}\nFahter Name :{fname}\nAge : {age}  Dob : {dob}  Gender : {gen} Hobbies : {hob} ";
        }
    }
}
