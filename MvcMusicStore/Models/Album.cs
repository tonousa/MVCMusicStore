using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcMusicStore.Infrastructure;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public virtual int AlbumId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual int ArtistId { get; set; }
        [Required(ErrorMessage ="Required")]
        [MaxWords(2)]
        public virtual string Title { get; set; }
        [Required(ErrorMessage ="Price is required")]
        [Range(0.01, 100.00, ErrorMessage ="out of range")]
        public virtual decimal Price { get; set; }
        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
    }
}