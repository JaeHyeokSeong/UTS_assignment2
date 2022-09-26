using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form3 : Form
    {
        private string fileName = "";
        private string userName = "";
        private string password = "";
        private bool editAble = false;
        public string UserName
        {
            set { userName = value; }
        }
        public string Password
        {
            set { password = value; }
        }
        public bool EditAble
        {
            set { editAble = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = userName;
            if (!editAble)
            {
                richTextBox1.ReadOnly = true;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            bool isBold = richTextBox1.SelectionFont.Bold;
            bool isItalic = richTextBox1.SelectionFont.Italic;
            bool isUnderLine = richTextBox1.SelectionFont.Underline;
            float fontSizeDifference = Convert.ToInt32(toolStripComboBox1.SelectedItem) - richTextBox1.Font.Size;
            if(isBold && isItalic && isUnderLine)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size + fontSizeDifference, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            else if(isBold && isItalic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size + fontSizeDifference, FontStyle.Bold | FontStyle.Italic);
            }
            else if(isBold && isUnderLine)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size + fontSizeDifference, FontStyle.Bold | FontStyle.Underline);
            }
            else if(isItalic && isUnderLine)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size + fontSizeDifference, FontStyle.Italic | FontStyle.Underline);
            }
            else if (isItalic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size + fontSizeDifference, FontStyle.Italic);
            }
            else if (isUnderLine)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size + fontSizeDifference, FontStyle.Underline);
            }
            else if (isBold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size + fontSizeDifference, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size + fontSizeDifference, FontStyle.Regular);
            }
            // richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size + fontSizeDifference, richTextBox1.SelectionFont.Bold ? FontStyle.Bold : FontStyle.Regular);

        }

        /// <summary>
        /// if selected text has regular font style, then change to bold font style. Otherwise change the selected font to regular font style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            float fontSize = richTextBox1.SelectionFont.Size;
            bool isBold = richTextBox1.SelectionFont.Bold;
            bool isItalic = richTextBox1.SelectionFont.Italic;
            bool isUnderLine = richTextBox1.SelectionFont.Underline;
            if(isItalic && isUnderLine)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Italic | FontStyle.Underline);
            }
            else if (isItalic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
            }
            else if (isUnderLine)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
            }
            // if selected font has bold style, then chage to regular style
            if (isBold)
            {
                if (isItalic || isUnderLine)
                {
                    // changed richTextBox1.Font.Size -> fontSize
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, richTextBox1.SelectionFont.Style | FontStyle.Regular);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, FontStyle.Regular);
                }
            }
            else
            {
                // make to bold
                // changed richTextBox1.Font.Size -> fontSize
                if (isItalic || isUnderLine)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, FontStyle.Bold);
                }
            }
        }
        /// <summary>
        /// if selected text has regular font style, then change to italic font style. Otherwise change the selected font to regular font style
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            float fontSize = richTextBox1.SelectionFont.Size;
            bool isItalic = richTextBox1.SelectionFont.Italic;
            bool isBold = richTextBox1.SelectionFont.Bold;
            bool isUnderLine = richTextBox1.SelectionFont.Underline;

            if(isBold && isUnderLine)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Bold | FontStyle.Underline);
            }
            else if (isBold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
            }
            else if (isUnderLine)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
            }

            if (isItalic)
            {
                if(isBold || isUnderLine)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, richTextBox1.SelectionFont.Style | FontStyle.Regular);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, FontStyle.Regular);
                }
            }
            else
            {
                if (isBold || isUnderLine)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, richTextBox1.SelectionFont.Style | FontStyle.Italic);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, FontStyle.Italic);
                }
            }
        }

        private void toolStripButton_underline_Click(object sender, EventArgs e)
        {
            float fontSize = richTextBox1.SelectionFont.Size;
            bool isUnderLine = richTextBox1.SelectionFont.Underline;
            bool isBold = richTextBox1.SelectionFont.Bold;
            bool isItalic = richTextBox1.SelectionFont.Italic;
            if(isBold && isItalic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Bold | FontStyle.Italic);
            }
            else if (isBold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
            }
            else if (isItalic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
            }

            if (isUnderLine)
            {
                if(isBold || isItalic)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, richTextBox1.SelectionFont.Style | FontStyle.Regular);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, FontStyle.Regular);
                }
            }
            else
            {
                if (isBold || isItalic)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                }
                else
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, fontSize, FontStyle.Underline);
                }
            }
        }
        private void CutSelectedText()
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                richTextBox1.Cut();
            }
        }
        private void CopySelectedText()
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                richTextBox1.Copy();
            }
        }
        private void PastText()
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }
        /// <summary>
        /// cut current selected text in the richTextBox and save the selected part into the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            CutSelectedText();
        }
        /// <summary>
        /// copy current selected text in the richTextBox and save the selected part into the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            CopySelectedText();
        }
        /// <summary>
        /// paste the text in the clipboard into the richtextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            PastText();
        }
        /// <summary>
        /// cut current selected text in the richTextBox and save the selected part into the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutSelectedText();
        }
        /// <summary>
        /// copy current selected text in the richTextBox and save the selected part into the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopySelectedText();
        }
        /// <summary>
        /// copy current selected text in the richTextBox and save the selected part into the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PastText();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login(userName, password);
            if (login.IsValid())
            {
                // show the text editor window
                Form3 form3 = new Form3();
                form3.UserName = login.Username; // set user same to be displayed in the tool strip label
                form3.Password = login.Password;
                form3.EditAble = login.AllowEdit();
                form3.Show();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login(userName, password);
            if (login.IsValid())
            {
                // show the text editor window
                Form3 form3 = new Form3();
                form3.UserName = login.Username; // set user same to be displayed in the tool strip label
                form3.Password = login.Password;
                form3.EditAble = login.AllowEdit();
                form3.Show();
            }
        }
        /// <summary>
        /// Save a file into rtf format
        /// </summary>
        private void SaveFile()
        {
            if (string.IsNullOrEmpty(fileName))
            {
                SaveAsFile();
            }
            else
            {
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.RichText);
            }
        }
        private void SaveAsFile()
        {
            if (editAble)
            {
                saveFileDialog1.DefaultExt = "*.rtf";
                saveFileDialog1.Filter = "RTF Files|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // process a file
                    fileName = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                MessageBox.Show("Permission denied", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Open a rtf format file 
        /// </summary>
        private void OpenFile()
        {
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "RTF Files|*.rtf";
            if(openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                fileName = openFileDialog1.FileName;
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }
        /// <summary>
        /// Save a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        /// <summary>
        /// Save File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        /// <summary>
        /// Save As
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }
    }
}
