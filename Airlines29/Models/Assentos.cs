using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines29.Models
{
    public class Assentos
    {
        public int Id { get; set; }
        public List<string> AssentosExistentesA { get; set; }
        public List<string> AssentosExistentesB { get; set; }
        public List<string> AssentosComprados { get; set; }
    }
}
