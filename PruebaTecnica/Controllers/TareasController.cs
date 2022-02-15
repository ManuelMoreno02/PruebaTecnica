using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace PruebaTecnica.Controllers
{
    public class TareasController : Controller
    {
        private readonly WebApplication1Context _context;

        public TareasController(WebApplication1Context context)
        {
            _context = context;
        }
        public IActionResult Index(int? Prioridad,bool? Estado)
        {

          
            IEnumerable<Tarea> ListaTareas = from Tarea in _context.Tareas                                        
                                              orderby Tarea.FechaCreacion descending
                                              select Tarea;



            

            if (Prioridad != null && Prioridad != 4)
            {
                ListaTareas = from Tarea in _context.Tareas
                              where Tarea.Prioridad.Equals(Prioridad)
                              orderby Tarea.FechaCreacion descending
                              select Tarea;

               
               
            }
            if(Estado != null)
            {
                ListaTareas = from Tarea in _context.Tareas
                              where Tarea.Estado.Equals(Estado)
                              orderby Tarea.FechaCreacion descending
                              select Tarea;
               
            }
            
            
            return View(ListaTareas);
        }
        public  IActionResult Terminadas()
        {
            IEnumerable<Tarea> ListaTareas = _context.Tareas;
            return View(ListaTareas);
        }

        public IActionResult Create()
        {
            

            return View();
        }

       


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                tarea.FechaCreacion = DateTime.Now;
                TimeSpan Tiempo = tarea.FechaEstimado - tarea.FechaCreacion;
                tarea.TiempoEstimado = Tiempo.ToString(@"dd\.hh\:mm\:ss");
                tarea.Estado = false;
                _context.Tareas.Add(tarea);
                _context.SaveChanges();
                TempData["mensaje"] = "La Tarea se a creado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult EditEstado(int? id) {
            var Consulta = _context.Tareas.Find(id);
            var resultado = _context.Tareas.Where(a => a.Id == id).Select(a => a.Estado).FirstOrDefault();
            resultado = (resultado == false) ? true : false;
            Consulta.Estado = resultado;
            Consulta.FechaFinal = DateTime.Now;
          
            if (resultado)
            {
                TempData["mensaje"] = "Se a Completado la Tarea";
           
            }
            else
            {
                TempData["mensaje"] = "La tarea no se a completado Aun";
          
            }
            _context.Tareas.Update(Consulta);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            var Consulta = _context.Tareas.Find(id);
            if(Consulta == null)
            {
                return NotFound();
            }
           
            return View(Consulta);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
               
                TimeSpan Tiempo = tarea.FechaEstimado - tarea.FechaCreacion;
                tarea.TiempoEstimado = Tiempo.ToString(@"dd\.hh\:mm\:ss");
                tarea.Estado = false;
                _context.Tareas.Update(tarea);
                _context.SaveChanges();
                TempData["mensaje"] = "La Tarea se a Actualizado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var Consulta = _context.Tareas.Find(Id);
            if (Consulta == null)
            {
                return NotFound();
            }

            return View(Consulta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarTa(int? Id)
        {
            var IdTarea = _context.Tareas.Find(Id);
            if(IdTarea == null)
            {
                return NotFound();
            }
            
                _context.Tareas.Remove(IdTarea);
                _context.SaveChanges();
                TempData["mensaje"] = "La Tarea se a Eliminado correctamente";

            return RedirectToAction("Index");
        }

       public IActionResult Graficas()
        {
            return View();
        }

    }
}
