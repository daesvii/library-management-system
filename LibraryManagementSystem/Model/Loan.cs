using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Loan
    {
        // Configure Id as primary key and autoincremental
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Attributes
        string bookTitle;
        long userIdentification;
        DateTime loanDate;
        DateTime dueDate;

        // Getters and Setters
        public DateTime LoanDate { get => loanDate; set => loanDate = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public long UserIdentification { get => userIdentification; set => userIdentification = value; }


        // Constructor
        public Loan() { }

        public Loan(string bookTitle, long userIdentification, DateTime loanDate, DateTime dueDate)
        {
            this.bookTitle = bookTitle;
            this.userIdentification = userIdentification;
            this.loanDate = loanDate;
            this.dueDate = dueDate;
        }
    }
}
