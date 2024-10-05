using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.services
{
    public interface ILoanService
    {
        void AddLoan(Loan loan);
        IEnumerable<Loan> GetLoansByUserId(long id);
        IEnumerable<Loan> GetAll();
    }
}
