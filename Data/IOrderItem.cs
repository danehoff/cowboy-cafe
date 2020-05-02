/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: IOrderItem

* Purpose: Interface to handle items being ordered.

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;


namespace CowboyCafe.Data
{
    /// <summary>
    /// Interface to handle items being ordered.
    /// </summary>
    public interface IOrderItem 
    {
        /// <summary>
        /// Price of the item being ordered get.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Calories of the item being ordered.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for the item being ordered
        /// </summary>
        List<string> SpecialInstructions
        {
            get;
        }

    }
}
