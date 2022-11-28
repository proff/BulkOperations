using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_DocumentConfiguration : EntityTypeConfiguration<Production_Document>
    {
        public Production_DocumentConfiguration()
            : this("Production")
        {
        }

        public Production_DocumentConfiguration(string schema)
        {
            ToTable("Document", schema);
            HasKey(x => x.DocumentNode);

            Property(x => x.DocumentNode).HasColumnName(@"DocumentNode").HasColumnType("hierarchyid").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DocumentLevel).HasColumnName(@"DocumentLevel").HasColumnType("smallint").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Owner).HasColumnName(@"Owner").HasColumnType("int").IsRequired();
            Property(x => x.FolderFlag).HasColumnName(@"FolderFlag").HasColumnType("bit").IsRequired();
            Property(x => x.FileName).HasColumnName(@"FileName").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.FileExtension).HasColumnName(@"FileExtension").HasColumnType("nvarchar").IsRequired().HasMaxLength(8);
            Property(x => x.Revision).HasColumnName(@"Revision").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(5);
            Property(x => x.ChangeNumber).HasColumnName(@"ChangeNumber").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsRequired();
            Property(x => x.DocumentSummary).HasColumnName(@"DocumentSummary").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Document).HasColumnName(@"Document").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.Production_Documents).HasForeignKey(c => c.Owner).WillCascadeOnDelete(false); 
        }
    }
}