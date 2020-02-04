using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRichTextBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //String txt = richTextBox1.Text;
           /* string[] RichTextBoxLines = richTextBox1.Lines;
            foreach (string str in RichTextBoxLines)
            {
                MessageBox.Show(str);
            }*/
            int n=richTextBox1.Lines.Count();
            for (int i = 0; i < n; i++)
            {
                string a = richTextBox1.Lines[i].ToString();
                MessageBox.Show(a);
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 5;
            richTextBox1.SelectionLength = 50;
            richTextBox1.SelectionColor = Color.Red;
            string txt = richTextBox1.SelectedText;
            MessageBox.Show(txt);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            //richTextBox1.DeselectAll();
        }


        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Cut();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                richTextBox1.Paste();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName);
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName);

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            for (int i=0; i<str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    richTextBox1.Select(i, 1);
                    richTextBox1.SelectionColor = Color.Red;
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
            string mas = textBox1.Text;
            String Str = richTextBox1.Text;
            var myStr = Str.Split(' ');
            int pos = -1;
            for (int i=0; i<myStr.Length; i++)
            {
                pos += myStr[i].Length + 1;
                if (myStr[i] == mas)
                {
                    richTextBox1.Select(pos - mas.Length, mas.Length);
                    richTextBox1.SelectionColor = Color.Green;
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
            string[] mas = { "Алӣ","Валӣ","Карим"};
            String Str = richTextBox1.Text;
            var myStr = Str.Split(' ');
            for (int k = 0; k < mas.Length; k++)
            {
                int pos = -1;
                for (int i = 0; i < myStr.Length; i++)
                {
                    pos += myStr[i].Length + 1;
                    if (myStr[i] == mas[k])
                    {
                        richTextBox1.Select(pos - mas[k].Length, mas[k].Length);
                        richTextBox1.SelectionColor = Color.Green;
                    }
                }
            }
        }
    }
}
