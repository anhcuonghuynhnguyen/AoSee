namespace AoSEE
{
    partial class fTutorial
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
            this.picTutor = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTutor
            // 
            this.picTutor.BackgroundImage = global::AoSEE.ResourcePic.tutorial;
            this.picTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTutor.Location = new System.Drawing.Point(339, 12);
            this.picTutor.Name = "picTutor";
            this.picTutor.Size = new System.Drawing.Size(533, 369);
            this.picTutor.TabIndex = 0;
            this.picTutor.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(11, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 26);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 342);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "5. Postfix expression will be displayed here.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "4. Results will be displayed here.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 77);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. If the expression is valid this button will light up and you can click them to" +
    " calculate.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Check the validity of the expression here.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Enter your expression here, you can only use +, -, *, /, ^ and brackets ( ). E" +
    "lements must be separated by the \"space\" character.";
            // 
            // fTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picTutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fTutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How to use ?";
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picTutor;
        private Button btnBack;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}