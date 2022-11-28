using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_ShipMethodConfiguration : EntityTypeConfiguration<Purchasing_ShipMethod>
    {
        public Purchasing_ShipMethodConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_ShipMethodConfiguration(string schema)
        {
            ToTable("ShipMethod", schema);
            HasKey(x => x.ShipMethodId);

            Property(x => x.ShipMethodId).HasColumnName(@"ShipMethodID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ShipBase).HasColumnName(@"ShipBase").HasColumnType("money").IsRequired();
            Property(x => x.ShipRate).HasColumnName(@"ShipRate").HasColumnType("money").IsRequired();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}