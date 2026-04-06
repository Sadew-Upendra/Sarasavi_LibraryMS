using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DAO
{
    public interface IBookDAO
    {
        bool Save(Book book);
        Book FindById(string bookId);
        List<Book> FindAll();
        bool Update(Book book);
        bool Delete(string bookId);
        bool ExistsById(string bookId);
        string GetNextBookId(char classification);
    }
}
