using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriCsharp.DriveInfo_Win_Project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			double totalSizeGB, totalFreeSizeGB;



			foreach (var driveInfo in DriveInfo.GetDrives())
			{

				//	WriteLine("DriverType : " + driveInfo.DriveType);
				if (driveInfo.IsReady)
				{
					treeView1.Nodes.Add(driveInfo.Name);
					totalSizeGB = driveInfo.TotalSize / 1073741824;
					totalFreeSizeGB = driveInfo.TotalFreeSpace / 1073741824;
					comboBox1.Items.Add(driveInfo.Name);
					listBox1.Items.Add(driveInfo.Name + " Total Size :" + totalSizeGB + " GB ,Free Space :" + totalFreeSizeGB + " GB");
					//WriteLine("RootDirectory : " + driveInfo.RootDirectory);
					//WriteLine("TotalFreeSpace : " + driveInfo.TotalFreeSpace);
				}

			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

			DriveInfo info = new DriveInfo(comboBox1.SelectedItem.ToString());
			double totalSizeGB, totalFreeSizeGB;
			totalSizeGB = info.TotalSize / 1073741824;
			totalFreeSizeGB = info.TotalFreeSpace / 1073741824;


			label1.Text = "Drive Name: " + info.Name + "\n";
			label1.Text += "Drive Label : " + info.VolumeLabel + "\n";
			label1.Text += "Drive Format : " + info.DriveFormat + "\n";
			//label1.Text += "Drive Free Space : " + info. + "\n";
			label1.Text += "Drive Total Size:" + totalSizeGB + "\n";
			label1.Text += "Drive Free Space : " + totalFreeSizeGB + "\n";

		}
	}
}
