using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;


namespace JoseMiguel_Aplicada1_p2
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parcial2DbDataSet.TiposTelefonos' table. You can move, or remove it, as needed.
            this.tiposTelefonosTableAdapter.Fill(this.parcial2DbDataSet.TiposTelefonos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();

            ClientesBLL.Guardar(clientes);
            LlenarClase();

        }

        private ClientesTelefonos LlenarClase()
        {
           ClientesTelefonos clientes = new ClientesTelefonos();
            Clientes cl = new Clientes();
            TiposTelefonos t = new TiposTelefonos();



            clientes.ClienteId =Convert.ToInt32(idtxt.Text);
            cl.Nombres = nombretxt.Text;
            cl.FechaNacimiento = fechatxt.Value;
            clientes.TipoId = Convert.ToInt32(tipotxt.Text);
            t.Descripcion = telefonotxt.Text;
            return clientes;

        }
    }
}
