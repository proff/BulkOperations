using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_Illustration
    {
        
        
        
        public int IllustrationId { get; set; } 

        
        
        
        public string Diagram { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_ProductModelIllustration> Production_ProductModelIllustrations { get; set; } 

        public Production_Illustration()
        {
            ModifiedDate = DateTime.Now;
            Production_ProductModelIllustrations = new List<Production_ProductModelIllustration>();
        }
    }
}