/*
 * Author: Emma Johnson
 * Class: Water
 * Purpose: Implement class representing water
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class that represents water as a drink
    /// </summary>
    public class Water: Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool lemon = false;
        /// <summary>
        /// If the tea has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Calories of a water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Price of Water
        /// </summary>
        public override double Price
        {
            get
            {
                return .12;
            }
        }

        /// <summary>
        /// Special instructions for the preperation of a Jerked Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Override of to string to correctly display Water name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string item = "Water";
            switch (Size)
            {
                case Size.Large:
                    return "Large " + item;
                case Size.Medium:
                    return "Medium " + item;
                case Size.Small:
                    return "Small " + item;
                default:
                    throw new NotImplementedException("Unknown size");
            }
        }

    }
}
