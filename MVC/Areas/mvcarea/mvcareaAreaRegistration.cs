using System.Web.Mvc;

namespace MVC.Areas.mvcarea
{
    public class mvcareaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "mvcarea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "mvcarea_default",
                "mvcarea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}