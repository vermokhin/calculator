﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (decimal.Parse(textBox1.Text) - decimal.Parse(textBox2.Text)).ToString();
            }
            catch(Exception)
            {}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }
	}
}
