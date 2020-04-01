/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Water

* Purpose: Represents the water class including instructions of whether or not the user wants ice or lemon.

*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data.Enums;

namespace CowboyCafe.Data.Drinks
{
    /// <summary>
    /// Base class for Water
    /// </summary>
    public class Water : Drink
    {

        /// <summary>
        /// The price of the water????
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// The calories of the water......
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Default bool set to false representing lemon.
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// Whether the water gets a lemon or not.
        /// </summary>
        public bool Lemon
        {

            get { return lemon; }
            set { 
                lemon = value;
                NotifyPropertyChanged("Lemon");
            }

        }

        /// <summary>
        /// Default bool set to true as the ice.
        /// </summary>
        private bool ice = true;
        /// <summary>
        /// If the drink gets ice.
        /// </summary>
        public override bool Ice
        {


            get { return ice; }
            set { 
                ice = value;
                NotifyPropertyChanged("Ice");
            }

        }

        /// <summary>
        /// Instructions including whether to hold the ice and or to add a lemon as well.
        /// </summary>
        public override List<string> SpecialInstructions
        {

            get
            {

                var instructions = new List<string>();
                if (!ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");
                return instructions;

            }
        }
        /// <summary>
        /// Readable string representing drink Water
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {

                case Size.Large:
                    
                    return "Large Water";

                case Size.Medium:
                    
                    return "Medium Water";

                case Size.Small:
                    
                    return "Small Water";

                default:
                    throw new NotImplementedException();

            }
            
        }
    }
}
