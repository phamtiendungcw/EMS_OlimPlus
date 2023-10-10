namespace OlimPlus.Application.DTO.User
{
    public class UserDto
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
    }
}
