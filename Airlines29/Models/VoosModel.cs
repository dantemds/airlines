using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines29.Models
{
    public class VoosModel
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Horario { get; set; }
        public double Preco { get; set; }

    }
}
