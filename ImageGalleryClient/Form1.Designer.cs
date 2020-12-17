using System;
using System.Windows.Forms;

namespace ImageGalleryClient
{
	partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._imageGalleryControl = new SIL.Windows.Forms.ImageToolbox.ImageGallery.ImageGalleryControl();
            this._checkForCollectionsTimer = new System.Windows.Forms.Timer(this.components);
            this._noCollectionsMessage = new SIL.Windows.Forms.Widgets.BetterLabel();
            this._fixSizingTimer = new System.Windows.Forms.Timer(this.components);
            this.clipboardButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _imageGalleryControl
            // 
            this._imageGalleryControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._imageGalleryControl.Location = new System.Drawing.Point(5, 0);
            this._imageGalleryControl.Name = "_imageGalleryControl";
            this._imageGalleryControl.SearchLanguage = "en";
            this._imageGalleryControl.Size = new System.Drawing.Size(794, 389);
            this._imageGalleryControl.TabIndex = 2;
            this._imageGalleryControl.ImageChanged += new System.EventHandler(this.onImageChanged);
            // 
            // _checkForCollectionsTimer
            // 
            this._checkForCollectionsTimer.Enabled = true;
            this._checkForCollectionsTimer.Interval = 1000;
            this._checkForCollectionsTimer.Tick += new System.EventHandler(this._checkForCollectionsTimer_Tick);
            // 
            // _noCollectionsMessage
            // 
            this._noCollectionsMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._noCollectionsMessage.Enabled = false;
            this._noCollectionsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._noCollectionsMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this._noCollectionsMessage.IsTextSelectable = false;
            this._noCollectionsMessage.Location = new System.Drawing.Point(198, 124);
            this._noCollectionsMessage.Multiline = true;
            this._noCollectionsMessage.Name = "_noCollectionsMessage";
            this._noCollectionsMessage.ReadOnly = true;
            this._noCollectionsMessage.Size = new System.Drawing.Size(337, 60);
            this._noCollectionsMessage.TabIndex = 3;
            this._noCollectionsMessage.TabStop = false;
            this._noCollectionsMessage.Text = "Please install one or more Bloom-compatible image collections on this computer fi" +
    "rst, for example https://bloomlibrary.org/artofreading.";
            this._noCollectionsMessage.Visible = false;
            // 
            // _fixSizingTimer
            // 
            this._fixSizingTimer.Enabled = true;
            this._fixSizingTimer.Tick += new System.EventHandler(this._fixSizingTimer_Tick);
            // 
            // clipboardButton
            // 
            this.clipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clipboardButton.Image = global::ImageGalleryClient.Properties.Resources.baseline_file_copy_black_18dp1;
            this.clipboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clipboardButton.Location = new System.Drawing.Point(640, 395);
            this.clipboardButton.Name = "clipboardButton";
            this.clipboardButton.Size = new System.Drawing.Size(119, 32);
            this.clipboardButton.TabIndex = 1;
            this.clipboardButton.Text = "Copy to Clipboard";
            this.clipboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clipboardButton.UseVisualStyleBackColor = true;
            this.clipboardButton.Click += new System.EventHandler(this.OnClipboardClick);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.Image = global::ImageGalleryClient.Properties.Resources.baseline_save_alt_black_18dp;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(576, 395);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(58, 32);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "    Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._noCollectionsMessage);
            this.Controls.Add(this._imageGalleryControl);
            this.Controls.Add(this.clipboardButton);
            this.Controls.Add(this.saveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Image Galleries";
            this.ResumeLayout(false);
            this.PerformLayout();

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

        #endregion

        private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button clipboardButton;
		private SIL.Windows.Forms.ImageToolbox.ImageGallery.ImageGalleryControl _imageGalleryControl;
		private System.Windows.Forms.Timer _checkForCollectionsTimer;
		private SIL.Windows.Forms.Widgets.BetterLabel _noCollectionsMessage;
		private System.Windows.Forms.Timer _fixSizingTimer;
	}
}

