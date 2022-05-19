using chapterFS.Contexts;
using chapterFS.Models;

namespace chapterFS.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;
        public LivroRepository(ChapterContext context)
        {
           _context = context;
        }
        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

    }
}
