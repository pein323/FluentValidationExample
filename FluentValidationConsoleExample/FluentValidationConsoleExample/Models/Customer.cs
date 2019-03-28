namespace FluentValidationConsoleExample.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public decimal Discount { get; set; }
        public string Address { get; set; }
    }
}