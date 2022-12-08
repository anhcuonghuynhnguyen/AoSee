using System.Xml.Linq;

namespace AoSEE
{
    public partial class fDashBoard : Form
    {
        public fDashBoard()
        {
            InitializeComponent();
        }

        // Button Start
        private void btnStart_Click(object sender, EventArgs e)
        {
            fStart fstart = new fStart();
            this.Hide();
            fstart.ShowDialog();
            this.Show();
        }
        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.BackgroundImage =  ResourcePic.HoverStart;
        }
        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackgroundImage = ResourcePic.btnStart;
        }

        // Button Help
        private void btnHelp_Click(object sender, EventArgs e)
        {
            fHelp fhelp = new fHelp();
            this.Hide();
            fhelp.ShowDialog();
            this.Show();
        }
        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            btnHelp.BackgroundImage = ResourcePic.HoverStart;
        }
        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.BackgroundImage = ResourcePic.btnStart;
        }

        // Button Setting
        private void btnSetting_Click(object sender, EventArgs e)
        {
            fSetting fsetting = new fSetting();
            this.Hide();
            fsetting.ShowDialog();
            this.Show();
        }
        private void btnSetting_MouseHover(object sender, EventArgs e)
        {
            btnSetting.BackgroundImage = ResourcePic.HoverStart;
        }
        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            btnSetting.BackgroundImage = ResourcePic.btnStart;
        }

        // Button Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = ResourcePic.HoverExit;
            btnExit.ForeColor = Color.White;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = ResourcePic.btnExit;
            btnExit.ForeColor = Color.Red;
        }
        private void fDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the app?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}