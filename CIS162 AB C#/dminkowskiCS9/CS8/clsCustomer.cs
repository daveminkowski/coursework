using System;
using System.Collections.Generic;
using System.Text;

//clsCustomer by Dave Minkowski

namespace CS8
{
    class clsCustomer
    {
        // declare class variables

        private string cstrName;
        private string cstrStreet;
        private string cstrCity;
        private string cstrState;
        private string cstrZip;

        // declare constructors:

        // default constructor:
        public clsCustomer()
        {

        }

        // overloaded constructor using property methods to assign values:

        public clsCustomer(string strName, string strStreet, string strCity, string strState, string strZip)
        {
            this.Name = strName;
            this.Street = strStreet;
            this.City = strCity;
            this.State = strState;
            this.Zip = strZip;
        }
    // name property
        public string Name
        {
            get
            {
                return cstrName;
            }
            set
            {
                cstrName = value;
            }
        }
    // street property
        public string Street
        {
            get
            {
                return cstrStreet;
            }
            set
            {
                cstrStreet = value;
            }
        }
    // city property
        public string City
        {
            get
            {
                return cstrCity;
            }
            set
            {
                cstrCity = value;
            }
        }
    // state property
        public string State
        {
            get
            {
                return cstrState;
            }
            set
            {
                cstrState = value;
            }
        }
    // zip code property
        public string Zip
        {
            get
            {
                return cstrZip;
            }
            set
            {
                cstrZip = value;
            }
        }

    }
}
