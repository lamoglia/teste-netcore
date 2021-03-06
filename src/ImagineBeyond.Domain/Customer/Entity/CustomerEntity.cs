using System;

namespace ImagineBeyond.Customer.Entity
{
    public class CustomerEntity
    {
        public CustomerEntity(string firstName, string lastName, string email)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DateCreate = DateTime.Now;
            this.DateLastUpdate = null;
        }

        public Guid Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public DateTime DateCreate { get; private set; }

        public DateTime? DateLastUpdate { get; private set; }

        public CustomerEntity Update(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DateLastUpdate = DateTime.Now;
            return this;
        }
    }
}