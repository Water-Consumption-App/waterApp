namespace waterApp
{
    partial class btn_cntc
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
            Card1 = new PictureBox();
            card2 = new PictureBox();
            ucPage1 = new ucPage1();
            img_btn_bk = new PictureBox();
            img_btn_bk2 = new PictureBox();
            ucPage2 = new ucPage2();
            pictureBox1 = new PictureBox();
            txt_hm2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_btn_bk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_btn_bk2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Card1
            // 
            Card1.BorderStyle = BorderStyle.Fixed3D;
            Card1.Cursor = Cursors.Hand;
            Card1.Image = Properties.Resources.Conheca;
            Card1.Location = new Point(139, 110);
            Card1.Name = "Card1";
            Card1.Size = new Size(357, 511);
            Card1.TabIndex = 0;
            Card1.TabStop = false;
            Card1.Click += Card1_Click;
            // 
            // card2
            // 
            card2.BorderStyle = BorderStyle.Fixed3D;
            card2.Cursor = Cursors.Hand;
            card2.Image = Properties.Resources.Curiosidades;
            card2.Location = new Point(580, 110);
            card2.Name = "card2";
            card2.Size = new Size(357, 511);
            card2.TabIndex = 0;
            card2.TabStop = false;
            card2.Click += card2_Click;
            // 
            // ucPage1
            // 
            ucPage1.BackColor = Color.FromArgb(128, 255, 128);
            ucPage1.BackgroundImageLayout = ImageLayout.None;
            ucPage1.Location = new Point(0, 0);
            ucPage1.Name = "ucPage1";
            ucPage1.Size = new Size(1080, 720);
            ucPage1.TabIndex = 2;
            // 
            // img_btn_bk
            // 
            img_btn_bk.Cursor = Cursors.Hand;
            img_btn_bk.Image = Properties.Resources.pngwing_com__1_;
            img_btn_bk.Location = new Point(12, 12);
            img_btn_bk.Name = "img_btn_bk";
            img_btn_bk.Size = new Size(50, 50);
            img_btn_bk.SizeMode = PictureBoxSizeMode.StretchImage;
            img_btn_bk.TabIndex = 3;
            img_btn_bk.TabStop = false;
            img_btn_bk.Click += pictureBox1_Click;
            // 
            // img_btn_bk2
            // 
            img_btn_bk2.Cursor = Cursors.Hand;
            img_btn_bk2.Image = Properties.Resources.pngwing2;
            img_btn_bk2.Location = new Point(12, 12);
            img_btn_bk2.Name = "img_btn_bk2";
            img_btn_bk2.Size = new Size(50, 50);
            img_btn_bk2.SizeMode = PictureBoxSizeMode.StretchImage;
            img_btn_bk2.TabIndex = 5;
            img_btn_bk2.TabStop = false;
            img_btn_bk2.Click += img_btn_bk2_Click;
            // 
            // ucPage2
            // 
            ucPage2.BackColor = Color.FromArgb(0, 14, 39);
            ucPage2.Location = new Point(0, 0);
            ucPage2.Name = "ucPage2";
            ucPage2.Size = new Size(1080, 720);
            ucPage2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(10, 29, 55);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(73, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(922, 590);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txt_hm2
            // 
            txt_hm2.AutoSize = true;
            txt_hm2.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_hm2.ForeColor = Color.White;
            txt_hm2.Location = new Point(312, 20);
            txt_hm2.Name = "txt_hm2";
            txt_hm2.Size = new Size(458, 42);
            txt_hm2.TabIndex = 7;
            txt_hm2.Text = "Por onde deseja comçar?";
            txt_hm2.Click += txt_hm_Click;
            // 
            // btn_cntc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 14, 39);
            ClientSize = new Size(1080, 720);
            Controls.Add(img_btn_bk);
            Controls.Add(img_btn_bk2);
            Controls.Add(ucPage2);
            Controls.Add(txt_hm2);
            Controls.Add(ucPage1);
            Controls.Add(Card1);
            Controls.Add(card2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "btn_cntc";
            Text = "formHome";
            Load += formHome_Load;
            ((System.ComponentModel.ISupportInitialize)Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_btn_bk).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_btn_bk2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Card1;
        private PictureBox card2;
        private ucPage1 ucPage1;
        private PictureBox img_btn_bk;
        private PictureBox img_btn_bk2;
        private ucPage2 ucPage2;
        private PictureBox pictureBox1;
        private Label txt_hm2;
    }
}
