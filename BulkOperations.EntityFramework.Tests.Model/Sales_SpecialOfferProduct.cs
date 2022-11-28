using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SpecialOfferProduct
    {
        
        
        
        public int SpecialOfferId { get; set; } 

        
        
        
        public int ProductId { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_SalesOrderDetail> Sales_SalesOrderDetails { get; set; } 

        

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        
        
        
        public virtual Sales_SpecialOffer Sales_SpecialOffer { get; set; } 

        public Sales_SpecialOfferProduct()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderDetails = new List<Sales_SalesOrderDetail>();
        }
    }
}