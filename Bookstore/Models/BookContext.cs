using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;
using BookStore.Models;

namespace Bookstore.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}