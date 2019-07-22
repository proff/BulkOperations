using System;
using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class Product
    {
        public Product()
        {
            this.BillOfMaterials = new List<BillOfMaterial>();
            this.BillOfMaterials1 = new List<BillOfMaterial>();
            this.ProductCostHistories = new List<ProductCostHistory>();
            this.ProductInventories = new List<ProductInventory>();
            this.ProductListPriceHistories = new List<ProductListPriceHistory>();
            this.ProductProductPhotoes = new List<ProductProductPhoto>();
            this.ProductReviews = new List<ProductReview>();
            this.ProductVendors = new List<ProductVendor>();
            this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            this.ShoppingCartItems = new List<ShoppingCartItem>();
            this.SpecialOfferProducts = new List<SpecialOfferProduct>();
            this.TransactionHistories = new List<TransactionHistory>();
            this.WorkOrders = new List<WorkOrder>();
        }

        public virtual int ProductID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ProductNumber { get; set; }
        public virtual bool MakeFlag { get; set; }
        public virtual bool FinishedGoodsFlag { get; set; }
        public virtual string Color { get; set; }
        public virtual short SafetyStockLevel { get; set; }
        public virtual short ReorderPoint { get; set; }
        public virtual decimal StandardCost { get; set; }
        public virtual decimal ListPrice { get; set; }
        public virtual string Size { get; set; }
        public virtual string SizeUnitMeasureCode { get; set; }
        public virtual string WeightUnitMeasureCode { get; set; }
        public virtual Nullable<decimal> Weight { get; set; }
        public virtual int DaysToManufacture { get; set; }
        public virtual string ProductLine { get; set; }
        public virtual string Class { get; set; }
        public virtual string Style { get; set; }
        public virtual Nullable<int> ProductSubcategoryID { get; set; }
        public virtual Nullable<int> ProductModelID { get; set; }
        public virtual System.DateTime SellStartDate { get; set; }
        public virtual Nullable<System.DateTime> SellEndDate { get; set; }
        public virtual Nullable<System.DateTime> DiscontinuedDate { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<BillOfMaterial> BillOfMaterials1 { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        public virtual ProductSubcategory ProductSubcategory { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
        public virtual UnitMeasure UnitMeasure1 { get; set; }
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public virtual ICollection<ProductProductPhoto> ProductProductPhotoes { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
