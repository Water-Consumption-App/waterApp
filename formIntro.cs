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
    public partial class formIntro : Form
    {

        formGame game;

        public formIntro()
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

        private void OpenGameForm()
        {
            if (game == null || game.IsDisposed)
            {
                game = new formGame();
                game.FormClosed += (s, e) => game = null;
                ShowForm(game);
            }
            else
            {
                game.Activate();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OpenGameForm();
            this.DoubleBuffered = true;

        }
    }
}
