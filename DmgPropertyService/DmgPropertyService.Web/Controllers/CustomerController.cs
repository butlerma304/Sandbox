using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DmgPropertyService.Domain;
using DmgPropertyService.Web.Models;

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
