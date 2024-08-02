using Repositories.Contracts;
using Repositories.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManger
    {

        private readonly RepositoryContext _context;

        private readonly Lazy<IBookRepository> _bookRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;

            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(context));
        }

        public IBookRepository Book => new BookRepository(_context);    

        public void Save()
        {
            _context.SaveChanges();
        }
        
    }
}
