using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.interfaces
{
    public interface ILoanRepository
    {
        IEnumerable<Loan> GetAll();
        Loan GetById(int id);
        void Add(Loan loan);
        void Delete(int id);

        IEnumerable<Loan> GetLoansByUserId(long id);
    }
}
