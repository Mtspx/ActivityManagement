using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityManagement.Models
{
    public class Usuario
    {
        public Usuario(int id, string nome, int cargoId, string login, string senha)
        {
            Id = id;
            Nome = nome;
            CargoId = cargoId;
            Login = login;
            Senha = senha;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargoId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

    }
}