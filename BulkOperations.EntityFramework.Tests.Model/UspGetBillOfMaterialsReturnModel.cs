namespace BulkOperations.EntityFramework.Tests.Model
{
    public class UspGetBillOfMaterialsReturnModel
    {
        public int? ProductAssemblyID { get; set; }
        public int? ComponentID { get; set; }
        public string ComponentDesc { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? StandardCost { get; set; }
        public decimal? ListPrice { get; set; }
        public short? BOMLevel { get; set; }
        public int? RecursionLevel { get; set; }
    }
}