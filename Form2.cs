using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicProject
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
          
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

          
            Form1 form1 = new Form1();
            form1.UpdateCredentials(username, password);
            form1.Show();

          
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordtxt.PasswordChar = '\0';
            }
            else
            {
                passwordtxt.PasswordChar = '*';
            }
        }
    }
    

       
  
}
