namespace project1
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("SDIN");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Axxist - SiteBytes", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Deleted Items");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Gearchiveerde e-mails");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Inbox");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mulder Connect");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Outbox");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sent Items");
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView2
            // 
            this.treeView2.CheckBoxes = true;
            this.treeView2.Location = new System.Drawing.Point(237, 182);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Node2";
            treeNode1.Text = "SDIN";
            treeNode2.Checked = true;
            treeNode2.Name = "Node0";
            treeNode2.Text = "Axxist - SiteBytes";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Deleted Items";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Gearchiveerde e-mails";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Inbox";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Mulder Connect";
            treeNode7.Name = "Node6";
            treeNode7.Text = "Outbox";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Sent Items";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView2.Size = new System.Drawing.Size(121, 97);
            this.treeView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button button1;
    }
}