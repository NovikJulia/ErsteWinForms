using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erste
{
    public partial class FormWindows : Form
    {
        public FormWindows()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            return;
        }

        private void FormWindows_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.smile;
        }
    }
}
