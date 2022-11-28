using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_Address
    {
        
        
        
        public int AddressId { get; set; } 

        
        
        
        public string AddressLine1 { get; set; } 

        
        
        
        public string AddressLine2 { get; set; } 

        
        
        
        public string City { get; set; } 

        
        
        
        public int StateProvinceId { get; set; } 

        
        
        
        public string PostalCode { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders_BillToAddressId { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders_ShipToAddressId { get; set; } 

        

        
        
        
        public virtual Person_StateProvince Person_StateProvince { get; set; } 

        public Person_Address()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Person_BusinessEntityAddresses = new List<Person_BusinessEntityAddress>();
            Sales_SalesOrderHeaders_BillToAddressId = new List<Sales_SalesOrderHeader>();
            Sales_SalesOrderHeaders_ShipToAddressId = new List<Sales_SalesOrderHeader>();
        }
    }
}