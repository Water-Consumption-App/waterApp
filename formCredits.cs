﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waterApp
{
    public partial class formCredits : Form
    {
        public formCredits()
        {
            InitializeComponent();
            this.Size = new Size(1080, 720);
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas
        }

        private void formCredits_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
