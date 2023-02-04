using SubtitlesFixLibrary.FileOperations;
using SubtitlesFixLibrary.Helper;
using SubtitlesFixLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubtitlesFixUI
{
    public partial class DashboardForm : Form
    {
        private FileDetailModel? newFileDetail;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fileTextBox.Text = openFileDialog.FileName;

                    // Get new file details
                    newFileDetail = FilePathHelper.GetNewFileDetail(openFileDialog.FileName);

                    if(newFileDetail != null)
                    {
                        newFileNameTextBox.Text = newFileDetail.NameWithExtension;
                    }
                    else
                    {
                        MessageBox.Show($"Error reading file {openFileDialog.FileName}");
                    }
                }
                else
                {
                    ClearForm();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            fileTextBox.Text = "";
            newFileNameTextBox.Text = "";
            newFileDetail = null;
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(fileTextBox.Text))
            {
                if(newFileDetail != null)
                {
                    //List<SubtitleModel> subtitles = FileReadWrite.ReadSubtitles(fileTextBox.Text);
                    //FileReadWrite.WriteAllSubtitles(subtitles, newFileDetail.FullPathName);

                    MessageBox.Show(
                        $"Subtitles are fixed and saved to the new file: {newFileDetail.FullPathName}",
                        "Subtitles fixed!");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cannot generate new file.");
                }
            }
            else
            {
                MessageBox.Show("Please select a file to fix first.");
            }
        }
    }
}
