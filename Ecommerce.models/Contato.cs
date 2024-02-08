using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.models
{
    public class Contato
    {
        public int ID { get; set; }
        public int UsuarioID  { get; set; }
        public string? Telefone { get; set; } = null!;
        public string? Celular { get; set; } = null!;
        public Usuario? Usuario { get; set; }
    }
}
