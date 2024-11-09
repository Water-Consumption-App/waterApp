namespace waterApp
{
    partial class UserControl5
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
            lbluserdica5 = new Label();
            SuspendLayout();
            // 
            // lbluserdica5
            // 
            lbluserdica5.AutoSize = true;
            lbluserdica5.Location = new Point(209, 165);
            lbluserdica5.Name = "lbluserdica5";
            lbluserdica5.Size = new Size(117, 20);
            lbluserdica5.TabIndex = 0;
            lbluserdica5.Text = "aqui vai a dica 5";
            // 
            // UserControl5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbluserdica5);
            Name = "UserControl5";
            Size = new Size(583, 368);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluserdica5;
    }
}
