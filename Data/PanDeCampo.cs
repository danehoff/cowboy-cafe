/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Pan de Campo

* Purpose: Holds the price and calories of the baked pan de campo based on size.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the pan de campo side
    /// </summary>
    public class PanDeCampo : Side
    {

        /// <summary>
        /// The price of the pan de campo based on size
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
        /// The calorires of the pan de campo based on side.
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 367;

                    case Size.Medium:
                        return 269;

                    case Size.Small:
                        return 227;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }
        }


        /// <summary>
        /// Readable string representing side Pan de campo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Pan de Campo";
        }

    }
}
