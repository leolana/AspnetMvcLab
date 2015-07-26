using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class CarrinhoComprasController : Controller
    {
        public ActionResult Index()
        {
            var album = TempData["album"];

            return View(album);
        }

        public ActionResult Adicionar(int id)
        {
            var dados = new MeusDados();
            var album = dados.Albuns.First();

            TempData["album"] = album;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Remover(int id)
        {
            

            return Json(new {});
        }
    }
}