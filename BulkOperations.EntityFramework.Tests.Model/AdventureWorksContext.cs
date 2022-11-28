using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class AdventureWorksContext : DbContext, IAdventureWorksContext
    {
        public DbSet<AwBuildVersion> AwBuildVersions { get; set; } 
        public DbSet<DatabaseLog> DatabaseLogs { get; set; } 
        public DbSet<ErrorLog> ErrorLogs { get; set; } 
        public DbSet<HumanResources_Department> HumanResources_Departments { get; set; } 
        public DbSet<HumanResources_Employee> HumanResources_Employees { get; set; } 
        public DbSet<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; } 
        public DbSet<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistories { get; set; } 
        public DbSet<HumanResources_JobCandidate> HumanResources_JobCandidates { get; set; } 
        public DbSet<HumanResources_Shift> HumanResources_Shifts { get; set; } 
        public DbSet<HumanResources_VEmployee> HumanResources_VEmployees { get; set; } 
        public DbSet<HumanResources_VEmployeeDepartment> HumanResources_VEmployeeDepartments { get; set; } 
        public DbSet<HumanResources_VEmployeeDepartmentHistory> HumanResources_VEmployeeDepartmentHistories { get; set; } 
        public DbSet<HumanResources_VJobCandidate> HumanResources_VJobCandidates { get; set; } 
        public DbSet<HumanResources_VJobCandidateEducation> HumanResources_VJobCandidateEducations { get; set; } 
        public DbSet<HumanResources_VJobCandidateEmployment> HumanResources_VJobCandidateEmployments { get; set; } 
        public DbSet<Person_Address> Person_Addresses { get; set; } 
        public DbSet<Person_AddressType> Person_AddressTypes { get; set; } 
        public DbSet<Person_BusinessEntity> Person_BusinessEntities { get; set; } 
        public DbSet<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } 
        public DbSet<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } 
        public DbSet<Person_ContactType> Person_ContactTypes { get; set; } 
        public DbSet<Person_CountryRegion> Person_CountryRegions { get; set; } 
        public DbSet<Person_EmailAddress> Person_EmailAddresses { get; set; } 
        public DbSet<Person_Password> Person_Passwords { get; set; } 
        public DbSet<Person_Person> Person_People { get; set; } 
        public DbSet<Person_PersonPhone> Person_PersonPhones { get; set; } 
        public DbSet<Person_PhoneNumberType> Person_PhoneNumberTypes { get; set; } 
        public DbSet<Person_StateProvince> Person_StateProvinces { get; set; } 
        public DbSet<Person_VAdditionalContactInfo> Person_VAdditionalContactInfoes { get; set; } 
        public DbSet<Person_VStateProvinceCountryRegion> Person_VStateProvinceCountryRegions { get; set; } 
        public DbSet<Production_BillOfMaterial> Production_BillOfMaterials { get; set; } 
        public DbSet<Production_Culture> Production_Cultures { get; set; } 
        public DbSet<Production_Document> Production_Documents { get; set; } 
        public DbSet<Production_Illustration> Production_Illustrations { get; set; } 
        public DbSet<Production_Location> Production_Locations { get; set; } 
        public DbSet<Production_Product> Production_Products { get; set; } 
        public DbSet<Production_ProductCategory> Production_ProductCategories { get; set; } 
        public DbSet<Production_ProductCostHistory> Production_ProductCostHistories { get; set; } 
        public DbSet<Production_ProductDescription> Production_ProductDescriptions { get; set; } 
        public DbSet<Production_ProductDocument> Production_ProductDocuments { get; set; } 
        public DbSet<Production_ProductInventory> Production_ProductInventories { get; set; } 
        public DbSet<Production_ProductListPriceHistory> Production_ProductListPriceHistories { get; set; } 
        public DbSet<Production_ProductModel> Production_ProductModels { get; set; } 
        public DbSet<Production_ProductModelIllustration> Production_ProductModelIllustrations { get; set; } 
        public DbSet<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } 
        public DbSet<Production_ProductPhoto> Production_ProductPhotoes { get; set; } 
        public DbSet<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; } 
        public DbSet<Production_ProductReview> Production_ProductReviews { get; set; } 
        public DbSet<Production_ProductSubcategory> Production_ProductSubcategories { get; set; } 
        public DbSet<Production_ScrapReason> Production_ScrapReasons { get; set; } 
        public DbSet<Production_TransactionHistory> Production_TransactionHistories { get; set; } 
        public DbSet<Production_TransactionHistoryArchive> Production_TransactionHistoryArchives { get; set; } 
        public DbSet<Production_UnitMeasure> Production_UnitMeasures { get; set; } 
        public DbSet<Production_VProductAndDescription> Production_VProductAndDescriptions { get; set; } 
        public DbSet<Production_VProductModelCatalogDescription> Production_VProductModelCatalogDescriptions { get; set; } 
        public DbSet<Production_VProductModelInstruction> Production_VProductModelInstructions { get; set; } 
        public DbSet<Production_WorkOrder> Production_WorkOrders { get; set; } 
        public DbSet<Production_WorkOrderRouting> Production_WorkOrderRoutings { get; set; } 
        public DbSet<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } 
        public DbSet<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } 
        public DbSet<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; } 
        public DbSet<Purchasing_ShipMethod> Purchasing_ShipMethods { get; set; } 
        public DbSet<Purchasing_Vendor> Purchasing_Vendors { get; set; } 
        public DbSet<Purchasing_VVendorWithAddress> Purchasing_VVendorWithAddresses { get; set; } 
        public DbSet<Purchasing_VVendorWithContact> Purchasing_VVendorWithContacts { get; set; } 
        public DbSet<Sales_CountryRegionCurrency> Sales_CountryRegionCurrencies { get; set; } 
        public DbSet<Sales_CreditCard> Sales_CreditCards { get; set; } 
        public DbSet<Sales_Currency> Sales_Currencies { get; set; } 
        public DbSet<Sales_CurrencyRate> Sales_CurrencyRates { get; set; } 
        public DbSet<Sales_Customer> Sales_Customers { get; set; } 
        public DbSet<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; } 
        public DbSet<Sales_SalesOrderDetail> Sales_SalesOrderDetails { get; set; } 
        public DbSet<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } 
        public DbSet<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReasons { get; set; } 
        public DbSet<Sales_SalesPerson> Sales_SalesPersons { get; set; } 
        public DbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistories { get; set; } 
        public DbSet<Sales_SalesReason> Sales_SalesReasons { get; set; } 
        public DbSet<Sales_SalesTaxRate> Sales_SalesTaxRates { get; set; } 
        public DbSet<Sales_SalesTerritory> Sales_SalesTerritories { get; set; } 
        public DbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } 
        public DbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItems { get; set; } 
        public DbSet<Sales_SpecialOffer> Sales_SpecialOffers { get; set; } 
        public DbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } 
        public DbSet<Sales_Store> Sales_Stores { get; set; } 
        public DbSet<Sales_VIndividualCustomer> Sales_VIndividualCustomers { get; set; } 
        public DbSet<Sales_VPersonDemographic> Sales_VPersonDemographics { get; set; } 
        public DbSet<Sales_VSalesPerson> Sales_VSalesPersons { get; set; } 
        public DbSet<Sales_VSalesPersonSalesByFiscalYear> Sales_VSalesPersonSalesByFiscalYears { get; set; } 
        public DbSet<Sales_VStoreWithAddress> Sales_VStoreWithAddresses { get; set; } 
        public DbSet<Sales_VStoreWithContact> Sales_VStoreWithContacts { get; set; } 
        public DbSet<Sales_VStoreWithDemographic> Sales_VStoreWithDemographics { get; set; } 

        static AdventureWorksContext()
        {
            System.Data.Entity.Database.SetInitializer<AdventureWorksContext>(null);
        }

        
        public AdventureWorksContext()
            : base("Data Source=localhost,15826;Initial Catalog=AdventureWorks;User Id=sa;Password=Yf7(nk,&vT`|Zkiw")
        {
        }

        
        public AdventureWorksContext(string connectionString)
            : base(connectionString)
        {
        }

        
        public AdventureWorksContext(string connectionString, DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        
        public AdventureWorksContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        
        public AdventureWorksContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        
        public AdventureWorksContext(ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AwBuildVersionConfiguration());
            modelBuilder.Configurations.Add(new DatabaseLogConfiguration());
            modelBuilder.Configurations.Add(new ErrorLogConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_DepartmentConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_EmployeeConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_EmployeeDepartmentHistoryConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_EmployeePayHistoryConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_JobCandidateConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_ShiftConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeDepartmentConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeDepartmentHistoryConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateEducationConfiguration());
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateEmploymentConfiguration());
            modelBuilder.Configurations.Add(new Person_AddressConfiguration());
            modelBuilder.Configurations.Add(new Person_AddressTypeConfiguration());
            modelBuilder.Configurations.Add(new Person_BusinessEntityConfiguration());
            modelBuilder.Configurations.Add(new Person_BusinessEntityAddressConfiguration());
            modelBuilder.Configurations.Add(new Person_BusinessEntityContactConfiguration());
            modelBuilder.Configurations.Add(new Person_ContactTypeConfiguration());
            modelBuilder.Configurations.Add(new Person_CountryRegionConfiguration());
            modelBuilder.Configurations.Add(new Person_EmailAddressConfiguration());
            modelBuilder.Configurations.Add(new Person_PasswordConfiguration());
            modelBuilder.Configurations.Add(new Person_PersonConfiguration());
            modelBuilder.Configurations.Add(new Person_PersonPhoneConfiguration());
            modelBuilder.Configurations.Add(new Person_PhoneNumberTypeConfiguration());
            modelBuilder.Configurations.Add(new Person_StateProvinceConfiguration());
            modelBuilder.Configurations.Add(new Person_VAdditionalContactInfoConfiguration());
            modelBuilder.Configurations.Add(new Person_VStateProvinceCountryRegionConfiguration());
            modelBuilder.Configurations.Add(new Production_BillOfMaterialConfiguration());
            modelBuilder.Configurations.Add(new Production_CultureConfiguration());
            modelBuilder.Configurations.Add(new Production_DocumentConfiguration());
            modelBuilder.Configurations.Add(new Production_IllustrationConfiguration());
            modelBuilder.Configurations.Add(new Production_LocationConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductCategoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductCostHistoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductDescriptionConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductDocumentConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductInventoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductListPriceHistoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductModelConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductModelIllustrationConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductModelProductDescriptionCultureConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductReviewConfiguration());
            modelBuilder.Configurations.Add(new Production_ProductSubcategoryConfiguration());
            modelBuilder.Configurations.Add(new Production_ScrapReasonConfiguration());
            modelBuilder.Configurations.Add(new Production_TransactionHistoryConfiguration());
            modelBuilder.Configurations.Add(new Production_TransactionHistoryArchiveConfiguration());
            modelBuilder.Configurations.Add(new Production_UnitMeasureConfiguration());
            modelBuilder.Configurations.Add(new Production_VProductAndDescriptionConfiguration());
            modelBuilder.Configurations.Add(new Production_VProductModelCatalogDescriptionConfiguration());
            modelBuilder.Configurations.Add(new Production_VProductModelInstructionConfiguration());
            modelBuilder.Configurations.Add(new Production_WorkOrderConfiguration());
            modelBuilder.Configurations.Add(new Production_WorkOrderRoutingConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_ProductVendorConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_ShipMethodConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_VendorConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_VVendorWithAddressConfiguration());
            modelBuilder.Configurations.Add(new Purchasing_VVendorWithContactConfiguration());
            modelBuilder.Configurations.Add(new Sales_CountryRegionCurrencyConfiguration());
            modelBuilder.Configurations.Add(new Sales_CreditCardConfiguration());
            modelBuilder.Configurations.Add(new Sales_CurrencyConfiguration());
            modelBuilder.Configurations.Add(new Sales_CurrencyRateConfiguration());
            modelBuilder.Configurations.Add(new Sales_CustomerConfiguration());
            modelBuilder.Configurations.Add(new Sales_PersonCreditCardConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderSalesReasonConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesPersonConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesPersonQuotaHistoryConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesReasonConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesTaxRateConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryConfiguration());
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryHistoryConfiguration());
            modelBuilder.Configurations.Add(new Sales_ShoppingCartItemConfiguration());
            modelBuilder.Configurations.Add(new Sales_SpecialOfferConfiguration());
            modelBuilder.Configurations.Add(new Sales_SpecialOfferProductConfiguration());
            modelBuilder.Configurations.Add(new Sales_StoreConfiguration());
            modelBuilder.Configurations.Add(new Sales_VIndividualCustomerConfiguration());
            modelBuilder.Configurations.Add(new Sales_VPersonDemographicConfiguration());
            modelBuilder.Configurations.Add(new Sales_VSalesPersonConfiguration());
            modelBuilder.Configurations.Add(new Sales_VSalesPersonSalesByFiscalYearConfiguration());
            modelBuilder.Configurations.Add(new Sales_VStoreWithAddressConfiguration());
            modelBuilder.Configurations.Add(new Sales_VStoreWithContactConfiguration());
            modelBuilder.Configurations.Add(new Sales_VStoreWithDemographicConfiguration());

            
            modelBuilder.Entity<HumanResources_Department>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Department_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<HumanResources_Employee>()
                .Property(e => e.NationalIdNumber)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Employee_NationalIDNumber", 1) { IsUnique = true })
                );

            modelBuilder.Entity<HumanResources_Employee>()
                .Property(e => e.LoginId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Employee_LoginID", 1) { IsUnique = true })
                );

            modelBuilder.Entity<HumanResources_Employee>()
                .Property(e => e.OrganizationNode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new[]
                    {
                        new IndexAttribute("IX_Employee_OrganizationLevel_OrganizationNode", 2),
                        new IndexAttribute("IX_Employee_OrganizationNode", 1)
                    }));

            modelBuilder.Entity<HumanResources_Employee>()
                .Property(e => e.OrganizationLevel)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Employee_OrganizationLevel_OrganizationNode", 1))
                );

            modelBuilder.Entity<HumanResources_Employee>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Employee_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<HumanResources_EmployeeDepartmentHistory>()
                .Property(e => e.DepartmentId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_EmployeeDepartmentHistory_DepartmentID", 1))
                );

            modelBuilder.Entity<HumanResources_EmployeeDepartmentHistory>()
                .Property(e => e.ShiftId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_EmployeeDepartmentHistory_ShiftID", 1))
                );

            modelBuilder.Entity<HumanResources_JobCandidate>()
                .Property(e => e.BusinessEntityId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_JobCandidate_BusinessEntityID", 1))
                );

            modelBuilder.Entity<HumanResources_Shift>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Shift_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<HumanResources_Shift>()
                .Property(e => e.StartTime)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Shift_StartTime_EndTime", 1) { IsUnique = true })
                );

            modelBuilder.Entity<HumanResources_Shift>()
                .Property(e => e.EndTime)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Shift_StartTime_EndTime", 2) { IsUnique = true })
                );

            modelBuilder.Entity<Person_Address>()
                .Property(e => e.AddressLine1)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_Address>()
                .Property(e => e.AddressLine2)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 2) { IsUnique = true })
                );

            modelBuilder.Entity<Person_Address>()
                .Property(e => e.City)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 3) { IsUnique = true })
                );

            modelBuilder.Entity<Person_Address>()
                .Property(e => e.StateProvinceId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new[]
                    {
                        new IndexAttribute("IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 4) { IsUnique = true },
                        new IndexAttribute("IX_Address_StateProvinceID", 1)
                    }));

            modelBuilder.Entity<Person_Address>()
                .Property(e => e.PostalCode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode", 5) { IsUnique = true })
                );

            modelBuilder.Entity<Person_Address>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Address_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_AddressType>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_AddressType_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_AddressType>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_AddressType_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_BusinessEntity>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_BusinessEntity_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_BusinessEntityAddress>()
                .Property(e => e.AddressId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_BusinessEntityAddress_AddressID", 1))
                );

            modelBuilder.Entity<Person_BusinessEntityAddress>()
                .Property(e => e.AddressTypeId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_BusinessEntityAddress_AddressTypeID", 1))
                );

            modelBuilder.Entity<Person_BusinessEntityAddress>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_BusinessEntityAddress_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_BusinessEntityContact>()
                .Property(e => e.PersonId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_BusinessEntityContact_PersonID", 1))
                );

            modelBuilder.Entity<Person_BusinessEntityContact>()
                .Property(e => e.ContactTypeId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_BusinessEntityContact_ContactTypeID", 1))
                );

            modelBuilder.Entity<Person_BusinessEntityContact>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_BusinessEntityContact_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_ContactType>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ContactType_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_CountryRegion>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_CountryRegion_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_EmailAddress>()
                .Property(e => e.EmailAddress)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_EmailAddress_EmailAddress", 1))
                );

            modelBuilder.Entity<Person_Person>()
                .Property(e => e.FirstName)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Person_LastName_FirstName_MiddleName", 2))
                );

            modelBuilder.Entity<Person_Person>()
                .Property(e => e.MiddleName)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Person_LastName_FirstName_MiddleName", 3))
                );

            modelBuilder.Entity<Person_Person>()
                .Property(e => e.LastName)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Person_LastName_FirstName_MiddleName", 1))
                );

            modelBuilder.Entity<Person_Person>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Person_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_PersonPhone>()
                .Property(e => e.PhoneNumber)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_PersonPhone_PhoneNumber", 1))
                );

            modelBuilder.Entity<Person_StateProvince>()
                .Property(e => e.StateProvinceCode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_StateProvince_StateProvinceCode_CountryRegionCode", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_StateProvince>()
                .Property(e => e.CountryRegionCode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_StateProvince_StateProvinceCode_CountryRegionCode", 2) { IsUnique = true })
                );

            modelBuilder.Entity<Person_StateProvince>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_StateProvince_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Person_StateProvince>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_StateProvince_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_BillOfMaterial>()
                .Property(e => e.ProductAssemblyId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_BillOfMaterial>()
                .Property(e => e.ComponentId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate", 2) { IsUnique = true })
                );

            modelBuilder.Entity<Production_BillOfMaterial>()
                .Property(e => e.StartDate)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate", 3) { IsUnique = true })
                );

            modelBuilder.Entity<Production_BillOfMaterial>()
                .Property(e => e.UnitMeasureCode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_BillOfMaterials_UnitMeasureCode", 1))
                );

            modelBuilder.Entity<Production_Culture>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Culture_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_Document>()
                .Property(e => e.DocumentNode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Document_DocumentLevel_DocumentNode", 2) { IsUnique = true })
                );

            modelBuilder.Entity<Production_Document>()
                .Property(e => e.DocumentLevel)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Document_DocumentLevel_DocumentNode", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_Document>()
                .Property(e => e.FileName)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Document_FileName_Revision", 1))
                );

            modelBuilder.Entity<Production_Document>()
                .Property(e => e.Revision)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Document_FileName_Revision", 2))
                );

            modelBuilder.Entity<Production_Document>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new[]
                    {
                        new IndexAttribute("AK_Document_rowguid", 1) { IsUnique = true },
                        new IndexAttribute("UQ__Document__F73921F7C5112C2E", 1) { IsUnique = true }
                    }));

            modelBuilder.Entity<Production_Location>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Location_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_Product>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Product_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_Product>()
                .Property(e => e.ProductNumber)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Product_ProductNumber", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_Product>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Product_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_ProductCategory>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ProductCategory_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_ProductCategory>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ProductCategory_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_ProductDescription>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ProductDescription_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_ProductModel>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ProductModel_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_ProductModel>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ProductModel_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_ProductReview>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ProductReview_ProductID_Name", 1))
                );

            modelBuilder.Entity<Production_ProductReview>()
                .Property(e => e.ReviewerName)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ProductReview_ProductID_Name", 2))
                );

            modelBuilder.Entity<Production_ProductSubcategory>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ProductSubcategory_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_ProductSubcategory>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ProductSubcategory_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_ScrapReason>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ScrapReason_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_TransactionHistory>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_TransactionHistory_ProductID", 1))
                );

            modelBuilder.Entity<Production_TransactionHistory>()
                .Property(e => e.ReferenceOrderId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_TransactionHistory_ReferenceOrderID_ReferenceOrderLineID", 1))
                );

            modelBuilder.Entity<Production_TransactionHistory>()
                .Property(e => e.ReferenceOrderLineId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_TransactionHistory_ReferenceOrderID_ReferenceOrderLineID", 2))
                );

            modelBuilder.Entity<Production_TransactionHistoryArchive>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_TransactionHistoryArchive_ProductID", 1))
                );

            modelBuilder.Entity<Production_TransactionHistoryArchive>()
                .Property(e => e.ReferenceOrderId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_TransactionHistoryArchive_ReferenceOrderID_ReferenceOrderLineID", 1))
                );

            modelBuilder.Entity<Production_TransactionHistoryArchive>()
                .Property(e => e.ReferenceOrderLineId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_TransactionHistoryArchive_ReferenceOrderID_ReferenceOrderLineID", 2))
                );

            modelBuilder.Entity<Production_UnitMeasure>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_UnitMeasure_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Production_WorkOrder>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_WorkOrder_ProductID", 1))
                );

            modelBuilder.Entity<Production_WorkOrder>()
                .Property(e => e.ScrapReasonId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_WorkOrder_ScrapReasonID", 1))
                );

            modelBuilder.Entity<Production_WorkOrderRouting>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_WorkOrderRouting_ProductID", 1))
                );

            modelBuilder.Entity<Purchasing_ProductVendor>()
                .Property(e => e.BusinessEntityId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ProductVendor_BusinessEntityID", 1))
                );

            modelBuilder.Entity<Purchasing_ProductVendor>()
                .Property(e => e.UnitMeasureCode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ProductVendor_UnitMeasureCode", 1))
                );

            modelBuilder.Entity<Purchasing_PurchaseOrderDetail>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_PurchaseOrderDetail_ProductID", 1))
                );

            modelBuilder.Entity<Purchasing_PurchaseOrderHeader>()
                .Property(e => e.EmployeeId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_PurchaseOrderHeader_EmployeeID", 1))
                );

            modelBuilder.Entity<Purchasing_PurchaseOrderHeader>()
                .Property(e => e.VendorId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_PurchaseOrderHeader_VendorID", 1))
                );

            modelBuilder.Entity<Purchasing_ShipMethod>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ShipMethod_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Purchasing_ShipMethod>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_ShipMethod_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Purchasing_Vendor>()
                .Property(e => e.AccountNumber)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Vendor_AccountNumber", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_CountryRegionCurrency>()
                .Property(e => e.CurrencyCode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CountryRegionCurrency_CurrencyCode", 1))
                );

            modelBuilder.Entity<Sales_CreditCard>()
                .Property(e => e.CardNumber)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_CreditCard_CardNumber", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_Currency>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Currency_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_CurrencyRate>()
                .Property(e => e.CurrencyRateDate)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_CurrencyRate>()
                .Property(e => e.FromCurrencyCode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode", 2) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_CurrencyRate>()
                .Property(e => e.ToCurrencyCode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode", 3) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_Customer>()
                .Property(e => e.TerritoryId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Customer_TerritoryID", 1))
                );

            modelBuilder.Entity<Sales_Customer>()
                .Property(e => e.AccountNumber)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Customer_AccountNumber", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_Customer>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Customer_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesOrderDetail>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_SalesOrderDetail_ProductID", 1))
                );

            modelBuilder.Entity<Sales_SalesOrderDetail>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesOrderDetail_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesOrderHeader>()
                .Property(e => e.SalesOrderNumber)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesOrderHeader_SalesOrderNumber", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesOrderHeader>()
                .Property(e => e.CustomerId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_SalesOrderHeader_CustomerID", 1))
                );

            modelBuilder.Entity<Sales_SalesOrderHeader>()
                .Property(e => e.SalesPersonId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_SalesOrderHeader_SalesPersonID", 1))
                );

            modelBuilder.Entity<Sales_SalesOrderHeader>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesOrderHeader_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesPerson>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesPerson_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesPersonQuotaHistory>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesPersonQuotaHistory_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesTaxRate>()
                .Property(e => e.StateProvinceId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesTaxRate_StateProvinceID_TaxType", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesTaxRate>()
                .Property(e => e.TaxType)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesTaxRate_StateProvinceID_TaxType", 2) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesTaxRate>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesTaxRate_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesTerritory>()
                .Property(e => e.Name)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesTerritory_Name", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesTerritory>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesTerritory_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SalesTerritoryHistory>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SalesTerritoryHistory_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_ShoppingCartItem>()
                .Property(e => e.ShoppingCartId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ShoppingCartItem_ShoppingCartID_ProductID", 1))
                );

            modelBuilder.Entity<Sales_ShoppingCartItem>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_ShoppingCartItem_ShoppingCartID_ProductID", 2))
                );

            modelBuilder.Entity<Sales_SpecialOffer>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SpecialOffer_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_SpecialOfferProduct>()
                .Property(e => e.ProductId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_SpecialOfferProduct_ProductID", 1))
                );

            modelBuilder.Entity<Sales_SpecialOfferProduct>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_SpecialOfferProduct_rowguid", 1) { IsUnique = true })
                );

            modelBuilder.Entity<Sales_Store>()
                .Property(e => e.SalesPersonId)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Store_SalesPersonID", 1))
                );

            modelBuilder.Entity<Sales_Store>()
                .Property(e => e.Rowguid)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_Store_rowguid", 1) { IsUnique = true })
                );

        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AwBuildVersionConfiguration(schema));
            modelBuilder.Configurations.Add(new DatabaseLogConfiguration(schema));
            modelBuilder.Configurations.Add(new ErrorLogConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_DepartmentConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_EmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_EmployeeDepartmentHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_EmployeePayHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_JobCandidateConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_ShiftConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeDepartmentConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VEmployeeDepartmentHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateEducationConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResources_VJobCandidateEmploymentConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_AddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_AddressTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_BusinessEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_BusinessEntityAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_BusinessEntityContactConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_ContactTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_CountryRegionConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_EmailAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_PasswordConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_PersonConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_PersonPhoneConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_PhoneNumberTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_StateProvinceConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_VAdditionalContactInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new Person_VStateProvinceCountryRegionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_BillOfMaterialConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_CultureConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_DocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_IllustrationConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_LocationConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductCostHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductDescriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductDocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductInventoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductListPriceHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductModelConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductModelIllustrationConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductModelProductDescriptionCultureConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductPhotoConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductProductPhotoConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductReviewConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ProductSubcategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_ScrapReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_TransactionHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_TransactionHistoryArchiveConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_UnitMeasureConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_VProductAndDescriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_VProductModelCatalogDescriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_VProductModelInstructionConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_WorkOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new Production_WorkOrderRoutingConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_ProductVendorConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_PurchaseOrderHeaderConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_ShipMethodConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_VendorConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_VVendorWithAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Purchasing_VVendorWithContactConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CountryRegionCurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CurrencyRateConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_CustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_PersonCreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesOrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesOrderHeaderSalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesPersonConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesPersonQuotaHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesTaxRateConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SalesTerritoryHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_ShoppingCartItemConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SpecialOfferConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_SpecialOfferProductConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_StoreConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VIndividualCustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VPersonDemographicConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VSalesPersonConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VSalesPersonSalesByFiscalYearConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VStoreWithAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VStoreWithContactConfiguration(schema));
            modelBuilder.Configurations.Add(new Sales_VStoreWithDemographicConfiguration(schema));

            return modelBuilder;
        }

        
        public int HumanResources_UspUpdateEmployeeHireInfo(int? businessEntityId, string jobTitle, DateTime? hireDate, DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!businessEntityId.HasValue)
                businessEntityIdParam.Value = DBNull.Value;

            var jobTitleParam = new SqlParameter { ParameterName = "@JobTitle", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = jobTitle, Size = 50 };
            if (jobTitleParam.Value == null)
                jobTitleParam.Value = DBNull.Value;

            var hireDateParam = new SqlParameter { ParameterName = "@HireDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = hireDate.GetValueOrDefault() };
            if (!hireDate.HasValue)
                hireDateParam.Value = DBNull.Value;

            var rateChangeDateParam = new SqlParameter { ParameterName = "@RateChangeDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = rateChangeDate.GetValueOrDefault() };
            if (!rateChangeDate.HasValue)
                rateChangeDateParam.Value = DBNull.Value;

            var rateParam = new SqlParameter { ParameterName = "@Rate", SqlDbType = SqlDbType.Money, Direction = ParameterDirection.Input, Value = rate.GetValueOrDefault(), Precision = 19, Scale = 4 };
            if (!rate.HasValue)
                rateParam.Value = DBNull.Value;

            var payFrequencyParam = new SqlParameter { ParameterName = "@PayFrequency", SqlDbType = SqlDbType.TinyInt, Direction = ParameterDirection.Input, Value = payFrequency.GetValueOrDefault(), Precision = 3, Scale = 0 };
            if (!payFrequency.HasValue)
                payFrequencyParam.Value = DBNull.Value;

            var currentFlagParam = new SqlParameter { ParameterName = "@CurrentFlag", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = currentFlag.GetValueOrDefault() };
            if (!currentFlag.HasValue)
                currentFlagParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };

            Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "EXEC @procResult = [HumanResources].[uspUpdateEmployeeHireInfo] @BusinessEntityID, @JobTitle, @HireDate, @RateChangeDate, @Rate, @PayFrequency, @CurrentFlag", businessEntityIdParam, jobTitleParam, hireDateParam, rateChangeDateParam, rateParam, payFrequencyParam, currentFlagParam, procResultParam);

            return (int)procResultParam.Value;
        }

        

        public int HumanResources_UspUpdateEmployeeLogin(int? businessEntityId, HierarchyId organizationNode, string loginId, string jobTitle, DateTime? hireDate, bool? currentFlag)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!businessEntityId.HasValue)
                businessEntityIdParam.Value = DBNull.Value;

            var organizationNodeParam = new SqlParameter { ParameterName = "@OrganizationNode", SqlDbType = SqlDbType.VarChar, Direction = ParameterDirection.Input, Value = organizationNode, Size = 892 };
            if (organizationNode == null)
                organizationNodeParam.Value = DBNull.Value;

            var loginIdParam = new SqlParameter { ParameterName = "@LoginID", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = loginId, Size = 256 };
            if (loginIdParam.Value == null)
                loginIdParam.Value = DBNull.Value;

            var jobTitleParam = new SqlParameter { ParameterName = "@JobTitle", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = jobTitle, Size = 50 };
            if (jobTitleParam.Value == null)
                jobTitleParam.Value = DBNull.Value;

            var hireDateParam = new SqlParameter { ParameterName = "@HireDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = hireDate.GetValueOrDefault() };
            if (!hireDate.HasValue)
                hireDateParam.Value = DBNull.Value;

            var currentFlagParam = new SqlParameter { ParameterName = "@CurrentFlag", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = currentFlag.GetValueOrDefault() };
            if (!currentFlag.HasValue)
                currentFlagParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };

            Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "EXEC @procResult = [HumanResources].[uspUpdateEmployeeLogin] @BusinessEntityID, @OrganizationNode, @LoginID, @JobTitle, @HireDate, @CurrentFlag", businessEntityIdParam, organizationNodeParam, loginIdParam, jobTitleParam, hireDateParam, currentFlagParam, procResultParam);

            return (int)procResultParam.Value;
        }

        

        public int HumanResources_UspUpdateEmployeePersonalInfo(int? businessEntityId, string nationalIdNumber, DateTime? birthDate, string maritalStatus, string gender)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!businessEntityId.HasValue)
                businessEntityIdParam.Value = DBNull.Value;

            var nationalIdNumberParam = new SqlParameter { ParameterName = "@NationalIDNumber", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = nationalIdNumber, Size = 15 };
            if (nationalIdNumberParam.Value == null)
                nationalIdNumberParam.Value = DBNull.Value;

            var birthDateParam = new SqlParameter { ParameterName = "@BirthDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = birthDate.GetValueOrDefault() };
            if (!birthDate.HasValue)
                birthDateParam.Value = DBNull.Value;

            var maritalStatusParam = new SqlParameter { ParameterName = "@MaritalStatus", SqlDbType = SqlDbType.NChar, Direction = ParameterDirection.Input, Value = maritalStatus, Size = 1 };
            if (maritalStatusParam.Value == null)
                maritalStatusParam.Value = DBNull.Value;

            var genderParam = new SqlParameter { ParameterName = "@Gender", SqlDbType = SqlDbType.NChar, Direction = ParameterDirection.Input, Value = gender, Size = 1 };
            if (genderParam.Value == null)
                genderParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };

            Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "EXEC @procResult = [HumanResources].[uspUpdateEmployeePersonalInfo] @BusinessEntityID, @NationalIDNumber, @BirthDate, @MaritalStatus, @Gender", businessEntityIdParam, nationalIdNumberParam, birthDateParam, maritalStatusParam, genderParam, procResultParam);

            return (int)procResultParam.Value;
        }

        

        public List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, DateTime? checkDate)
        {
            int procResult;
            return UspGetBillOfMaterials(startProductId, checkDate, out procResult);
        }

        public List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, DateTime? checkDate, out int procResult)
        {
            var startProductIdParam = new SqlParameter { ParameterName = "@StartProductID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = startProductId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!startProductId.HasValue)
                startProductIdParam.Value = DBNull.Value;

            var checkDateParam = new SqlParameter { ParameterName = "@CheckDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = checkDate.GetValueOrDefault() };
            if (!checkDate.HasValue)
                checkDateParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UspGetBillOfMaterialsReturnModel>("EXEC @procResult = [dbo].[uspGetBillOfMaterials] @StartProductID, @CheckDate", startProductIdParam, checkDateParam, procResultParam).ToList();
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async Task<List<UspGetBillOfMaterialsReturnModel>> UspGetBillOfMaterialsAsync(int? startProductId, DateTime? checkDate)
        {
            var startProductIdParam = new SqlParameter { ParameterName = "@StartProductID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = startProductId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!startProductId.HasValue)
                startProductIdParam.Value = DBNull.Value;

            var checkDateParam = new SqlParameter { ParameterName = "@CheckDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = checkDate.GetValueOrDefault() };
            if (!checkDate.HasValue)
                checkDateParam.Value = DBNull.Value;

            var procResultData = await Database.SqlQuery<UspGetBillOfMaterialsReturnModel>("EXEC [dbo].[uspGetBillOfMaterials] @StartProductID, @CheckDate", startProductIdParam, checkDateParam).ToListAsync();
            return procResultData;
        }

        public List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId)
        {
            int procResult;
            return UspGetEmployeeManagers(businessEntityId, out procResult);
        }

        public List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId, out int procResult)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!businessEntityId.HasValue)
                businessEntityIdParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UspGetEmployeeManagersReturnModel>("EXEC @procResult = [dbo].[uspGetEmployeeManagers] @BusinessEntityID", businessEntityIdParam, procResultParam).ToList();
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async Task<List<UspGetEmployeeManagersReturnModel>> UspGetEmployeeManagersAsync(int? businessEntityId)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!businessEntityId.HasValue)
                businessEntityIdParam.Value = DBNull.Value;

            var procResultData = await Database.SqlQuery<UspGetEmployeeManagersReturnModel>("EXEC [dbo].[uspGetEmployeeManagers] @BusinessEntityID", businessEntityIdParam).ToListAsync();
            return procResultData;
        }

        public List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId)
        {
            int procResult;
            return UspGetManagerEmployees(businessEntityId, out procResult);
        }

        public List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId, out int procResult)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!businessEntityId.HasValue)
                businessEntityIdParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UspGetManagerEmployeesReturnModel>("EXEC @procResult = [dbo].[uspGetManagerEmployees] @BusinessEntityID", businessEntityIdParam, procResultParam).ToList();
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async Task<List<UspGetManagerEmployeesReturnModel>> UspGetManagerEmployeesAsync(int? businessEntityId)
        {
            var businessEntityIdParam = new SqlParameter { ParameterName = "@BusinessEntityID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = businessEntityId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!businessEntityId.HasValue)
                businessEntityIdParam.Value = DBNull.Value;

            var procResultData = await Database.SqlQuery<UspGetManagerEmployeesReturnModel>("EXEC [dbo].[uspGetManagerEmployees] @BusinessEntityID", businessEntityIdParam).ToListAsync();
            return procResultData;
        }

        public List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, DateTime? checkDate)
        {
            int procResult;
            return UspGetWhereUsedProductId(startProductId, checkDate, out procResult);
        }

        public List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, DateTime? checkDate, out int procResult)
        {
            var startProductIdParam = new SqlParameter { ParameterName = "@StartProductID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = startProductId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!startProductId.HasValue)
                startProductIdParam.Value = DBNull.Value;

            var checkDateParam = new SqlParameter { ParameterName = "@CheckDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = checkDate.GetValueOrDefault() };
            if (!checkDate.HasValue)
                checkDateParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UspGetWhereUsedProductIdReturnModel>("EXEC @procResult = [dbo].[uspGetWhereUsedProductID] @StartProductID, @CheckDate", startProductIdParam, checkDateParam, procResultParam).ToList();
            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async Task<List<UspGetWhereUsedProductIdReturnModel>> UspGetWhereUsedProductIdAsync(int? startProductId, DateTime? checkDate)
        {
            var startProductIdParam = new SqlParameter { ParameterName = "@StartProductID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = startProductId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!startProductId.HasValue)
                startProductIdParam.Value = DBNull.Value;

            var checkDateParam = new SqlParameter { ParameterName = "@CheckDate", SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input, Value = checkDate.GetValueOrDefault() };
            if (!checkDate.HasValue)
                checkDateParam.Value = DBNull.Value;

            var procResultData = await Database.SqlQuery<UspGetWhereUsedProductIdReturnModel>("EXEC [dbo].[uspGetWhereUsedProductID] @StartProductID, @CheckDate", startProductIdParam, checkDateParam).ToListAsync();
            return procResultData;
        }

        public int UspLogError(out int? errorLogId)
        {
            var errorLogIdParam = new SqlParameter { ParameterName = "@ErrorLogID", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output, Precision = 10, Scale = 0 };
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };

            Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "EXEC @procResult = [dbo].[uspLogError] @ErrorLogID OUTPUT", errorLogIdParam, procResultParam);

            if (IsSqlParameterNull(errorLogIdParam))
                errorLogId = null;
            else
                errorLogId = (int) errorLogIdParam.Value;

            return (int)procResultParam.Value;
        }

        

        public int UspPrintError()
        {
            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };

            Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "EXEC @procResult = [dbo].[uspPrintError] ", procResultParam);

            return (int)procResultParam.Value;
        }

        

        public int UspSearchCandidateResumes(string searchString, bool? useInflectional, bool? useThesaurus, int? language)
        {
            var searchStringParam = new SqlParameter { ParameterName = "@searchString", SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input, Value = searchString, Size = 1000 };
            if (searchStringParam.Value == null)
                searchStringParam.Value = DBNull.Value;

            var useInflectionalParam = new SqlParameter { ParameterName = "@useInflectional", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = useInflectional.GetValueOrDefault() };
            if (!useInflectional.HasValue)
                useInflectionalParam.Value = DBNull.Value;

            var useThesaurusParam = new SqlParameter { ParameterName = "@useThesaurus", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input, Value = useThesaurus.GetValueOrDefault() };
            if (!useThesaurus.HasValue)
                useThesaurusParam.Value = DBNull.Value;

            var languageParam = new SqlParameter { ParameterName = "@language", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = language.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!language.HasValue)
                languageParam.Value = DBNull.Value;

            var procResultParam = new SqlParameter { ParameterName = "@procResult", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };

            Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "EXEC @procResult = [dbo].[uspSearchCandidateResumes] @searchString, @useInflectional, @useThesaurus, @language", searchStringParam, useInflectionalParam, useThesaurusParam, languageParam, procResultParam);

            return (int)procResultParam.Value;
        }

        

    }
}