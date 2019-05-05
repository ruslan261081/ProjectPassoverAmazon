using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CreditNumber { get; set; }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            if ((customer1 == null) && (customer2 == null))
                return true;
            if ((customer1 == null) || (customer2 == null))
                return false;
            return (customer1.Id == customer2.Id);
        }
        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(customer1 == customer2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Customer customer = obj as Customer;
            if (customer == null)
                return false;
            return this.Id == customer.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return $"Customer Id {Id}, FirstName {FirstName}, LastName {LastName}, CreditNumber {CreditNumber}";
        }
    }
}
