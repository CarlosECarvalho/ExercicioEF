using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Genero { get; set;}
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set;}
        public string? SituacaoCadastro { get; set;}
        public DateTimeOffset DataCadastro { get; set;}
        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega>? EnderecosEntregas { get; set; }
        public ICollection<Departamento>? Departamentos { get; set; }
    }
}
