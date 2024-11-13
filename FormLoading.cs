using System;
using System.Drawing;
using System.Windows.Forms;

namespace waterApp
{
    public partial class FormLoading : Form
    {
        private CustomProgressBar customProgressBar;
        private System.Windows.Forms.Timer timer;

        public FormLoading()
        {
            InitializeComponent();
            this.Text = "Poseidon's Journey";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(720, 480);

            customProgressBar = new CustomProgressBar
            {
                Location = new Point(68, 217),
                Size = new Size(500, 30),
                ProgressBarColor = ColorTranslator.FromHtml("#f2b671"), // Definindo a cor dourada
                BorderRadius = 15
            };
            Controls.Add(customProgressBar);

            timer = new System.Windows.Forms.Timer
            {
                Interval = 30
            };
            timer.Tick += Timer_Tick;
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            customProgressBar.Progress = 0;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (customProgressBar.Progress < 100)
            {
                customProgressBar.Progress += 1;
            }
            else
            {
                timer.Stop();
                OpenMainForm();
                this.Hide();
            }
        }

        private void OpenMainForm()
        {
            formMain mainForm = new formMain();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }
    }
}
