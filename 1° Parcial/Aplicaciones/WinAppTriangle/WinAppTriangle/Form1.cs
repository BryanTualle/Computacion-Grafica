using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTriangle
{
    public partial class frmTriangle : Form
    {
        private float mSideA, mSideB, mSideC, mPerimeter, mArea,mS, mHeron;
        
        public frmTriangle()
        {
            InitializeComponent();
            mSideA = 0.0f; mSideB = 0.0f; mSideC = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        private void ReadData()
        {
            
            try
            {
                mSideA = float.Parse(txtSideA.Text);
                mSideB = float.Parse(txtSideB.Text);
                mSideC = float.Parse(txtSideC.Text);
            }
            catch
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

            if (((mSideA + mSideB) > mSideC) && ((mSideA + mSideC) > mSideB) && ((mSideB + mSideC) > mSideA))
            {
            }
            else
            {
                MessageBox.Show("Error en el ingreso de datos", "Mensaje de error");
            }

        }

        private void PerimeterTriangle()
        {

            mPerimeter = mSideA+mSideB+mSideC;

        }

        private void AreaTriangle()
        {
            mS = (mSideA + mSideB + mSideC) / 2;
            mHeron = mS * (mS - mSideA) * (mS - mSideB) * (mS - mSideC);
            mArea = (float)Math.Sqrt(mHeron);
        }

        private void PrintData()
        {

            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();

        }

        private void InitializeData()
        {

            txtSideA.Focus();
            mSideA = 0.0f; mSideB = 0.0f; mSideC = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtSideA.Text = ""; txtSideB.Text = ""; txtSideC.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";


        }


        private void frmTriangle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ReadData();
            PerimeterTriangle();
            AreaTriangle();
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
