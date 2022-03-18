
namespace osuSBD
{
    partial class Download
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
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusTxt
            // 
            this.statusTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTxt.Location = new System.Drawing.Point(13, 13);
            this.statusTxt.Multiline = true;
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.ReadOnly = true;
            this.statusTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.statusTxt.Size = new System.Drawing.Size(775, 425);
            this.statusTxt.TabIndex = 0;
            this.statusTxt.WordWrap = false;
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusTxt);
            this.Name = "Download";
            this.Text = "osu! SBD";
            this.Load += new System.EventHandler(this.Download_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statusTxt;
    }
}