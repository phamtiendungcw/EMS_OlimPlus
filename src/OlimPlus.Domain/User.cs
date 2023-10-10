namespace OlimPlus.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Image { get; set; }
        public string Status { get; set; }
        public string? ActivationCode { get; set; }
        public string? ForgotCode { get; set; }
        public DateTime? ForgotCodeSentTime { get; set; }

        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Role> Roles { get; set; }
        public IReadOnlyList<Order> Orders { get; set; }
        public IReadOnlyList<CartItem> CartItems { get; set; }
    }
}