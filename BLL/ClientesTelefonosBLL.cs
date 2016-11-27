using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;
using System.Windows.Forms;

namespace BLL
{
   public class ClientesTelefonosBLL

    {
            public static List<ClientesTelefonos> GetLis(int Id)
            {
                var lista = new List<ClientesTelefonos>();
            using (var db=new Parcial2Db())
            {
                try
                {
                    lista = db.clienteTelefono.Where(t => t.Id == Id).ToList();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }
            }
                return lista;
            }
        }
}
