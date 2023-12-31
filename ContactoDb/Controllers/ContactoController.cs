﻿using Microsoft.AspNetCore.Mvc;
using ContactoDb.Data;
using ContactoDb.Models;

namespace ContactoDb.Controllers
{
    public class ContactoController : Controller
    {
      //  public IActionResult Index()
      //  {
      //      return View();
      //  }

        ContactoDatos contactoDatos=new ContactoDatos();

        public IActionResult Listar()
        {
            var lista= contactoDatos.ListarContacto();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel model)
        {
            var respuesta = contactoDatos.GuardarContacto(model);
            if (respuesta)
                return RedirectToAction("Listar");
            else
            {
                return View();
            }
            }

    }
}
