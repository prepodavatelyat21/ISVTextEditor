﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (tbSearchText.Text == "")
            {
                MessageBox.Show("Please insert text and search again!");
            }
            else
            {
                MainForm.Searchtext = tbSearchText.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
