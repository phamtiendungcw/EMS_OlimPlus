using OlimPlus.Domain.Core;

namespace OlimPlus.Domain
{
    public class Role : BaseEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public User User { get; set; }
    }
}