﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obeidat.Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncrypted.Text = txtPlan.Text.ToEncreptedString();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtPlan.Text = txtEncrypted.Text.ToFlatString();
        }
    }
}
