﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IN
{
    public partial class PdfReader : Form
    {
        public PdfReader()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pdf|*.pdf";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                axAcroPDF1.src = ofd.FileName;
            }
        }
    }
}
