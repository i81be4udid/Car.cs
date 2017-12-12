using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Car_Proj
{
    public partial class Form1 : Form
    {
        private Car myCar;

        public Form1()
        {
            myCar = new Car();

            InitializeComponent();
        }

        private void GetCarData(Car car)
        {
            try
            {
                myCar.Make = txtMake.Text;

                myCar.Year = int.Parse(txtModel.Text);

                myCar.Speed = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Must enter a valid make and year model for the car. ", ex.Message, "\r\n", ex.StackTrace));
            }
        }

        private void BtnAcc_Click(object sender, EventArgs e)
        {
            GetCarData(myCar);
            myCar.AccSpeed(5);
            MessageBox.Show(" Your car is a " + myCar.Year + myCar.Make + " and it is     traveling " + myCar.Speed + " mph. ");
        }

        private void BtnBrake_Click(object sender, EventArgs e)
        {
            GetCarData(myCar);
            myCar.DecSpeed(5);
            MessageBox.Show(" Your car is a " + myCar.Year + myCar.Make + " and it is     traveling " + myCar.Speed + " mph. ");
        }
    }
}