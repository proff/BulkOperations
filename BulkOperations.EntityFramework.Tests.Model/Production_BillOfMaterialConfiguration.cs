using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_BillOfMaterialConfiguration : EntityTypeConfiguration<Production_BillOfMaterial>
    {
        public Production_BillOfMaterialConfiguration()
            : this("Production")
        {
        }

        public Production_BillOfMaterialConfiguration(string schema)
        {
            ToTable("BillOfMaterials", schema);
            HasKey(x => x.BillOfMaterialsId);

            Property(x => x.BillOfMaterialsId).HasColumnName(@"BillOfMaterialsID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductAssemblyId).HasColumnName(@"ProductAssemblyID").HasColumnType("int").IsOptional();
            Property(x => x.ComponentId).HasColumnName(@"ComponentID").HasColumnType("int").IsRequired();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsRequired();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName(@"UnitMeasureCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.BomLevel).HasColumnName(@"BOMLevel").HasColumnType("smallint").IsRequired();
            Property(x => x.PerAssemblyQty).HasColumnName(@"PerAssemblyQty").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasOptional(a => a.ProductAssembly).WithMany(b => b.Production_BillOfMaterials_ProductAssemblyId).HasForeignKey(c => c.ProductAssemblyId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Component).WithMany(b => b.Production_BillOfMaterials_ComponentId).HasForeignKey(c => c.ComponentId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_UnitMeasure).WithMany(b => b.Production_BillOfMaterials).HasForeignKey(c => c.UnitMeasureCode).WillCascadeOnDelete(false); 
        }
    }
}