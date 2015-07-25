using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class LojaController : Controller
    {
        // GET: Loja
        public ActionResult Index()
        {
            var dados = new MeusDados();
            var generos = dados.Generos.ToList();

            return View(generos);
        }

        public ActionResult Buscar(string genero)
        {
            var dados = new MeusDados();
            var albums = dados.Albuns.Where(g => g.Genero.Nome == genero).ToList();

            return View(albums);
        }

        public ActionResult Details(int id)
        {
            var dados = new MeusDados();
            var album = dados.Albuns.Single(a => a.Id == id);

            return View(album);
        }

        public ActionResult Criar()
        {
            var dados = new MeusDados();
            var model = new AlbumViewModel
            {
                Artistas = new SelectList(dados.Artistas, "Id", "Nome"),
                Generos = new MultiSelectList(dados.Generos, "Id", "Nome"),
                AlbumArtUrl = "~/Images/placeholder.png"
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Criar(AlbumViewModel model)
        {
            var dados = new MeusDados();
            model = new AlbumViewModel
            {
                Artistas = new SelectList(items: dados.Artistas, dataValueField: "Id", dataTextField: "Nome"),
                Generos = new MultiSelectList(dados.Generos, "Id", "Nome"),
                AlbumArtUrl = "~/Images/placeholder.png"
            };
            return View(model);
        }
    }
}