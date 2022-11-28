using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_PersonCreditCard
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public int CreditCardId { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Person_Person Person_Person { get; set; } 

        
        
        
        public virtual Sales_CreditCard Sales_CreditCard { get; set; } 

        public Sales_PersonCreditCard()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}