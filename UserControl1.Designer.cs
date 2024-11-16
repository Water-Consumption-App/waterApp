namespace waterApp
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            lbluserdica1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbluserdica1
            // 
            lbluserdica1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluserdica1.ForeColor = Color.White;
            lbluserdica1.Location = new Point(15, 194);
            lbluserdica1.Name = "lbluserdica1";
            lbluserdica1.Size = new Size(484, 108);
            lbluserdica1.TabIndex = 0;
            lbluserdica1.Text = "Sempre verifique se seu chuveiro, vaso sanitário, tanque ou torneiras apresentam vazamentos.";
            lbluserdica1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 14, 39);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(515, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 485);
            panel1.TabIndex = 2;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 29, 55);
            Controls.Add(panel1);
            Controls.Add(lbluserdica1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControl1";
            Size = new Size(1026, 542);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbluserdica1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
