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
using Negocio;

namespace Negocio
{
    public partial class Principal : Form
    {
        public List<Usuario> Listado { get; set; }

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NegocioUsuario Listar = new NegocioUsuario();
            Listado = Listar.ListarUsuarios();
            dataGridView1.DataSource = Listado;
            //dataGridView1.DataBind();
        }
    }
}
