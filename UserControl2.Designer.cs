namespace waterApp
{
    partial class UserControl2
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
            lbluserdica2 = new Label();
            SuspendLayout();
            // 
            // lbluserdica2
            // 
            lbluserdica2.AutoSize = true;
            lbluserdica2.Location = new Point(214, 150);
            lbluserdica2.Name = "lbluserdica2";
            lbluserdica2.Size = new Size(117, 20);
            lbluserdica2.TabIndex = 0;
            lbluserdica2.Text = "aqui vai a dica 2";
            lbluserdica2.Click += lbluserdica2_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbluserdica2);
            Name = "UserControl2";
            Size = new Size(603, 368);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluserdica2;
    }
}
