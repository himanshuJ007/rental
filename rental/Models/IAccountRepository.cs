using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace rental.Models
{
    public interface IAccountRepository
    {
        public ActionResult Login(string returnUrl);
        public ActionResult Register();
        public ActionResult ForgotPassword();
        public ActionResult ForgotPasswordConfirmation();
        public ActionResult ResetPassword(string code);
        public ActionResult ResetPasswordConfirmation();
        public ActionResult ExternalLogin(string provider, string returnUrl);
        public ActionResult LogOff();
        public ActionResult ExternalLoginFailure();
    }
}
