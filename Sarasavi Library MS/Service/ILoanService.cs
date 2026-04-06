using Sarasavi_Library_MS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service
{
    public interface ILoanService
    {
        /// <summary>Verifies borrower and returns user info with active loan count.</summary>
        UserDTO VerifyBorrower(string userId);

        /// <summary>
        /// Issues a loan for a single copy. Returns null on success or an error message.
        /// </summary>
        string IssueLoan(string userId, string copyId);

        List<LoanDTO> GetActiveLoansByUser(string userId);
        List<LoanDTO> GetAllActiveLoans();
        List<LoanDTO> GetAllLoans();

        /// <summary>Gets summary stats for the dashboard.</summary>
        (int total, int active, int overdue) GetLoanStats();
    }
}
