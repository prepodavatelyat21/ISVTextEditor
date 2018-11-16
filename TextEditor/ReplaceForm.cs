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
    public partial class ReplaceForm : Form
    {
        public ReplaceForm()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (tbReplace.Text != "")
            {
                MainForm.Replacetext = tbReplace.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please insert text and continue!");
            }
        }
    }
}
