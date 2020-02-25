/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Jerked Soda

* Purpose: Represents the jerked soda including, ice, flavor, price, and calories.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Jerked Soda Class
    /// </summary>
    public class JerkedSoda : Drink 
    {

        /// <summary>
        /// Prices for the Soda based on size.
        /// </summary>
        public override double Price
        {

            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 2.59;

                    case Size.Medium:
                        return 2.10;

                    case Size.Small:
                        return 1.59;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }

        }

        /// <summary>
        /// The calories of the Soda
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 198;

                    case Size.Medium:
                        return 146;

                    case Size.Small:
                        return 110;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }
        }

        private SodaFlavor flav;
        /// <summary>
        /// The choosen flavor of the soda.
        /// </summary>
        public SodaFlavor Flavor
        {

            get
            {

                return flav;

            }
            set
            {

                flav = value;


            }


        }

        /// <summary>
        /// Default bool set to true as the ice.
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// If the burger has pickle.
        /// </summary>
        public bool Ice
        {


            get { return ice; }
            set { ice = value; }

        }

        /// <summary>
        /// Instructions for the soda being whether or not the user wants ice.
        /// </summary>
        public override List<string> SpecialInstructions
        {

            get
            {

                var instructions = new List<string>();
                if (!ice) instructions.Add("Hold Ice");
                return instructions;

            }
        }
        /// <summary>
        /// Readable string representing drink Jerked Chicken.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string flavS = "";

            if (Flavor == SodaFlavor.CreamSoda)
            {

                flavS = "Cream Soda";

            }
            else if(Flavor == SodaFlavor.OrangeSoda)
            {

                flavS = "Orange Soda";

            }
            else if(Flavor == SodaFlavor.Sarsparilla)
            {

                flavS = "Sarsparilla";

            }
            else if(Flavor == SodaFlavor.BirchBeer)
            {

                flavS = "Birch Beer";

            }
            else
            {

                flavS = "Root Beer";

            }
            switch (Size)
            {

                case Size.Large:
                    return "Large " + flavS + " Jerked Soda";

                case Size.Medium:
                    return "Medium " + flavS + " Jerked Soda";

                case Size.Small:
                    return "Small " + flavS + " Jerked Soda";

                default:
                    throw new NotImplementedException();

            }

            
        }
    }
}
