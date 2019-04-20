using System;
using System.Collections;
using System.Collections.Generic;
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
            foreach (String drives in nameOfDrives) drive.Items.Add(drives);
            drive.SelectedIndex = 0;
            mainPath.Text = nameOfDrives[0];
            myStack.Push(mainPath.Text);
            RefreshListView();
        }

        public SidePanel GetSidePanel()
        {
            return this;
        }

        private void drive_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String[] names;
            names = System.IO.Directory.GetLogicalDrives();
            mainPath.Text = names[drive.SelectedIndex];
            myStack.Clear();
            myStack.Push(mainPath.Text);
        }

        private void MainListView_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void MainListView_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        public void RefreshListView()
        {
            mainListView.ItemsSource = "";
            List<Classes.Controller> controllerList = new List<Classes.Controller>();
            Classes.Directory directories = new Classes.Directory(mainPath.Text);
            List<Classes.DiskItem> diskItemsList = directories.getSubdirectories();
            foreach (var item in diskItemsList) controllerList.Add(new Classes.Controller(item));
            mainListView.ItemsSource = controllerList;
        }
    }
}
