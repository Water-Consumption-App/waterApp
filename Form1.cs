using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace waterApp
{
    public partial class Form1 : Form
    {
        formHome home;
        formInfo info;
        formGame game;
        formCredits credits;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1080, 720);
            this.MaximizeBox = false;
            this.IsMdiContainer = true;
            mdiProp();
        }

        private void mdiProp()
        {
            var mdiClient = Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiClient != null)
            {
                mdiClient.BackColor = Color.FromArgb(232, 234, 237);
                mdiClient.Dock = DockStyle.Fill; // Garante que o MDI ocupe todo o espaço disponível
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new formHome();
                home.FormClosed += (s, e) => home = null;
                ShowForm(home);
            }
            else
            {
                home.Activate();
            }
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Dock = DockStyle.Fill; // Preenche automaticamente o espaço disponível no MDI
            form.MaximizeBox = false;
            form.Show();
        }

        // Métodos para abrir cada formulário
        private void OpenHomeForm()
        {
            if (home == null || home.IsDisposed)
            {
                home = new formHome();
                home.FormClosed += (s, e) => home = null;
                ShowForm(home);
            }
            else
            {
                home.Activate();
            }
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

        private void OpenCreditsForm()
        {
            if (credits == null || credits.IsDisposed)
            {
                credits = new formCredits();
                credits.FormClosed += (s, e) => credits = null;
                ShowForm(credits);
            }
            else
            {
                credits.Activate();
            }
        }

        // Sidebar
        private bool sidebarExpand = false;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 54)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 251)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
            AdjustPanelsWidth();
        }

        private void AdjustPanelsWidth()
        {
            pnHome.Width = sidebar.Width;
            pnInfo.Width = sidebar.Width;
            pnGame.Width = sidebar.Width;
            pnCredits.Width = sidebar.Width;
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        // Eventos dos botões
        private void button1_Click(object sender, EventArgs e)
        {
            OpenHomeForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenInfoForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenGameForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenCreditsForm();
        }
    }
}
