﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BookStoreEntities : DbContext
    {
        public BookStoreEntities()
            : base("name=BookStoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
    
        public virtual int InsertBook(string bookName, Nullable<decimal> bookPrice, Nullable<int> authorID)
        {
            var bookNameParameter = bookName != null ?
                new ObjectParameter("bookName", bookName) :
                new ObjectParameter("bookName", typeof(string));
    
            var bookPriceParameter = bookPrice.HasValue ?
                new ObjectParameter("bookPrice", bookPrice) :
                new ObjectParameter("bookPrice", typeof(decimal));
    
            var authorIDParameter = authorID.HasValue ?
                new ObjectParameter("authorID", authorID) :
                new ObjectParameter("authorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBook", bookNameParameter, bookPriceParameter, authorIDParameter);
        }
    }
}
