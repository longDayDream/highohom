using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class winform : Form
    {
       static public bool sign;
        static public string inputstring;
        public string[] arr;

        public winform()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //serialPort1.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
 
        }

     

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _isSerialOpen_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                MessageBox.Show("open");
            else
                MessageBox.Show("close");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form2 frm2 = new Form2();
            //frm2.Show();
           if(!serialPort1 .IsOpen)
                serialPort1.Open();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.ReadTo(arr[0]);
            textBox1.Text = arr[0];
        }
    }
}
