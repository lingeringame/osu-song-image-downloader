
namespace osuSBD
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.exitLabel = new System.Windows.Forms.Label();
            this.dl_s_button = new System.Windows.Forms.Button();
            this.dl_bg_button = new System.Windows.Forms.Button();
            this.WelcomeDescLabel = new System.Windows.Forms.Label();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.browse1Btn = new System.Windows.Forms.Button();
            this.pathLbl = new System.Windows.Forms.Label();
            this.DestTxt = new System.Windows.Forms.TextBox();
            this.Browse2Btn = new System.Windows.Forms.Button();
            this.DestLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.exitLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitLabel.Location = new System.Drawing.Point(750, 367);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(26, 13);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "Exit";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // dl_s_button
            // 
            this.dl_s_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dl_s_button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.dl_s_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dl_s_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dl_s_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dl_s_button.Location = new System.Drawing.Point(597, 64);
            this.dl_s_button.Margin = new System.Windows.Forms.Padding(0);
            this.dl_s_button.Name = "dl_s_button";
            this.dl_s_button.Size = new System.Drawing.Size(175, 29);
            this.dl_s_button.TabIndex = 3;
            this.dl_s_button.Text = "Download songs";
            this.dl_s_button.UseVisualStyleBackColor = false;
            this.dl_s_button.Click += new System.EventHandler(this.dl_s_button_Click);
            // 
            // dl_bg_button
            // 
            this.dl_bg_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dl_bg_button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.dl_bg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dl_bg_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dl_bg_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dl_bg_button.Location = new System.Drawing.Point(597, 117);
            this.dl_bg_button.Margin = new System.Windows.Forms.Padding(0);
            this.dl_bg_button.Name = "dl_bg_button";
            this.dl_bg_button.Size = new System.Drawing.Size(175, 29);
            this.dl_bg_button.TabIndex = 2;
            this.dl_bg_button.Text = "Download backgrounds";
            this.dl_bg_button.UseVisualStyleBackColor = false;
            this.dl_bg_button.Click += new System.EventHandler(this.dl_bg_button_Click);
            // 
            // WelcomeDescLabel
            // 
            this.WelcomeDescLabel.AutoSize = true;
            this.WelcomeDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeDescLabel.Location = new System.Drawing.Point(18, 143);
            this.WelcomeDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeDescLabel.Name = "WelcomeDescLabel";
            this.WelcomeDescLabel.Size = new System.Drawing.Size(407, 51);
            this.WelcomeDescLabel.TabIndex = 1;
            this.WelcomeDescLabel.Text = "Select an option to download all of the background images\r\nfrom the soundtracks y" +
    "ou have downloaded on your local osu! drive\r\nor the soundtracks themselves.";
            // 
            // pathTxt
            // 
            this.pathTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTxt.Enabled = false;
            this.pathTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathTxt.Location = new System.Drawing.Point(18, 297);
            this.pathTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pathTxt.Multiline = true;
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(574, 25);
            this.pathTxt.TabIndex = 5;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 8);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(431, 135);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to osu! Song and \r\nBackground image \r\nDownloader.\r\n";
            // 
            // browse1Btn
            // 
            this.browse1Btn.BackColor = System.Drawing.Color.White;
            this.browse1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.browse1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse1Btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browse1Btn.ForeColor = System.Drawing.Color.Black;
            this.browse1Btn.Location = new System.Drawing.Point(597, 298);
            this.browse1Btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.browse1Btn.Name = "browse1Btn";
            this.browse1Btn.Size = new System.Drawing.Size(72, 24);
            this.browse1Btn.TabIndex = 6;
            this.browse1Btn.Text = "Browse";
            this.browse1Btn.UseVisualStyleBackColor = false;
            this.browse1Btn.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pathLbl
            // 
            this.pathLbl.AutoSize = true;
            this.pathLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pathLbl.Location = new System.Drawing.Point(18, 281);
            this.pathLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(245, 13);
            this.pathLbl.TabIndex = 7;
            this.pathLbl.Text = "Select the folder that you would like to search";
            // 
            // DestTxt
            // 
            this.DestTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestTxt.Enabled = false;
            this.DestTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DestTxt.Location = new System.Drawing.Point(18, 355);
            this.DestTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DestTxt.Multiline = true;
            this.DestTxt.Name = "DestTxt";
            this.DestTxt.Size = new System.Drawing.Size(574, 25);
            this.DestTxt.TabIndex = 8;
            // 
            // Browse2Btn
            // 
            this.Browse2Btn.BackColor = System.Drawing.Color.White;
            this.Browse2Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Browse2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse2Btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Browse2Btn.ForeColor = System.Drawing.Color.Black;
            this.Browse2Btn.Location = new System.Drawing.Point(597, 355);
            this.Browse2Btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Browse2Btn.Name = "Browse2Btn";
            this.Browse2Btn.Size = new System.Drawing.Size(72, 24);
            this.Browse2Btn.TabIndex = 9;
            this.Browse2Btn.Text = "Browse";
            this.Browse2Btn.UseVisualStyleBackColor = false;
            this.Browse2Btn.Click += new System.EventHandler(this.Browse2Btn_Click);
            // 
            // DestLbl
            // 
            this.DestLbl.AutoSize = true;
            this.DestLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DestLbl.Location = new System.Drawing.Point(18, 335);
            this.DestLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestLbl.Name = "DestLbl";
            this.DestLbl.Size = new System.Drawing.Size(325, 13);
            this.DestLbl.TabIndex = 10;
            this.DestLbl.Text = "Next, select the folder where you want your files to be saved.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DestLbl);
            this.Controls.Add(this.Browse2Btn);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.DestTxt);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.pathLbl);
            this.Controls.Add(this.dl_bg_button);
            this.Controls.Add(this.browse1Btn);
            this.Controls.Add(this.dl_s_button);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.WelcomeDescLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Welcome";
            this.Text = "osu! SBD";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Button dl_s_button;
        private System.Windows.Forms.Button dl_bg_button;
        private System.Windows.Forms.Label WelcomeDescLabel;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button browse1Btn;
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.TextBox DestTxt;
        private System.Windows.Forms.Button Browse2Btn;
        private System.Windows.Forms.Label DestLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

