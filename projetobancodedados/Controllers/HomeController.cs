using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using projetobancodedados.Models;
using System.Diagnostics;

namespace projetobancodedados.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {   
            MySqlConnection connection = new MySqlConnection("server=localhost;database=db_vendas;uid=root;password=admin");
            connection.Open();
            MySqlCommand CountVendas = connection.CreateCommand();
            CountVendas.CommandText=$"Select count(1) total_tb_vendas from tb_vendas";
            MySqlDataReader dr1;
            dr1 = CountVendas.ExecuteReader();
            dr1.Read();
            int resulV = dr1.GetInt32(0);

            MySqlConnection connection1 = new MySqlConnection("server=localhost;database=db_vendas;uid=root;password=admin");
            connection1.Open();
            MySqlCommand CountUsuarios = connection1.CreateCommand();
            CountUsuarios.CommandText = $"Select count(1) total_tb_usuarios from tb_usuarios";
            MySqlDataReader dr2;
            dr2 = CountUsuarios.ExecuteReader();
            dr2.Read();
            int resulU = dr2.GetInt32(0);

            MySqlConnection connection2 = new MySqlConnection("server=localhost;database=db_vendas;uid=root;password=admin");
            connection2.Open();
            MySqlCommand CountClientes = connection2.CreateCommand();
            CountClientes.CommandText = $"Select count(1) total_tb_clientes from tb_clientes";
            MySqlDataReader dr3;
            dr3 = CountClientes.ExecuteReader();
            dr3.Read();
            int resulC = dr3.GetInt32(0);
            ViewBag.vendas = resulV;
            ViewBag.usuarios = resulU;
            ViewBag.clientes = resulC;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}