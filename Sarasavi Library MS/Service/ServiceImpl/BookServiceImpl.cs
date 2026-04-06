using Sarasavi_Library_MS.DAO;
using Sarasavi_Library_MS.DAO.DAOImpl;
using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service.ServiceImpl
{
    public class BookServiceImpl : IBookService
    {
        private readonly IBookDAO _bookDAO = new BookDAOImpl();
        private readonly ICopyDAO _copyDAO = new CopyDAOImpl();

        public bool RegisterBook(BookDTO dto, string[] copyTypes)
        {
            if (copyTypes == null || copyTypes.Length == 0)
                throw new ArgumentException("At least one copy type is required.");
            if (copyTypes.Length > 10)
                throw new ArgumentException("Maximum 10 copies allowed per book.");

            var book = new Book
            {
                BookID = dto.BookID,
                Classification = dto.Classification[0],
                Title = dto.Title,
                Author = dto.Author,
                Publisher = dto.Publisher,
                ISBN = dto.ISBN
            };

            if (!_bookDAO.Save(book)) return false;

            for (int i = 0; i < copyTypes.Length; i++)
            {
                // CopyID = BookID + (i+1) as 1 digit (e.g. A00011, A00012 ...)
                string copyId = dto.BookID + (i + 1);
                var copy = new Copy
                {
                    CopyID = copyId,
                    BookID = dto.BookID,
                    CopyType = copyTypes[i],
                    Status = "Available"
                };
                _copyDAO.Save(copy);
            }
            return true;
        }

        public BookDTO GetBookById(string bookId)
        {
            var book = _bookDAO.FindById(bookId);
            if (book == null) return null;
            var copies = _copyDAO.FindByBookId(bookId);
            return ToDTO(book, copies);
        }

        public List<BookDTO> GetAllBooks()
        {
            var books = _bookDAO.FindAll();
            var result = new List<BookDTO>();
            foreach (var b in books)
            {
                var copies = _copyDAO.FindByBookId(b.BookID);
                result.Add(ToDTO(b, copies));
            }
            return result;
        }

        public bool UpdateBook(BookDTO dto)
        {
            var book = new Book
            {
                BookID = dto.BookID,
                Classification = dto.Classification[0],
                Title = dto.Title,
                Author = dto.Author,
                Publisher = dto.Publisher,
                ISBN = dto.ISBN
            };
            return _bookDAO.Update(book);
        }

        public bool DeleteBook(string bookId) => _bookDAO.Delete(bookId);

        public string GenerateNextBookId(char classification) =>
            _bookDAO.GetNextBookId(classification);

        private static BookDTO ToDTO(Book b, List<Copy> copies) => new BookDTO
        {
            BookID = b.BookID,
            Classification = b.Classification.ToString(),
            Title = b.Title,
            Author = b.Author,
            Publisher = b.Publisher,
            ISBN = b.ISBN,
            TotalCopies = copies.Count,
            AvailableCopies = copies.Count(c => c.Status == "Available" && c.CopyType == "Borrowable")
        };
    }
}
