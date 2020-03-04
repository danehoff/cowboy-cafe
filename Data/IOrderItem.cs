using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.Data 
=======

namespace CowboyCafe.Data
>>>>>>> 6db0ae7d03fd7a52dd4a7b5472a8e906198a6014
{
    public interface IOrderItem
    {

<<<<<<< HEAD
        Double Price { get; }
        IEnumerable<string> SpecialInstructions
        {
            get;
        }
=======
        List<string> SpecialInstructions { get; }

        double Price { get;  }



>>>>>>> 6db0ae7d03fd7a52dd4a7b5472a8e906198a6014
    }
}
