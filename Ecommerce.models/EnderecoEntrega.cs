using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.models
{
    public class EnderecoEntrega
    {
        public int Id { get; set; }
        public int UsuarioID { get; set; }
        public string? NomeEndereco { get; set; } = null!;//apelido do usuário para o endereco, casa, trabalho etc
        public string? CEP { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; } = null!;
        public string? Complemento { get; set; } = null!;
        public Usuario? Usuario { get; set;}

    }
}
