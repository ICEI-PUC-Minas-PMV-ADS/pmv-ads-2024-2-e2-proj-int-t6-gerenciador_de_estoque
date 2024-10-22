using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using StockUp.Models;
using System.Diagnostics;

namespace StockUp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public string UserName { get; set; }
        public string UserType { get; set; }
        public string UserEmail { get; set; }
        public string PublicVariable { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UserName = HttpContext.Session.GetString("UserName");
            UserType = HttpContext.Session.GetString("UserType");
            UserEmail = HttpContext.Session.GetString("UserEmail");

            // Check if user is logged in
            if (UserEmail == null)
            {
                // Redirect to login page if not authenticated
                return View("Login");
            }


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "Hello from ViewBag!";

            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            // Logic to handle form submission
            // You can process the "name" value and add more logic here.
            //ViewBag.Message = $"Hello, {Email}";

            if (AuthenticateUser(Email, Password))
            {

                //ViewData["ErrorMessage"] = "No input yet";
                // Redirect to another page after successful login
                return RedirectToAction(nameof(Index));
            }
            else
            {
                // Show error message if login fails
                ViewData["Message"] = "Invalid username or password";
                return View();
            }

            return View(); // Return the view after processing the POST request
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
                    HttpContext.Session.SetString("UserName", reader["Nome"].ToString());
                    HttpContext.Session.SetString("UserId", reader["Id"].ToString());
                    HttpContext.Session.SetString("UserEmail", reader["Email"].ToString());

                    return true;
                }
            }
            return false;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
