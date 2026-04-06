using Sarasavi_Library_MS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasavi_Library_MS.Service
{
    public interface IReturnService
    {
        /// <summary>
        /// Processes return of a copy. Returns a result message (success or error).
        /// Also handles reservation notification if applicable.
        /// </summary>
        string ProcessReturn(string copyId);

        List<LoanDTO> GetReturnHistory();
    }
}
