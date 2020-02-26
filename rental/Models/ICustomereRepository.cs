using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rental.Models
{
   public interface ICustomereRepository
    {
        IEnumerable<Customer> AllCustomer { get; }
        public Customer getCustomerById(int id);
    }
}
