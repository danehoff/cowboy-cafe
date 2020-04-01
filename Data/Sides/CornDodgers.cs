/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Corn Dodgers

* Purpose: Holds the price and calories of the corn dodgers based on size.

*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Enums;


namespace CowboyCafe.Data.Sides
{
    /// <summary>
    /// A class representing corn dodger side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// The price of the corn dodger's side based on size
        /// </summary>
        public override double Price
        {

            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 1.99;

                    case Size.Medium:
                        return 1.79;

                    case Size.Small:
                        return 1.59;

                    default:
                        throw new NotImplementedException("Unknown Price.");

                }

            }

        }

        /// <summary>
        /// The calories of the corn dodgers based on size
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 717;

                    case Size.Medium:
                        return 685;

                    case Size.Small:
                        return 512;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }
        }

        /// <summary>
        /// Readable string representing side Corn Dodgers.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Corn Dodgers";
        }
    }
}
