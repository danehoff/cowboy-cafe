﻿/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Baked Beans

* Purpose: Holds the price and calories of the baked beans based on size.

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
    /// A class representing the Baked Beans Side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// The price of the baked beans based on size
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
        /// The Calories of the baked beans based on size
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 410; 

                    case Size.Medium:
                        return 378;

                    case Size.Small:
                        return 312;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }
        }

        /// <summary>
        /// Readable string representing side Baked Beans.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size + " Baked Beans";
        }

        

    }
}
