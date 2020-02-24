/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Chili Cheese Fries

* Purpose: Holds the price and calories of the chili cheese fries based on size.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the chili cheese fries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The price of the fries based on size.
        /// </summary>
        public override double Price {

            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 3.99;

                    case Size.Medium:
                        return 2.99;

                    case Size.Small:
                        return 1.99;

                    default:
                        throw new NotImplementedException("Unknown Price.");

                }

            }

        }

        /// <summary>
        /// The calories of the fries baed on size
        /// </summary>
        public override uint Calories {
            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 610;
                        
                    case Size.Medium:
                        return 524;
                     
                    case Size.Small:
                        return 433;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }
        }

        /// <summary>
        /// Readable string representing entreeside
        /// <returns></returns>
        public override string ToString()
        {
            return Size +  " Chili Cheese Fries";
        }

    }
}
