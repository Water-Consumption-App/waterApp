using System;
using System.Drawing;
using System.Windows.Forms;

namespace waterApp
{
    public partial class Form2 : Form
    {
        formMain formmain;

        public Form2()
        {
            InitializeComponent();
            this.Text = "Poseidon's Journey"; // Define o título da janela
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1132, 763);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void OpenFormMain()
        {
            if (formmain == null || formmain.IsDisposed)
            {
                formmain = new formMain();
                formmain.StartPosition = FormStartPosition.CenterScreen;

                // Adiciona um evento para fechar o aplicativo quando formMain é fechado
                formmain.FormClosed += (s, e) => this.Close();

                formmain.Show(); // Exibe formMain de forma independente
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Abre o Form de loading
            FormLoading formLoading = new FormLoading();
            formLoading.Show(); // Exibe a tela de loading

            // Fecha a tela de entrada
            this.Hide();

            // Quando a tela de loading for fechada, abre o Form principal
            formLoading.FormClosed += (s, args) =>
            {
                OpenFormMain();
                this.Close(); // Fecha a tela de loading após o form principal ser aberto
            };
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha todo o aplicativo
        }
    }
}
