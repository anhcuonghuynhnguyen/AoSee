using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AoSEE
{
    public partial class fTutorial : Form
    {
        public fTutorial()
        {
            InitializeComponent();
            this.Icon = ResourcePic.LogoIcon1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
