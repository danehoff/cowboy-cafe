﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using CowboyCafe.Data;


namespace CowboyCafe.Data
{
    public class Order: INotifyPropertyChanged
    {

        private uint lastOrderNumber = 0;

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
        }
        
        public uint OrderNumber { get { lastOrderNumber++; return lastOrderNumber; } }

        public event PropertyChangedEventHandler PropertyChanged;
        private List<IOrderItem> items = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Items => items.ToArray();


        public void Add(IOrderItem item)
        {


            items.Add(item);
            ///if(item is INotifyPropertyChanged pcItem) 
            ///{ 

                /// pcItem.PropertyChanged += OnItemChanged;
             
            ///}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }
        public void Remove(IOrderItem item)
        {

            items.Remove(item);
            ///if (item is INotifyPropertyChanged pcItem)
            ///{

                /// pcItem.PropertyChanged -= OnItemChanged;

            ///}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        ///private void OnItemChanged(object sender, PropertyChangedEventArgs e)
       /// {

           /// PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
           /// if(e.PropertyName == "Price") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

       /// }
        

    }
}
