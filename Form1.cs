using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace YouTube_Downloader_New
{
    public partial class Form1 : Form
    {
        public YouTube youtube;
        public Video vid;
        string urlBeginning = "https://img.youtube.com/vi/";
        string urlEnding = "/hqdefault.jpg";
        string trimUrl;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            youtube = YouTube.Default;
            vid = youtube.GetVideo(txtURL.Text);
            lblTitle.Text = vid.Title;
            lblAuthor.Text = vid.Info.Author;
            trimUrl = txtURL.Text.Substring(txtURL.Text.IndexOf("=")+1);
            imgVideo.Load(urlBeginning + trimUrl + urlEnding);
            TimeSpan time = TimeSpan.FromSeconds(vid.Info.LengthSeconds.Value);
            string displayTime = time.ToString(@"hh\:mm\:ss");
            lblTime.Text = displayTime;
            pnlControls.Visible = true;
            lblStatus.Text = "Video Ready For Download";
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "MP4 File (*.MP4)|*.MP4";
            saveFileDialog.FileName = vid.Title;
            lblStatus.Text = "Currently Saving...";
            var result = saveFileDialog.ShowDialog();
            try
            {
                if (result == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(saveFileDialog.FileName, vid.GetBytes());
                    lblStatus.Text = "Video Successfully Saved!";
                }
                else if (result == DialogResult.Cancel)
                {
                    lblStatus.Text = "Cancelled Saving";
                }
            }
            catch (Exception)
            {
                result = DialogResult.Cancel;
            }
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "MP3 File (*.mp3)|*.mp3";
            saveFileDialog.FileName = vid.Title;
            lblStatus.Text = "Currently Saving...";
            var result = saveFileDialog.ShowDialog();
            try
            {
                if (result == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(saveFileDialog.FileName, vid.GetBytes());
                    lblStatus.Text = "Audio Successfully Saved!";
                }
                else if (result == DialogResult.Cancel)
                {
                    lblStatus.Text = "Cancelled Saving";
                }
            }
            catch (Exception)
            {
                result = DialogResult.Cancel;
            }
        }
    }
}
