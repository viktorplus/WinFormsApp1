﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class HomeUser : Form
    {
        Login loginForm;
        public HomeUser(Login loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

    }
}

