using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rental.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }

