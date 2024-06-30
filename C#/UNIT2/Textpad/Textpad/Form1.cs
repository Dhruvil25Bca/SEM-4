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

namespace Textpad
{
    public partial class Form1 : Form
    {
        String path;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "ALL Richext Files|.rtf|All Text Files|*.text|All files|*.*";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                path=openFileDialog1.FileName;
                richTextBox1.LoadFile(path);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(path==null)
            {
                saveFileDialog1.Filter = "ALL Richext Files|.rtf|All Text Files|*.text|All files|*.*";
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(path);
                }
            }
            else
            {
               richTextBox1.SaveFile(path);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "ALL Richext Files|.rtf|All Text Files|*.text|All files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                richTextBox1.SaveFile(path);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanRedo)
            {
                richTextBox1.Redo();
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fnt=new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            richTextBox1.SelectionFont=fnt;
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            richTextBox1.SelectionFont = fnt;
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            richTextBox1.SelectionFont = fnt;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
