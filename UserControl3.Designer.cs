namespace waterApp
{
    partial class UserControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3));
            lbluserdica3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbluserdica3
            // 
            lbluserdica3.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluserdica3.ForeColor = Color.White;
            lbluserdica3.Location = new Point(8, 200);
            lbluserdica3.Name = "lbluserdica3";
            lbluserdica3.Size = new Size(498, 145);
            lbluserdica3.TabIndex = 0;
            lbluserdica3.Text = resources.GetString("lbluserdica3.Text");
            lbluserdica3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 482);
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
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 69);
            Controls.Add(lbluserdica3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControl3";
            Size = new Size(1026, 542);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbluserdica3;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
