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
using System.Globalization;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (optFile.ShowDialog() == DialogResult.OK)
            {
                txt2.Text = optFile.FileName;
            }

            txt1.Text = Path.GetFileName(optFile.FileName);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt1.Text) || string.IsNullOrWhiteSpace(txt2.Text))
            {
                MessageBox.Show("Please select a file before copying.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string destinationFileName = Path.Combine(Application.StartupPath, txt1.Text);
            string sourcePath = txt2.Text;

            try
            {
                // If the source is a directory, copy its contents recursively
                if (Directory.Exists(sourcePath))
                {
                    CopyDirectory(sourcePath, Application.StartupPath);
                }
                else
                {
                    // If the source is a single file, handle it as before
                    if (File.Exists(destinationFileName))
                    {
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(txt1.Text);
                        string extension = Path.GetExtension(txt1.Text);
                        string newFileName = $"{fileNameWithoutExtension}_Copy{extension}";

                        destinationFileName = Path.Combine(Application.StartupPath, newFileName);
                    }

                    File.Copy(sourcePath, destinationFileName, true);
                }

                MessageBox.Show("File(s) copied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying file(s): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt1.Text = "";
            txt2.Text = "";
        }

        private void CopyDirectory(string sourceDir, string destDir)
        {
            if (!Directory.Exists(destDir))
            {
                Directory.CreateDirectory(destDir);
            }

            foreach (var file in Directory.GetFiles(sourceDir))
            {
                string fileName = Path.GetFileName(file);
                string destPath = Path.Combine(destDir, fileName);

                int count = 1;
                while (File.Exists(destPath))
                {
                    string newFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_{count}{Path.GetExtension(fileName)}";
                    destPath = Path.Combine(destDir, newFileName);
                    count++;
                }

                File.Copy(file, destPath);
            }

            foreach (var subDir in Directory.GetDirectories(sourceDir))
            {
                string dirName = Path.GetFileName(subDir);
                string destSubDir = Path.Combine(destDir, dirName);
                CopyDirectory(subDir, destSubDir);
            }
        }
    }
}