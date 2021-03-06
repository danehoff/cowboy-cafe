﻿/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Drink

* Purpose: Represents for the drinks and can be overridden by derived classes.

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CowboyCafe.Data.Enums;

namespace CowboyCafe.Data.Drinks
{
    /// <summary>
    /// Base Class for representing sides.
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Event for property changed with a clicked button
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the size of the Drink
        /// </summary>
        public virtual Size Size { get; set; }

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

        /// <summary>
        /// Gets and sets whether the drink has ice
        /// </summary>
        public virtual bool Ice { get; set; }

        /// <summary>
        /// Notifys our special instructions of the change made
        /// </summary>
        protected void NotifyPropertyChanged (string property){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}
