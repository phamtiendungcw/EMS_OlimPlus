using OlimPlus.Domain.Core;

namespace OlimPlus.Domain
{
    public class Payment : BaseEntity
    {
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public Order Order { get; set; }
    }
}
