﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barinakapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListele formListele = new FormListele();
            formListele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEkle formEkle = new FormEkle();
            formEkle.ShowDialog();  
        }
    }
}
