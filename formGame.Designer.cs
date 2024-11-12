namespace waterApp
{
    partial class formGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGame));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 92, 153);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(92, 289);
            button1.Name = "button1";
            button1.Size = new Size(150, 60);
            button1.TabIndex = 1;
            button1.Text = "RESPOSTA1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(43, 92, 153);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(295, 289);
            button2.Name = "button2";
            button2.Size = new Size(150, 60);
            button2.TabIndex = 2;
            button2.Text = "RESPOSTA2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(43, 92, 153);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(510, 289);
            button3.Name = "button3";
            button3.Size = new Size(150, 60);
            button3.TabIndex = 3;
            button3.Text = "RESPOSTA3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(43, 92, 153);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(707, 289);
            button4.Name = "button4";
            button4.Size = new Size(150, 60);
            button4.TabIndex = 4;
            button4.Text = "RESPOSTA4";
            button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(92, 113);
            label5.Name = "label5";
            label5.Size = new Size(765, 89);
            label5.TabIndex = 9;
            label5.Text = "Pergunta aqui...";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.LightBlue;
            progressBar1.ForeColor = Color.DodgerBlue;
            progressBar1.Location = new Point(56, 158);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(300, 20);
            progressBar1.TabIndex = 10;
            // 
            // progressBar2
            // 
            progressBar2.BackColor = Color.LightGreen;
            progressBar2.ForeColor = Color.Red;
            progressBar2.Location = new Point(711, 158);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(300, 20);
            progressBar2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(776, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 181);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 14;
            label1.Text = "Mr. Gota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(823, 181);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 15;
            label2.Text = "Dr. Consumo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 29, 55);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(56, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 400);
            panel1.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(362, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(343, 166);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // formGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 14, 39);
            ClientSize = new Size(1080, 720);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(progressBar2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formGame";
            Text = "Form Game";
            Load += formGame_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox3;
    }
}
