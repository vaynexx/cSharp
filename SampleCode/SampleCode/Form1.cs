﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewEntry newEntry = new NewEntry();
            newEntry.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewEntryForm viewEntryForm = new ViewEntryForm();
            viewEntryForm.ShowDialog();
        }
    }
}
