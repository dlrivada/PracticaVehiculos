using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFSQLServerRepository;
using PracticaVehiculos.Contrato;
using PracticaVehiculos.Dominio;

namespace ClienteWebVehiculos.Controllers
{
    public class VehicleController : Controller
    {
        private IVehicleRepository _vehicleRepository;

        // GET: Vehicle
        public ActionResult Index()
        {
            _vehicleRepository = new VehicleRepository();
            List<PracticaVehiculos.Dominio.VehicleD> vehicles = _vehicleRepository.GetVehicles();
            return View(vehicles);
        }

        // GET: Vehicle/Details/5
        public ActionResult Details(int id)
        {
            _vehicleRepository = new VehicleRepository();
            PracticaVehiculos.Dominio.VehicleD vehicleD = _vehicleRepository.GetVehicleById(id);
            return View(vehicleD);
        }

        // GET: Vehicle/Create
        public ActionResult Create()
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Vehicle/Create
        [HttpPost]
        public ActionResult Create(VehicleD model)
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, VehicleD model)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vehicle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, VehicleD model)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
