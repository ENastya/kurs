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
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        RecordsDAO recordsDAO = new RecordsDAO();
        public ActionResult Index()
        {
            return View(recordsDAO.GetAllRecords());
        }

        public ActionResult Edit(int id)
        {
            return View(recordsDAO.AddDetails(id));
        }

        
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(Records records)
        {
            try
            {
                if (recordsDAO.Edit(records))
                    return RedirectToAction("Index");
                else
                    return View("Edit");
            }
            catch
            {
                return View("Edit");
            }
        }

        public ActionResult CreateCountry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCountry(String Country, String Visa)
        {
            {
                if (Visa == "Да") Visa = "1"; else Visa = "0";
                if (recordsDAO.AddCountry(Country, Visa))
                    return RedirectToAction("Index");
                else
                    return View("CreateCountry");

            }
        }

        public ActionResult CreateHotel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateHotel(String Hotel, String Stars)
        {
            {
                if (recordsDAO.AddHotel(Hotel, Stars))
                    return RedirectToAction("Index");
                else
                    return View("CreateHotel");

            }
        }

        public ActionResult Details(int id)
        {
            return View(recordsDAO.AddDetails(id));
        }

        public ActionResult Req()
        {
            return View(recordsDAO.ShowAllReq());
        }

        public ActionResult ReqAction(int id)
        {
            return View(recordsDAO.ShowOneReq(id));
        }

        [HttpPost]
        public ActionResult ReqAction(Request rec, String Status)
        {
            if (Status == "Принять") Status = "1"; else Status = "0";
            if (recordsDAO.StatReq(rec.ID, Status))
                return RedirectToAction("Req");
                else return RedirectToAction("Req");
        }

        public ActionResult Delete(int id)
        {
            return View(recordsDAO.AddDetails(id));
        }

        

        [HttpPost]
        public ActionResult Delete(Records records)
        {
            try
            {
                if (recordsDAO.DeleteT(records))
                    return RedirectToAction("Index");
                else
                    return View("Delete");
            }
            catch
            {
                return View("Index");
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Records records)
        {
                if (recordsDAO.AddTour(records))
                    return RedirectToAction("Index");
                else
                    return View("Create");
          
        }

    }
}