using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    class Orders
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Product { get; set; }
        public float Price { get; set; }

        public static bool operator ==(Orders orders1, Orders orders2)
        {
            if ((orders1 == null) && (orders2 == null))
                    return true;
            if ((orders1 == null) || (orders2 == null))
                    return false;
            return (orders1.Id == orders2.Id);
        }
        public static bool operator !=(Orders orders1, Orders orders2)
        {
            return (orders1 == orders2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Orders orders = obj as Orders;
            if (orders == null)
                return false;
            return this.Id == orders.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return $"Orders Id {Id}, FirstName {FirstName}, LastName {LastName}, Product {Product}, Price {Price}";
        }
    }
}
