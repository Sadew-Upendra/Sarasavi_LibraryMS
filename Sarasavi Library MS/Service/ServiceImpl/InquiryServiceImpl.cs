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
    public class InquiryServiceImpl : IInquiryService
    {
        private readonly IBookDAO _bookDAO = new BookDAOImpl();
        private readonly ICopyDAO _copyDAO = new CopyDAOImpl();

        public List<InquiryResultDTO> SearchBooks(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return new List<InquiryResultDTO>();

            var results = new List<InquiryResultDTO>();
            var allBooks = _bookDAO.FindAll();

            string term = searchTerm.Trim().ToLower();

            foreach (var book in allBooks)
            {
                bool match = book.BookID.ToLower().Contains(term)
                          || book.Title.ToLower().Contains(term)
                          || book.Author.ToLower().Contains(term);
                if (match)
                    results.Add(BuildResult(book));
            }
            return results;
        }

        public InquiryResultDTO GetBookAvailability(string bookId)
        {
            var book = _bookDAO.FindById(bookId);
            return book == null ? null : BuildResult(book);
        }

        private InquiryResultDTO BuildResult(Book book)
        {
            var copies = _copyDAO.FindByBookId(book.BookID);
            int total = copies.Count;
            int reference = copies.Count(c => c.CopyType == "Reference");
            int available = copies.Count(c => c.Status == "Available" && c.CopyType == "Borrowable");
            int loaned = copies.Count(c => c.Status == "Loaned");
            int reserved = copies.Count(c => c.Status == "Reserved");

            string availability;
            if (reference == total)
                availability = "Reference Only — cannot be borrowed";
            else if (available == 0 && loaned > 0)
                availability = "All copies currently on loan";
            else if (available > 0)
                availability = $"{available} of {total - reference} borrowable cop{(available == 1 ? "y" : "ies")} available";
            else
                availability = "No copies available";

            return new InquiryResultDTO
            {
                BookID = book.BookID,
                Title = book.Title,
                Author = book.Author,
                Publisher = book.Publisher,
                ISBN = book.ISBN,
                TotalCopies = total,
                AvailableCopies = available,
                LoanedCopies = loaned,
                ReferenceCopies = reference,
                ReservedCopies = reserved,
                AvailabilityStatus = availability
            };
        }
    }
}
