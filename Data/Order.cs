using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;


namespace CowboyCafe.Data
{
    public class Order
    {

        private uint lastOrderNumber = 0;

        public double Subtotal { get; }
        
        public uint OrderNumber { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        private List<IOrderItem> items = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Items => items.ToArray();

        public void Add(IOrderItem item)
        {

            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            
        }
        public void Remove(IOrderItem item)
        {

            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            
        }

    }
}
