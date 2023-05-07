﻿using BookShopTutorial.DBL.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopTutorial.DBL.Context
{
    public class BookShopDB : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Buyer> Buyers{ get; set; }
        public DbSet<Seller> Sellers{ get; set; }
        public DbSet<Deal> Deals { get; set; }
        public BookShopDB(DbContextOptions<BookShopDB> options) : base(options) 
        { 
            
        }
    }
}
