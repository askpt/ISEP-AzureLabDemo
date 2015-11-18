﻿using ISEP_AzureLabDemo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISEP_AzureLabDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var requestClient = new HttpRequestClient();

            var model = requestClient.GetFixtureTable();

            return View(model);
        }
    }
}