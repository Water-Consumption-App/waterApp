namespace waterApp
{
    partial class UserControl6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl6));
            lbluserdica6 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbluserdica6
            // 
            lbluserdica6.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluserdica6.ForeColor = Color.White;
            lbluserdica6.Location = new Point(16, 175);
            lbluserdica6.Name = "lbluserdica6";
            lbluserdica6.Size = new Size(483, 202);
            lbluserdica6.TabIndex = 0;
            lbluserdica6.Text = resources.GetString("lbluserdica6.Text");
            lbluserdica6.TextAlign = ContentAlignment.MiddleCenter;
            lbluserdica6.Click += lbluserdica6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 14, 39);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(515, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 485);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 485);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UserControl6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 69);
            Controls.Add(panel1);
            Controls.Add(lbluserdica6);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControl6";
            Size = new Size(1026, 542);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbluserdica6;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
