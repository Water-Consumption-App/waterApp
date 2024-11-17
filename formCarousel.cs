using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace waterApp
{
    public partial class formCarousel : Form
    {
        private List<UserControl> carouselItems;
        private int currentItemIndex = 0;

        formDados dados;

        public formCarousel()
        {
            InitializeComponent();
            InitializeCarousel();
            this.Size = new Size(1080, 720);
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this.MdiParent;  // Define o formulário pai
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Dock = DockStyle.Fill; // Preenche automaticamente o espaço disponível no MDI
            form.MaximizeBox = false;
            form.Show();
        }

        private void formCarousel_Load(object sender, EventArgs e)
        {
            // Mostrar o primeiro item quando o formulário carregar
            ShowCurrentItem();
        }

        private void InitializeCarousel()
        {
            // Inicializar a lista de UserControls
            carouselItems = new List<UserControl>
            {
                new DadosControl(),
                new DadosControl2(),
                new DadosControl3(),
                new DadosControl4(),
                new DadosControl5(),
                // Adicione mais UserControls conforme necessário
            };
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            currentItemIndex = (currentItemIndex + 1) % carouselItems.Count;
            ShowCurrentItem();
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            currentItemIndex = (currentItemIndex - 1 + carouselItems.Count) % carouselItems.Count;
            ShowCurrentItem();
        }

        private void ShowCurrentItem()
        {
            // Limpar o contêiner
            panelCarousel.Controls.Clear();

            // Adicionar o item atual ao contêiner
            var currentItem = carouselItems[currentItemIndex];
            currentItem.Dock = DockStyle.Fill;
            panelCarousel.Controls.Add(currentItem);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenDadosForm();
            this.DoubleBuffered = true;
        }

    }
}
