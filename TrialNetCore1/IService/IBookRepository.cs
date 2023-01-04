using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialNetCore1.Models;

namespace TrialNetCore1.IService
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
    }
}
