using System;
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
    public partial class formInfo : Form
    {
        public formInfo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas
            this.Size = new Size(1080, 720); // Pode ser igual ao MDI parent ou ajustar conforme necessário
        }

        private void formInfo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
