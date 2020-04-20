using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This class implements methods to create list of menu items
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Compiles list of entrees
        /// </summary>
        public IEnumerable<IOrderItem> Entrees() 
        {
            return new List<IOrderItem>()
            {
            new AngryChicken(),
            new CowpokeChili(),
            new DakotaDoubleBurger(),
            new PecosPulledPork(),
            new RustlersRibs(),
            new TexasTripleBurger(),
            new TrailBurger()

            };
        }

        /// <summary>
        /// Compiles list of drinks
        /// </summary>
        /// <returns>List of drinks</returns>
        public IEnumerable<IOrderItem> Drinks()
        {
            return new List<IOrderItem>()
            {
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };
        }


        /// <summary>
        /// Compiles list of sides
        /// </summary>
        /// <returns>List of sides</returns>
        public IEnumerable<IOrderItem> Sides()
        {
            return new List<IOrderItem>()
            {
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo()
            };
        }

        /// <summary>
        /// Complete list of menu items
        /// </summary>
        /// <returns>List of menu items</returns>
        public IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> completeMenu = new List<IOrderItem>();

            IEnumerable<IOrderItem> drink = Drinks();
            IEnumerable<IOrderItem> entree = Entrees();
            IEnumerable<IOrderItem> side = Sides();
            foreach (Drink d in drink)
            {
                completeMenu.Add(d);
            }
            foreach (Entree e in entree)
            {
                completeMenu.Add(e);
            }
            foreach (Side s in side)
            {
                completeMenu.Add(s);
            }
            return completeMenu;

        }



       

    }
}
