using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_CreditCard
    {
        
        
        
        public int CreditCardId { get; set; } 

        
        
        
        public string CardType { get; set; } 

        
        
        
        public string CardNumber { get; set; } 

        
        
        
        public byte ExpMonth { get; set; } 

        
        
        
        public short ExpYear { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } 

        public Sales_CreditCard()
        {
            ModifiedDate = DateTime.Now;
            Sales_PersonCreditCards = new List<Sales_PersonCreditCard>();
            Sales_SalesOrderHeaders = new List<Sales_SalesOrderHeader>();
        }
    }
}