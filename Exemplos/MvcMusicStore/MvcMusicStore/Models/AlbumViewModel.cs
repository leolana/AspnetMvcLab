using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class AlbumViewModel
    {
        public int AlbumId { get; set; }
        public IEnumerable<int> GeneroIds { get; set; }
        public IEnumerable<SelectListItem> Generos { get; set; }
        public int ArtistaId { get; set; }
        public IEnumerable<SelectListItem> Artistas { get; set; }

        [StringLength(160)]
        [DataType(DataType.MultilineText)]
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        [UIHint("Thumbnail")]
        public string AlbumArtUrl { get; set; }

        public DayOfWeek DiaSemana { get; set; }
    }
}