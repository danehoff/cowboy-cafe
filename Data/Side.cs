/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Entree

* Purpose: Represents for the sides and can be overridden by derived classes.

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event for property changed with a clicked button
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the size of the Side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the Special instructions for the sides.
        /// </summary>
        public virtual List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// Notifys our special instructions of the change made
        /// </summary>
        protected void NotifyPropertyChanged (string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
