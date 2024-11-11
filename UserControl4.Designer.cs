namespace waterApp
{
    partial class UserControl4
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
            lbluserdica4 = new Label();
            SuspendLayout();
            // 
            // lbluserdica4
            // 
            lbluserdica4.AutoSize = true;
            lbluserdica4.Location = new Point(193, 157);
            lbluserdica4.Name = "lbluserdica4";
            lbluserdica4.Size = new Size(117, 20);
            lbluserdica4.TabIndex = 0;
            lbluserdica4.Text = "aqui vai a dica 4";
            // 
            // UserControl4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbluserdica4);
            Name = "UserControl4";
            Size = new Size(594, 366);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluserdica4;
    }
}
