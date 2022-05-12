using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    public class ReviewCreacionDTO
    {
        public string Coemntario { get; set; }
        [Range(1, 5)]
        public int Puntuacion { get; set; }

    }
}
