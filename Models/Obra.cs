using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityManagement.Models
{
    public class Obra
    {
        public Obra(int obraId, DateTime inicio, DateTime previsao, DateTime termino, string responsavelGeral, string chefeDaObra, string status, string uF, string municipio)
        {
            ObraId = obraId;
            Inicio = inicio;
            Previsao = previsao;
            Termino = termino;
            ResponsavelGeral = responsavelGeral;
            ChefeDaObra = chefeDaObra;
            Status = status;
            UF = uF;
            Municipio = municipio;
        }

        public int ObraId { get; set; }
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