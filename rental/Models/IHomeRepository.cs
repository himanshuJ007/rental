using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rental.Models
{
    public interface IHomeRepository
    {
        public ActionResult Index();
        public ActionResult About();
        public ActionResult Contact();
    }
}
