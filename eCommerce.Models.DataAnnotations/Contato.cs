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
        public string? Telefone { get; set; } = null!;
        public string? Celular { get; set; } = null!;
        /*A propriedade UsuarioID é uma chave estrangeira
         * Irá gerar uma coluna relacionada a tabela Usuario
         * Pela convenção é a chave prioritária
         * [ForeignKey("UsuarioID")] - Define a chave estrangeira
         */
        public int UsuarioID  { get; set; }
        /*A propriedade Usuario é uma propriedade de navegação
         *Pode ser usada para gerar uma coluna relacionada a tabela Usuario no lugar de UsuarioId
         * [ForeignKey("UsuarioId")] - Define a chave estrangeira
         */
        public Usuario? Usuario { get; set; }
        /*A terceira forma de relacionar as tabelas é utilizando a propriedade da classe Usuario
         * Utilizando a notação [foreingKey("UsuarioId")]
         */

    }
}
