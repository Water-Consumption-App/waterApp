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
            lbluserdica1 = new Label();
            SuspendLayout();
            // 
            // lbluserdica1
            // 
            lbluserdica1.AutoSize = true;
            lbluserdica1.Location = new Point(208, 149);
            lbluserdica1.Name = "lbluserdica1";
            lbluserdica1.Size = new Size(117, 20);
            lbluserdica1.TabIndex = 0;
            lbluserdica1.Text = "aqui vai a dica 1";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbluserdica1);
            Name = "UserControl1";
            Size = new Size(589, 369);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluserdica1;
    }
}
