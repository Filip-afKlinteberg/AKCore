﻿using AKCore.DataModel;
using AKCore.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace AKCore.Controllers
{
    public class PageController : Controller
    {
        private readonly AKContext _db;

        public PageController(AKContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            ViewData["Title"] = "Home";
            var model = new PageRenderModel();

            return View(model);
        }

        public ActionResult Page(string slug)
        {
            var loggedIn = User.Identity.IsAuthenticated;
            var redirectLink = "/";
            if (loggedIn)
            {
                redirectLink = "/upcoming";
            }

            Page page;
            if (string.IsNullOrWhiteSpace(slug))
            {
                if (loggedIn)
                {
                    return Redirect(redirectLink);
                }
                page = _db.Pages.FirstOrDefault(x => x.Slug == "/");
            }
            else
            {
                page = _db.Pages.FirstOrDefault(x => x.Slug == ("/" + slug));
            }
            if (slug == "teapot")
            {
                Response.StatusCode = 418;
                return View("Teapot");
            }
            else if (page == null)
            {
                Response.StatusCode = 404;
                return View("Error");
            }
            if (page.LoggedIn && !loggedIn)
            {
                return Redirect(redirectLink);
            }
            if (page.LoggedOut && loggedIn)
            {
                return Redirect(redirectLink);
            }
            if (page.BalettOnly)
            {
                if (!(User.IsInRole(AkRoles.Balett) || User.IsInRole(AkRoles.SuperNintendo)))
                {
                    return Redirect(redirectLink);
                }
            }
            ViewData["Title"] = page.Name;
            if (!string.IsNullOrWhiteSpace(page.MetaDescription))
            {
                ViewData["Description"] = page.MetaDescription;
            }

            var model = new PageRenderModel()
            {
                Widgets = page.WidgetsJson != null ? JsonConvert.DeserializeObject<List<Widget>>(page.WidgetsJson) : new List<Widget>()
            };
            for (var i = 0; i < model.Widgets.Count; i++)
            {
                model.Widgets[i].Id = i;
            }

            return View("Index", model);
        }
    }
}