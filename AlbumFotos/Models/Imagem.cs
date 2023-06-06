using System.ComponentModel.DataAnnotations;

namespace AlbumFotos.Models
{
    public class Imagem
    {
        public int ImagemId { get; set; }

        public string Link { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
