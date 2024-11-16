using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace waterApp
{


    public partial class btn_cntc : Form
    {
        public btn_cntc()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas
            //esconder
            img_btn_bk2.Hide();
            img_btn_bk.Hide();
            ucPage1.Hide();
            ucPage2.Hide();

        }

        private void formHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;


        }

        private void Card1_Click(object sender, EventArgs e)
        {
            //esconder
            //txt_hm.Hide();
            //mostrar
            ucPage1.Show();
            img_btn_bk.Show();
        }

        private void card2_Click(object sender, EventArgs e)
        {
            //esconder
            //txt_hm.Hide();
            ucPage1.Hide();
            //mostrar
            img_btn_bk2.Show();
            ucPage2.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //esconder
            ucPage1.Hide();
            img_btn_bk.Hide();

        }

        private void img_btn_bk2_Click(object sender, EventArgs e)
        {
            //esconder
            ucPage2.Hide();
            img_btn_bk2.Hide();
        }

        private void txt_hm_Click(object sender, EventArgs e)
        {

        }
    }
} 