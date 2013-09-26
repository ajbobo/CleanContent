using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using folderSelect;

namespace CleanContent
{
	public enum Action
	{
		List,
		KeepNewest,
		DeleteAll
	}

	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();

			// Put the default directory in the GUI
			txtPath.Text = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			ScanDirectory(Action.List);
		}

		private void ScanDirectory(Action action)
		{
			if (action == Action.List)
				txtOutput.Text = "";

			string directory = txtPath.Text;
			DirectoryInfo topdir = new DirectoryInfo(directory);
			if (!topdir.Exists)
			{
				MessageBox.Show(directory, "Directory doesn't exist");
				return;
			}

			// Look through the files - find all of the flexsimcontent DLLs
			try
			{
				List<FileInfo> foundfiles = new List<FileInfo>();
				FileInfo[] files = topdir.GetFiles();

				// Find all of the DLLs - determine which is the newest
				FileInfo newest = null;
				foreach (FileInfo curfile in files)
				{
					if (curfile.Name.StartsWith("flexsimcontent"))
					{
						foundfiles.Add(curfile);
						if (newest == null || curfile.LastWriteTime > newest.LastWriteTime)
							newest = curfile;
					}
				}

				foreach (FileInfo curfile in foundfiles)
				{
					bool newfile = (curfile == newest);
					if (action == Action.List)
					{
						txtOutput.Text += (newfile ? "***\t" : "\t") + curfile.Name + "\t" + curfile.LastWriteTime + (newfile ? " ***" : "") + "\r\n";
					}
					else if (action == Action.DeleteAll)
					{
						curfile.Delete();
					}
					else if (action == Action.KeepNewest)
					{
						if (!newfile)
							curfile.Delete();
						else
							curfile.MoveTo("flexsimcontent.dll");
					}
				}

				if (foundfiles.Count == 0 && action == Action.List)
				{
					txtOutput.Text = "flexsimcontent.dll not found in the specified directory";
				}

				if (action != Action.List)
				{
					txtOutput.Text += "Files Updated\r\n";
				}
			}
			catch (Exception ex)
			{
				// This happens if the directory was deleted
				txtOutput.Text = "EX: " + ex.Message;
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			FolderSelect dlg = new FolderSelect();

			dlg.ShowDialog();

			txtPath.Text = dlg.fullPath;
			ScanDirectory(Action.List);
		}

		private void btnKeepNewest_Click(object sender, EventArgs e)
		{
			ScanDirectory(Action.KeepNewest);
		}

		private void btnDeleteAll_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Are you sure you want to delete all content DLLs?", "Delete All", MessageBoxButtons.YesNo);
			if (res == DialogResult.Yes)
				ScanDirectory(Action.DeleteAll);
		}
	}
}
