using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using BulkOperations.EntityFramework.Tests.Model;

namespace BulkOperations.EntityFramework.Tests
{
    public partial class ExternalAdventureWorksContext : DbContext
    {
        static ExternalAdventureWorksContext()
        {
            Database.SetInitializer<ExternalAdventureWorksContext>(null);
        }

        public ExternalAdventureWorksContext()
            : base("Data Source=localhost,15826;Initial Catalog=AdventureWorks;User Id=sa;Password=Yf7(nk,&vT`|Zkiw")
        {
        }

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
    }
}
