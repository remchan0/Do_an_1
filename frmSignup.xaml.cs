﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Do_An_1
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class frmSignup : Window
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void signupbutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đăng ký thành công!","Thông báo",MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
