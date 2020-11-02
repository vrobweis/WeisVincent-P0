﻿using SufferShopDB.Models;
using SufferShopDB.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SufferShopBL
{
    public class ProductService
    {
        readonly IRepository repo;

        public ProductService(ref IRepository repo)
        {
            this.repo = repo;
        }

        public void AddProductToStock(Product addedProduct, Location targetLocation)
        {
            repo.AddNewProductToStock(addedProduct.Id, targetLocation.Id);
        }

        public List<InventoryLineItem> GetAllProductsAtLocation(Location location)
        {
            return repo.GetAllInventoryLineItemsAtLocationAsync(location.Id).Result;
        }

        public List<OrderLineItem> GetAllProductsInOrder(Order order)
        {
            return repo.GetOrderedProductsInAnOrder(order.Id);
        }

        public Task<List<OrderLineItem>> GetAllProductsInOrderAsync(Order order)
        {
            return repo.GetOrderedProductsInAnOrderAsync(order.Id);
        }

    }
}
