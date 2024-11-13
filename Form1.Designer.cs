namespace waterApp
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            pnHome = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pnInfo = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            pnGame = new Panel();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            pnCredits = new Panel();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            pnHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 29, 55);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 43);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1089, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 2;
            label1.Text = "Poseidon's Journey";
            // 
            // btnHam
            // 
            btnHam.Cursor = Cursors.Hand;
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(8, 9);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(36, 25);
            btnHam.SizeMode = PictureBoxSizeMode.Zoom;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(10, 29, 55);
            sidebar.Controls.Add(pnHome);
            sidebar.Controls.Add(pnInfo);
            sidebar.Controls.Add(pnGame);
            sidebar.Controls.Add(pnCredits);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 43);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(52, 720);
            sidebar.TabIndex = 1;
            // 
            // pnHome
            // 
            pnHome.BackColor = Color.FromArgb(10, 29, 55);
            pnHome.Controls.Add(pictureBox1);
            pnHome.Controls.Add(button1);
            pnHome.ForeColor = Color.White;
            pnHome.Location = new Point(0, 0);
            pnHome.Margin = new Padding(0);
            pnHome.Name = "pnHome";
            pnHome.Size = new Size(292, 55);
            pnHome.TabIndex = 3;
            pnHome.Paint += pnHome_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 29, 55);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-6, -13);
            button1.Name = "button1";
            button1.Size = new Size(311, 84);
            button1.TabIndex = 2;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnInfo
            // 
            pnInfo.BackColor = Color.FromArgb(10, 29, 55);
            pnInfo.Controls.Add(pictureBox2);
            pnInfo.Controls.Add(button2);
            pnInfo.ForeColor = Color.White;
            pnInfo.Location = new Point(0, 55);
            pnInfo.Margin = new Padding(0);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(292, 55);
            pnInfo.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(10, 29, 55);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-6, -50);
            button2.Name = "button2";
            button2.Size = new Size(311, 153);
            button2.TabIndex = 2;
            button2.Text = "INFO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnGame
            // 
            pnGame.BackColor = Color.FromArgb(10, 29, 55);
            pnGame.Controls.Add(pictureBox3);
            pnGame.Controls.Add(button3);
            pnGame.ForeColor = Color.White;
            pnGame.Location = new Point(0, 110);
            pnGame.Margin = new Padding(0);
            pnGame.Name = "pnGame";
            pnGame.Size = new Size(292, 55);
            pnGame.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(10, 29, 55);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-6, -52);
            button3.Name = "button3";
            button3.Size = new Size(311, 153);
            button3.TabIndex = 2;
            button3.Text = "GAME";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pnCredits
            // 
            pnCredits.BackColor = Color.FromArgb(10, 29, 55);
            pnCredits.Controls.Add(pictureBox4);
            pnCredits.Controls.Add(button4);
            pnCredits.ForeColor = Color.White;
            pnCredits.Location = new Point(0, 165);
            pnCredits.Margin = new Padding(0);
            pnCredits.Name = "pnCredits";
            pnCredits.Size = new Size(292, 55);
            pnCredits.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(10, 29, 55);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-5, -52);
            button4.Name = "button4";
            button4.Size = new Size(310, 153);
            button4.TabIndex = 2;
            button4.Text = "CRÉDITOS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // formMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1132, 763);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "formMain";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            pnHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnCredits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button button1;
        private Panel pnHome;
        private Panel pnInfo;
        private Button button2;
        private Panel pnGame;
        private Button button3;
        private Panel pnCredits;
        private Button button4;
        private System.Windows.Forms.Timer sidebarTransition;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox5;
    }
}
