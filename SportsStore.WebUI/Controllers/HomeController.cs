using SportsStore.WebUI.Infrastructure.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is  the index of action on the home controller.";
        }


        [RangeException]
        //[HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "RangeError")]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return string.Format("The id value is: {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }

        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write(string.Format("You requested the {0} action.", actionName));
        }
    }
}