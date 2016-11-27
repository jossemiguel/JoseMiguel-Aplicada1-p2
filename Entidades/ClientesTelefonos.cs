using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class ClientesTelefonos
    {

        [Key]
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public int TipoId { get; set; }
    }
}
