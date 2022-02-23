
namespace ShortcutCreator
{
    partial class frmShortcutCreator
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
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnDestination = new System.Windows.Forms.Button();
            this.lstTargets = new System.Windows.Forms.ListBox();
            this.lblTargets = new System.Windows.Forms.Label();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dlgSelectTargetFiles = new System.Windows.Forms.OpenFileDialog();
            this.dlgSelectDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.dlgSelectTargetFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(132, 12);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(308, 20);
            this.txtDestination.TabIndex = 1;
            this.txtDestination.TabStop = false;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(12, 15);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(114, 13);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "Shortcut(s) Destination";
            // 
            // btnDestination
            // 
            this.btnDestination.AutoSize = true;
            this.btnDestination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDestination.Location = new System.Drawing.Point(446, 10);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(26, 23);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // lstTargets
            // 
            this.lstTargets.FormattingEnabled = true;
            this.lstTargets.HorizontalScrollbar = true;
            this.lstTargets.Location = new System.Drawing.Point(12, 62);
            this.lstTargets.Name = "lstTargets";
            this.lstTargets.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTargets.Size = new System.Drawing.Size(460, 108);
            this.lstTargets.TabIndex = 4;
            this.lstTargets.SelectedIndexChanged += new System.EventHandler(this.lstTargets_SelectedIndexChanged);
            // 
            // lblTargets
            // 
            this.lblTargets.AutoSize = true;
            this.lblTargets.Location = new System.Drawing.Point(12, 46);
            this.lblTargets.Name = "lblTargets";
            this.lblTargets.Size = new System.Drawing.Size(92, 13);
            this.lblTargets.TabIndex = 3;
            this.lblTargets.Text = "Shortcut Target(s)";
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.AutoSize = true;
            this.btnAddFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddFiles.Location = new System.Drawing.Point(50, 176);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(66, 23);
            this.btnAddFiles.TabIndex = 5;
            this.btnAddFiles.Text = "Add File(s)";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(306, 176);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create Shortcut(s)";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(196, 176);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(57, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dlgSelectTargetFiles
            // 
            this.dlgSelectTargetFiles.Multiselect = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(259, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(41, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.AutoSize = true;
            this.btnAddFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddFolder.Location = new System.Drawing.Point(122, 176);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(68, 23);
            this.btnAddFolder.TabIndex = 6;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // frmShortcutCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.lblTargets);
            this.Controls.Add(this.lstTargets);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDestination);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "frmShortcutCreator";
            this.Text = "Shortcut Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.ListBox lstTargets;
        private System.Windows.Forms.Label lblTargets;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.OpenFileDialog dlgSelectTargetFiles;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectTargetFolder;
        private System.Windows.Forms.Button btnAddFolder;
    }
}

