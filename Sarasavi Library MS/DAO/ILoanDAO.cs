using Sarasavi_Library_MS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.DAO
{
    public interface ILoanDAO
    {
        bool Save(Loan loan);
        Loan FindById(int loanId);
        List<Loan> FindByUserId(string userId);
        List<Loan> FindActiveLoansByCopyId(string copyId);
        List<Loan> FindAllActive();
        List<Loan> FindAll();
        bool UpdateStatus(int loanId, string status, System.DateTime? returnDate);
        int CountActiveByUserId(string userId);
        bool IsOverdue(int loanId);
    }
}
