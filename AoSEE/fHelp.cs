using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            this.Icon = ResourcePic.LogoIcon1;
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
            fTutorial fTutorial = new fTutorial();
            fTutorial.ShowDialog();
        }
        private void btnQues2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("31211024087 - Lê Trần Khánh Phú\r\n31211024275 - Huỳnh Nguyễn Anh Cường\r\n31211027645 - Huỳnh Trịnh Tiến Khoa\r\n31211027688 - Nguyễn Ngọc Tường Vy", "About us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnQues3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The results will be saved in: \r\n" + Global.path + "\r\n\nYou can open it in Setting !!!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnQues4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can use the following operators: +, -, *, /, ^\r\nAnd brackets ( )", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnQues5_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://drive.google.com/drive/folders/1HXvAqzpQNOo5FKeIjdDfEVWBDgLy2bqb?usp=sharing", UseShellExecute = true });
        }
        private void btnQues6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://github.com/anhcuonghuynhnguyen/AoSee-1", UseShellExecute = true });
        }

    }
}
