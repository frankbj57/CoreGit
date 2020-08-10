using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RegisterLib
{
	public class Register
    {
        private List<double> itemList;

        public Register()
        {
            itemList = new List<double>();
        }

        public double Total {get; private set;}

        public double NItems { get {
            return itemList.Count;
        }}

        public void AddItem(double item)
        {
            if (item < 0)
                throw new ArgumentException("Idiot!");

			itemList.Add(item);
            Total += item;
        }
	}
}
