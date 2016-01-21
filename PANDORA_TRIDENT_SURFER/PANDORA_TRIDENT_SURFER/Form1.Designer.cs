namespace PANDORA_TRIDENT_SURFER
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
            this.pandoraNotifIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.browserBar = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.addressBox = new System.Windows.Forms.ToolStripTextBox();
            this.linkReleaseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.stopLoadingButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pageInfoButton = new System.Windows.Forms.ToolStripButton();
            this.webRenderer = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loadStatusFlag = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.savePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.internetOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percentageLoadLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadProgressIndicator = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.browserBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pandoraNotifIcon
            // 
            this.pandoraNotifIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.pandoraNotifIcon.BalloonTipText = "Page Loaded";
            this.pandoraNotifIcon.BalloonTipTitle = "Pandora\'s Notifier";
            this.pandoraNotifIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("pandoraNotifIcon.Icon")));
            this.pandoraNotifIcon.Text = "Pandora\'s Surfer";
            this.pandoraNotifIcon.Visible = true;
            this.pandoraNotifIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pandoraNotifIcon_MouseClick);
            this.pandoraNotifIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pandoraNotifIcon_MouseDoubleClick);
            // 
            // browserBar
            // 
            this.browserBar.AllowItemReorder = true;
            this.browserBar.BackColor = System.Drawing.Color.Transparent;
            this.browserBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.browserBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.addressBox,
            this.linkReleaseButton,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.stopLoadingButton,
            this.toolStripButton2,
            this.pageInfoButton,
            this.toolStripButton3});
            this.browserBar.Location = new System.Drawing.Point(0, 0);
            this.browserBar.Name = "browserBar";
            this.browserBar.Size = new System.Drawing.Size(884, 25);
            this.browserBar.TabIndex = 1;
            this.browserBar.TabStop = true;
            this.browserBar.Text = "browserStripTool";
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 22);
            this.backButton.Text = "toolStripButton1";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(23, 22);
            this.forwardButton.Text = "toolStripButton1";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.AcceptsReturn = true;
            this.addressBox.AcceptsTab = true;
            this.addressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(500, 25);
            this.addressBox.ToolTipText = global::PANDORA_TRIDENT_SURFER.Properties.Settings.Default.addressBoxToolTip;
            this.addressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressBox_KeyPress);
            this.addressBox.Click += new System.EventHandler(this.addressBox_Click);
            // 
            // linkReleaseButton
            // 
            this.linkReleaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.linkReleaseButton.Image = ((System.Drawing.Image)(resources.GetObject("linkReleaseButton.Image")));
            this.linkReleaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.linkReleaseButton.Name = "linkReleaseButton";
            this.linkReleaseButton.Size = new System.Drawing.Size(23, 22);
            this.linkReleaseButton.Text = "Go";
            this.linkReleaseButton.Click += new System.EventHandler(this.linkReleaseButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Reresh";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // stopLoadingButton
            // 
            this.stopLoadingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopLoadingButton.Image = ((System.Drawing.Image)(resources.GetObject("stopLoadingButton.Image")));
            this.stopLoadingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopLoadingButton.Name = "stopLoadingButton";
            this.stopLoadingButton.Size = new System.Drawing.Size(23, 22);
            this.stopLoadingButton.Text = "Stop";
            this.stopLoadingButton.Click += new System.EventHandler(this.stopLoadingButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // pageInfoButton
            // 
            this.pageInfoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pageInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("pageInfoButton.Image")));
            this.pageInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pageInfoButton.Name = "pageInfoButton";
            this.pageInfoButton.Size = new System.Drawing.Size(23, 22);
            this.pageInfoButton.Text = "Page Information";
            this.pageInfoButton.Click += new System.EventHandler(this.pageInfoButton_Click);
            // 
            // webRenderer
            // 
            this.webRenderer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webRenderer.Location = new System.Drawing.Point(0, 25);
            this.webRenderer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webRenderer.Name = "webRenderer";
            this.webRenderer.Size = new System.Drawing.Size(884, 318);
            this.webRenderer.TabIndex = 2;
            this.webRenderer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webRenderer_DocumentCompleted);
            this.webRenderer.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webRenderer_Navigated);
            this.webRenderer.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webRenderer_Navigating);
            this.webRenderer.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webRenderer_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowItemReorder = global::PANDORA_TRIDENT_SURFER.Properties.Settings.Default.Enabled;
            this.statusStrip1.DataBindings.Add(new System.Windows.Forms.Binding("AllowItemReorder", global::PANDORA_TRIDENT_SURFER.Properties.Settings.Default, "Enabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadStatusFlag,
            this.toolStripDropDownButton1,
            this.percentageLoadLabel,
            this.loadProgressIndicator,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 343);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(884, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loadStatusFlag
            // 
            this.loadStatusFlag.Name = "loadStatusFlag";
            this.loadStatusFlag.Size = new System.Drawing.Size(39, 21);
            this.loadStatusFlag.Text = "DONE";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePageToolStripMenuItem,
            this.bookmarkCurrentToolStripMenuItem,
            this.closeCurrentToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.internetOptionsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // savePageToolStripMenuItem
            // 
            this.savePageToolStripMenuItem.Name = "savePageToolStripMenuItem";
            this.savePageToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.savePageToolStripMenuItem.Text = "Save Page";
            this.savePageToolStripMenuItem.Click += new System.EventHandler(this.savePageToolStripMenuItem_Click);
            // 
            // bookmarkCurrentToolStripMenuItem
            // 
            this.bookmarkCurrentToolStripMenuItem.Name = "bookmarkCurrentToolStripMenuItem";
            this.bookmarkCurrentToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bookmarkCurrentToolStripMenuItem.Text = "Bookmark Current";
            this.bookmarkCurrentToolStripMenuItem.Click += new System.EventHandler(this.bookmarkCurrentToolStripMenuItem_Click);
            // 
            // closeCurrentToolStripMenuItem
            // 
            this.closeCurrentToolStripMenuItem.Name = "closeCurrentToolStripMenuItem";
            this.closeCurrentToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.closeCurrentToolStripMenuItem.Text = "Close Current";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // internetOptionsToolStripMenuItem
            // 
            this.internetOptionsToolStripMenuItem.Name = "internetOptionsToolStripMenuItem";
            this.internetOptionsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.internetOptionsToolStripMenuItem.Text = "Internet Options";
            this.internetOptionsToolStripMenuItem.Click += new System.EventHandler(this.internetOptionsToolStripMenuItem_Click);
            // 
            // percentageLoadLabel
            // 
            this.percentageLoadLabel.Name = "percentageLoadLabel";
            this.percentageLoadLabel.Size = new System.Drawing.Size(26, 21);
            this.percentageLoadLabel.Text = "0 %";
            // 
            // loadProgressIndicator
            // 
            this.loadProgressIndicator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loadProgressIndicator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadProgressIndicator.ControlAlign = global::PANDORA_TRIDENT_SURFER.Properties.Settings.Default.MiddleRight;
            this.loadProgressIndicator.MarqueeAnimationSpeed = 10;
            this.loadProgressIndicator.Name = "loadProgressIndicator";
            this.loadProgressIndicator.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.loadProgressIndicator.Size = new System.Drawing.Size(200, 20);
            this.loadProgressIndicator.Step = 5;
            this.loadProgressIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(78, 21);
            this.statusLabel.Text = "None Loaded";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 369);
            this.Controls.Add(this.webRenderer);
            this.Controls.Add(this.browserBar);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pandora Surfer";
            this.browserBar.ResumeLayout(false);
            this.browserBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel loadStatusFlag;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem savePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        public System.Windows.Forms.ToolStripProgressBar loadProgressIndicator;
        private System.Windows.Forms.ToolStripStatusLabel percentageLoadLabel;
        private System.Windows.Forms.ToolStrip browserBar;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripTextBox addressBox;
        private System.Windows.Forms.ToolStripButton linkReleaseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.WebBrowser webRenderer;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton stopLoadingButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem internetOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton pageInfoButton;
        public System.Windows.Forms.NotifyIcon pandoraNotifIcon;
        private System.Windows.Forms.ToolStripButton toolStripButton3;

    }
}

