using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Threading;
using System.Threading.Tasks;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public interface IAdventureWorksContext : IDisposable
    {
        DbSet<AwBuildVersion> AwBuildVersions { get; set; } 
        DbSet<DatabaseLog> DatabaseLogs { get; set; } 
        DbSet<ErrorLog> ErrorLogs { get; set; } 
        DbSet<HumanResources_Department> HumanResources_Departments { get; set; } 
        DbSet<HumanResources_Employee> HumanResources_Employees { get; set; } 
        DbSet<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; } 
        DbSet<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistories { get; set; } 
        DbSet<HumanResources_JobCandidate> HumanResources_JobCandidates { get; set; } 
        DbSet<HumanResources_Shift> HumanResources_Shifts { get; set; } 
        DbSet<HumanResources_VEmployee> HumanResources_VEmployees { get; set; } 
        DbSet<HumanResources_VEmployeeDepartment> HumanResources_VEmployeeDepartments { get; set; } 
        DbSet<HumanResources_VEmployeeDepartmentHistory> HumanResources_VEmployeeDepartmentHistories { get; set; } 
        DbSet<HumanResources_VJobCandidate> HumanResources_VJobCandidates { get; set; } 
        DbSet<HumanResources_VJobCandidateEducation> HumanResources_VJobCandidateEducations { get; set; } 
        DbSet<HumanResources_VJobCandidateEmployment> HumanResources_VJobCandidateEmployments { get; set; } 
        DbSet<Person_Address> Person_Addresses { get; set; } 
        DbSet<Person_AddressType> Person_AddressTypes { get; set; } 
        DbSet<Person_BusinessEntity> Person_BusinessEntities { get; set; } 
        DbSet<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } 
        DbSet<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } 
        DbSet<Person_ContactType> Person_ContactTypes { get; set; } 
        DbSet<Person_CountryRegion> Person_CountryRegions { get; set; } 
        DbSet<Person_EmailAddress> Person_EmailAddresses { get; set; } 
        DbSet<Person_Password> Person_Passwords { get; set; } 
        DbSet<Person_Person> Person_People { get; set; } 
        DbSet<Person_PersonPhone> Person_PersonPhones { get; set; } 
        DbSet<Person_PhoneNumberType> Person_PhoneNumberTypes { get; set; } 
        DbSet<Person_StateProvince> Person_StateProvinces { get; set; } 
        DbSet<Person_VAdditionalContactInfo> Person_VAdditionalContactInfoes { get; set; } 
        DbSet<Person_VStateProvinceCountryRegion> Person_VStateProvinceCountryRegions { get; set; } 
        DbSet<Production_BillOfMaterial> Production_BillOfMaterials { get; set; } 
        DbSet<Production_Culture> Production_Cultures { get; set; } 
        DbSet<Production_Document> Production_Documents { get; set; } 
        DbSet<Production_Illustration> Production_Illustrations { get; set; } 
        DbSet<Production_Location> Production_Locations { get; set; } 
        DbSet<Production_Product> Production_Products { get; set; } 
        DbSet<Production_ProductCategory> Production_ProductCategories { get; set; } 
        DbSet<Production_ProductCostHistory> Production_ProductCostHistories { get; set; } 
        DbSet<Production_ProductDescription> Production_ProductDescriptions { get; set; } 
        DbSet<Production_ProductDocument> Production_ProductDocuments { get; set; } 
        DbSet<Production_ProductInventory> Production_ProductInventories { get; set; } 
        DbSet<Production_ProductListPriceHistory> Production_ProductListPriceHistories { get; set; } 
        DbSet<Production_ProductModel> Production_ProductModels { get; set; } 
        DbSet<Production_ProductModelIllustration> Production_ProductModelIllustrations { get; set; } 
        DbSet<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } 
        DbSet<Production_ProductPhoto> Production_ProductPhotoes { get; set; } 
        DbSet<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; } 
        DbSet<Production_ProductReview> Production_ProductReviews { get; set; } 
        DbSet<Production_ProductSubcategory> Production_ProductSubcategories { get; set; } 
        DbSet<Production_ScrapReason> Production_ScrapReasons { get; set; } 
        DbSet<Production_TransactionHistory> Production_TransactionHistories { get; set; } 
        DbSet<Production_TransactionHistoryArchive> Production_TransactionHistoryArchives { get; set; } 
        DbSet<Production_UnitMeasure> Production_UnitMeasures { get; set; } 
        DbSet<Production_VProductAndDescription> Production_VProductAndDescriptions { get; set; } 
        DbSet<Production_VProductModelCatalogDescription> Production_VProductModelCatalogDescriptions { get; set; } 
        DbSet<Production_VProductModelInstruction> Production_VProductModelInstructions { get; set; } 
        DbSet<Production_WorkOrder> Production_WorkOrders { get; set; } 
        DbSet<Production_WorkOrderRouting> Production_WorkOrderRoutings { get; set; } 
        DbSet<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } 
        DbSet<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } 
        DbSet<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; } 
        DbSet<Purchasing_ShipMethod> Purchasing_ShipMethods { get; set; } 
        DbSet<Purchasing_Vendor> Purchasing_Vendors { get; set; } 
        DbSet<Purchasing_VVendorWithAddress> Purchasing_VVendorWithAddresses { get; set; } 
        DbSet<Purchasing_VVendorWithContact> Purchasing_VVendorWithContacts { get; set; } 
        DbSet<Sales_CountryRegionCurrency> Sales_CountryRegionCurrencies { get; set; } 
        DbSet<Sales_CreditCard> Sales_CreditCards { get; set; } 
        DbSet<Sales_Currency> Sales_Currencies { get; set; } 
        DbSet<Sales_CurrencyRate> Sales_CurrencyRates { get; set; } 
        DbSet<Sales_Customer> Sales_Customers { get; set; } 
        DbSet<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; } 
        DbSet<Sales_SalesOrderDetail> Sales_SalesOrderDetails { get; set; } 
        DbSet<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } 
        DbSet<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReasons { get; set; } 
        DbSet<Sales_SalesPerson> Sales_SalesPersons { get; set; } 
        DbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistories { get; set; } 
        DbSet<Sales_SalesReason> Sales_SalesReasons { get; set; } 
        DbSet<Sales_SalesTaxRate> Sales_SalesTaxRates { get; set; } 
        DbSet<Sales_SalesTerritory> Sales_SalesTerritories { get; set; } 
        DbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } 
        DbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItems { get; set; } 
        DbSet<Sales_SpecialOffer> Sales_SpecialOffers { get; set; } 
        DbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } 
        DbSet<Sales_Store> Sales_Stores { get; set; } 
        DbSet<Sales_VIndividualCustomer> Sales_VIndividualCustomers { get; set; } 
        DbSet<Sales_VPersonDemographic> Sales_VPersonDemographics { get; set; } 
        DbSet<Sales_VSalesPerson> Sales_VSalesPersons { get; set; } 
        DbSet<Sales_VSalesPersonSalesByFiscalYear> Sales_VSalesPersonSalesByFiscalYears { get; set; } 
        DbSet<Sales_VStoreWithAddress> Sales_VStoreWithAddresses { get; set; } 
        DbSet<Sales_VStoreWithContact> Sales_VStoreWithContacts { get; set; } 
        DbSet<Sales_VStoreWithDemographic> Sales_VStoreWithDemographics { get; set; } 

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbChangeTracker ChangeTracker { get; }
        DbContextConfiguration Configuration { get; }
        Database Database { get; }
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        DbSet Set(Type entityType);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        
        int HumanResources_UspUpdateEmployeeHireInfo(int? businessEntityId, string jobTitle, DateTime? hireDate, DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag);
        

        int HumanResources_UspUpdateEmployeeLogin(int? businessEntityId, HierarchyId organizationNode, string loginId, string jobTitle, DateTime? hireDate, bool? currentFlag);
        

        int HumanResources_UspUpdateEmployeePersonalInfo(int? businessEntityId, string nationalIdNumber, DateTime? birthDate, string maritalStatus, string gender);
        

        List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, DateTime? checkDate);
        List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, DateTime? checkDate, out int procResult);
        Task<List<UspGetBillOfMaterialsReturnModel>> UspGetBillOfMaterialsAsync(int? startProductId, DateTime? checkDate);

        List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId);
        List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId, out int procResult);
        Task<List<UspGetEmployeeManagersReturnModel>> UspGetEmployeeManagersAsync(int? businessEntityId);

        List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId);
        List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId, out int procResult);
        Task<List<UspGetManagerEmployeesReturnModel>> UspGetManagerEmployeesAsync(int? businessEntityId);

        List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, DateTime? checkDate);
        List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, DateTime? checkDate, out int procResult);
        Task<List<UspGetWhereUsedProductIdReturnModel>> UspGetWhereUsedProductIdAsync(int? startProductId, DateTime? checkDate);

        int UspLogError(out int? errorLogId);
        

        int UspPrintError();
        

        int UspSearchCandidateResumes(string searchString, bool? useInflectional, bool? useThesaurus, int? language);
        

    }
}