using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waterApp
{
    public partial class ucPage2 : UserControl
    {
        public ucPage2()
        {
            InitializeComponent();
            txt_opc1_uc8.Hide();
            txt_opc2_uc8.Hide();
            txt_opc3_uc8.Hide();
            txt_opc4_uc8.Hide();
            txt_opc5_uc8.Hide();
            txt_opc6_uc8.Hide();
            txt_opc7_uc8.Hide();
            txt_opc8_uc8.Hide();
            txt_opc9_uc8.Hide();

            if (txt_opc1_uc8.Visible && txt_opc2_uc8.Visible && txt_opc3_uc8.Visible &&
    txt_opc4_uc8.Visible && txt_opc5_uc8.Visible && txt_opc6_uc8.Visible &&
    txt_opc7_uc8.Visible && txt_opc8_uc8.Visible && txt_opc9_uc8.Visible)
            {
               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndica1_Click(object sender, EventArgs e)
        {

        }

        private void btn_opc1_uc8_Click(object sender, EventArgs e)
        {
            txt_opc1_uc8.Show();
        }

        private void txt_opc2_uc8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_opc2_uc8_Click(object sender, EventArgs e)
        {
            txt_opc2_uc8.Show();
        }

        private void txt_opc3_uc8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_opc3_uc8_Click(object sender, EventArgs e)
        {
            txt_opc3_uc8.Show();
        }

        private void btn_opc4_uc8_Click(object sender, EventArgs e)
        {
            txt_opc4_uc8.Show();
        }

        private void txt_opc4_uc8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_opc7_uc8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_opc5_uc8_Click(object sender, EventArgs e)
        {
            txt_opc5_uc8.Show();
        }

        private void btn_opc6_uc8_Click(object sender, EventArgs e)
        {
            txt_opc6_uc8.Show();
        }

        private void btn_opc7_uc8_Click(object sender, EventArgs e)
        {
            txt_opc7_uc8.Show();
        }

        private void btn_opc8_uc8_Click(object sender, EventArgs e)
        {
            txt_opc8_uc8.Show();
        }

        private void btn_opc9_uc8_Click(object sender, EventArgs e)
        {
            txt_opc9_uc8.Show();
        }

        
    }
}
