using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcApplication.Models;
using mvcApplication.DAO;
using Microsoft.AspNet.Identity;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        RecordsDAO recordsDAO = new RecordsDAO();
        public ActionResult Index()
        {
            return View(recordsDAO.RandDetails());
        }

        public ActionResult Stat()
        {
            return View();
        }

        public ActionResult Tours()
        {
            return View(recordsDAO.GetAllRecords());
        }
        [HttpPost]
        public ActionResult Tours(String Country, String Visa, String Stars, String Gor)
        {
            if (Country == "Все") Country = "%";
            if (Visa == "Все") Visa = "%"; else if (Visa == "Да") Visa = "1"; else Visa ="0" ;
            if (Gor == "Все") Gor = "%"; else if (Gor == "Да") Gor = "1"; else Gor= "0";
            return View(recordsDAO.Filter(Country, Visa, Stars, Gor));
        }

        public ActionResult Details(int id)
        {
            return View(recordsDAO.AddDetails(id));
        }
        [Authorize]
        [HttpPost]
        public ActionResult Details(Records record, string email)
        {
           int id = record.ID;
          email = User.Identity.GetUserName();
           if (recordsDAO.AddReq(email, id))
          return View(recordsDAO.AddDetails(id));
            else
            return View(recordsDAO.AddDetails(id));
        }
        

       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}