using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class TiposTelefonos
    {

        [Key]
        public int TipoId { get; set; }

        public string Descripcion { get; set; }

        public List<Clientes> cliente{ get; set; }

        public TiposTelefonos()
        {
            this.cliente = new List<Clientes>();
        }

        public TiposTelefonos(int tipoId, string Descripcion)
        {
            this.TipoId = tipoId;
            this.Descripcion = Descripcion;
            this.cliente = new List<Clientes>();
        }

    }
}
