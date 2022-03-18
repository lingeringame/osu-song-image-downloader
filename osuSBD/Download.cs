using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace osuSBD
{
    public partial class Download : Form
    {
        public string source;
        public string destination;
        public string type;
        public string[] imageTypes = { "*jpg", "*jpeg", "*gif", "*tiff", "*bmp", "*png", "*webp" };
        //public string[] audioTypes = {} will add more audio types later
        public string appTitle = "osu! SBD";
        public Download()
        {
            InitializeComponent();
        }
        public Download(string src, string dest, string type)
        {
            InitializeComponent();
            this.source = src;
            this.destination = dest;
            this.type = type;
            //MessageBox.Show($"Source: {src}, Dest: {dest}, type: {type}");


            //next add method that will search for either songs (.jpg,.png etc) or music (.mp3), depending on the type. 
        }

        private async void Download_Load(object sender, EventArgs e)
        {
            if (this.type == "bg")
            {
                try
                {
                    int flag = 0;
                    await Task.Run(() => CopyFilesRecursivelyAsync(source, destination, ref flag, type));
                    if (flag != 0)
                        this.DialogResult = DialogResult.Cancel;
                    statusTxt.Text += "Success";
                } catch(Exception ex)
                {
                    throw ex;
                }

            } else if(this.type == "song")
            {
                try
                {
                    int flag = 0;
                    CopyFilesRecursivelyAsync(source, destination, ref flag, type);
                    if (flag != 0)
                        this.DialogResult = DialogResult.Cancel;
                    statusTxt.Text += "Success";
                } catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void CopyFilesRecursivelyAsync(string source, string destination, ref int flag, string tp)
        {

            string[] files = new string[] { };
            string[] temp = new string[] { };
            //for background images
            if (tp == "bg")
            {
                foreach (var i in imageTypes)
                {
                    if (files.Length == 0)
                        files = Directory.GetFiles(source, i, SearchOption.AllDirectories);
                    else
                    {
                        //temp stores the new batch of images depending on the type and it's used to combine it with files[]
                        temp = Directory.GetFiles(source, i, SearchOption.AllDirectories);
                        files = files.Concat(temp).Distinct().ToArray();
                    }
                    Array.Clear(temp, 0, temp.Length);
                }
            } else if(tp == "song")
            {
                if (files.Length == 0)
                    files = Directory.GetFiles(source, "*mp3", SearchOption.AllDirectories);
                else
                {
                    //temp stores the new batch of images depending on the type and it's used to combine it with files[]
                    temp = Directory.GetFiles(source, "*mp3", SearchOption.AllDirectories);
                    files = files.Concat(temp).Distinct().ToArray();
                }
                Array.Clear(temp, 0, temp.Length);
            }


            if(files.Length == 0)
            {
                MessageBox.Show("No files found", appTitle);
                flag = 1;
                return;
            } else
            {
                foreach (string newPath in files)
                {
                    try
                    {
                        File.Copy(newPath, newPath.Replace(source, destination), true);
                        SetText($"{newPath} has been copied {Environment.NewLine}");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

        }
        //creates new thread
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.statusTxt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
                this.statusTxt.Text += text;
        }
    }
}
