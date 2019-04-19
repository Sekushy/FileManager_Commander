﻿using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Commander_Jr
{
    /// <summary>
    /// Interaction logic for SidePanel.xaml
    /// </summary>
    public partial class SidePanel : UserControl
    {
        Stack myStack = new Stack();
        public Boolean isSideActive { get; set; }

        public SidePanel()
        {
            InitializeComponent();
            String[] nameOfDrives;
            nameOfDrives = System.IO.Directory.GetLogicalDrives();
            foreach (String drives in nameOfDrives)
            {
                drive.Items.Add(drives);
            }
            drive.SelectedIndex = 0;
            mainPath.Text = nameOfDrives[0];
            myStack.Push(mainPath.Text);
        }

        public SidePanel GetSidePanel()
        {
            return this;
        }

        private void MainListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MainListView_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void MainListView_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
