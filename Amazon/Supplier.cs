using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    class Supplier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public float NumberOfProduct { get; set; }

        public static bool operator ==(Supplier supplier1, Supplier supplier2)
        {
            if ((supplier1 == null) && (supplier2 == null))
                return true;
            if ((supplier1 == null) || (supplier2 == null))
                return false;
            return (supplier1.Id == supplier2.Id);
        }
        public static bool operator !=(Supplier supplier1, Supplier supplier2)
        {
            return (supplier1 == supplier2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Supplier supplier = obj as Supplier;
            if (supplier == null)
                return false;
            return this.Id == supplier.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return $"Supplier ID {Id}, FirstName {FirstName}, LastName {LastName}, Country {Country}, Address {Address}, Product number {NumberOfProduct}";
        }
    }
}
