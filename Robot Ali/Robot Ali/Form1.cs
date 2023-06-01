using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Robot_Ali
{
    public partial class Form1 : Form
    {
        SerialPort port = null;
        public Form1()
        {
            InitializeComponent();
            if(port == null)
            {
                port = new SerialPort("COM6", 115200);
                port.Open();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string str = port.ReadLine();
                if (str == null || str == string.Empty)
                {
                    return;
                }
                string[] temps = str.Split(new char[] { ':' });
                if (temps.Length == 1)
                {
                    lbl_valueKhoancach.Text = temps[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't read");
            }
            timer_loadvalue.Enabled = true;
        }

        private void lbl_cm_Click(object sender, EventArgs e)
        {

        }

        private void lbl_value_Click(object sender, EventArgs e)
        {
            
        }

        private void timer_loadvalue_Tick(object sender, EventArgs e)
        {
            try
            {
                string str = port.ReadLine();
                if (str == null || str == string.Empty)
                {
                    return;
                }
                string[] temps = str.Split(new char[] { ':' });
                if (temps.Length == 1)
                {
                    lbl_valueKhoancach.Text = temps[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't read");
            }
        }
    }
}
