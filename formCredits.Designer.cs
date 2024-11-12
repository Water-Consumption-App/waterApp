namespace waterApp
{
    partial class formCredits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCredits));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(255, 34);
            label1.Name = "label1";
            label1.Size = new Size(586, 44);
            label1.TabIndex = 0;
            label1.Text = "Programação de Computadores";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(472, 192);
            label2.Name = "label2";
            label2.Size = new Size(124, 24);
            label2.TabIndex = 1;
            label2.Text = "Integrantes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(444, 228);
            label3.Name = "label3";
            label3.Size = new Size(197, 75);
            label3.TabIndex = 2;
            label3.Text = "Bryan Joab Messias de Souza, \r\nDavi Guilherme Grigolin, \r\nFernando Rafael Lopes Filho, \r\nItalo Lenharo Thomazete\r\nVictor Augusto de Mattos Carbelotti";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(440, 337);
            label4.Name = "label4";
            label4.Size = new Size(187, 24);
            label4.TabIndex = 3;
            label4.Text = "Desenvolvimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(478, 116);
            label5.Name = "label5";
            label5.Size = new Size(109, 24);
            label5.TabIndex = 4;
            label5.Text = "Professor";
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(454, 150);
            label6.Name = "label6";
            label6.Size = new Size(168, 18);
            label6.TabIndex = 5;
            label6.Text = "Prof. Dr. Elvio Gilberto da Silva";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(507, 531);
            label8.Name = "label8";
            label8.Size = new Size(69, 24);
            label8.TabIndex = 7;
            label8.Text = "Apoio";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 378);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(361, 566);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // formCredits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1080, 720);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCredits";
            Text = "formCredits";
            Load += formCredits_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        public Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}