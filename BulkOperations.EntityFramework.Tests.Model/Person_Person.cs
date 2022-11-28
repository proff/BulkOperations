using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_Person
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public string PersonType { get; set; } 

        
        
        
        public bool NameStyle { get; set; } 

        
        
        
        public string Title { get; set; } 

        
        
        
        public string FirstName { get; set; } 

        
        
        
        public string MiddleName { get; set; } 

        
        
        
        public string LastName { get; set; } 

        
        
        
        public string Suffix { get; set; } 

        
        
        
        public int EmailPromotion { get; set; } 

        
        
        
        public string AdditionalContactInfo { get; set; } 

        
        
        
        public string Demographics { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } 

        
        
        
        public virtual ICollection<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } 

        
        
        
        public virtual ICollection<Person_EmailAddress> Person_EmailAddresses { get; set; } 

        
        
        
        public virtual ICollection<Person_PersonPhone> Person_PersonPhones { get; set; } 

        
        
        
        public virtual ICollection<Sales_Customer> Sales_Customers { get; set; } 

        
        
        
        public virtual ICollection<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; } 

        
        
        
        public virtual Person_Password Person_Password { get; set; } 

        

        
        
        
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } 

        public Person_Person()
        {
            NameStyle = false;
            EmailPromotion = 0;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Person_BusinessEntityContacts = new List<Person_BusinessEntityContact>();
            Sales_Customers = new List<Sales_Customer>();
            Person_EmailAddresses = new List<Person_EmailAddress>();
            Sales_PersonCreditCards = new List<Sales_PersonCreditCard>();
            Person_PersonPhones = new List<Person_PersonPhone>();
        }
    }
}