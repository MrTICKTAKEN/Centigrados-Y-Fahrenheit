﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centigrados_Y_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celcius = double.Parse(CELStextBox1.Text);
            double fahrenheit = ConvertirAFahrenheit(celcius);

            RESULTlabel1.Text = celcius + " ° C es igual a " + fahrenheit + "° F"; 
        }

        private double ConvertirAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
            throw new NotImplementedException();
        }
    }
}
