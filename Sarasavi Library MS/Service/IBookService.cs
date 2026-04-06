using Sarasavi_Library_MS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service
{
    public interface IBookService
    {
        bool RegisterBook(BookDTO dto, string[] copyTypes);
        BookDTO GetBookById(string bookId);
        List<BookDTO> GetAllBooks();
        bool UpdateBook(BookDTO dto);
        bool DeleteBook(string bookId);
        string GenerateNextBookId(char classification);
    }
}
