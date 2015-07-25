using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public virtual int Id { get; set; }
        public virtual int GeneroId { get; set; }
        public virtual int ArtistaId { get; set; }
        public virtual string Titulo { get; set; }
        public virtual decimal Preco { get; set; }

        [DataType(DataType.ImageUrl)]
        [DisplayName("Album Art URL")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual Artista Artista { get; set; }
    }
}