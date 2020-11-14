using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public partial class Principal : Form
    {
        public List<Persona> Listado { get; set; }

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NegocioUsuario Listar = new NegocioUsuario();
            Listado = Listar.ListarPersonas();
            dataGridView1.DataSource = Listado;
            //dataGridView1.DataBind();
        }
    }
}
