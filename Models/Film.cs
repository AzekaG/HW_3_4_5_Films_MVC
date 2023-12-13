using System.ComponentModel;

namespace HW_3_4_5_Films_MVC.Models
{
    public class Film
    {
        public int id { get; set; }
        [DisplayName("Имя")]
        public string? Name { get; set; }
        [DisplayName("Описание")]
        public string? Description { get; set; }
        [DisplayName("Жанр")]
        public string? Jenre { get; set; }
        [DisplayName("Год")]
        public int Year { get; set; }
        [DisplayName("Режисер")]
        public string? Producer { get; set; }
        [DisplayName("Постер")]
        public string? Poster { get; set; }
    }
}
