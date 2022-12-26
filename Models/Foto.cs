using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityManagement.Models
{
    public class Foto
    {
        public int Id { get; set; }
        public Image Imagem { get; set; }
        public int ProjetoId { get; set; }
    }
}