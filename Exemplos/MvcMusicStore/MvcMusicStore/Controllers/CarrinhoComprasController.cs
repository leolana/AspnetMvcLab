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
            //Recupera os items e insere para a viewModel
            return View();
        }

        public ActionResult Adicionar(int id)
        {

            //TODO: Obtem o album e adiciona no carrinho
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Remover(int id)
        {
            

            return Json(new {});
        }
    }
}