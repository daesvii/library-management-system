using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class User : Person
    {
        // Attributes
        long identification;
        string password;
        int tipo;
        List<Loan> loanHistory;

        // Getters and Setters
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Identification { get => identification; set => identification = value; }
        public List<Loan> LoanHistory { get => loanHistory; set => loanHistory = value; }
        public string Password { get => password; set => password = value; }
        public int Tipo { get => tipo; set => tipo = value; }


        // Constructor
        public User() { }

        public User(long identification, string password, int tipo,string name, int age, string gender, string address, string phoneNumber, string email)
            : base(name, age, gender, address, phoneNumber, email)
        {
            Identification = identification;
            Password = password;
            Tipo = tipo;
        }
    }
}
