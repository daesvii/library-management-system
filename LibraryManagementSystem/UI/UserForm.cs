using LibraryManagementSystem.Model;
using LibraryManagementSystem.services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.ui
{
    public partial class UserForm : MaterialForm
    {
        private readonly ILoanService loanService;
        private readonly IBookService bookService;
        long userId;

        public UserForm(ILoanService loanService , IBookService bookService, long userId)
        {
            InitializeComponent();
            this.loanService = loanService;
            this.bookService = bookService;
            this.userId = userId;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey900,
                Primary.Grey500, Accent.Indigo700,
                TextShade.WHITE
            );

            titleSearchBox.Hint = "Buscar por titulo";
            authorSearchBox.Hint = "Buscar por autor";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchTitleBtn_Click(object sender, EventArgs e)
        {
            string searchTitle = titleSearchBox.Text;

            try
            {
                IEnumerable<Book> searchResults = bookService.SearchBooksByTitle(searchTitle);

                // Clear the ListView before adding new items
                bookListView.Items.Clear();

                if (searchResults.Any())
                {
                    foreach (Book book in searchResults)
                    {
                        // Create a ListViewItem with the book details
                        ListViewItem item = new ListViewItem(Convert.ToString(book.Id));
                        item.SubItems.Add(book.Title);
                        item.SubItems.Add(book.Author);
                        item.SubItems.Add(book.Category);
                        item.SubItems.Add(book.NumberOfCopies.ToString());
                        item.SubItems.Add(book.PublicationYear.ToString());

                        // Add the ListViewItem to the ListView
                        bookListView.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron libros con el título proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // load loand event
        private void loadLoansBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the list of loans associated with the user ID
                IEnumerable<Loan> userLoans = loanService.GetLoansByUserId(userId);

                // Clear the ListView before adding new items
                loansHistoryListView.Items.Clear();

                // Cycle through the loans and add each one to the ListView
                foreach (Loan loan in userLoans)
                {
                    // Create a ListView Item with the loan details
                    ListViewItem item = new ListViewItem(Convert.ToString(loan.UserIdentification));

                    item.SubItems.Add(loan.BookTitle);
                    item.SubItems.Add(loan.LoanDate.ToString());
                    item.SubItems.Add(loan.DueDate.ToString());

                    // Adds the ListView Item to the ListView
                    loansHistoryListView.Items.Add(item);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los préstamos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchAuthorBtn_Click(object sender, EventArgs e)
        {
            string searchAuthor = authorSearchBox.Text;

            try
            {
                IEnumerable<Book> searchResults = bookService.SearchBooksByAuthor(searchAuthor);

                // Clear the ListView before adding new items
                bookListView.Items.Clear();

                if (searchResults.Any())
                {
                    foreach (Book book in searchResults)
                    {
                        // Create a ListViewItem with the book details
                        ListViewItem item = new ListViewItem(Convert.ToString(book.Id));
                        item.SubItems.Add(book.Title);
                        item.SubItems.Add(book.Author);
                        item.SubItems.Add(book.Category);
                        item.SubItems.Add(book.NumberOfCopies.ToString());
                        item.SubItems.Add(book.PublicationYear.ToString());

                        // Add the ListViewItem to the ListView
                        bookListView.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron libros con el autor proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchCategoryBtn_Click(object sender, EventArgs e)
        {
            string searchCategory = categorySearchBox.Text;

            try
            {
                IEnumerable<Book> searchResults = bookService.SearchBooksByCategory(searchCategory);

                // Clear the ListView before adding new items
                bookListView.Items.Clear();

                if (searchResults.Any())
                {
                    foreach (Book book in searchResults)
                    {
                        // Create a ListViewItem with the book details
                        ListViewItem item = new ListViewItem(Convert.ToString(book.Id));
                        item.SubItems.Add(book.Title);
                        item.SubItems.Add(book.Author);
                        item.SubItems.Add(book.Category);
                        item.SubItems.Add(book.NumberOfCopies.ToString());
                        item.SubItems.Add(book.PublicationYear.ToString());

                        // Add the ListViewItem to the ListView
                        bookListView.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron libros con la categoría proporcionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
