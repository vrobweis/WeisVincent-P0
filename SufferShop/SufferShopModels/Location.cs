﻿using System;
using System.Collections.Generic;

namespace SufferShopModels
{
    //TODO: Add XML Documentation on Location class
    public class Location : IStorableInRepo
    {
        // TODO: Create Location constructors
        int id;

        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private string name;

        public string Name { get { return name; } set { name = value; } }

        private string address;
        public string Address { get { return address; } set { address = value; } }

        List<Product> ProductStock;

        Stack<Order> OrderHistory;


    }
}