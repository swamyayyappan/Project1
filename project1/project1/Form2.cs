using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
namespace project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();
           
            string rootDirectory = @"C:\";  
           
            TreeNode rootNode = new TreeNode(rootDirectory);
            treeView2.Nodes.Add(rootNode);
        
            AddDirectories(rootNode, rootDirectory);
        }


        private void AddDirectories(TreeNode parentNode, string path)
        {
            try
            {
              
                string[] directories = Directory.GetDirectories(path);

          
                foreach (string directory in directories)
                {
                
                    TreeNode directoryNode = new TreeNode(Path.GetFileName(directory));

                    parentNode.Nodes.Add(directoryNode);
              
                    AddDirectories(directoryNode, directory);
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access Denied");
            }
            catch (Exception ex)
            {
                parentNode.Nodes.Add($"Error: {ex.Message}");
            }
        }
    }
}
