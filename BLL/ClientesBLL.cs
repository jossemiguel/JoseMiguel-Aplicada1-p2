using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;
using System.Data.Entity;
using System.Windows.Forms;

namespace BLL
{
     public class ClientesBLL
    {
        private static List<Clientes> Lista;
        public static bool Guardar (Clientes clientes)
        {
            bool resultado = false;
            using (var db = new Parcial2Db())
            {
                try
                {
                    db.Cliente.Add(clientes);
                    db.SaveChanges();
                    resultado = true;


                }
                catch (Exception)
                {

                    throw;
                }

                return resultado;
            }
        }

        public static Clientes Buscar (int ClienteId)
        {
            var cliente =new Clientes();
            using (var db = new Parcial2Db())
            {
                try
                {
                    cliente= db.Cliente.Find(ClienteId);



                }
                catch (Exception)
                {

                    throw;
                }
                return cliente;
            }
            
        }

        public static void Eliminar(int clienteId)
        {
            var db = new Parcial2Db();

            Clientes cliente = Buscar(clienteId);
            db.Entry(cliente).State = EntityState.Deleted;
            db.SaveChanges();


        }

        public static void Modificar(Clientes cliente)
        {
            var db = new Parcial2Db();
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
            Lista = ClientesBLL.GetLista();
            Lista = GetLista();
        }

        public static List<Clientes> GetLista()
        {
            var lista = new List<Clientes>();
            using (var db = new Parcial2Db())
            {
                try
                {
                    lista = db.Cliente.ToList();
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
