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

                // Esconde o formulário de entrada sem fechá-lo
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenFormMain(); // Abre formMain ao clicar em "Entrar"
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha todo o aplicativo
        }
    }
}
