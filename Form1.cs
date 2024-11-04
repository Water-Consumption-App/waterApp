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
            this.StartPosition = FormStartPosition.CenterScreen; // Centraliza na tela
            this.Size = new Size(1080, 720); // Tamanho fixo para o Form1
            this.MaximizeBox = false; // Desabilita a maximização
            this.IsMdiContainer = true; // Certifique-se de que é um MDI container
            mdiProp();
        }

        private void mdiProp()
        {
            var mdiClient = Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiClient != null)
                mdiClient.BackColor = Color.FromArgb(232, 234, 237);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Garante que o formHome seja exibido automaticamente ao iniciar o projeto
            if (home == null)
            {
                home = new formHome();
                home.FormClosed += (s, e) => home = null;
                ShowForm(home); // Use ShowForm para abrir o home
            }
            else
            {
                home.Activate();
            }
        }


        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual; // Previne que o Windows altere a posição
            form.Location = new Point(0, 0); // Alinha o formulário na posição inicial do MDI
            form.Size = new Size(this.ClientSize.Width - 251, this.ClientSize.Height - 43); // Ajusta o tamanho do formulário
            form.MaximizeBox = false; // Desabilita a maximização
            form.Show();
        }

        // HOME
        private void OpenHomeForm()
        {
            if (home == null || home.IsDisposed)
            {
                home = new formHome();
                home.FormClosed += (s, e) => home = null; // Remove a referência quando o form é fechado
                ShowForm(home);
            }
            else
            {
                home.Activate();
            }
        }

        // INFO
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

        // GAME
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

        // CREDITS
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

        // SIDEBAR
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

            // Ajuste as larguras dos painéis de acordo com a sidebar
            AdjustPanelsWidth();
        }

        private void AdjustPanelsWidth()
        {
            // Ajuste as larguras dos painéis de acordo com a sidebar
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
            if (home == null)
            {
                home = new formHome();
                home.FormClosed += Home_FormClosed;
                ShowForm(home); // Use ShowForm para abrir o home
            }
            else
            {
                home.Activate();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            info = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (info == null)
            {
                info = new formInfo();
                info.FormClosed += Info_FormClosed;
                ShowForm(info); // Use ShowForm para abrir o info
            }
            else
            {
                info.Activate();
            }
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            info = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                game = new formGame();
                game.FormClosed += Game_FormClosed;
                ShowForm(game); // Use ShowForm para abrir o game
            }
            else
            {
                game.Activate();
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            info = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (credits == null)
            {
                credits = new formCredits();
                credits.FormClosed += Credits_FormClosed;
                ShowForm(credits); // Use ShowForm para abrir o credits
            }
            else
            {
                credits.Activate();
            }
        }

        private void Credits_FormClosed(object sender, FormClosedEventArgs e)
        {
            info = null;
        }

    }
}