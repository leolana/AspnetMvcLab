using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreDb : DbContext
    {
        public MusicStoreDb()
            : base("name=MusicStoreDb")
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artista> Artists { get; set; }
        public DbSet<Genero> Genres { get; set; }
    }
}