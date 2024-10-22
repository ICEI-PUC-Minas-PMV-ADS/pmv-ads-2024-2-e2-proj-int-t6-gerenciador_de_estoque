using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace StockUp.Views.Home
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string ErrorMessage { get; set; }

        public string PublicVariable { get; set; }

        public void OnGet()
        {
            PublicVariable = null;
        }
        [ValidateAntiForgeryToken]
        public IActionResult OnPost()
        {
            // This will be called when the form is submitted via POST
            return RedirectToPage("/Home/Privacy");
        }

        public IActionResult OnPostAction()
        {
            
            
            if (AuthenticateUser(Email, Password))
            {
                ViewData["Message"] = "Hello from ViewBag!";
                //ViewData["ErrorMessage"] = "No input yet";
                // Redirect to another page after successful login
                return RedirectToPage("Index");
            }
            else
            {
                // Show error message if login fails
                ViewData["Message"] = "Hello from ViewBag!";
                return RedirectToPage("/Home/Privacy");
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=stockup;Trusted_Connection=True;MultipleActiveResultSets=true";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.Usuarios WHERE Email = @Email AND Senha = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    // Store user data in session
                    HttpContext.Session.SetString("UserName", reader["Name"].ToString());
                    HttpContext.Session.SetString("UserId", reader["Id"].ToString());
                    HttpContext.Session.SetString("UserEmail", reader["Email"].ToString());

                    return true;
                }
            }
            return false;
        }

    }
}
