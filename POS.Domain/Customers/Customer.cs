using POS.Domain.Primitives;
using POS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Customers
{
    public sealed class Customer : AggregateRoot
    {
        public Customer(CustomerId id, string name, string lastName, string email, PhoneNumber phoneNumber, bool active)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Active = active;
        }

        public Customer()
        {
                
        }

        public CustomerId Id { get; private set;}
        public string Name { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string FullName => $"{Name} {LastName}";
        public string Email { get; private set; } = string.Empty;
        public PhoneNumber PhoneNumber { get; private set; }
        public bool Active { get; private set; }
    }
}
