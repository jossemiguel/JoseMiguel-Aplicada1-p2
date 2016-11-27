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
   public class TiposTelefonosBLL
    {
        private static List<TiposTelefonos> Lista;
        public static bool Guardar(TiposTelefonos telefono)
        {
            bool resultado = false;
            using (var db = new Parcial2Db())
            {
                try
                {
                    db.TipoTefefono.Add(telefono);
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

        public static TiposTelefonos Buscar(int TipoId)
        {
            var telefono = new TiposTelefonos();
            using (var db = new Parcial2Db())
            {
                try
                {
                    telefono = db.TipoTefefono.Find(TipoId);



                }
                catch (Exception)
                {

                    throw;
                }
                return telefono;
            }

        }

        public static void Eliminar(int TipoId)
        {
            var db = new Parcial2Db();

            TiposTelefonos telefono = Buscar(TipoId);
            db.Entry(telefono).State = EntityState.Deleted;
            db.SaveChanges();


        }

        public static void Modificar(TiposTelefonos telefono)
        {
            var db = new Parcial2Db();
            db.Entry(telefono).State = EntityState.Modified;
            db.SaveChanges();
            Lista = TiposTelefonosBLL.GetLista();
            Lista = GetLista();
        }

        public static List<TiposTelefonos> GetLista()
        {
            var lista = new List<TiposTelefonos>();
            using (var db = new Parcial2Db())
            {
                try
                {
                    lista = db.TipoTefefono.ToList();
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
