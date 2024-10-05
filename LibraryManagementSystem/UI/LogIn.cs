using LibraryManagementSystem.data;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.services;
using LibraryManagementSystem.ui;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LogIn : MaterialForm
    {
        private readonly IUserService userService;
        private readonly IBookService bookService;
        private readonly ILoanService loanService;
        private readonly ILibrarianService librarianService;

        public LogIn(IUserService userService, ILoanService loanService, IBookService bookService, ILibrarianService librarianService)
        {
            InitializeComponent();
            this.userService = userService;
            this.bookService = bookService;
            this.loanService = loanService;
            this.librarianService = librarianService;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey900,
                Primary.Grey500, Accent.Indigo700,
                TextShade.WHITE
            );

            idBox.Hint = "Número de identificación";
            passwordLogInBox.Hint = "Contraseña";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Enabled = true;
            this.Show();
        }

        private void eye2Picture_Click(object sender, EventArgs e)
        {
            if (passwordLogInBox.Password)
            {
                passwordLogInBox.Hide();
                passwordLogInBox.Password = false;
                eye2Picture.Image = Properties.Resources.cerrado;
                passwordLogInBox.Show();
            }
            else
            {
                passwordLogInBox.Hide();
                passwordLogInBox.Password = true;
                eye2Picture.Image = Properties.Resources.vista;
                passwordLogInBox.Show();
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            // Open the registration form
            SignUp signUpForm = new SignUp(userService);
            signUpForm.Show();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long userId = long.Parse(idBox.Text);
                string password = passwordLogInBox.Text;

                // Check if the username and password are valid
                bool isValidLogin = userService.login(userId, password);
                bool isValidLoginLibrarian = librarianService.login(userId, password);

                if (isValidLogin || isValidLoginLibrarian)
                {
                    // Password is correct, get the user
                    User loggedInUser = userService.GetById(userId);
                    Librarian loggedInLibrarian = librarianService.GetById(userId);
                    // Check the "tipo" field and open the corresponding form
                    if (loggedInUser != null )
                    {
                        if (loggedInUser.Tipo == 1 )
                        {
                            MessageBox.Show("Inicio de sesión exitoso.");
                            // Open the form UserForm
                            UserForm userForm = new UserForm(loanService, bookService, userId);
                            userForm.ShowDialog();
                        }
                    }
                    if (loggedInLibrarian != null)
                    {
                        if (loggedInLibrarian.Tipo == 2)
                        {
                            MessageBox.Show("Inicio de sesión exitoso.");
                            // Open the form LibrarianForm
                            LibrarianForm librarianForm = new LibrarianForm(bookService, userService, loanService);
                            librarianForm.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, verifica tus credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID de usuario no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
