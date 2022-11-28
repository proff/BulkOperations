using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_Product
    {
        
        
        
        public int ProductId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public string ProductNumber { get; set; } 

        
        
        
        public bool MakeFlag { get; set; } 

        
        
        
        public bool FinishedGoodsFlag { get; set; } 

        
        
        
        public string Color { get; set; } 

        
        
        
        public short SafetyStockLevel { get; set; } 

        
        
        
        public short ReorderPoint { get; set; } 

        
        
        
        public decimal StandardCost { get; set; } 

        
        
        
        public decimal ListPrice { get; set; } 

        
        
        
        public string Size { get; set; } 

        
        
        
        public string SizeUnitMeasureCode { get; set; } 

        
        
        
        public string WeightUnitMeasureCode { get; set; } 

        
        
        
        public decimal? Weight { get; set; } 

        
        
        
        public int DaysToManufacture { get; set; } 

        
        
        
        public string ProductLine { get; set; } 

        
        
        
        public string Class { get; set; } 

        
        
        
        public string Style { get; set; } 

        
        
        
        public int? ProductSubcategoryId { get; set; } 

        
        
        
        public int? ProductModelId { get; set; } 

        
        
        
        public DateTime SellStartDate { get; set; } 

        
        
        
        public DateTime? SellEndDate { get; set; } 

        
        
        
        public DateTime? DiscontinuedDate { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_BillOfMaterial> Production_BillOfMaterials_ComponentId { get; set; } 

        
        
        
        public virtual ICollection<Production_BillOfMaterial> Production_BillOfMaterials_ProductAssemblyId { get; set; } 

        
        
        
        public virtual ICollection<Production_ProductCostHistory> Production_ProductCostHistories { get; set; } 

        
        
        
        public virtual ICollection<Production_ProductDocument> Production_ProductDocuments { get; set; } 

        
        
        
        public virtual ICollection<Production_ProductInventory> Production_ProductInventories { get; set; } 

        
        
        
        public virtual ICollection<Production_ProductListPriceHistory> Production_ProductListPriceHistories { get; set; } 

        
        
        
        public virtual ICollection<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; } 

        
        
        
        public virtual ICollection<Production_ProductReview> Production_ProductReviews { get; set; } 

        
        
        
        public virtual ICollection<Production_TransactionHistory> Production_TransactionHistories { get; set; } 

        
        
        
        public virtual ICollection<Production_WorkOrder> Production_WorkOrders { get; set; } 

        
        
        
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } 

        
        
        
        public virtual ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } 

        
        
        
        public virtual ICollection<Sales_ShoppingCartItem> Sales_ShoppingCartItems { get; set; } 

        
        
        
        public virtual ICollection<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } 

        

        
        
        
        public virtual Production_ProductModel Production_ProductModel { get; set; } 

        
        
        
        public virtual Production_ProductSubcategory Production_ProductSubcategory { get; set; } 

        
        
        
        public virtual Production_UnitMeasure Production_UnitMeasure_SizeUnitMeasureCode { get; set; } 

        
        
        
        public virtual Production_UnitMeasure Production_UnitMeasure_WeightUnitMeasureCode { get; set; } 

        public Production_Product()
        {
            MakeFlag = true;
            FinishedGoodsFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_BillOfMaterials_ComponentId = new List<Production_BillOfMaterial>();
            Production_BillOfMaterials_ProductAssemblyId = new List<Production_BillOfMaterial>();
            Production_ProductCostHistories = new List<Production_ProductCostHistory>();
            Production_ProductDocuments = new List<Production_ProductDocument>();
            Production_ProductInventories = new List<Production_ProductInventory>();
            Production_ProductListPriceHistories = new List<Production_ProductListPriceHistory>();
            Production_ProductProductPhotoes = new List<Production_ProductProductPhoto>();
            Production_ProductReviews = new List<Production_ProductReview>();
            Purchasing_ProductVendors = new List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderDetails = new List<Purchasing_PurchaseOrderDetail>();
            Sales_ShoppingCartItems = new List<Sales_ShoppingCartItem>();
            Sales_SpecialOfferProducts = new List<Sales_SpecialOfferProduct>();
            Production_TransactionHistories = new List<Production_TransactionHistory>();
            Production_WorkOrders = new List<Production_WorkOrder>();
        }
    }
}