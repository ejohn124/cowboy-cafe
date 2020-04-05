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
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            Button b = (Button)sender;
            if (DataContext is Order data)
            {
                switch (b.Name)
                {
                        //Entrees
                    case "AddAngryChickenButton":
                        data.Add(new AngryChicken());
                        break;
                    case "AddCowpokeChiliButton":
                        var item = new CowpokeChili();
                        var screen = new CowpokeChiliCustomization();
                        screen.DataContext = item;
                        data.Add(item);                        
                        orderControl?.SwapScreen(new CowpokeChiliCustomization());
                        break;
                    case "AddRustlersRibsButton":
                        data.Add(new RustlersRibs());
                        break;
                    case "AddDakotaDoubleBurgerButton":
                        data.Add(new DakotaDoubleBurger());
                        break;
                    case "AddTexasTripleBurgerButton":
                        data.Add(new TexasTripleBurger());
                        break;
                    case "AddTrailBurgerButton":
                        data.Add(new TrailBurger());
                        break;
                    case "AddPecosPulledPorkButton":
                        data.Add(new PecosPulledPork());
                        break;

                        //Sides
                    case "AddBakedBeansButton":
                        data.Add(new BakedBeans());
                        break;
                    case "AddChiliCheeseFriesButton":
                        data.Add(new ChiliCheeseFries());
                        break;
                    case "AddCornDodgersButton":
                        data.Add(new CornDodgers());
                        break;
                    case "AddPanDeCampoButton":
                        data.Add(new PanDeCampo());
                        break;

                        //Drinks
                    case "AddJerkedSodaButton":
                        data.Add(new JerkedSoda());
                        break;
                    case "AddCowboyCoffeeButton":
                        data.Add(new CowboyCoffee());
                        break;
                    case "AddTexasTeaButton":
                        data.Add(new TexasTea());
                        break;
                    case "AddWaterButton":
                        data.Add(new Water());
                        break;

                }
            }

        }
    }
}
