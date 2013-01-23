using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestSerialCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;

            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            InputChar('n');


            // comment
        }



        private void InputChar(char c)
        {
            char[] buff = new char[1];


            buff[0] = c;
            // Send the one character buffer.
            serialPort1.Write(buff, 0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputChar('f');
        }
    }
}
