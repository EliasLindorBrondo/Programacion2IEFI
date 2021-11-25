using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();

		}
		//METODO PARA ABRIR FORMULARIOS EN EL PANEL CONTENEDOR
		private void AbrirFormularios<FormularioAbrir>() where FormularioAbrir : Form, new()
		{
			Form Formularios;

			Formularios = PanelContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();

			if (Formularios == null)
			{
				Formularios = new FormularioAbrir
				{
					TopLevel = false,
					Dock = DockStyle.Fill
				};

				PanelContenedor.Controls.Add(Formularios);

				PanelContenedor.Tag = Formularios;

				Formularios.Show();

				Formularios.BringToFront();
			}
			else
			{
				Formularios.BringToFront();
			}
		}

        private void btnCategorias_Click(object sender, EventArgs e)
        {
			AbrirFormularios<FrmCategorias>();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
			AbrirFormularios<FrmProductos>();
		}


    }

}

