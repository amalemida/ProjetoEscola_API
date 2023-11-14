using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscola_API.Models
{
    public class Curso
    {
        public int id { get; set; }
        public int codigo { get; set; }
        public string? nome { get; set; }
        public string? periodo { get; set; }

    }
}