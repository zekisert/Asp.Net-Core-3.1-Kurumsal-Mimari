using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class ProductDetail:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string CategoryName { get; set; }

    }
}