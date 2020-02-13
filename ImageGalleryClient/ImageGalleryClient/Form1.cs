using System;
using System.Windows.Forms;
using SIL.Windows.Forms.ImageToolbox;
using SIL.Windows.Forms.ImageToolbox.ImageGallery;

namespace ImageGalleryClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			using (var imageInfo = new PalasoImage())  
			using (var dlg = new ImageToolboxDialog(imageInfo, null))
			{
				dlg.SearchLanguage = "en";
				var result = dlg.ShowDialog();
				if (DialogResult.OK == result && dlg.ImageInfo != null)
				{
					MessageBox.Show(dlg.ImageInfo.OriginalFilePath);
				}
			}
		}
	}
}
