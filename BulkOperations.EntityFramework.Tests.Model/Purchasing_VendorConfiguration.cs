using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_VendorConfiguration : EntityTypeConfiguration<Purchasing_Vendor>
    {
        public Purchasing_VendorConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_VendorConfiguration(string schema)
        {
            ToTable("Vendor", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AccountNumber).HasColumnName(@"AccountNumber").HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.CreditRating).HasColumnName(@"CreditRating").HasColumnType("tinyint").IsRequired();
            Property(x => x.PreferredVendorStatus).HasColumnName(@"PreferredVendorStatus").HasColumnType("bit").IsRequired();
            Property(x => x.ActiveFlag).HasColumnName(@"ActiveFlag").HasColumnType("bit").IsRequired();
            Property(x => x.PurchasingWebServiceUrl).HasColumnName(@"PurchasingWebServiceURL").HasColumnType("nvarchar").IsOptional().HasMaxLength(1024);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_BusinessEntity).WithOptional(b => b.Purchasing_Vendor).WillCascadeOnDelete(false); 
        }
    }
}