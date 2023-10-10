using OlimPlus.Domain.Core;

namespace OlimPlus.Domain
{
    public class ProductImage : BaseEntity
    {
        public string Image { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
