namespace AoSEE
{
    partial class fSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSetting));
            this.ptLogo = new System.Windows.Forms.PictureBox();
            this.pnsetting = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.tbSetPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnFont = new System.Windows.Forms.Panel();
            this.ftTime = new System.Windows.Forms.RadioButton();
            this.ftArial = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnColor = new System.Windows.Forms.Panel();
            this.clDefault = new System.Windows.Forms.RadioButton();
            this.clBlue = new System.Windows.Forms.RadioButton();
            this.clRed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).BeginInit();
            this.pnsetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnFont.SuspendLayout();
            this.pnColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptLogo
            // 
            this.ptLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptLogo.BackgroundImage = global::AoSEE.ResourcePic.Logo;
            this.ptLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptLogo.Location = new System.Drawing.Point(43, 33);
            this.ptLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptLogo.Name = "ptLogo";
            this.ptLogo.Size = new System.Drawing.Size(143, 67);
            this.ptLogo.TabIndex = 2;
            this.ptLogo.TabStop = false;
            // 
            // pnsetting
            // 
            this.pnsetting.BackColor = System.Drawing.Color.Transparent;
            this.pnsetting.BackgroundImage = global::AoSEE.ResourcePic.BGBorder;
            this.pnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnsetting.Controls.Add(this.btnCancel);
            this.pnsetting.Controls.Add(this.btnSave);
            this.pnsetting.Controls.Add(this.panel1);
            this.pnsetting.Controls.Add(this.pnFont);
            this.pnsetting.Controls.Add(this.pnColor);
            this.pnsetting.Controls.Add(this.lbStart);
            this.pnsetting.Controls.Add(this.btnBack);
            this.pnsetting.Location = new System.Drawing.Point(281, 183);
            this.pnsetting.Name = "pnsetting";
            this.pnsetting.Size = new System.Drawing.Size(790, 700);
            this.pnsetting.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::AoSEE.ResourcePic.btnExit;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(533, 427);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 67);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::AoSEE.ResourcePic.btnStart1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(533, 350);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 67);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnSetPath);
            this.panel1.Controls.Add(this.tbSetPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(53, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 167);
            this.panel1.TabIndex = 8;
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(270, 95);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 48);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSetPath
            // 
            this.btnSetPath.AutoSize = true;
            this.btnSetPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetPath.Location = new System.Drawing.Point(331, 42);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(50, 35);
            this.btnSetPath.TabIndex = 2;
            this.btnSetPath.Text = "...";
            this.btnSetPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // tbSetPath
            // 
            this.tbSetPath.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSetPath.Location = new System.Drawing.Point(30, 42);
            this.tbSetPath.Name = "tbSetPath";
            this.tbSetPath.Size = new System.Drawing.Size(295, 33);
            this.tbSetPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Path to save :";
            // 
            // pnFont
            // 
            this.pnFont.Controls.Add(this.ftTime);
            this.pnFont.Controls.Add(this.ftArial);
            this.pnFont.Controls.Add(this.label2);
            this.pnFont.Location = new System.Drawing.Point(441, 167);
            this.pnFont.Name = "pnFont";
            this.pnFont.Size = new System.Drawing.Size(326, 137);
            this.pnFont.TabIndex = 7;
            // 
            // ftTime
            // 
            this.ftTime.AutoSize = true;
            this.ftTime.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ftTime.Location = new System.Drawing.Point(34, 77);
            this.ftTime.Name = "ftTime";
            this.ftTime.Size = new System.Drawing.Size(181, 26);
            this.ftTime.TabIndex = 10;
            this.ftTime.TabStop = true;
            this.ftTime.Text = "Time new Romans";
            this.ftTime.UseVisualStyleBackColor = true;
            // 
            // ftArial
            // 
            this.ftArial.AutoSize = true;
            this.ftArial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ftArial.Location = new System.Drawing.Point(34, 35);
            this.ftArial.Name = "ftArial";
            this.ftArial.Size = new System.Drawing.Size(77, 32);
            this.ftArial.TabIndex = 9;
            this.ftArial.TabStop = true;
            this.ftArial.Text = "Arial";
            this.ftArial.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Font :";
            // 
            // pnColor
            // 
            this.pnColor.Controls.Add(this.clDefault);
            this.pnColor.Controls.Add(this.clBlue);
            this.pnColor.Controls.Add(this.clRed);
            this.pnColor.Controls.Add(this.label1);
            this.pnColor.Location = new System.Drawing.Point(53, 167);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(326, 137);
            this.pnColor.TabIndex = 6;
            // 
            // clDefault
            // 
            this.clDefault.AutoSize = true;
            this.clDefault.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clDefault.ForeColor = System.Drawing.Color.Black;
            this.clDefault.Location = new System.Drawing.Point(30, 32);
            this.clDefault.Name = "clDefault";
            this.clDefault.Size = new System.Drawing.Size(97, 27);
            this.clDefault.TabIndex = 3;
            this.clDefault.TabStop = true;
            this.clDefault.Text = "Default";
            this.clDefault.UseVisualStyleBackColor = true;
            // 
            // clBlue
            // 
            this.clBlue.AutoSize = true;
            this.clBlue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clBlue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clBlue.Location = new System.Drawing.Point(30, 105);
            this.clBlue.Name = "clBlue";
            this.clBlue.Size = new System.Drawing.Size(73, 27);
            this.clBlue.TabIndex = 2;
            this.clBlue.TabStop = true;
            this.clBlue.Text = "Blue";
            this.clBlue.UseVisualStyleBackColor = true;
            // 
            // clRed
            // 
            this.clRed.AutoSize = true;
            this.clRed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clRed.ForeColor = System.Drawing.Color.Red;
            this.clRed.Location = new System.Drawing.Point(30, 68);
            this.clRed.Name = "clRed";
            this.clRed.Size = new System.Drawing.Size(71, 27);
            this.clRed.TabIndex = 1;
            this.clRed.TabStop = true;
            this.clRed.Text = "Red";
            this.clRed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color :";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStart.Location = new System.Drawing.Point(316, 62);
            this.lbStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(159, 46);
            this.lbStart.TabIndex = 5;
            this.lbStart.Text = "Setting";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::AoSEE.ResourcePic.btnBack;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(26, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 52);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AoSEE.ResourcePic.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1349, 968);
            this.Controls.Add(this.pnsetting);
            this.Controls.Add(this.ptLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AoSEE (Application of stack expression evaluation)";
            ((System.ComponentModel.ISupportInitialize)(this.ptLogo)).EndInit();
            this.pnsetting.ResumeLayout(false);
            this.pnsetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnFont.ResumeLayout(false);
            this.pnFont.PerformLayout();
            this.pnColor.ResumeLayout(false);
            this.pnColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptLogo;
        private Panel pnsetting;
        private Button btnBack;
        private Label lbStart;
        private Panel pnFont;
        private Panel pnColor;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private RadioButton ftTime;
        private RadioButton ftArial;
        private RadioButton clBlue;
        private RadioButton clRed;
        private TextBox tbSetPath;
        private Button btnCancel;
        private Button btnSave;
        private Button btnSetPath;
        private RadioButton clDefault;
        private FolderBrowserDialog folderBrowserDialog;
        private Button btnOpen;
    }
}