using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSquart
{
    public partial class fmrSquart : Form
    {

        private float mSideA, mSideB, mPerimeter, mArea;

        public fmrSquart()
        {
            InitializeComponent();
            mSideA = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        private void ReadData()
        {
            try
            {
                mSideA = float.Parse(txtSideA.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

        }

        private void InitializeData()
        {

            txtSideA.Focus();
            mSideA = 0.0f; mSideB = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
        }

        private void PrintData()
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        private void PerimeterSquart()
        {

            mPerimeter = 4*mSideA;

        }

        private void AreaSquart()
        {

            // mArea = (float)Math.PI * mRadius * mRadius
            mArea = (float)Math.Pow(mSideA,2);

        }

        private void txtSideA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSideB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSideA_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            PerimeterSquart();
            AreaSquart();
            PrintData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
