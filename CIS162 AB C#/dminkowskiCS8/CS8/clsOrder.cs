using System;
using System.Collections.Generic;
using System.Text;

//clsCOrder by Dave Minkowski

namespace CS8
{
    class clsOrder
    {
        // declare class variables

        protected string cstrDescription;
        protected int cintQuantity;
        protected decimal cdecPrice;
        protected decimal cdecExtendedPrice;

        //shared working variables
        protected static decimal cdecTotalPrice;
        protected static int cintTotalCount;
            
    // declare constructors:

    // default constructor:
    public clsOrder()
    {

    }

    // overloaded constructor using property methods to assign values:
    public clsOrder(string strDescription, int intQuantity, decimal decPrice)
    {
        this.Description = strDescription;
        this.Quantity = intQuantity;
        this.Price = decPrice;
    }
    
    // description property (get/set)
    public string Description
        {
            get
            {
                return cstrDescription;
            }
            set
            {
                cstrDescription = value;
            }
        }

    // quantity property
    public int Quantity
        {
            get
            {
                return cintQuantity;
            }
            set
            {
                cintQuantity = value;
            }
        }

    // price property
    public decimal Price
        {
            get
            {
                return cdecPrice;
            }
            set
            {
                cdecPrice = value;
            }
        }

    // declare read-only properties (get with no set)
        public decimal ExtendedPrice 
        {
            get
            {
                return cdecExtendedPrice;
            }
        }

    // declare Shared (static) ReadOnly Properites
        public static decimal TotalPrice 
        {
            get
            {
                return cdecTotalPrice;
            }
        }

        public static int TotalCount 
       {
            get
            {
                return cintTotalCount;
            }
        }

    //  declare supporting methods - method to calculate the total price (price * quantity)
        public void calcExtendedPrice()
        {
            cdecExtendedPrice = cintQuantity * cdecPrice;
        }

        // declare supporting methods - method to add the total price of the items to the overall price of the "cart" and incremement the number of unique item types purchased
        public void accumulateTotals()
        {
            cdecTotalPrice += cdecExtendedPrice;
            cintTotalCount += 1;
        }

        // declare supporting methods - method to reset the count and price totals
        public static void resetTotals()
        {
            cdecTotalPrice = 0;
            cintTotalCount = 0;
        }

    }//end of class
}
