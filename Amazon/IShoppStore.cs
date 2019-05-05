using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    interface IShoppStore
    {
        Customer GetCustomerName(string name);
        void GetNewCustomer(Customer customer);
        void GetOrders(int id);
        void GetNewOrders(Orders orders);
        Supplier GetSupplierByName(string name);
        void GetSupplierNewSupplier(Supplier supplier);
    }
}
