﻿using SilkPlaster.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SilkPlaster.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            MemberManager memberManager = new MemberManager();
            memberManager.GetAllMember();

            return View();
        }
    }
}