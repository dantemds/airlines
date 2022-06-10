using Airlines29.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines29.Controllers
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
            return View();
        }
        public List<VoosModel> BuscarTodosVoo()
        {
            List<VoosModel> voos = new List<VoosModel>();
            VoosModel voos1 = new VoosModel();
            VoosModel voos2 = new VoosModel();
            voos1.Id = 1;
            voos1.Destino = "São Paulo";
            voos1.Origem = "Rio de Janeiro";
            voos1.Preco = 350;
            voos1.Horario = "14h00";
            voos2.Id = 2;
            voos2.Destino = "São Paulo";
            voos2.Origem = "Rio Grande do Sul";
            voos2.Preco = 500;
            voos2.Horario = "16h00";
            voos.Add(voos1);
            voos.Add(voos2);
            return voos;
        }
        public IActionResult Voos()
        {


            var result = BuscarTodosVoo();

            return View(result);
        }

        
        public IActionResult ComprarPoltronas(int id, List<string> poltronas)
        {
            switch (id)
            {
                case 1:
                    foreach (var poltrona in poltronas)
                    {
                        Program.poltronasCompradas1.Add(poltrona);
                    };
                    
                    break;
                case 2:
                    foreach (var poltrona in poltronas)
                    {
                        Program.poltronasCompradas2.Add(poltrona);
                    };
                    break;
                case 3:
                    foreach (var poltrona in poltronas)
                    {
                        Program.poltronasCompradas3.Add(poltrona);
                    };
                    break;
            }

            return Ok(true);
        }

        public Assentos BuscarAssentosPorId(int id)
        {
            Assentos assentos = new Assentos();
            assentos.AssentosExistentesA = Program.poltronasExistentesA;
            assentos.AssentosExistentesB = Program.poltronasExistentesB;
            assentos.Id = id;
            switch (id)
            {
                case 1:
                    assentos.AssentosComprados = Program.poltronasCompradas1;
                    break;
                case 2:
                    assentos.AssentosComprados = Program.poltronasCompradas2;
                    break;
                case 3:
                    assentos.AssentosComprados = Program.poltronasCompradas3;
                    break;
            }

            return assentos;


        }

        public IActionResult Assentos(int id)
        {
            var result = BuscarAssentosPorId(id);


            return View(result);

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
