using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_VProductModelInstructionConfiguration : EntityTypeConfiguration<Production_VProductModelInstruction>
    {
        public Production_VProductModelInstructionConfiguration()
            : this("Production")
        {
        }

        public Production_VProductModelInstructionConfiguration(string schema)
        {
            ToTable("vProductModelInstructions", schema);
            HasKey(x => new { x.ProductModelId, x.Name, x.Rowguid, x.ModifiedDate });

            Property(x => x.ProductModelId).HasColumnName(@"ProductModelID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Instructions).HasColumnName(@"Instructions").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.LocationId).HasColumnName(@"LocationID").HasColumnType("int").IsOptional();
            Property(x => x.SetupHours).HasColumnName(@"SetupHours").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.MachineHours).HasColumnName(@"MachineHours").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.LaborHours).HasColumnName(@"LaborHours").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.LotSize).HasColumnName(@"LotSize").HasColumnType("int").IsOptional();
            Property(x => x.Step).HasColumnName(@"Step").HasColumnType("nvarchar").IsOptional().HasMaxLength(1024);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}