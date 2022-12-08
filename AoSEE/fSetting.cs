using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AoSEE
{
    public partial class fSetting : Form
    {
        public fSetting()
        {
            InitializeComponent();
            // Thiết lập các setting
            // Font
            if (Global.font == "Arial")
            {
                ftArial.Checked = true;
                ftTime.Checked = false;
            }
            else
            {
                ftArial.Checked = false;
                ftTime.Checked = true;
            }
            // Color
            if (Global.color == "Default")
            {
                clDefault.Checked = true;
                clBlue.Checked = false;
                clRed.Checked = false;
            }
            else if (Global.color == "Blue")
            {
                clDefault.Checked = false;
                clBlue.Checked = true;
                clRed.Checked = false;
            }
            else
            {
                clDefault.Checked = false;
                clBlue.Checked = false;
                clRed.Checked = true;
            }
            tbSetPath.Text = Global.path;
        }

        // Event click save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            SetResult(pnFont, 1);
            SetResult(pnColor, 2);
            Global.path = $@"{tbSetPath.Text}";
            this.Close();
        }
        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = ResourcePic.HoverStart;
        }
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = ResourcePic.btnStart1;
        }

        // Event click cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = ResourcePic.HoverExit;
            btn.ForeColor = Color.White;
        }
        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = ResourcePic.btnExit;
            btn.ForeColor = Color.Red;
        }

        // Event click back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event click set path
        private void btnSetPath_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
        public void ChooseFolder()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbSetPath.Text = folderBrowserDialog.SelectedPath + @"\result.txt";
            }
        }

        // Event click open button
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = @Global.path; 
                var process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = fileName };
                process.Start();
            }
            catch
            {
                MessageBox.Show("File does not exist, Please check again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void SetResult(Panel pnl, int temp)
        {
            RadioButton rdChecked = null;

            foreach (RadioButton item in pnl.Controls)
            {
                if (item != null)
                {
                    if (item.Checked)
                    {
                        rdChecked = item;
                        break;
                    }
                }
            }
            if (temp == 1)
            {
                Global.font = rdChecked.Text;
            }
            if (temp == 2)
            {
                Global.color = rdChecked.Text;
            }
        }
    }
}
