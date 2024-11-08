namespace waterApp
{
    partial class formHome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            labelStatistics = new Label();
            labelLegalInfo = new Label();
            progressBarConsumption = new ProgressBar();

            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(451, 50);
            label1.Name = "label1";
            label1.Size = new Size(127, 47);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // labelStatistics
            // 
            labelStatistics.AutoSize = true;
            labelStatistics.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatistics.Location = new Point(100, 150);
            labelStatistics.Name = "labelStatistics";
            labelStatistics.Size = new Size(400, 21);
            labelStatistics.TabIndex = 1;
            labelStatistics.Text = "Estatísticas: Consumo de água esta semana foi 20% menor.";

            // 
            // progressBarConsumption
            // 
            progressBarConsumption.Location = new Point(100, 200);
            progressBarConsumption.Name = "progressBarConsumption";
            progressBarConsumption.Size = new Size(400, 30);
            progressBarConsumption.TabIndex = 2;
            progressBarConsumption.Value = 50; // Exemplo: 50% do consumo atingido dps tem q add o valor real, nao ffaço ideia de api <3

            // 
            // labelLegalInfo
            // 
            labelLegalInfo.AutoSize = true;
            labelLegalInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLegalInfo.Location = new Point(100, 270);
            labelLegalInfo.Name = "labelLegalInfo";
            labelLegalInfo.Size = new Size(350, 21);
            labelLegalInfo.TabIndex = 3;
            labelLegalInfo.Text = "Aviso: Respeite as normas locais de consumo de água.";

            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 720);
            Controls.Add(label1);
            Controls.Add(labelStatistics);
            Controls.Add(progressBarConsumption);
            Controls.Add(labelLegalInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formHome";
            Text = "formHome";
            Load += formHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelStatistics;
        private Label labelLegalInfo;
        private ProgressBar progressBarConsumption;
    }
}
