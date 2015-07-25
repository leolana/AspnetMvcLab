using MvcMusicStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dados = new MeusDados();
            var albuns = dados.Albuns.Take(6).ToList();
            return View(albuns);
        }

        public ActionResult BuscarArtista(string q)
        {
            var artists = ObterArtistas(q);

            return PartialView("_BuscarArtistaPartialView", artists);
        }

        private List<Artista> ObterArtistas(string searchString)
        {
            var dados = new MeusDados();
            return dados.Artistas.Where(a => a.Nome.Contains(searchString))
                .ToList();
        }

        public ActionResult Ofertas()
        {
            var album = GetDailyDeal();

            return PartialView("_OfertasPartialView", album);
        }

        // Select an album and discount it by 50%
        private Album GetDailyDeal()
        {
            var dados = new MeusDados();
            var album = dados.Albuns.OrderBy(a => System.Guid.NewGuid())
                .First();

            album.Preco *= 0.5m;
            return album;
        }
    }
}