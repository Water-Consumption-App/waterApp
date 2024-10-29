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
            mdiProp();
        }

        bool menuExpand = false;
        private void mdiProp()
        {
            this.setBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234,237);
        }   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 54)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnHome.Width = sidebar.Width;
                    pnInfo.Width = sidebar.Width;
                    pnGame.Width = sidebar.Width;
                    pnCredits.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 251)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnHome.Width = sidebar.Width;
                    pnInfo.Width = sidebar.Width;
                    pnGame.Width = sidebar.Width;
                    pnCredits.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        // HOME
        private void button1_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new formHome();
                home.FormClosed += Home_FormClosed;
                home.MdiParent = this;
                home.Show();
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

        // INFO
        private void button4_Click(object sender, EventArgs e)
        {
            if (info == null)
            {
                info = new formInfo();
                info.FormClosed += Info_FormClosed;
                info.MdiParent = this;
                info.Show();
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

        // GAME
        private void button3_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                game = new formGame();
                game.FormClosed += Game_FormClosed;
                game.MdiParent = this;
                game.Show();
            }
            else
            {
                game.Activate();
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            game = null;
        }

        // CREDITS
        private void button2_Click(object sender, EventArgs e)
        {
            if (credits == null)
            {
                credits = new formCredits();
                credits.FormClosed += Credits_FormClosed;
                credits.MdiParent = this;
                credits.Show();
            }
            else
            {
                credits.Activate();
            }
        }

        private void Credits_FormClosed(object sender, FormClosedEventArgs e)
        {
            credits = null;
        }

    }
}
