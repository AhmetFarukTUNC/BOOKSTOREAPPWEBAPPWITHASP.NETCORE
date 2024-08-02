using Entities.Models;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IBookRepository :IRepositoryBase<Book>
    {
        
        Book GetOneBookById(int id,bool trackChanges);

        IQueryable<Book> GetAllBooks(bool trackChanges);

        void CreateOneBook(Book book);

        void UpdateOneBook(Book book);

        void DeleteOneBook(Book book);

    }
}
