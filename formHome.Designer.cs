namespace waterApp
{
    partial class formHome
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
            img_bk_hm = new PictureBox();
            img_card1 = new PictureBox();
            img_card2 = new PictureBox();
            label_home = new Label();
            ucPage11 = new ucPage1();
            ucPage21 = new ucPage2();
            btn_back1 = new PictureBox();
            btn_back2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img_bk_hm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_back1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_back2).BeginInit();
            SuspendLayout();
            // 
            // img_bk_hm
            // 
            img_bk_hm.BackColor = Color.FromArgb(10, 29, 55);
            img_bk_hm.Location = new Point(79, 65);
            img_bk_hm.Name = "img_bk_hm";
            img_bk_hm.Size = new Size(922, 590);
            img_bk_hm.TabIndex = 0;
            img_bk_hm.TabStop = false;
            img_bk_hm.Click += pictureBox1_Click;
            // 
            // img_card1
            // 
            img_card1.Cursor = Cursors.Hand;
            img_card1.Image = Properties.Resources.Conheca;
            img_card1.Location = new Point(155, 104);
            img_card1.Name = "img_card1";
            img_card1.Size = new Size(357, 511);
            img_card1.TabIndex = 1;
            img_card1.TabStop = false;
            img_card1.Click += img_card1_Click;
            // 
            // img_card2
            // 
            img_card2.Cursor = Cursors.Hand;
            img_card2.Image = Properties.Resources.Curiosidades;
            img_card2.Location = new Point(573, 104);
            img_card2.Name = "img_card2";
            img_card2.Size = new Size(357, 511);
            img_card2.TabIndex = 2;
            img_card2.TabStop = false;
            img_card2.Click += img_card2_Click;
            // 
            // label_home
            // 
            label_home.AutoSize = true;
            label_home.Cursor = Cursors.Help;
            label_home.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_home.ForeColor = Color.White;
            label_home.Location = new Point(362, 16);
            label_home.Name = "label_home";
            label_home.Size = new Size(372, 33);
            label_home.TabIndex = 3;
            label_home.Text = "Por onde deseja começar?";
            label_home.Click += label_home_Click;
            // 
            // ucPage11
            // 
            ucPage11.BackColor = Color.FromArgb(0, 14, 39);
            ucPage11.BackgroundImageLayout = ImageLayout.None;
            ucPage11.Cursor = Cursors.Hand;
            ucPage11.Location = new Point(0, 0);
            ucPage11.Name = "ucPage11";
            ucPage11.Size = new Size(1080, 720);
            ucPage11.TabIndex = 4;
            // 
            // ucPage21
            // 
            ucPage21.BackColor = Color.FromArgb(0, 14, 39);
            ucPage21.Location = new Point(0, 0);
            ucPage21.Name = "ucPage21";
            ucPage21.Size = new Size(1080, 720);
            ucPage21.TabIndex = 5;
            // 
            // btn_back1
            // 
            btn_back1.Cursor = Cursors.Hand;
            btn_back1.Image = Properties.Resources.pngwing_com__1_;
            btn_back1.Location = new Point(12, 12);
            btn_back1.Name = "btn_back1";
            btn_back1.Size = new Size(50, 50);
            btn_back1.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back1.TabIndex = 6;
            btn_back1.TabStop = false;
            btn_back1.Click += btn_back1_Click;
            // 
            // btn_back2
            // 
            btn_back2.Cursor = Cursors.Hand;
            btn_back2.Image = Properties.Resources.pngwing2;
            btn_back2.Location = new Point(12, 12);
            btn_back2.Name = "btn_back2";
            btn_back2.Size = new Size(50, 50);
            btn_back2.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_back2.TabIndex = 7;
            btn_back2.TabStop = false;
            btn_back2.Click += btn_back2_Click;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 14, 39);
            ClientSize = new Size(1080, 720);
            Controls.Add(label_home);
            Controls.Add(btn_back2);
            Controls.Add(btn_back1);
            Controls.Add(ucPage21);
            Controls.Add(ucPage11);
            Controls.Add(img_card2);
            Controls.Add(img_card1);
            Controls.Add(img_bk_hm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formHome";
            Text = "formHome";
            Load += formHome_Load;
            ((System.ComponentModel.ISupportInitialize)img_bk_hm).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_back1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_back2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox img_bk_hm;
        private PictureBox img_card1;
        private PictureBox img_card2;
        private Label label_home;
        private ucPage1 ucPage11;
        private ucPage2 ucPage21;
        private PictureBox btn_back1;
        private PictureBox btn_back2;
    }
}