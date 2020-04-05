using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            DataContext = new Order();
        }

        public void OnMenuItemSelectionButtonClicked(object send, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }

        public void CancelOrder(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();
        }

        public void CompletedOrder(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();
        }

    }
}
