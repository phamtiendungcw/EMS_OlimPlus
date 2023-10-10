using OlimPlus.Domain.Core;

namespace OlimPlus.Domain
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        public IReadOnlyList<Product> Products { get; set; }
    }
}