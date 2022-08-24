using ChapterFST2.Contexts;
using ChapterFST2.Models;

namespace ChapterFST2.Repositories
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
