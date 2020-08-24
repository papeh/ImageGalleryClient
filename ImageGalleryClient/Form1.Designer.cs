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
            this.saveButton = new System.Windows.Forms.Button();
            this.clipboardButton = new System.Windows.Forms.Button();
            this._imageGalleryControl = new SIL.Windows.Forms.ImageToolbox.ImageGallery.ImageGalleryControl();
            this._checkForCollectionsTimer = new System.Windows.Forms.Timer(this.components);
            this._noCollectionsMessage = new SIL.Windows.Forms.Widgets.BetterLabel();
            this._fixSizingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // clipboardButton
            // 
            resources.ApplyResources(this.clipboardButton, "clipboardButton");
            this.clipboardButton.Name = "clipboardButton";
            this.clipboardButton.UseVisualStyleBackColor = true;
            this.clipboardButton.Click += new System.EventHandler(this.OnClipboardClick);
            // 
            // _imageGalleryControl
            // 
            resources.ApplyResources(this._imageGalleryControl, "_imageGalleryControl");
            this._imageGalleryControl.Name = "_imageGalleryControl";
            this._imageGalleryControl.SearchLanguage = "en";
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
            resources.ApplyResources(this._noCollectionsMessage, "_noCollectionsMessage");
            this._noCollectionsMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this._noCollectionsMessage.IsTextSelectable = false;
            this._noCollectionsMessage.Name = "_noCollectionsMessage";
            this._noCollectionsMessage.ReadOnly = true;
            this._noCollectionsMessage.TabStop = false;
            // 
            // _fixSizingTimer
            // 
            this._fixSizingTimer.Enabled = true;
            this._fixSizingTimer.Tick += new System.EventHandler(this._fixSizingTimer_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._noCollectionsMessage);
            this.Controls.Add(this._imageGalleryControl);
            this.Controls.Add(this.clipboardButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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

