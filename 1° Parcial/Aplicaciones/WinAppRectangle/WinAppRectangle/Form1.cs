using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRectangle
{
    public partial class Form1 : Form
    {
        private float mSideA, mSideB, mPerimeter, mArea;

        public Form1()
        {
            InitializeComponent();
            mSideA = 0.0f; mSideB = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        private void ReadData()
        {

            try
            {
                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

        }

        private void PerimeterRetangle()
        {
            mPerimeter = 2*mSideA + 2*mSideB;
        }

        private void AreaRetangle()
        {

            // mArea = (float)Math.PI * mRadius * mRadius
            mArea = mSideA*mSideB;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSideA.Focus();
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            PerimeterRetangle();
            AreaRetangle();
            PrintData();
        }

        private void PrintData()
        {

            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();

        }

        private void InitializeData()
        {

            txtSideA.Focus();
            mSideA = 0.0f; mSideB = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Text = ""; txtSideB.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";


        }

        private void txtSideA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
