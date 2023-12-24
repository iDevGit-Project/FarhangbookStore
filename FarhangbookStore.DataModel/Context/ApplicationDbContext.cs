using FarhangbookStore.DataModel.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhangbookStore.DataModel.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        #region DbSets All Tables

        public DbSet<TBL_Product> TProducts { get; set; }
        public DbSet<TBL_ProductCategory> TProductCategory { get; set; }
        public DbSet<TBL_ProductGallery> TProductGallery { get; set; }
        public DbSet<TBL_ProductReview> TProductReview { get; set; }
        public DbSet<TBL_PropertyName> TPropertyName { get; set; }
        public DbSet<TBL_PropertyName_Category> TPropertyName_Category { get; set; }
        public DbSet<TBL_PropertyValue> TPropertyValue { get; set; }

        #endregion
    }
}
