using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagementSystem.Model
{
    public class Book
    {
        // Configure Id as primary key and autoincremental
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Attributes
        string title;
        string author;
        string category;
        int numberOfCopies;
        int publicationYear;

        // Getters and Setters
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Category { get => category; set => category = value; }
        public int NumberOfCopies { get => numberOfCopies; set => numberOfCopies = value; }
        public int PublicationYear { get => publicationYear; set => publicationYear = value; }

        public Book() { }

        // Constructor
        public Book(string title, string author, string category, int numberOfCopies, int publicationYear)
        {
            this.title = title;
            this.author = author;
            this.category = category;
            this.numberOfCopies = numberOfCopies;
            this.publicationYear = publicationYear;
        }
    }
}
