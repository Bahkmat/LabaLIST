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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp13._Pages
{
    /// <summary>
    /// Interaction logic for Autch.xaml
    /// </summary>
    public partial class Autch : Page
    {
        public Autch()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new User(TBLogin.Text, int.Parse(TBPassword.Text));
        }
    }
}