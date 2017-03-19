using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ram_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You clicked me");

            //we are going to increase height & width of button by 10px
            //on every click of this button

            /*
            //get property
            int height = button1.Height;
            int width = button1.Width;

            //increment value
            height += 10;
            width += 10;

            //set property
            button1.Height = height;
            button1.Width = width;
            */

            //get and set on the same line
            button1.Height = button1.Height += 10;
            button1.Width = button1.Width += 10;


            //MessageBox.Show(button1.Height.ToString());
            //MessageBox.Show(button1.Width.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Black;
            this.button1.ForeColor = Color.Gray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Gray;
            this.button1.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Visible == true)
                dateTimePicker1.Hide();
            else
                dateTimePicker1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myCalendar3.MyCustomProperty = "ram";

            //dateTimePicker1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
