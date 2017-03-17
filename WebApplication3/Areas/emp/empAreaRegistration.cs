using System.Web.Mvc;

namespace WebApplication3.Areas.emp
{
    public class empAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "emp";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "emp_default",
                "emp/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}