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
    }
}