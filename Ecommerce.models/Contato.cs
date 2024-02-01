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
        public string? Telefone { get; set; }
        public string? Celular { get; set;}
        public Usuario? Usuario { get; set; }
    }
}
