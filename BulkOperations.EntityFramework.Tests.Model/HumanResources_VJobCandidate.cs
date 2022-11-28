using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_VJobCandidate
    {
        public int JobCandidateId { get; set; } 
        public int? BusinessEntityId { get; set; } 
        public string Name46Prefix { get; set; } 
        public string Name46First { get; set; } 
        public string Name46Middle { get; set; } 
        public string Name46Last { get; set; } 
        public string Name46Suffix { get; set; } 
        public string Skills { get; set; } 
        public string Addr46Type { get; set; } 
        public string Addr46Loc46CountryRegion { get; set; } 
        public string Addr46Loc46State { get; set; } 
        public string Addr46Loc46City { get; set; } 
        public string Addr46PostalCode { get; set; } 
        public string EMail { get; set; } 
        public string WebSite { get; set; } 
        public DateTime ModifiedDate { get; set; } 
    }
}