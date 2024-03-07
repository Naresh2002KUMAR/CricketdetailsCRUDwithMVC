using Cricket.Models;
using Cricket.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cricket.Controllers
{
    public class CricketerDetailController:Controller
    {
        private readonly ICricketerRepository _obj;
        private readonly string _connectionstring;
        public CricketerDetailController(ICricketerRepository model, IConfiguration configuration)
        {
            _obj = model;
            _connectionstring = configuration.GetConnectionString("DbConnectionString");
        }

        // GET: CricketerDetailsController
        public ActionResult Index()
        {
            var result = _obj.ReadPlayer();
            return View("View", result);
        }

        // GET: CricketerDetailsController/Details/5
        public ActionResult Details(int id)
        {
            var result = _obj.ReadPlayerById(id);
            return View("Details", result);
        }

        // GET: CricketerDetailsController/Create
        [HttpGet]
        public ActionResult Create(long ? id)
        {
            try
            {
                if (id.HasValue)
                {
                    var Get = _obj.ReadPlayerById(id.Value);
                    return View("Create", Get);
                }
                else
                {
                    var result = new Cricketer();
                    return View("Create", result);
                }
            }
            catch
            {
                return View("Error");
            }
        }

        // POST: CricketerDetailsController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Cricketer score)
        {
            try
            {
                if (score.CricketerId == 0)
                {
                    _obj.InsertPlayer(score);

                }
                else
                {
                    _obj.UpdatePlayer(score.CricketerId, score);
                }
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: CricketerDetailsController/Delete/5
        public ActionResult Delete(long id)
        {
            var result = _obj.ReadPlayerById(id);
            return View("Delete", result);
        }

        // POST: CricketerDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteById(long cricketerId)
        {
            try
            {
                _obj.DeletePlayer(cricketerId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }
    }
}

