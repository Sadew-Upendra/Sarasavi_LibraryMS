using Sarasavi_Library_MS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service
{
    public interface IInquiryService
    {
        List<InquiryResultDTO> SearchBooks(string searchTerm);
        InquiryResultDTO GetBookAvailability(string bookId);
    }
}
