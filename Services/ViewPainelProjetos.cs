using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityManagement.Services
{
    public class ViewPainelProjetos
    {
        public ViewPainelProjetos(int id, string dataInicio, string previsao, string dataFim, string identificacaoDoProjeto, string responsavel, string status, string progresso, string localidade, string corProgresso)
        {
            Id = id;
            DataInicio = dataInicio;
            Previsao = previsao;
            DataFim = dataFim;
            IdentificacaoDoProjeto = identificacaoDoProjeto;
            Responsavel = responsavel;
            Status = status;
            Progresso = progresso;
            Localidade = localidade;
            CorProgresso = corProgresso;
        }
        public int Id { get; set; }
        public string DataInicio { get; set; }
        public string Previsao { get; set; }
        public string DataFim { get; set; }
        public string IdentificacaoDoProjeto { get; set; }
        public string Responsavel { get; set; }
        public string Status { get; set; }
        public string  Progresso { get; set; }
        public string Localidade { get; set; }
        public string CorProgresso { get; set; }
    }
}