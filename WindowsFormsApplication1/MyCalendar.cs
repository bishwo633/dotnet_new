using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MyCalendar : UserControl
    {
        public MyCalendar()
        {
            InitializeComponent();
        }

        //this is our custom property
        public string MyCustomProperty { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Visible == true)
                dateTimePicker1.Hide();
            else
                dateTimePicker1.Show();
        }
    }
}
