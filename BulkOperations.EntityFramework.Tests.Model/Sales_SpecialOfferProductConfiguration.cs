using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SpecialOfferProductConfiguration : EntityTypeConfiguration<Sales_SpecialOfferProduct>
    {
        public Sales_SpecialOfferProductConfiguration()
            : this("Sales")
        {
        }

        public Sales_SpecialOfferProductConfiguration(string schema)
        {
            ToTable("SpecialOfferProduct", schema);
            HasKey(x => new { x.SpecialOfferId, x.ProductId });

            Property(x => x.SpecialOfferId).HasColumnName(@"SpecialOfferID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Product).WithMany(b => b.Sales_SpecialOfferProducts).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Sales_SpecialOffer).WithMany(b => b.Sales_SpecialOfferProducts).HasForeignKey(c => c.SpecialOfferId).WillCascadeOnDelete(false); 
        }
    }
}