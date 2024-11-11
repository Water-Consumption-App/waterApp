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
            lbluserdica6 = new Label();
            SuspendLayout();
            // 
            // lbluserdica6
            // 
            lbluserdica6.AutoSize = true;
            lbluserdica6.Location = new Point(196, 159);
            lbluserdica6.Name = "lbluserdica6";
            lbluserdica6.Size = new Size(117, 20);
            lbluserdica6.TabIndex = 0;
            lbluserdica6.Text = "aqui vai a dica 6";
            lbluserdica6.Click += lbluserdica6_Click;
            // 
            // UserControl6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbluserdica6);
            Name = "UserControl6";
            Size = new Size(580, 370);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluserdica6;
    }
}
