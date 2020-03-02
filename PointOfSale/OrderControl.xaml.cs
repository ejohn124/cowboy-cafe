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
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if(DataContext is Order data)
            {
                switch (b.Name)
                {
                    case "AddAngryChickenButton":
                        data.Add(new AngryChicken());
                        break;

                    case "AddCowpokeChiliButton":
                        data.Add(new CowpokeChili());
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
