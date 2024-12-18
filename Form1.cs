using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace waterApp
{
    public partial class formMain : Form
    {
        formHome home;
        formInfo info;
        formGame game;
        formCredits credits;
        formDados dados;
        formIntro intro;

        public formMain()
        {
            InitializeComponent();
            this.Text = "Poseidon's Journey"; // Define o t�tulo da janela
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1132, 763);
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas
            this.MaximizeBox = false;
            this.IsMdiContainer = true;
            mdiProp();

            // Ativa o DoubleBuffered para evitar flickering
            this.DoubleBuffered = true;
        }


        private void mdiProp()
        {
            var mdiClient = Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiClient != null)
            {
                mdiClient.BackColor = Color.FromArgb(232, 234, 237);
                mdiClient.Dock = DockStyle.Fill; // Garante que o MDI ocupe todo o espa�o dispon�vel
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
            form.Dock = DockStyle.Fill; // Preenche automaticamente o espa�o dispon�vel no MDI
            form.MaximizeBox = false;
            form.Show();
        }

        // M�todos para abrir cada formul�rio
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

        private void OpenIntroForm()
        {
            if (intro == null || intro.IsDisposed)
            {
                intro = new formIntro();
                intro.FormClosed += (s, e) => intro = null;
                ShowForm(intro);
            }
            else
            {
                intro.Activate();
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

        private void OpenDadosForm()
        {
            if (dados == null || dados.IsDisposed)
            {
                dados = new formDados();
                dados.FormClosed += (s, e) => dados = null;
                ShowForm(dados);
            }
            else
            {
                dados.Activate();
            }
        }

        // Sidebar
        private bool sidebarExpand = false;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 52)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 252)
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
            this.DoubleBuffered = true;
        }

        // Eventos dos bot�es
        private void button1_Click(object sender, EventArgs e)
        {
            OpenHomeForm();
            this.DoubleBuffered = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenDadosForm();
            this.DoubleBuffered = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenIntroForm();
            this.DoubleBuffered = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            OpenCreditsForm();
            this.DoubleBuffered = true;
        }

        private void pnHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenHomeForm();
            this.DoubleBuffered = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenCreditsForm();
            this.DoubleBuffered = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenIntroForm();
            this.DoubleBuffered = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenDadosForm();
            this.DoubleBuffered = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha todo o aplicativo
        }
    }
}
