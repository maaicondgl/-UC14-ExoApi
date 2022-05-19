namespace chapterFS.Models
{
    public class Livro
    {
        public int id { get; set; }

        public string? titulo { get; set; }

        public int? QuantidadePaginas { get; set; }

        public bool Disponivel { get; set; }
    }
}