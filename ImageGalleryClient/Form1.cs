using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageGalleryClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.clipboardButton.Enabled = this.saveButton.Enabled = false;
        }
        void onImageChanged(object sender, EventArgs e)
        {
            this.clipboardButton.Enabled = this.saveButton.Enabled = this._imageGalleryControl.GetImage() != null;
        }
        private void OnSaveClick(object sender, EventArgs e)
        {
            if (this._imageGalleryControl.GetImage() == null)
            {
                MessageBox.Show("Please choose at least one image.");
            }
            else
            {
                var filename = this._imageGalleryControl.GetImage().FileName;
                using (var dialog = new SaveFileDialog
                {
                    Filter = "All files (*.*)|*.*",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    RestoreDirectory = true,
                    DefaultExt = Path.GetExtension(filename),
                    FileName = filename
                })
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        this._imageGalleryControl.GetImage().Save(dialog.FileName);
                    }
                }
            }

        }

        private void OnClipboardClick(object sender, EventArgs e)
        {
            if (this._imageGalleryControl.GetImage() == null)
            {
                MessageBox.Show("Please choose at least one image.");
            }
            else
            {
                Clipboard.SetImage(this._imageGalleryControl.GetImage().Image);
            }
        }

        private void _checkForCollectionsTimer_Tick(object sender, EventArgs e)
        {
            this._checkForCollectionsTimer.Enabled = false;
            if (!this._imageGalleryControl.HaveImageCollectionOnThisComputer)
            {
                this._imageGalleryControl.Visible = false;
                this._noCollectionsMessage.Visible = true;
            }
        }

        private void _fixSizingTimer_Tick(object sender, EventArgs e)
        {
            this._fixSizingTimer.Enabled = false;
            // for some reason, the _messageLabel that says "In the box above, type what..."
            // is cut off initially... something is going wrong with the sizing. If we
            // cause it to recalculate things after a short delay, all is well
            this.Size = new Size(this.Size.Width - 1, this.Size.Height);
        }
    }
}
