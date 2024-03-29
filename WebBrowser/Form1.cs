﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
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

        private void addressBar_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(addressBar.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            webBrowser1.Url = new Uri(addressBar.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();  
        }
    }
}
