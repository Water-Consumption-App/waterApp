namespace waterApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            pnHome = new Panel();
            button1 = new Button();
            pnCredits = new Panel();
            button4 = new Button();
            pnGame = new Panel();
            button3 = new Button();
            pnInfo = new Panel();
            button2 = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            pnHome.SuspendLayout();
            pnCredits.SuspendLayout();
            pnGame.SuspendLayout();
            pnInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1166, 43);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 13);
            label1.Name = "label1";
            label1.Size = new Size(144, 17);
            label1.TabIndex = 2;
            label1.Text = "Water Comsuption App";
            // 
            // btnHam
            // 
            btnHam.Cursor = Cursors.No;
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(12, 9);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(27, 23);
            btnHam.SizeMode = PictureBoxSizeMode.Zoom;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.SteelBlue;
            sidebar.Controls.Add(pnHome);
            sidebar.Controls.Add(pnCredits);
            sidebar.Controls.Add(pnGame);
            sidebar.Controls.Add(pnInfo);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 43);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(251, 549);
            sidebar.TabIndex = 1;
            // 
            // pnHome
            // 
            pnHome.Controls.Add(button1);
            pnHome.Location = new Point(0, 0);
            pnHome.Margin = new Padding(0);
            pnHome.Name = "pnHome";
            pnHome.Size = new Size(251, 55);
            pnHome.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-5, -48);
            button1.Name = "button1";
            button1.Size = new Size(277, 153);
            button1.TabIndex = 2;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnCredits
            // 
            pnCredits.Controls.Add(button4);
            pnCredits.Location = new Point(0, 55);
            pnCredits.Margin = new Padding(0);
            pnCredits.Name = "pnCredits";
            pnCredits.Size = new Size(251, 55);
            pnCredits.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-5, -46);
            button4.Name = "button4";
            button4.Size = new Size(277, 153);
            button4.TabIndex = 2;
            button4.Text = "CRÉDITOS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pnGame
            // 
            pnGame.Controls.Add(button3);
            pnGame.Location = new Point(0, 110);
            pnGame.Margin = new Padding(0);
            pnGame.Name = "pnGame";
            pnGame.Size = new Size(251, 55);
            pnGame.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-5, -46);
            button3.Name = "button3";
            button3.Size = new Size(277, 153);
            button3.TabIndex = 2;
            button3.Text = "GAME";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pnInfo
            // 
            pnInfo.Controls.Add(button2);
            pnInfo.Location = new Point(0, 165);
            pnInfo.Margin = new Padding(0);
            pnInfo.Name = "pnInfo";
            pnInfo.Size = new Size(251, 55);
            pnInfo.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-5, -46);
            button2.Name = "button2";
            button2.Size = new Size(277, 153);
            button2.TabIndex = 2;
            button2.Text = "INFO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1166, 592);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            pnHome.ResumeLayout(false);
            pnCredits.ResumeLayout(false);
            pnGame.ResumeLayout(false);
            pnInfo.ResumeLayout(false);
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
    }
}
