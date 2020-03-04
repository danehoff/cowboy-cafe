using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
<<<<<<< HEAD
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
=======

namespace CowboyCafe.Data
{
    public class Order :INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public double Subtotal => 0;
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public uint OrderNumber { get;  }
>>>>>>> 6db0ae7d03fd7a52dd4a7b5472a8e906198a6014

        public void Add(IOrderItem item)
        {

<<<<<<< HEAD
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            
        }
        public void Remove(IOrderItem item)
        {

            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            
        }

=======


        }

        public void Remove(IOrderItem item)
        {



        }
>>>>>>> 6db0ae7d03fd7a52dd4a7b5472a8e906198a6014
    }
}
