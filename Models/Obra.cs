using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityManagement.Models
{
    public class Obra
    {
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Previsao { get; set; }
        public DateTime Termino { get; set; }
        public string ResponsavelGeral { get; set; }
        public string ChefeDaObra { get; set; }
        public string Status { get; set; }
        public string UF { get; set; }
        public string Municipio { get; set; }
    }
}