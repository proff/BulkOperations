using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesOrderHeader
    {
        
        
        
        public int SalesOrderId { get; set; } 

        
        
        
        public byte RevisionNumber { get; set; } 

        
        
        
        public DateTime OrderDate { get; set; } 

        
        
        
        public DateTime DueDate { get; set; } 

        
        
        
        public DateTime? ShipDate { get; set; } 

        
        
        
        public byte Status { get; set; } 

        
        
        
        public bool OnlineOrderFlag { get; set; } 

        
        
        
        public string SalesOrderNumber { get; private set; } 

        
        
        
        public string PurchaseOrderNumber { get; set; } 

        
        
        
        public string AccountNumber { get; set; } 

        
        
        
        public int CustomerId { get; set; } 

        
        
        
        public int? SalesPersonId { get; set; } 

        
        
        
        public int? TerritoryId { get; set; } 

        
        
        
        public int BillToAddressId { get; set; } 

        
        
        
        public int ShipToAddressId { get; set; } 

        
        
        
        public int ShipMethodId { get; set; } 

        
        
        
        public int? CreditCardId { get; set; } 

        
        
        
        public string CreditCardApprovalCode { get; set; } 

        
        
        
        public int? CurrencyRateId { get; set; } 

        
        
        
        public decimal SubTotal { get; set; } 

        
        
        
        public decimal TaxAmt { get; set; } 

        
        
        
        public decimal Freight { get; set; } 

        
        
        
        public decimal TotalDue { get; private set; } 

        
        
        
        public string Comment { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_SalesOrderDetail> Sales_SalesOrderDetails { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReasons { get; set; } 

        

        
        
        
        public virtual Person_Address BillToAddress { get; set; } 

        
        
        
        public virtual Person_Address ShipToAddress { get; set; } 

        
        
        
        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; } 

        
        
        
        public virtual Sales_CreditCard Sales_CreditCard { get; set; } 

        
        
        
        public virtual Sales_CurrencyRate Sales_CurrencyRate { get; set; } 

        
        
        
        public virtual Sales_Customer Sales_Customer { get; set; } 

        
        
        
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } 

        
        
        
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } 

        public Sales_SalesOrderHeader()
        {
            RevisionNumber = 0;
            OrderDate = DateTime.Now;
            Status = 1;
            OnlineOrderFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderDetails = new List<Sales_SalesOrderDetail>();
            Sales_SalesOrderHeaderSalesReasons = new List<Sales_SalesOrderHeaderSalesReason>();
        }
    }
}