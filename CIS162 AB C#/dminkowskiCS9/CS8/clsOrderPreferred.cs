using System;
using System.Collections.Generic;
using System.Text;

//clsOrderPreferred by Dave Minkowski

namespace CS8
{

    class clsOrderPreferred : clsOrder
    {
        private const decimal cdecDISCOUNT_RATE = 0.05M;

        public clsOrderPreferred()
            : base()
        {
            // call base default constructor
        }

        public clsOrderPreferred(string strDescription, int intQuantity, decimal decPrice)
            : base(strDescription, intQuantity, decPrice)
        {
            // call base overloaded-class constructor and pass values
        }

        //override definition of virtual definition in base 

        public override void calcExtendedPrice()
        {
            cdecExtendedPrice = cintQuantity * (cdecPrice - (cdecPrice * cdecDISCOUNT_RATE));

        }

    }

}
