/*
 * Author: Emma Johnson
 * Class: CowboyCoffee
 * Purpose: Implement a class representing the cowboy coffee drink
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee: Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool roomForCream = false;
        /// <summary>
        /// If there is room for cream in the coffee
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool decaf = false;

        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Calories of Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 3;
                    case (Size.Medium):
                        return 5;
                    case (Size.Large):
                        return 7;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        /// <summary>
        /// Price of Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return .60;
                    case (Size.Medium):
                        return 1.10;
                    case (Size.Large):
                        return 1.60;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        private bool ice = false;
        /// <summary>
        /// If ice is added to the coffee
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Special instructions for the preperation of a Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (ice) instructions.Add("Add Ice");
                if (roomForCream) instructions.Add("Room for Cream");
                if (decaf) instructions.Add("Decaf");
                return instructions;
            }
        }

        /// <summary>
        /// Override of to string to correctly display Cowboy Coffee name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string completedDrink;
            switch (Size)
            {
                case Size.Large:
                    completedDrink = "Large Cowboy Coffee";
                    break;
                case Size.Medium:
                    completedDrink = "Medium Cowboy Coffee";
                    break;
                case Size.Small:
                    completedDrink = "Small Cowboy Coffee";
                    break;
                default:
                    throw new NotImplementedException("Unknown size");
            }

            if (!decaf)
            {
                return completedDrink;
            }
            else
            {
                return "Decaf " + completedDrink;
            }
        }


    }
}
