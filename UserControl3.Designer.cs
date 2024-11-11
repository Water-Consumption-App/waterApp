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
            lbluserdica3 = new Label();
            SuspendLayout();
            // 
            // lbluserdica3
            // 
            lbluserdica3.AutoSize = true;
            lbluserdica3.Location = new Point(209, 148);
            lbluserdica3.Name = "lbluserdica3";
            lbluserdica3.Size = new Size(117, 20);
            lbluserdica3.TabIndex = 0;
            lbluserdica3.Text = "aqui vai a dica 3";
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbluserdica3);
            Name = "UserControl3";
            Size = new Size(604, 370);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluserdica3;
    }
}
