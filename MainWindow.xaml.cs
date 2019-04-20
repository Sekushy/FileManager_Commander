using Commander_Jr.Classes;
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

namespace Commander_Jr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SidePanel sideLeft;
        SidePanel sideRight;
        TabControl leftTab;
        TabControl rightTab;
        Utility myUtility;

        public MainWindow() : base()
        {
            InitializeComponent();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Sets the date to the label at the bottom of the Window
            lblStatus.Text = DateTime.Now.ToLongDateString();

            // Create two TabControls (left and right) which are going to be added to the mainGrid
            leftTab = new TabControl();
            rightTab = new TabControl();

            // Set each SidePanel so that it covers half of the width of mainGrid
            sideLeft = new SidePanel
            {
                Width = mainGrid.Width / 2
            };
            sideRight = new SidePanel()
            {
                Width = mainGrid.Width / 2
            };

            // Left side settings
            leftTab.Items.Add(sideLeft);
            mainGrid.Children.Add(leftTab);
            Grid.SetColumn(rightTab, 1);
            Grid.SetRowSpan(leftTab, 2);

            // Right side settings
            rightTab.Items.Add(sideRight);
            mainGrid.Children.Add(rightTab);
            Grid.SetColumn(rightTab, 1);
            Grid.SetRowSpan(rightTab, 2);

            myUtility = new Utility(leftTab, rightTab);
        }

        public void notYetImplemeted(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not yet implemented! Check back at a later date", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void aboutPage(object sender, RoutedEventArgs e)
        {
            Misc.AboutStudent aboutPage = new Misc.AboutStudent();
            aboutPage.Show();
        }

    }
}
