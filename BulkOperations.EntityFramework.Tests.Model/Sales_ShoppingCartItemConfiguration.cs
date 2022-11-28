using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_ShoppingCartItemConfiguration : EntityTypeConfiguration<Sales_ShoppingCartItem>
    {
        public Sales_ShoppingCartItemConfiguration()
            : this("Sales")
        {
        }

        public Sales_ShoppingCartItemConfiguration(string schema)
        {
            ToTable("ShoppingCartItem", schema);
            HasKey(x => x.ShoppingCartItemId);

            Property(x => x.ShoppingCartItemId).HasColumnName(@"ShoppingCartItemID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ShoppingCartId).HasColumnName(@"ShoppingCartID").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Product).WithMany(b => b.Sales_ShoppingCartItems).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
        }
    }
}