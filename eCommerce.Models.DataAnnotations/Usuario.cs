using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.models
{        /*Usando o padrão de Annotations para definir as propriedades da classe
         *Podemos utilizar as seguintes annotations:
         *Schema: Define o nome do esquema no banco de dados
         *[Table("NomeDaTabela")] - Define o nome da tabela no banco de dados
         *[Column("NomeDaColuna")] - Define o nome da coluna no banco de dados
         *[NotMapped] - Define que a propriedade não gera coluna no banco de dados
         *[ForeignKey("NomeDaChaveEstrangeira")] - Define a chave estrangeira
         *[InverseProperty("NomeDaPropriedade")] - Define a propriedade inversa
         *[databaseGenerated(DatabaseGeneratedOption.Identity)] - Define que a propriedade será gerada pelo banco de dados
         *DataAnnotations:
         *[Key] - Define a chave primária
         *EF Core:
         *[Index] - Define um índice no banco (Unique)
         */
    [Index(nameof(Email), IsUnique = true, Name = "IX_EMAIL_UNICO")]
    [Index(nameof(Nome), nameof(CPF))]
    [Table("TB_USUARIOS")]
    public class Usuario
    {
        #region DadosUsuario
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Genero { get; set;}
        [Column("CIN")]
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;
        #endregion

        #region DadosComplementares
        public string? NomeMae { get; set;}
        public string? NomePai { get; set;}
        public string? SituacaoCadastro { get; set;}
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Matricula { get; set;}
        public DateTimeOffset DataCadastro { get; set;}
        #endregion

        #region RelacionamentoUsuario
        [ForeignKey("UsuarioId")]
        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega>? EnderecosEntregas { get; set; }
        public ICollection<Departamento>? Departamentos { get; set; }
        #endregion

        #region RelacionamentoPedido
        [InverseProperty("Cliente")]
        public ICollection<Pedido>? PedidosCliente { get; set; }
        [InverseProperty("Colaborador")]
        public ICollection<Pedido>? PedidosColaborador { get; set; }
        [InverseProperty("Supervisor")]
        public ICollection<Pedido>? PedidosSupervisor { get; set; }
        #endregion
    }
}
