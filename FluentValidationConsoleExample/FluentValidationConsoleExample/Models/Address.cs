using System.Collections.Generic;

namespace FluentValidationConsoleExample.Models
{
    public class Address
    {
        public List<string> Lines { get; set; } = new List<string>();
        public string Town { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
    }
}