using System;
using FluentValidationConsoleExample.Models;
using FluentValidationConsoleExample.Validators;

namespace FluentValidationConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var validator = new CustomerValidator();

            var result = validator.Validate(customer);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine($"Property {failure.PropertyName} failed validation. Error was: {failure.ErrorMessage}");
                }
            }

            Console.ReadKey();
        }
    }
}
