using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SpecialOfferConfiguration : EntityTypeConfiguration<Sales_SpecialOffer>
    {
        public Sales_SpecialOfferConfiguration()
            : this("Sales")
        {
        }

        public Sales_SpecialOfferConfiguration(string schema)
        {
            ToTable("SpecialOffer", schema);
            HasKey(x => x.SpecialOfferId);

            Property(x => x.SpecialOfferId).HasColumnName(@"SpecialOfferID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(255);
            Property(x => x.DiscountPct).HasColumnName(@"DiscountPct").HasColumnType("smallmoney").IsRequired();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Category).HasColumnName(@"Category").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsRequired();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsRequired();
            Property(x => x.MinQty).HasColumnName(@"MinQty").HasColumnType("int").IsRequired();
            Property(x => x.MaxQty).HasColumnName(@"MaxQty").HasColumnType("int").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}