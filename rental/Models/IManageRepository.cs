using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rental.Models
{
    public interface IManageRepository
    {
        public ActionResult AddPhoneNumber();
        public ActionResult ChangePassword();
        public ActionResult SetPassword();
        public ActionResult LinkLogin(string provider);
       
    }
}
