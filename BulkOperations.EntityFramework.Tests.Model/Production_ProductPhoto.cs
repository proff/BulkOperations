using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductPhoto
    {
        
        
        
        public int ProductPhotoId { get; set; } 

        
        
        
        public byte[] ThumbNailPhoto { get; set; } 

        
        
        
        public string ThumbnailPhotoFileName { get; set; } 

        
        
        
        public byte[] LargePhoto { get; set; } 

        
        
        
        public string LargePhotoFileName { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; } 

        public Production_ProductPhoto()
        {
            ModifiedDate = DateTime.Now;
            Production_ProductProductPhotoes = new List<Production_ProductProductPhoto>();
        }
    }
}