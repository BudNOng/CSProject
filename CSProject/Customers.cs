using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    class Customers
    {
        public string _name;
        public int _Id;
        public int _NumOfOrder;
        public List<Order> orders = new List<Order>();

        public Customers(string name, int id)
        {
            this._name = name;
            this._Id = id;
        }

        public override string ToString()
        {
            return "Name is: " + _name + " & the ID is: " + _Id;
        }
    }

    public class Order
    {
        
    }
}
