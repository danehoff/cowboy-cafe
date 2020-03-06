/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Entree

* Purpose: Represents for the entrees and can be overridden by derived classes.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class that represents the entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {

        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        ///protected void NotifyPropertyChanged (string property){
        ///PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        ///PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        ///}

    }
}
