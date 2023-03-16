using System.Web.Mvc;

namespace sdasd
{
    public class CustomActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Bu metot, her action methodu çalışmadan önce çalışacak
            // ...
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // Bu metot, her action methodu çalıştıktan sonra çalışacak
            // ...
        }
    }
}
