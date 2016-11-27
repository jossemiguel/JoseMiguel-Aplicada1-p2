using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        public string Nombres{ get; set; }

        public DateTime  FechaNacimiento { get; set; }

        public float LimiteCredito { get; set; }

        public List<TiposTelefonos> Telefono { get; set; }

        public Clientes()
        {
            this.Telefono = new List<TiposTelefonos>();

        }

        public Clientes (int ClienteId, string Nombres)
        {
            this.ClienteId = ClienteId;
            this.Nombres = Nombres;
            this.Telefono = new List<TiposTelefonos>();
        }
    }
}
