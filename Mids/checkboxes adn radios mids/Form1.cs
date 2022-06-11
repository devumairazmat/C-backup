using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkboxes_adn_radios_mids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            String Teams = "";

            if (checkBox1.Checked)
            {
                Teams = Teams + checkBox1.Text + "\r\n";
            }
            if (checkBox2.Checked)
            {
                Teams = Teams + checkBox2.Text + "\r\n";
            }
            if (checkBox3.Checked)
            {
                Teams = Teams + checkBox3.Text + "\r\n";
            }
            if (checkBox4.Checked)
            {
                Teams = Teams + checkBox4.Text + "\r\n";
            }
            if (checkBox5.Checked)
            {
                Teams = Teams + checkBox5.Text + "\r\n";
            }
            MessageBox.Show(Teams);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String Teams = "";

            if (radioButton1.Checked)
            {
                Teams = Teams + radioButton1.Text + "\r\n";
            }
            if (radioButton2.Checked)
            {
                Teams = Teams + radioButton2.Text + "\r\n";
            }
            if (radioButton3.Checked)
            {
                Teams = Teams + radioButton3.Text + "\r\n";
            }
            if (radioButton4.Checked)
            {
                Teams = Teams + radioButton4.Text + "\r\n";
            }
            if (radioButton5.Checked)
            {
                Teams = Teams + radioButton5.Text + "\r\n";
            }
            MessageBox.Show(Teams);
        }
    }
}
