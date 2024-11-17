namespace waterApp
{
    partial class formCarousel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCarousel));
            panelCarousel = new Panel();
            btnPrevious = new PictureBox();
            btnNext = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnPrevious).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCarousel
            // 
            panelCarousel.Location = new Point(105, 73);
            panelCarousel.Name = "panelCarousel";
            panelCarousel.Size = new Size(870, 568);
            panelCarousel.TabIndex = 4;
            // 
            // btnPrevious
            // 
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(-1, 343);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(100, 50);
            btnPrevious.SizeMode = PictureBoxSizeMode.Zoom;
            btnPrevious.TabIndex = 5;
            btnPrevious.TabStop = false;
            btnPrevious.Click += btnPrevious_Click_1;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(981, 343);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 50);
            btnNext.SizeMode = PictureBoxSizeMode.Zoom;
            btnNext.TabIndex = 6;
            btnNext.TabStop = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // formCarousel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 14, 39);
            ClientSize = new Size(1080, 720);
            Controls.Add(pictureBox1);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(panelCarousel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCarousel";
            Text = "formCarousel";
            Load += formCarousel_Load;
            ((System.ComponentModel.ISupportInitialize)btnPrevious).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCarousel;
        private PictureBox btnPrevious;
        private PictureBox btnNext;
        private PictureBox pictureBox1;
    }
}