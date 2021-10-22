﻿using Microsoft.EntityFrameworkCore;
using Products_Inc.Models;
using Products_Inc.Models.Interfaces;
using Products_Inc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products_Inc.Data
{
    public class DbShoppingCartRepo : IShoppingCartRepo
    {
        private readonly ApplicationDbContext _context;

        public DbShoppingCartRepo(ApplicationDbContext context)
        {
            this._context = context;
        }

        public ShoppingCart AddProduct(int productId, string shoppingCartId)
        {
            ShoppingCart shoppingCart = Read(shoppingCartId);
            Product product = _context.Products.Find(productId);
            shoppingCart.AddProduct(new ShoppingCartProduct() { Product = product, ProductId = productId, ShoppingCartId = Int32.Parse(shoppingCartId) });
            _context.Update(shoppingCart);
            _context.SaveChanges();

            return shoppingCart;
                
        }


        public ShoppingCart Create(ShoppingCart shoppingCart)
        {
            _context.Add(shoppingCart);
            _context.SaveChanges();

            return Read(shoppingCart.ShoppingCartId.ToString());
        }

        public bool Delete(ShoppingCart shoppingCart)
        {
            _context.ShoppingCarts.Remove(shoppingCart);
            _context.SaveChanges();

            return true;
        }

        public List<ShoppingCart> Read()
        {
            return _context.ShoppingCarts.ToList();
        }

        public ShoppingCart Read(string id)
        {
            return _context.ShoppingCarts.Include(sc => sc.Products).ThenInclude(scp => scp.Product).Where(sc => sc.ShoppingCartId.ToString().Equals(id)).FirstOrDefault();
        }

        public ShoppingCart ReadActiveByUser(string userid)
        {
            return _context.ShoppingCarts.Include(sc => sc.Products).ThenInclude(scp => scp.Product).Where(sc => sc.UserId.Equals(userid) && sc.Active && !sc.TransactionComplete).FirstOrDefault();
        }

        public List<ShoppingCart> ReadByUser(string userid)
        {
            return _context.ShoppingCarts.Where(sc => sc.UserId.Equals(userid)).ToList();
        }

        public ShoppingCart Update(ShoppingCart shoppingCart)
        {
            _context.Update(shoppingCart);
            _context.SaveChanges();

            return shoppingCart;
        }
    }
}