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
using PointOfSale.CustomizationScreens.DrinkCustomization;
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
                        {
                            var item = new AngryChicken();
                            var screen = new AngryChickenCustomization();
                            screen.DataContext = item;
                            data.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                        }
                    case "AddCowpokeChiliButton":
                        {
                            var item = new CowpokeChili();
                            var screen = new CowpokeChiliCustomization();
                            screen.DataContext = item;
                            data.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                        }
                    case "AddRustlersRibsButton":
                        data.Add(new RustlersRibs());
                        break;
                    case "AddDakotaDoubleBurgerButton":
                        {
                            var item = new DakotaDoubleBurger();
                            var screen = new DakotaDoubleCustomization();
                            screen.DataContext = item;
                            data.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                        }                       
                    case "AddTexasTripleBurgerButton":
                        {
                            var item = new TexasTripleBurger();
                            var screen = new TexasTripleCustomization();
                            screen.DataContext = item;
                            data.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                        }
                    case "AddTrailBurgerButton":
                        {
                            var item = new TrailBurger();
                            var screen = new TrailBurgerCustomization();
                            screen.DataContext = item;
                            data.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                        }
                    case "AddPecosPulledPorkButton":
                        {
                            var item = new PecosPulledPork();
                            var screen = new PecosPulledPorkCustomization();
                            screen.DataContext = item;
                            data.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                        }

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
                        {
                            var item = new Water();
                            var screen = new WaterCustomization();
                            screen.DataContext = item;
                            data.Add(item);
                            orderControl?.SwapScreen(screen);
                            break;
                        }


                }
            }

        }
    }
}
