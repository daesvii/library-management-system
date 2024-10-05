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
    public partial class LibrarianForm : MaterialForm
    {
        private readonly IBookService bookService;
        private readonly IUserService userService;
        private readonly ILoanService loanService;

        public LibrarianForm(IBookService bookService, IUserService userService, ILoanService loanService)
        {
            InitializeComponent();
            this.bookService = bookService;
            this.userService = userService;
            this.loanService = loanService;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey900,
                Primary.Grey500, Accent.Indigo700,
                TextShade.WHITE
            );

            titleBox.Hint = "Título del libro";
            authorBox.Hint = "Autor del libro";
            yearBox.Hint = "Año de publicación";
            idBookBox.Hint = "ID del libro a prestar";
            idUserBox.Hint = "ID de la persona a la que se presta";
            idBox.Hint = "ID del libro a modificar";
            titleBookBox.Hint = "Nombre del libro corregido";
            copiesBookBox.Hint = "Nuevo número de copias";
            authorBookBox.Hint = "Nombre del autor corregido";
            titleSearchBox.Hint = "Buscar por titulo";
            authorSearchBox.Hint = "Buscar por autor";
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {

        }

        private void registerLoanBtn_Click(object sender, EventArgs e)
        {
            // Get the form data
            string idBookText = idBookBox.Text;
            string idUserText = idUserBox.Text;
            DateTime dueDate = dueDateBook.Value;

            // Validates that the fields are not empty
            if (string.IsNullOrWhiteSpace(idBookText) || string.IsNullOrWhiteSpace(idUserText))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that the IDs are valid
            if (!int.TryParse(idBookText, out int bookId) || !long.TryParse(idUserText, out long userId))
            {
                MessageBox.Show("Por favor, ingrese IDs de libro y usuario válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that the return date is greater than the current date
            if (dueDate <= DateTime.Now)
            {
                MessageBox.Show("La fecha de devolución debe ser posterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Use the service to add the loan
            try
            {
                Book bookFound = bookService.GetBookById(bookId);
                string nameBook = bookFound.Title;
                // Create a Loan object with the data provided
                // The loan date is taken from the real time in which the request is made.
                Loan newLoan = new Loan(nameBook, userId, DateTime.Now, dueDate);
                loanService.AddLoan(newLoan);
                MessageBox.Show("Préstamo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el préstamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // book registering event
        private void registerBookBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text) ||
                string.IsNullOrWhiteSpace(authorBox.Text) ||
                string.IsNullOrWhiteSpace(categoryBox.Text) ||
                string.IsNullOrWhiteSpace(yearBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (copiesSlide.Value <= 0)
            {
                MessageBox.Show("Ingrese un número válido de copias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(yearBox.Text, out int publicationYear) || publicationYear <= 0 || publicationYear > 2023)
            {
                MessageBox.Show("Ingrese un año de publicación válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (categoryBox.Text)
            {
                case "AVENTURAS":
                case "CIENCIA FICCIÓN":
                case "ROMANCE":
                case "FANTASÍA":
                case "NOVELA":
                case "CUENTO":
                    // The category is valid
                    break;
                default:
                    MessageBox.Show("La categoría no es válida", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            Book newBook = new Book
            {
                Title = titleBox.Text,
                Author = authorBox.Text,
                Category = categoryBox.Text,
                NumberOfCopies = copiesSlide.Value,
                PublicationYear = publicationYear
            };

            try
            {
                bookService.AddBook(newBook);
                MessageBox.Show("Registro de libro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // book update event
        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            // Check if a valid ID has been entered
            if (!int.TryParse(idBox.Text, out int selectedBookId) || selectedBookId <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID de libro válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the new workbook data from the controls
            string updatedTitle = titleBookBox.Text;
            string updatedAuthor = authorBookBox.Text;

            // Check if the copies text box is not empty and is convertible to integer
            if (!int.TryParse(copiesBookBox.Text, out int updatedNumberOfCopies) || updatedNumberOfCopies <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido de copias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the new data
            if (string.IsNullOrWhiteSpace(updatedTitle) ||
                string.IsNullOrWhiteSpace(updatedAuthor) ||
                updatedNumberOfCopies <= 0)
            {
                MessageBox.Show("Por favor, complete todos los campos con datos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the current workbook from the database using the given ID
            try
            {
                Book existingBook = bookService.GetBookById(selectedBookId);

                // Check if a book with the given ID was found
                if (existingBook == null)
                {
                    MessageBox.Show("No se encontró un libro con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update existing book data with new data
                existingBook.Title = updatedTitle;
                existingBook.Author = updatedAuthor;
                existingBook.NumberOfCopies = updatedNumberOfCopies;

                // Call service to update the book
                bookService.UpdateBook(existingBook);
                MessageBox.Show("Actualización de libro exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // event to search book by title
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


        // event to search book by author
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


        // event to search book by category
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

        private void loadLoansBtn_Click(object sender, EventArgs e)
        {

        }

        private void loadLoansBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the all list of loans
                IEnumerable<Loan> loans = loanService.GetAll();

                // Clear the ListView before adding new items
                loansHistoryListView.Items.Clear();

                // Cycle through the loans and add each one to the ListView
                foreach (Loan loan in loans)
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

        private void loadUsersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén la lista de todos los usuarios
                IEnumerable<User> allUsers = userService.GetAll();

                // Limpia el ListView antes de agregar nuevos elementos
                usersListView.Items.Clear();

                // Recorre la lista de usuarios y agrega cada uno al ListView
                foreach (User user in allUsers)
                {
                    // Crea un ListViewItem con los detalles del usuario
                    ListViewItem item = new ListViewItem(user.Identification.ToString());
                    item.SubItems.Add(user.Name);
                    item.SubItems.Add(user.Age.ToString());
                    item.SubItems.Add(user.Gender);
                    item.SubItems.Add(user.Address);
                    item.SubItems.Add(user.PhoneNumber);
                    item.SubItems.Add(user.Email);

                    // Agrega el ListViewItem al ListView
                    usersListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
