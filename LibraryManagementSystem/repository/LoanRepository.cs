using LibraryManagementSystem.data;
using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.repository
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LibraryContext dbContext;

        public LoanRepository(LibraryContext context)
        {
            dbContext = context;
        }

        public IEnumerable<Loan> GetAll()
        {
            return dbContext.Loans.ToList();
        }

        public Loan GetById(int id)
        {
            return dbContext.Loans.Find(id);
        }

        public void Add(Loan loan)
        {
            dbContext.Loans.Add(loan);
            dbContext.SaveChanges();
        }


        public IEnumerable<Loan> GetLoansByUserId(long userId)
        {
            return dbContext.Loans.Where(loan => loan.UserIdentification == userId).ToList();
        }

        public void Delete(int id)
        {
            var loanToDelete = dbContext.Loans.Find(id);

            if (loanToDelete != null)
            {
                // Delete the loan from the database
                dbContext.Loans.Remove(loanToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
