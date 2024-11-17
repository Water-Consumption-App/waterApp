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

    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
            this.Size = new Size(1080, 720);
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas

            btn_back2.Hide();
            btn_back1.Hide();
            ucPage11.Hide();
            ucPage21.Hide();
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void img_card1_Click(object sender, EventArgs e)
        {
            //esconder
            label_home.Hide();
            //mostrar
            btn_back1.Show();
            ucPage11.Show();
        }

        private void img_card2_Click(object sender, EventArgs e)
        {
            //esconder
            label_home.Hide();
            //mostrar
            btn_back2.Show();
            ucPage21.Show();
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            //mostrar
            label_home.Show();
            //esconder
            ucPage11.Hide();
            btn_back1.Hide();
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            //mostrar
            label_home.Show();
            //esconder
            ucPage21.Hide();
            btn_back2.Hide();
        }

        private void label_home_Click(object sender, EventArgs e)
        {

        }

        private void ucPage21_Load(object sender, EventArgs e)
        {

        }
    }
}
