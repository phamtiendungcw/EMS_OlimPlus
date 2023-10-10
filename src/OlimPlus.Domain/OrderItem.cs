using OlimPlus.Domain.Core;

namespace OlimPlus.Domain
{
    public class OrderItem : BaseEntity
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public decimal UnitPrice { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
