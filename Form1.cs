using System.Diagnostics;

namespace LabTOIB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Valid.ValidatePassword(textBox2.Text, "123456789"); //&& Valid.ValidateLogin(textBox1.Text, "Max"))
           
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox2.UseSystemPasswordChar == true)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;

        }
    }
}
