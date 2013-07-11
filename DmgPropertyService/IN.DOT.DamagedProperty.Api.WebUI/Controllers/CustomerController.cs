using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IN.DOT.DamagedProperty.Api.Domain;

namespace IN.DOT.DamagedProperty.Api.WebUI.Controllers
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
