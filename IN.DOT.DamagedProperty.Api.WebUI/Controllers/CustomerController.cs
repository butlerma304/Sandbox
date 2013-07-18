using System.Web.Mvc;

namespace DmgPropertyService.Web.Controllers
{
    public class CustomerController : Controller
    {

        
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            //Customer customerObject 
            //var employeeViewModelObject = Mapper.Map<Customer, CustomerViewModel>(customer );
            return View();
        }

    }
}
