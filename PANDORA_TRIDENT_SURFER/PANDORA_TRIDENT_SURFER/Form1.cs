using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack;
namespace PANDORA_TRIDENT_SURFER
{
    public partial class Form1 : Form
    {
        
        int errorCount;
        public Form1()
        {
            InitializeComponent();
            webRenderer.AllowNavigation = true;
            webRenderer.WebBrowserShortcutsEnabled = true;
            webRenderer.AllowWebBrowserDrop = true;
            errorCount = 0;
            
            
            this.ShowInTaskbar = true;
            
            
            
            
            
        }
        public Form1(string url)
        {
            InitializeComponent();
            webRenderer.AllowNavigation = true;
            webRenderer.WebBrowserShortcutsEnabled = true;
            webRenderer.AllowWebBrowserDrop = true;
            errorCount = 0;
            
            
            webRenderer.Navigate(url);
        }

        private void addressBox_Click(object sender, EventArgs e)
        {
            addressBox.SelectAll();
        }

        private void addressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n')
            {
                webRenderer.Navigate(addressBox.Text);
                Form1.ActiveForm.Text = webRenderer.DocumentTitle.ToString()+" in Pandora Surfer";
                statusLabel.Text = webRenderer.StatusText;
            }
        }

        private void linkReleaseButton_Click(object sender, EventArgs e)
        {
            webRenderer.Navigate(addressBox.Text);
            statusLabel.Text = webRenderer.StatusText;
        }


        private void webRenderer_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

            try
            {
                loadProgressIndicator.Value = Convert.ToInt32(e.CurrentProgress);
                loadProgressIndicator.Maximum = Convert.ToInt32(e.MaximumProgress);
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal,this.Handle);
                TaskbarManager.Instance.SetProgressValue(Convert.ToInt32(e.CurrentProgress) / 100, Convert.ToInt32(e.MaximumProgress) / 100);
                percentageLoadLabel.Text = loadProgressIndicator.Value / 100 + " %";

            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
            
        }

        private void webRenderer_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            loadStatusFlag.Text = "LOAD REQUEST BEING SENT";
            statusLabel.Text = "Waiting for reply from "+addressBox.Text ;
        }



        private void webRenderer_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            addressBox.Text = e.Url.AbsoluteUri;
            loadStatusFlag.Text = "DOWNLOADING WEBPAGE";
            statusLabel.Text = "Getting data from "+e.Url.AbsoluteUri;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (webRenderer.CanGoBack)
            {
                webRenderer.GoBack();
            }
            else
            {
                MessageBox.Show("Cannot Go Back", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            statusLabel.Text = webRenderer.StatusText;
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (webRenderer.CanGoForward)
            {
                webRenderer.GoForward();
            }
            else
            {
                MessageBox.Show("Cannot Go Forward", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            statusLabel.Text = webRenderer.StatusText;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webRenderer.Refresh(WebBrowserRefreshOption.Completely);
            statusLabel.Text = webRenderer.StatusText;
        }

        private void webRenderer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                Form1.ActiveForm.Text = webRenderer.DocumentTitle + " in Pandora Surfer";
                loadStatusFlag.Text = "DONE LOADING!";
                statusLabel.Text = webRenderer.StatusText+" with "+errorCount+" errors";
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
                
                
            }
            catch (NullReferenceException nre)
            {
                statusLabel.Text = nre.Message;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webRenderer.Navigate("http://www.bing.com/");
        }

        private void stopLoadingButton_Click(object sender, EventArgs e)
        {
            webRenderer.Stop();
        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
           /*
            * 
            * CODE NOT NECESSARY
            * 
            */
            
        }

        private void pandoraNotifIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Form1 ob = new Form1();
                ob.Show();
            }
            catch (NullReferenceException nre)
            {
                statusLabel.Text = nre.Message;
            }
        }

        private void savePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webRenderer.ShowSaveAsDialog();
        }

        private void bookmarkCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pandoraNotifIcon.ShowBalloonTip(4000, "Bookmark Notification", "The current Page you have in the browser has been bookmarked", ToolTipIcon.Info);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * CODE TO DO ON TAB SUPPORT
             */ 
        }

        private void internetOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /*
            *
            * Some digging needed in the MSDN MVP Forum
            * 
            */
        }

        private void pageInfoButton_Click(object sender, EventArgs e)
        {
            webRenderer.ShowPropertiesDialog();
           
        }

        private void pandoraNotifIcon_MouseClick(object sender, MouseEventArgs e)
        {
            
             
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Form1.ActiveForm.Close();
            }
            catch(NullReferenceException nre)
            {
                statusLabel.Text = nre.Message;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            if (ab.ShowDialog() == DialogResult.OK)
            {
            }
            else
            {
                pandoraNotifIcon.ShowBalloonTip(2000, "Error", "Uncaught Exception Occured", ToolTipIcon.Error);
            }
        }

        


       
    }
}
