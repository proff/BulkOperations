using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_Document
    {
        
        
        
        public System.Data.Entity.Hierarchy.HierarchyId DocumentNode { get; set; } 

        
        
        
        public short? DocumentLevel { get; private set; } 

        
        
        
        public string Title { get; set; } 

        
        
        
        public int Owner { get; set; } 

        
        
        
        public bool FolderFlag { get; set; } 

        
        
        
        public string FileName { get; set; } 

        
        
        
        public string FileExtension { get; set; } 

        
        
        
        public string Revision { get; set; } 

        
        
        
        public int ChangeNumber { get; set; } 

        
        
        
        public byte Status { get; set; } 

        
        
        
        public string DocumentSummary { get; set; } 

        
        
        
        public byte[] Document { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_ProductDocument> Production_ProductDocuments { get; set; } 

        

        
        
        
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } 

        public Production_Document()
        {
            FolderFlag = false;
            ChangeNumber = 0;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_ProductDocuments = new List<Production_ProductDocument>();
        }
    }
}