/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Cowboy Coffee

* Purpose: Represents the coffee including, ice, cream, decaf, price, and calories.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Cowboy Coffee Class
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Prices of the Coffee based on size.
        /// </summary>
        public override double Price
        {

            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 1.60;

                    case Size.Medium:
                        return 1.10;

                    case Size.Small:
                        return 0.60;

                    default:
                        throw new NotImplementedException("Unknown Price.");

                }

            }

        }

        /// <summary>
        /// The calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 7;

                    case Size.Medium:
                        return 5;

                    case Size.Small:
                        return 3;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }
        }

        /// <summary>
        /// Default bool set to false representing cream.
        /// </summary>
        private bool roomForCream = false;
        /// <summary>
        /// If the coffee gets cream.
        /// </summary>
        public bool RoomForCream
        {

            get { return roomForCream; }
            set { roomForCream = value; }

        }

        /// <summary>
        /// Default bool set to false representing decaf coffee.
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// If the coffee is decaf or not.
        /// </summary>
        public bool Decaf
        {

            get { return decaf; }
            set { decaf = value; }

        }

        /// <summary>
        /// Default bool set to false as the ice.
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// If the coffee gets ice or not.
        /// </summary>
        public bool Ice
        {


            get { return ice; }
            set { ice = value; }

        }

        /// <summary>
        /// Instructions including whether or not the coffee gets ice and also checks for cream.
        /// </summary>
        public override List<string> SpecialInstructions
        {

            get
            {

                var instructions = new List<string>();
                if (ice) instructions.Add("Add Ice");
                if (roomForCream) instructions.Add("Room for Cream");
                
                return instructions;

            }
        }
        /// <summary>
        /// Readable string representing drink Cowboy Coffee.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {

                case Size.Large:
                    if (Decaf) return "Large Decaf Cowboy Coffee";
                    return "Large Cowboy Coffee";

                case Size.Medium:
                    if (Decaf) return "Medium Decaf Cowboy Coffee";
                    return "Medium Cowboy Coffee";

                case Size.Small:
                    if (Decaf) return "Small Decaf Cowboy Coffee";
                    return "Small Cowboy Coffee";

                default:
                    throw new NotImplementedException();

            }
            
            
        }
    }
}
