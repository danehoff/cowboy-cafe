using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;


namespace CowboyCafe.Data
{
    public interface IOrderItem 
    {

        double Price { get; }
        List<string> SpecialInstructions
        {
            get;
        }

    }
}
