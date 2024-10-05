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
    public partial class SignUp : MaterialForm
    {
        private readonly IUserService userService;

        public SignUp(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey900,       
                Primary.Grey500, Accent.Indigo700,      
                TextShade.WHITE                         
            );

            idBox.Hint = "Número de identificación";
            nameBox.Hint = "Nombre";
            addressBox.Hint = "Dirección";
            phoneBox.Hint = "Numero de teléfono";
            emailBox.Hint = "Correo electrónico";
            passwordBox.Hint = "Escribe una contraseña";
            passwordBox2.Hint = "Confirma tu contraseña";
        }



        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // Validate empty fields
            if (string.IsNullOrWhiteSpace(idBox.Text) ||
                string.IsNullOrWhiteSpace(nameBox.Text) ||
                string.IsNullOrWhiteSpace(ageSlider.Text) ||
                string.IsNullOrWhiteSpace(genreList.Text) ||
                string.IsNullOrWhiteSpace(addressBox.Text) ||
                string.IsNullOrWhiteSpace(phoneBox.Text) ||
                string.IsNullOrWhiteSpace(emailBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that the identification number is numeric
            if (!IsNumeric(idBox.Text))
            {
                MessageBox.Show("El número de identificación debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that the genre is a valid genre
            if (genreList.Text != "MASCULINO" && genreList.Text != "FEMENINO")
            {
                MessageBox.Show("El género no es válido", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that the name does not contain numbers
            if (ContainsNumbers(nameBox.Text))
            {
                MessageBox.Show("El nombre no puede contener caracteres numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that the phone number is numeric
            if (!IsNumeric(phoneBox.Text))
            {
                MessageBox.Show("El número de teléfono debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that the age is greater than or equal to 8
            if (ageSlider.Value <= 8)
            {
                MessageBox.Show("La edad debe ser igual o mayor a 8.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordBox.Text) || string.IsNullOrWhiteSpace(passwordBox2.Text) || passwordBox.Text != passwordBox2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden o no son válidas", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {
                Identification = long.Parse(idBox.Text),
                Password = passwordBox.Text,
                Tipo = 1, // Type 1 means normal user, type 2 means librarian
                Name = nameBox.Text,
                Age = ageSlider.Value,
                Gender = genreList.Text,
                Address = addressBox.Text,
                PhoneNumber = phoneBox.Text,
                Email = emailBox.Text,
            };

            // Call the method of service to add the new user
            bool addedUser = userService.AddUser(newUser);
            if (addedUser)
            {
                MessageBox.Show("Registro exitoso. Ahora puedes iniciar sesión.");
            }
            else
            {
                MessageBox.Show("Ya existe un usuario con la misma identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }

        // Helper method to check if a string contains only numeric characters
        private bool IsNumeric(string input)
        {
            return long.TryParse(input, out _);
        }

        // Helper method to check if a string contains any numeric characters
        private bool ContainsNumbers(string input)
        {
            return input.Any(char.IsDigit);
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eyePicture_Click(object sender, EventArgs e)
        {
            if (passwordBox.Password)
            {
                passwordBox.Hide();
                passwordBox.Password = false;
                eyePicture.Image = Properties.Resources.cerrado;
                passwordBox.Show();
            }
            else
            {
                passwordBox.Hide();
                passwordBox.Password = true;
                eyePicture.Image = Properties.Resources.vista;
                passwordBox.Show();
            }
        }

        private void eye2Picture_Click(object sender, EventArgs e)
        {
            if (passwordBox2.Password)
            {
                passwordBox2.Hide();
                passwordBox2.Password = false;
                eye2Picture.Image = Properties.Resources.cerrado;
                passwordBox2.Show();
            }
            else
            {
                passwordBox2.Hide();
                passwordBox2.Password = true;
                eye2Picture.Image = Properties.Resources.vista;
                passwordBox2.Show();
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
