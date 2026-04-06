using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DAO
{
    public interface ICopyDAO
    {
        bool Save(Copy copy);
        Copy FindById(string copyId);
        List<Copy> FindByBookId(string bookId);
        List<Copy> FindAll();
        bool UpdateStatus(string copyId, string status);
        bool Delete(string copyId);
        int CountByBookId(string bookId);
    }
}
