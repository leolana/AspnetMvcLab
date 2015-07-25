using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StorageManagerController : Controller
    {
        private readonly MusicStoreDb _storeContext = new MusicStoreDb();
        // GET: StorageManager
        public ActionResult Index()
        {
            var albums = _storeContext.Albums.Include(a => a.Artista).Include(a => a.Genero);
            return View(albums.ToList());
        }

        // GET: StorageManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var album = _storeContext.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // GET: StorageManager/Create
        public ActionResult Create()
        {
            ViewBag.ArtistId = new SelectList(_storeContext.Artists, "ArtistId", "Name");
            ViewBag.GenreId = new SelectList(_storeContext.Genres, "GenreId", "Name");
            return View();
        }

        // POST: StorageManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Album album)
        {
            if (ModelState.IsValid)
            {
                _storeContext.Albums.Add(album);
                _storeContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArtistId = new SelectList(_storeContext.Artists, "ArtistId", "Name", album.ArtistaId);
            ViewBag.GenreId = new SelectList(_storeContext.Genres, "GenreId", "Name", album.GeneroId);
            return View(album);
        }

        // GET: StorageManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var album = _storeContext.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtistId = new SelectList(_storeContext.Artists, "ArtistId", "Name", album.ArtistaId);
            ViewBag.GenreId = new SelectList(_storeContext.Genres, "GenreId", "Name", album.GeneroId);
            return View(album);
        }

        // POST: StorageManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Album album)
        {
            if (ModelState.IsValid)
            {
                _storeContext.Entry(album).State = EntityState.Modified;
                _storeContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArtistId = new SelectList(_storeContext.Artists, "ArtistId", "Name", album.ArtistaId);
            ViewBag.GenreId = new SelectList(_storeContext.Genres, "GenreId", "Name", album.GeneroId);
            return View(album);
        }

        // GET: StorageManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var album = _storeContext.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // POST: StorageManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var album = _storeContext.Albums.Find(id);
            _storeContext.Albums.Remove(album);
            _storeContext.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _storeContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}