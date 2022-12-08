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
    public partial class fHelp : Form
    {
        public fHelp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnQues_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = ResourcePic.HoverStart;
        }
        private void btnQues_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = ResourcePic.btnStart1;
        }

        private void btnQues1_Click(object sender, EventArgs e)
        {

        }
    }
}
