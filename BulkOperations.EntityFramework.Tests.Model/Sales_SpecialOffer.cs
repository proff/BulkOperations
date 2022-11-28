using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SpecialOffer
    {
        
        
        
        public int SpecialOfferId { get; set; } 

        
        
        
        public string Description { get; set; } 

        
        
        
        public decimal DiscountPct { get; set; } 

        
        
        
        public string Type { get; set; } 

        
        
        
        public string Category { get; set; } 

        
        
        
        public DateTime StartDate { get; set; } 

        
        
        
        public DateTime EndDate { get; set; } 

        
        
        
        public int MinQty { get; set; } 

        
        
        
        public int? MaxQty { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } 

        public Sales_SpecialOffer()
        {
            MinQty = 0;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_SpecialOfferProducts = new List<Sales_SpecialOfferProduct>();
        }
    }
}