using FarhangbookStore.DataModel.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarhangbookStore.DataModel
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        #region DbSets All Tables

        public DbSet<TBL_Product> TBLProducts { get; set; }
        public DbSet<TBL_ProductCategory> TBLProductCategory { get; set; }
        public DbSet<TBL_ProductGallery> TBLProductGallery { get; set; }
        public DbSet<TBL_ProductReview> TBLProductReview { get; set; }
        public DbSet<TBL_PropertyName> TBLPropertyName { get; set; }
        public DbSet<TBL_ProductPrice> TBLProductPrice { get; set; }
        public DbSet<TBL_PropertyName_Category> TBLPropertyName_Category { get; set; }
        public DbSet<TBL_PropertyValue> TBLPropertyValue { get; set; }
        public DbSet<TBL_ProductReating> TBLProductReating { get; set; }
        public DbSet<TBL_ProductFaviorate> TBLProductFaviorate { get; set; }

        #endregion

        //نوشتن تابع جهت از بین بردن خطای مربوط به ارتباط یک جدول با خودش
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }
    }
}
