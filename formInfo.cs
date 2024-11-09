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
    public partial class formInfo : Form
    {
        public formInfo()
        {
            InitializeComponent();
        }

        private void formInfo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btndica2_Click(object sender, EventArgs e)
        {

        }

        private void btndica3_Click(object sender, EventArgs e)
        {

        }

        private void lbldica1_Click(object sender, EventArgs e)
        {

        }

        private void userControl61_Load(object sender, EventArgs e)
        {

        }

        private void btndica1_Click(object sender, EventArgs e)
        {
            //esconder outros user control
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            //mostrar o user control dica 1
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void btndica4_Click(object sender, EventArgs e)
        {
            //esconder outros user control
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl51.Hide();
            userControl61.Hide();
            //mostrar o user control dica 4
            userControl41.Show();
            userControl41.BringToFront();
        }

        private void btndica5_Click(object sender, EventArgs e)
        {
            //esconder outros user control
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl61.Hide();
            //mostrar o user control dica 5
            userControl51.Show();
            userControl51.BringToFront();
        }

        private void btndica2_Click_1(object sender, EventArgs e)
        {
            //esconder outros user control
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            //mostrar o user control dica 2
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void btndica3_Click_1(object sender, EventArgs e)
        {
            //esconder outros user control
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            //mostrar o user control dica 3
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void btndica6_Click(object sender, EventArgs e)
        {
            //esconder outros user control
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl51.Hide();
            //mostrar o user control dica 6
            userControl61.Show();
            userControl61.BringToFront();
        }
    }
}
