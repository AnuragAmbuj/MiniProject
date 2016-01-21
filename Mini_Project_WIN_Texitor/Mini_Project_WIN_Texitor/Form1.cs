using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Texitor
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        String signatureString = "- Pandora's Textitor";
        SaveFileDialog saveFile = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string file)
        {
            InitializeComponent();
            Form1.ActiveForm.Text = "An outsider file";
            try
            {
                string str = file;
                int dotindex = str.IndexOf('.');
                string extension = str.Substring(dotindex);
                if (extension.Equals(".rtf"))
                {
                    richTextBox1.LoadFile(str, RichTextBoxStreamType.RichText);
                    Form1.ActiveForm.Text = str + signatureString;
                }
                else if(extension.Equals(".txt"))
                {
                    richTextBox1.LoadFile(str, RichTextBoxStreamType.PlainText);
                    Form1.ActiveForm.Text = str + signatureString;
                }
                else
                {
                    richTextBox1.LoadFile(str, RichTextBoxStreamType.PlainText);
                    Form1.ActiveForm.Text = str + signatureString;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(" Cannot open File due to an Error : " + exc.Data.Values, " It's Unfortunate ");
            }
            

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFile.Title = "Pandora's File Open Dialog";
            openFile.Filter = "Plain Text files (*.txt)|*.txt|Rich Text files (*.rtf*)|*.rtf";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str = openFile.SafeFileName;
                    int dotindex = str.IndexOf('.');
                    string extension = str.Substring(dotindex);
                    if (extension.Equals(".txt"))
                    {
                        richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
                        Form1.ActiveForm.Text = openFile.SafeFileName + signatureString;
                    }
                    else
                    {
                        richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                        Form1.ActiveForm.Text = openFile.SafeFileName + signatureString;
                    }

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Cannot open File due to an Error : " + exc.Data.Values, "Unfortunately Application ");
                }
            }


        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            saveFile.Filter = "Plain Text files (*.txt)|*.txt|Rich Text files (*.rtf*)|*.rtf";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filename = saveFile.FileName;
                using (Stream s = File.Open(filename, FileMode.CreateNew))
                {
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }
            }
            string ext = filename.Substring(filename.IndexOf('.'));
            if (ext.Equals(".txt"))
            {
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
                Form1.ActiveForm.Text = filename + signatureString;
            }
            else
            {
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
                Form1.ActiveForm.Text = filename + signatureString;
            }

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(openFile.FileName);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData(DataFormats.Text))
            {
                richTextBox1.Paste();
            }
            else
            {

            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void clearSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
        }

        private void redoLastActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
            {
                richTextBox1.Redo();
            }
        }

        private void fontFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SearchDialog sd = new SearchDialog();
            string searchKey = "";
            bool IsSelected = false;
            int index = 0;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                //Dialog box is is shown.

            }
            searchKey = sd.GetKey();
            IsSelected = sd.IsCheckBoxSelected();

            if (!IsSelected)
            {

                while (index < richTextBox1.Text.LastIndexOf(searchKey))
                {
                    richTextBox1.Find(searchKey, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                    richTextBox1.SelectionBackColor = Color.LawnGreen;
                    index = richTextBox1.Text.IndexOf(searchKey, index) + 1;
                }
            }
            else
            {
                while (index < richTextBox1.Text.LastIndexOf(searchKey))
                {
                    richTextBox1.Find(searchKey, index, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
                    richTextBox1.SelectionColor = Color.Honeydew;
                    index = richTextBox1.Text.IndexOf(searchKey, index) + 1;
                }
            }


        }

        private void fontColorChooserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = cd.Color;

            }
        }

        private void backgroundColorChooserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog bcd = new ColorDialog();
            if (bcd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = bcd.Color;
            }
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void selectedTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog stcd = new ColorDialog();
            if (stcd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = stcd.Color;
            }

        }

        private void selectionBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog sbcd = new ColorDialog();
            if (sbcd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = sbcd.Color;
            }

        }

        private void selectionTextStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fd.Font;

        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProject ap = new AboutProject();
            ap.ShowDialog();
        }

        private void searchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SearchKey = "";
            String ReplaceKey = "";
            bool CaseMatch = false;
            bool ReplaceAll = true;
            SearchAndReplace sarDialog = new SearchAndReplace();
            if (sarDialog.ShowDialog() == DialogResult.OK)
            {

            }


            SearchKey = sarDialog.GetKey();
            ReplaceKey = sarDialog.GetReplaceKey();
            CaseMatch = sarDialog.ConsiderMatchCase();
            ReplaceAll = sarDialog.ConsiderReplaceAll();
            richTextBox1.Text = richTextBox1.Text.Replace(SearchKey, ReplaceKey);


        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop,false);
            string filename = fileNames[0];
            try
            {
                string str = filename;
                int dotindex = str.IndexOf('.');
                string extension = str.Substring(dotindex);
                if (extension.Equals(".txt"))
                {
                    richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
                    Form1.ActiveForm.Text = filename + signatureString;
                }
                else if (extension.Equals(".rtf"))
                {
                    richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
                    Form1.ActiveForm.Text = filename + signatureString;
                }
                else
                {
                    
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Cannot open File due to an Error : " + exc.Data.Values, "Unfortunately Application ");
            }

        }

        private void menuStrip1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void menuStrip1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string filename = fileNames[0];
            try
            {
                string str = filename;
                int dotindex = str.IndexOf('.');
                string extension = str.Substring(dotindex);
                if (extension.Equals(".txt"))
                {
                    richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
                    Form1.ActiveForm.Text = filename + signatureString;
                }
                else if (extension.Equals(".rtf"))
                {
                    richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
                    Form1.ActiveForm.Text = filename + signatureString;
                }
                else
                {

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Cannot open File due to an Error : " + exc.Data.Values, "Unfortunately Application ");
            }
        }

        

       
    }
}
