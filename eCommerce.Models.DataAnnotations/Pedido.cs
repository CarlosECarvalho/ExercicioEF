using Ecommerce.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.models
{ 
    public class Pedido
    {
        public int Id { get; set; }
        
        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        public Usuario? Cliente { get; set; }
        
        [ForeignKey("ColaboradorId")]
        public int ColaboradorId { get; set; }
        public Usuario? Colaborador { get; set; }
        
        [ForeignKey("SupervidorId")]
        public int SupervidorId { get; set; }
        public Usuario? Supervisor { get; set; }
    }
}
