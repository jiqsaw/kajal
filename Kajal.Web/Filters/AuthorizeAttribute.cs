using Kajal.Web.App_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kajal.Filters
{
    public class AuthAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.IsChildAction)
            {

                if (!SessionManager.GetInstance().IsFbLogin)
                    HttpContext.Current.Response.Redirect("~/");

            }
        }
         
    }
}