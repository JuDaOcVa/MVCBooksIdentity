namespace Prj_JDOV_BooksIdentityCoreMVCApp.Models
{
    public class Libros
    {
        public string? Id { get; set; }
        public string? Isbn { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Temas { get; set; }
        public string? Editorial { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
