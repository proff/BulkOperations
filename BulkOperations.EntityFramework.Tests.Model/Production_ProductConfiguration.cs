using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductConfiguration : EntityTypeConfiguration<Production_Product>
    {
        public Production_ProductConfiguration()
            : this("Production")
        {
        }

        public Production_ProductConfiguration(string schema)
        {
            ToTable("Product", schema);
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ProductNumber).HasColumnName(@"ProductNumber").HasColumnType("nvarchar").IsRequired().HasMaxLength(25);
            Property(x => x.MakeFlag).HasColumnName(@"MakeFlag").HasColumnType("bit").IsRequired();
            Property(x => x.FinishedGoodsFlag).HasColumnName(@"FinishedGoodsFlag").HasColumnType("bit").IsRequired();
            Property(x => x.Color).HasColumnName(@"Color").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.SafetyStockLevel).HasColumnName(@"SafetyStockLevel").HasColumnType("smallint").IsRequired();
            Property(x => x.ReorderPoint).HasColumnName(@"ReorderPoint").HasColumnType("smallint").IsRequired();
            Property(x => x.StandardCost).HasColumnName(@"StandardCost").HasColumnType("money").IsRequired();
            Property(x => x.ListPrice).HasColumnName(@"ListPrice").HasColumnType("money").IsRequired();
            Property(x => x.Size).HasColumnName(@"Size").HasColumnType("nvarchar").IsOptional().HasMaxLength(5);
            Property(x => x.SizeUnitMeasureCode).HasColumnName(@"SizeUnitMeasureCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.WeightUnitMeasureCode).HasColumnName(@"WeightUnitMeasureCode").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.Weight).HasColumnName(@"Weight").HasColumnType("decimal").IsOptional().HasPrecision(8,2);
            Property(x => x.DaysToManufacture).HasColumnName(@"DaysToManufacture").HasColumnType("int").IsRequired();
            Property(x => x.ProductLine).HasColumnName(@"ProductLine").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.Class).HasColumnName(@"Class").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.Style).HasColumnName(@"Style").HasColumnType("nchar").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.ProductSubcategoryId).HasColumnName(@"ProductSubcategoryID").HasColumnType("int").IsOptional();
            Property(x => x.ProductModelId).HasColumnName(@"ProductModelID").HasColumnType("int").IsOptional();
            Property(x => x.SellStartDate).HasColumnName(@"SellStartDate").HasColumnType("datetime").IsRequired();
            Property(x => x.SellEndDate).HasColumnName(@"SellEndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DiscontinuedDate).HasColumnName(@"DiscontinuedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasOptional(a => a.Production_ProductModel).WithMany(b => b.Production_Products).HasForeignKey(c => c.ProductModelId).WillCascadeOnDelete(false); 
            HasOptional(a => a.Production_ProductSubcategory).WithMany(b => b.Production_Products).HasForeignKey(c => c.ProductSubcategoryId).WillCascadeOnDelete(false); 
            HasOptional(a => a.Production_UnitMeasure_SizeUnitMeasureCode).WithMany(b => b.Production_Products_SizeUnitMeasureCode).HasForeignKey(c => c.SizeUnitMeasureCode).WillCascadeOnDelete(false); 
            HasOptional(a => a.Production_UnitMeasure_WeightUnitMeasureCode).WithMany(b => b.Production_Products_WeightUnitMeasureCode).HasForeignKey(c => c.WeightUnitMeasureCode).WillCascadeOnDelete(false); 
        }
    }
}