﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.Data 
{
    public interface IOrderItem
    {

        Double Price { get; }
        IEnumerable<string> SpecialInstructions
        {
            get;
        }
    }
}
