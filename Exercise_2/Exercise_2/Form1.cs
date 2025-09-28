using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (male.Checked) gender = "Kişi";
            else if (female.Checked) gender = "Qadın";

            string seher = "";
            if (listBox1.SelectedItem != null)
                seher = listBox1.SelectedItem.ToString();

            
            string hobi = "";
            if (checkBox1.Checked) hobi += "İdman ";
            if (checkBox2.Checked) hobi += "Kitab oxumaq ";
            if (checkBox3.Checked) hobi += "Rəsm çəkmək ";

           
            string info = $"Cins: {gender}\nŞəhər: {seher}\nHobbi: {hobi}";
            MessageBox.Show(info, "İstifadəçi məlumatları");
        }
    }
}
