using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicProject
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }
        private void GoToForm3()
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void UpdateCredentials(string username, string password)
        {
           textBox1.Text = username;
           textBox2.Text = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both username and password.");
            }
            else
            {

                GoToForm3();

            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
            this.Hide();
        }
    }
    
}
