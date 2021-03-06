﻿using Snake201806.Model;
using System;
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

namespace Snake201806
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Arena arena;

        public MainWindow()
        {
            InitializeComponent();
            arena = new Arena(this);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            arena.KeyDown(e);
        }
    }
}
