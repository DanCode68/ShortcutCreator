using System;
using System.IO;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace ShortcutCreator
{
    public partial class frmShortcutCreator : Form
    {
        public frmShortcutCreator()
        {
            InitializeComponent();
        }

        private void CreateShortcut(string destinationPath, string targetPath)
        {
            IWshShell_Class wsh = new IWshShell_Class();
            IWshShortcut shortcut = (IWshShortcut) wsh.CreateShortcut(Path.Combine(Path.GetFullPath(destinationPath), Path.GetFileName(targetPath) + ".lnk"));
            shortcut.TargetPath = Path.GetFullPath(targetPath);
            shortcut.Save();
        }

        private void UpdateButtons()
        {
            btnRemove.Enabled = lstTargets.SelectedIndices.Count > 0;
            btnClear.Enabled = lstTargets.Items.Count > 0;
            btnCreate.Enabled = Directory.Exists(txtDestination.Text) && lstTargets.Items.Count > 0;
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSelectDestination.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtDestination.Text = dlgSelectDestination.SelectedPath;
            }

            UpdateButtons();
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSelectTargetFiles.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (string target in dlgSelectTargetFiles.FileNames)
                {
                    if (!lstTargets.Items.Contains(target))
                    {
                        lstTargets.Items.Add(target);
                    }
                }
            }

            UpdateButtons();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSelectTargetFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (!lstTargets.Items.Contains(dlgSelectTargetFolder.SelectedPath))
                {
                    lstTargets.Items.Add(dlgSelectTargetFolder.SelectedPath);
                }
            }

            UpdateButtons();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (lstTargets.SelectedIndices.Count > 0)
            {
                lstTargets.Items.RemoveAt(lstTargets.SelectedIndices[0]);
            }

            UpdateButtons();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstTargets.Items.Clear();
            UpdateButtons();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            foreach (object target in lstTargets.Items)
            {
                CreateShortcut(txtDestination.Text, target.ToString());
            }
        }

        private void lstTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }
    }
}