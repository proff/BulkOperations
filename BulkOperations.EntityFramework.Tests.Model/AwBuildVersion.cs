using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class AwBuildVersion
    {
        
        
        
        public byte SystemInformationId { get; set; } 

        
        
        
        public string DatabaseVersion { get; set; } 

        
        
        
        public DateTime VersionDate { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        public AwBuildVersion()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}