using System.Collections.Generic;
using System.Linq;

namespace MvcMusicStore.Models
{
    public class MeusDados
    {
        public MeusDados()
        {
            Artistas = CarregarArtistas().ToList();
            Generos = CarregarGeneros().ToList();
            const string imgUrl = "~/Images/placeholder.png";

            Albuns = new[]
            {
                new Album
                {
                    Id = 1,
                    Title = "The Best Of The Men At Work",
                    Genre = Generos.Single(g => g.Nome == "Pop"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 1),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 2,
                    Title = "...And Justice For All",
                    Genre = Generos.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 1),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 3,
                    Title = "Black Light Syndrome",
                    Genre = Generos.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 1),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 4,
                    Title = "10,000 Days",
                    Genre = Generos.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 1),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 5,
                    Title = "11i",
                    Genre = Generos.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 1),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Title = "1960",
                    Genre = Generos.Single(g => g.Nome == "Indie"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 3),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 6,
                    Title = "4x4=12 ",
                    Genre = Generos.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 2),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 7,
                    Title = "A Copland Celebration, Vol. I",
                    Genre = Generos.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 4),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 8,
                    Title = "A Lively Mind",
                    Genre = Generos.Single(g => g.Nome == "Electronic"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 3),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 9,
                    Title = "A Matter of Life and Death",
                    Genre = Generos.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 6),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 10,
                    Title = "A Real Dead One",
                    Genre = Generos.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 5),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 11,
                    Title = "A Real Live One",
                    Genre = Generos.Single(g => g.Nome == "Metal"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 7),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 12,
                    Title = "A Rush of Blood to the Head",
                    Genre = Generos.Single(g => g.Nome == "Rock"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 8),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 13,
                    Title = "A Soprano Inspired",
                    Genre = Generos.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 9),
                    AlbumArtUrl = imgUrl
                },
                new Album
                {
                    Id = 14,
                    Title = "A Winter Symphony",
                    Genre = Generos.Single(g => g.Nome == "Classical"),
                    Price = 8.99M,
                    Artista = Artistas.Single(a => a.Id == 10),
                    AlbumArtUrl = imgUrl
                }
            }.ToList();
        }

        public IEnumerable<Album> Albuns { get; set; }
        public IEnumerable<Artista> Artistas { get; set; }
        public IEnumerable<Genero> Generos { get; set; }

        private IEnumerable<Artista> CarregarArtistas()
        {
            return new List<Artista>
            {
                new Artista {Id = 1, Nome = "65daysofstatic"},
                new Artista {Id = 2, Nome = "Aaron Goldberg"},
                new Artista {Id = 3, Nome = "Above & Beyond"},
                new Artista {Id = 4, Nome = "Above the Fold"},
                new Artista {Id = 5, Nome = "AC/DC"},
                new Artista {Id = 6, Nome = "Accept"},
                new Artista {Id = 7, Nome = "Adicts"},
                new Artista {Id = 8, Nome = "Adrian Leaper & Doreen de Feis"},
                new Artista {Id = 9, Nome = "Aerosmith"},
                new Artista {Id = 10, Nome = "Aisha Duo"}
            };
        }

        private IEnumerable<Genero> CarregarGeneros()
        {
            return new List<Genero>
            {
                new Genero {Id = 1, Nome = "Pop"},
                new Genero {Id = 2, Nome = "Rock"},
                new Genero {Id = 3, Nome = "Jazz"},
                new Genero {Id = 4, Nome = "Metal"},
                new Genero {Id = 5, Nome = "Electronic"},
                new Genero {Id = 6, Nome = "Blues"},
                new Genero {Id = 7, Nome = "Latin"},
                new Genero {Id = 8, Nome = "Rap"},
                new Genero {Id = 9, Nome = "Classical"},
                new Genero {Id = 10, Nome = "Alternative"},
                new Genero {Id = 11, Nome = "Country"},
                new Genero {Id = 12, Nome = "R&B"},
                new Genero {Id = 13, Nome = "Indie"},
                new Genero {Id = 14, Nome = "Punk"},
                new Genero {Id = 15, Nome = "World"}
            };
        }
    }
}