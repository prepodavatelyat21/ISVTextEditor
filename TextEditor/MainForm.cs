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

namespace TextEditor
{
   
    public partial class MainForm : Form
    {
        bool bold;
        bool italic;
        bool underline;
        public static string Searchtext;
        public static string Replacetext;
        public MainForm()
        {
            InitializeComponent();
        }
        public static string Reverse (string str)
        {
            string newStr = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }

            return newStr;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbText.Text!=String.Empty)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to save current file?", "Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string textfile = "";
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "RTF Files|*.rtf| Text files|*.txt| Doc files|*.doc";
                    dlg.Title = "Save file";
                    dlg.InitialDirectory = @"C:\Users\Ivaylo\Downloads";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        textfile = dlg.FileName;
                        string a = Reverse(textfile);
                        if (a.Substring(0, 3) == "ftr")
                        {
                            rtbText.SaveFile(textfile);
                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter(textfile))
                            {
                                sw.WriteLine(rtbText.Text);
                            }
                        }

                    }
                    rtbText.Clear();
                }
                if (result==DialogResult.No)
                {
                    rtbText.Clear();
                }
            }
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbText.Text == "")
            {
                Application.Exit();
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to save the file before exit?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string textfile = "";
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "RTF Files|*.rtf| Text files|*.txt| Doc files|*.doc";
                    dlg.Title = "Save file";
                    dlg.InitialDirectory = @"C:\Users\Ivaylo\Downloads";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        textfile = dlg.FileName;
                        string a = Reverse(textfile);
                        if (a.Substring(0, 3) == "ftr")
                        {
                            rtbText.SaveFile(textfile);
                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter(textfile))
                            {
                                sw.WriteLine(rtbText.Text);
                            }
                        }

                    }
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                rtbText.Text = "";
                string textfile = "";
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "RTF Files|*.rtf| Text files|*.txt| Doc files|*.doc";
                dlg.Title = "Open file";
                dlg.InitialDirectory = @"C:\Users\Ivaylo\Downloads";
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    textfile = dlg.FileName;
                    string a = Reverse(textfile);
                    if (a.Substring(0, 3) == "ftr") 
                    {
                        rtbText.LoadFile(textfile);
                    }
                    else
                    {
                        using (StreamReader sr = new StreamReader(textfile))
                        {
                            while(!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                rtbText.Text += line + Environment.NewLine;
                            }
                        }
                    }
                    
                }
           
    
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionLength > 0)
            
                
                rtbText.Cut();
           
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionLength > 0)
            
                
                rtbText.Copy();
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rtbText.Paste();      
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (rtbText.Text == String.Empty)
            {
                MessageBox.Show("Please insert text in the textbox!");
            }
            else
            {
                if (rtbText.SelectionFont.Bold == false && rtbText.SelectionFont.Underline == false && rtbText.SelectionFont.Italic == false)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Bold);
                    bold = true;
                    italic = false;
                    underline = false;
                }
                   
                else if (!(rtbText.SelectionFont.Bold) && italic == true && underline == true)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                    bold = true;
                    italic = true;
                    underline = true;
                }
                else  if (!(rtbText.SelectionFont.Bold) && italic == false && underline == true)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Bold | FontStyle.Underline);
                    bold = true;
                    italic = false;
                    underline = true;

                }
                else  if (!(rtbText.SelectionFont.Bold) && italic == true && underline == false)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic | FontStyle.Bold);
                    bold = true;
                    italic = true;
                    underline = false;
                }
                else  if ((rtbText.SelectionFont.Bold) && italic == true && underline == true)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Underline | FontStyle.Italic);
                    bold = false;
                    italic = true;
                    underline = true;
                }
                else if ((rtbText.SelectionFont.Bold) && italic == false && underline == true)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Underline);
                    bold = false;
                    italic = false;
                    underline = true;
                }
                else if ((rtbText.SelectionFont.Bold) && italic == true && underline == false)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic);
                    bold = false;
                    italic = true;
                    underline = false;
                }
                else  if ((rtbText.SelectionFont.Bold) && italic == false && underline == false)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Regular);
                    bold = false;
                    italic = false;
                    underline = false;
                }

              

            }
           
            
        }

       

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (rtbText.Text != String.Empty)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to save current file?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string textfile = "";
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "RTF Files|*.rtf| Text files|*.txt| Doc files|*.doc";
                    dlg.Title = "Save file";
                    dlg.InitialDirectory = @"C:\Users\Ivaylo\Downloads";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        textfile = dlg.FileName;
                        string a = Reverse(textfile);
                        if (a.Substring(0, 3) == "ftr")
                        {
                            rtbText.SaveFile(textfile);
                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter(textfile))
                            {
                                sw.WriteLine(rtbText.Text);
                            }
                        }

                    }
                    rtbText.Clear();
                }
                if (result == DialogResult.No)
                {
                    rtbText.Clear();
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textfile = "";
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "RTF Files|*.rtf| Text files|*.txt| Doc files|*.doc";
            dlg.Title = "Save file";
            dlg.InitialDirectory = @"C:\Users\Ivaylo\Downloads";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textfile = dlg.FileName;
                string a = Reverse(textfile);
                if (a.Substring(0, 3) == "ftr")
                {
                    rtbText.SaveFile(textfile);
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(textfile))
                    {
                        sw.WriteLine(rtbText.Text);
                    }
                }
                
            }
            rtbText.Clear();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            string textfile = "";
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "RTF Files|*.rtf| Text files|*.txt| Doc files|*.doc";
            dlg.Title = "Save file";
            dlg.InitialDirectory = @"C:\Users\Ivaylo\Downloads";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textfile = dlg.FileName;
                string a = Reverse(textfile);
                if (a.Substring(0, 3) == "ftr")
                {
                    rtbText.SaveFile(textfile);
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(textfile))
                    {
                        sw.WriteLine(rtbText.Text);
                    }
                }

            }
            rtbText.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                rtbText.SelectionFont = fd.Font;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = cd.ShowDialog();
            if (result == DialogResult.OK)
            {
                rtbText.SelectionColor = cd.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (rtbText.Text == String.Empty)
            {
                MessageBox.Show("Please insert text in the textbox!");
            }
            else
            {
                    if (rtbText.SelectionFont.Bold == false && rtbText.SelectionFont.Underline == false && rtbText.SelectionFont.Italic == false)
                     {
                        rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic);
                        bold = false;
                        italic = true;
                        underline = false;
                     }
                
                    else if (!(rtbText.SelectionFont.Italic) && bold == true && underline == true)
                    {
                        rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                        italic = true;
                    }
                    else if (!(rtbText.SelectionFont.Italic) && bold == false && underline == true)
                    {
                        rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic | FontStyle.Underline);
                        italic = true;

                    }
                    else if (!(rtbText.SelectionFont.Italic) && bold == true && underline == false)
                    {
                        rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic | FontStyle.Bold);
                        italic = true;

                    }
                    else if ((rtbText.SelectionFont.Italic) && bold == true && underline == true)
                    {
                        rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Underline | FontStyle.Bold);
                        italic = false;
                    }
                    else if ((rtbText.SelectionFont.Italic) && bold == false && underline == true)
                    {
                        rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Underline);
                        italic = false;
                    }
                    else if ((rtbText.SelectionFont.Italic) && bold == true && underline == false)
                    {
                        rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Bold);
                        italic = false;
                    }
                    else if ((rtbText.SelectionFont.Italic) && bold == false && underline == false)
                    {
                        rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Regular);
                        italic = false;
                    }


            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (rtbText.Text == String.Empty)
            {
                MessageBox.Show("Please insert text in the textbox!");
            }
            else
            {
                if (rtbText.SelectionFont.Bold == false && rtbText.SelectionFont.Underline == false && rtbText.SelectionFont.Italic == false)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Underline);
                    bold = false;
                    italic = false;
                    underline = true;
                }
                else if (!(rtbText.SelectionFont.Underline) && italic == true && bold == true)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                    underline = true;
                }
                else if (!(rtbText.SelectionFont.Underline) && italic == false && bold == true)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Bold | FontStyle.Underline);
                    underline = true;

                }
                else if (!(rtbText.SelectionFont.Underline) && italic == true && bold == false)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic | FontStyle.Underline);
                    underline = true;

                }
                else  if ((rtbText.SelectionFont.Underline) && italic == true && bold== true)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Bold | FontStyle.Italic);
                    underline = false;
                }
                else  if ((rtbText.SelectionFont.Underline) && italic == false && bold == true)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Bold);
                    underline = false;
                }
                else  if ((rtbText.SelectionFont.Underline) && italic == true && bold == false)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Italic);
                    underline = false;
                }
                else  if ((rtbText.SelectionFont.Underline) && italic == false && bold == false)
                {
                    rtbText.SelectionFont = new Font(rtbText.Font, FontStyle.Regular);
                    underline = false;
                }



            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm frm = new InfoForm();
            frm.Show();
            
            
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.AppendText(DateTime.Now.ToString());

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionLength > 0)
            {
                rtbText.SelectedText = "";
                
            }
        }

        private void searchTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbText.Text != "")
            {
                SearchForm sfmr = new SearchForm();
                if (sfmr.ShowDialog() == DialogResult.OK)
                {
                    if (rtbText.Text.Contains(Searchtext))
                    {
                        rtbText.Find(Searchtext);
                    }
                    else
                    {
                        MessageBox.Show("The text is not found!");
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no text to search, please insert text and continue!");
            }
           


        }

        private void replaceTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbText.Text != "")
            {
                if (rtbText.SelectionLength > 0)
                {
                    ReplaceForm rfrm = new ReplaceForm();
                    if (rfrm.ShowDialog() == DialogResult.OK)
                    {
                        rtbText.SelectedText = Replacetext;
                    }
                }
                else
                {
                    MessageBox.Show("Mark the text, you want to replace and continue!");
                }
            }
            else
            {
                MessageBox.Show("There is no text to replace");
            }

            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Redo();
        }

       

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
            string textfile = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "RTF Files|*.rtf| Text files|*.txt| Doc files|*.doc";
            dlg.Title = "Open file";
            dlg.InitialDirectory = @"C:\Users\Ivaylo\Downloads";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                textfile = dlg.FileName;
                string a = Reverse(textfile);
                if (a.Substring(0, 3) == "ftr")
                {
                    rtbText.LoadFile(textfile);
                }
                else
                {
                    using (StreamReader sr = new StreamReader(textfile))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            rtbText.Text += line + Environment.NewLine;
                        }
                    }
                }

            }
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionLength > 0)
                rtbText.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionLength > 0)
                rtbText.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtbText.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtbText.Redo();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionLength > 0)
            {
                rtbText.SelectedText = "";
            }
        }

       

    }
}
