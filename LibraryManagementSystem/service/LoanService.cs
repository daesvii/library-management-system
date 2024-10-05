using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;

        public LoanService(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public void AddLoan(Loan loan)
        {
            _loanRepository.Add(loan);
        }


        public IEnumerable<Loan> GetLoansByUserId(long userId)
        {
            return _loanRepository.GetLoansByUserId(userId);
        }


        public IEnumerable<Loan> GetAll()
        {
            return _loanRepository.GetAll();
        }
    }
}
