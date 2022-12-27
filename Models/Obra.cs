using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string IdentificacaoDoProjeto { get; set; }
        public string ChefeDaObra { get; set; }
        public int Status { get; set; }
        public string UF { get; set; }
        public string Municipio { get; set; }
        public int Progresso { get; set; } = 0; 
    }
}