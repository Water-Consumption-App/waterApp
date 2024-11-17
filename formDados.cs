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
    public partial class formDados : Form
    {
        formInfo info;
        formCarousel carousel;

        public formDados()
        {
            InitializeComponent();
            this.Size = new Size(1080, 720);
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas
            this.DoubleBuffered = true;
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this.MdiParent;  // Define o formulário pai
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Dock = DockStyle.Fill; // Preenche automaticamente o espaço disponível no MDI
            form.MaximizeBox = false;
            form.Show();
        }

        private void OpenInfoForm()
        {
            if (info == null || info.IsDisposed)
            {
                info = new formInfo();
                info.FormClosed += (s, e) => info = null;
                ShowForm(info);
            }
            else
            {
                info.Activate();
            }
        }

        private void OpenCarouselForm()
        {
            if (carousel == null || carousel.IsDisposed)
            {
                carousel = new formCarousel();
                carousel.FormClosed += (s, e) => carousel = null;
                ShowForm(carousel);
            }
            else
            {
                carousel.Activate();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenCarouselForm();
            this.DoubleBuffered = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenInfoForm();
            this.DoubleBuffered = true;
        }

        private void formDados_Load(object sender, EventArgs e)
        {

        }
    }
}
