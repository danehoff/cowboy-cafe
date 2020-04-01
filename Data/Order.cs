/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Order

* Purpose: Represents for the order being taken.

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Enums;


namespace CowboyCafe.Data
{
    /// <summary>
    /// This class represents the order being taken.
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Keeps track of the order number before 
        /// </summary>
        private uint lastOrderNumber = 0;


        /// <summary>
        /// Calculates the subtotal of the total order
        /// </summary>
        public double Subtotal 
        {
            
            get
            {
                double totalPrice = 0;
                foreach(IOrderItem iItem in items)
                {

                    totalPrice += iItem.Price;

                }

                return totalPrice;
            }
           /// private set;
        }

        /// <summary>
        /// This method assists in updating the subtotal for changing sizes
        /// </summary>
        /// <param name="i">The item</param>
        /// <param name="new_size">The size the item is suppose to be</param>
       /// public void subtotalHelperFunction(IOrderItem i, Size new_size)
      ///  {
           /// Side s;
           /// Drink d;

          ///  Subtotal -= i.Price;
          ///  if (i is Side)
          ///  {
          ///      s = (Side)i;
           ///     s.Size = new_size;
             ///   Subtotal += s.Price;
            ///}
          ///  else
           /// {
                ///d = (Drink)i;
               /// d.Size = new_size;
             ///   Subtotal += d.Price;
          ///  }
           /// itemPrices.RemoveAt(itemPrices.Count - 1);

           /// string priceOfItemAsCurrency = String.Format("{0:C}", i.Price);
            ///itemPrices.Add(priceOfItemAsCurrency);
        ///}

        /// <summary>
        /// Updates the order number.
        /// </summary>
        public uint OrderNumber { get { lastOrderNumber++; return lastOrderNumber; } }

        /// <summary>
        /// Event for property changed with a clicked button
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// List of our items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Sends items into a array 
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// The list of the item prices on the currentn order
        /// </summary>
        private List<string> itemPrices;


        /// <summary>
        /// Property to return the list of item prices in the current order 
        /// </summary>
        public IEnumerable<string> ItemPrices { get { return itemPrices.ToArray(); } }



        /// <summary>
        /// Adds item to the list.
        /// </summary>
        /// <param name="item">Item to be added</param>
        public void Add(IOrderItem item)
        {


            items.Add(item);
            if(item is INotifyPropertyChanged pcItem) 
            { 

                pcItem.PropertyChanged += OnItemChanged;
             
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        /// <summary>
        /// Removes items from the list.
        /// </summary>
        /// <param name="item">Item to be removed</param>
        public void Remove(IOrderItem item)
        {

            items.Remove(item);
            if (item is INotifyPropertyChanged pcItem)
            {

                 pcItem.PropertyChanged -= OnItemChanged;

            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }
        

    }
}
