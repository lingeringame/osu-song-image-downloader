using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osuSBD
{
    public partial class Welcome : Form
    {
        private string searchFolder;
        private string destFolder;
        private bool mouseDown;
        private Point lastLocation;
        private string appTitle = "osu! SBD";
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }
        //mouseDown, MouseMove, and MouseUp are handlers so that we can drag the form around since it is borderless
        private void Welcome_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location; //50x50
        }

        private void Welcome_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Welcome_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //closes current form
        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //search for path in your computer
        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fexp_search = new FolderBrowserDialog();
                //user actually selected path
                if (fexp_search.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //reminder to store the path. Should I make a "path" class or a tuple? Property? 
                    pathTxt.Text = fexp_search.SelectedPath;
                    searchFolder = fexp_search.SelectedPath;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Browse2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fexp_dest = new FolderBrowserDialog();
                //user actually selected path
                if (fexp_dest.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //reminder to store the path. Should I make a "path" class or a tuple? Property? 
                    DestTxt.Text = fexp_dest.SelectedPath;
                    destFolder = fexp_dest.SelectedPath;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //clicked backgrounds
        private void dl_bg_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchFolder) || string.IsNullOrEmpty(destFolder))
                MessageBox.Show("You must select a folder.", appTitle);
            else if (searchFolder == destFolder)
                MessageBox.Show("Directories cannot be the same", appTitle);
            else
            {
                //check if paths are empty otherwise proceed
                Download DLForm = new Download(searchFolder, destFolder, "bg");
                DLForm.ShowDialog();
            }

        }
        //clicked songs
        private void dl_s_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchFolder) || string.IsNullOrEmpty(destFolder))
                MessageBox.Show("You must select a folder.", appTitle);
            else if (searchFolder == destFolder)
                MessageBox.Show("Directories cannot be the same", appTitle);
            else
            {
                Download DLForm = new Download(searchFolder, destFolder, "song");
                DLForm.ShowDialog();
            }

        }

    }
}
