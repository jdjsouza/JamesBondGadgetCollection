using JamesBondGadgetCollection.Data;
using JamesBondGadgetCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamesBondGadgetCollection.Controllers
{
    public class GadgetsController : Controller
    {
        // GET: Gadgets
        public ActionResult Index()
        {
            // generate some fake data and send it to a view
            List<GadgetModel> gadgets = new List<GadgetModel>();

            GadgetDAO gadgetDAO = new GadgetDAO();

            gadgets = gadgetDAO.FetchAll();

            return View("Index", gadgets);
        }

        public ActionResult Details(int id)
        {
            GadgetDAO gadgetDAO = new GadgetDAO();
            GadgetModel gadget = gadgetDAO.FetchOne(id);

            return View("Details", gadget);
        }

        public ActionResult Create()
        {
            return View("GadgetForm");
        }

        public ActionResult Edit(int id)
        {
            GadgetDAO gadgetDAO = new GadgetDAO();
            GadgetModel gadgets = gadgetDAO.FetchOne(id);
            return View("GadgetForm", gadgets);
        }

        public ActionResult Delete(int id)
        {
            GadgetDAO gadgetDAO = new GadgetDAO();
            gadgetDAO.Delete(id);

            List<GadgetModel> gadgets = gadgetDAO.FetchAll();
            return View("Index", gadgets);
        }

        public ActionResult ProcessCreate(GadgetModel gadgetModel)
        {
            // save to the db

            GadgetDAO gadgetDAO = new GadgetDAO();

            gadgetDAO.CreateOrUpdate(gadgetModel);

            return View("Details", gadgetModel);
        }
    }
}