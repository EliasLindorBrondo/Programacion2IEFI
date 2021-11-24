using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class FrmProductos : Form
    {
        NegArticulo objNegArt = new NegArticulo();
        Articulo objEntArt = new Articulo();
        public FrmProductos()
        {
            InitializeComponent();
            gridArticulo.ColumnCount = 6;
            gridArticulo.Columns[0].HeaderText = "Codigo";
            gridArticulo.Columns[1].HeaderText = "Nombre";
            gridArticulo.Columns[2].HeaderText = "Categoria";
            gridArticulo.Columns[3].HeaderText = "Marca";
            gridArticulo.Columns[4].HeaderText = "Fecha de Vto";

            gridArticulo.Columns[0].Width = 100;
            gridArticulo.Columns[1].Width = 100;
            gridArticulo.Columns[3].Width = 150;
            CompletarDG();
            btmodi.Enabled = false;
            btdelete.Enabled = false;
        }

        private void CompletarDG()
        {
            gridArticulo.Rows.Clear();


            DataSet ds = new DataSet();
            ds = objNegArt.ListadoArt("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                 gridArticulo.Rows.Add(dr[0], dr[1], dr[2], dr[3],Convert.ToDateTime(dr[4]).ToShortDateString());
                }


            }
            else
            {
                MessageBox.Show("No hay Articulos cargados en el sistema.");
            }


        }


        private void txtBox_a_Obj()
        {
            try
            {
                objEntArt.CodArt = txtcod.Text;
                objEntArt.Nombre = txtnom.Text;
                objEntArt.Categoria = comboCategoria.Text;
                objEntArt.Marca = comboMarca.Text;
                objEntArt.FechaVto = Convert.ToDateTime(Datetime.Value.ToShortDateString());
            }
            catch (Exception)
            {

                MessageBox.Show("Tiene que completar todos los campos");
            }

        }

        private void Limpiar()
        {
            txtcod.Text = string.Empty;
            txtnom.Text = string.Empty;
            comboCategoria.SelectedIndex = -1;
            comboMarca.SelectedIndex = -1;
        }

        private void dgAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntArt.Nombre = Convert.ToString(gridArticulo.CurrentRow.Cells[0].Value);
            ds = objNegArt.ListadoArt(objEntArt.Nombre);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DstxtBox(ds);
                btguardar.Visible = false;

            }

        }

        private void DstxtBox(DataSet ds)
        {

            txtcod.Text = ds.Tables[0].Rows[0]["Codigo"].ToString();
            txtnom.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            comboCategoria.Text = ds.Tables[0].Rows[0]["Categoria"].ToString();
            comboMarca.Text = ds.Tables[0].Rows[0]["Marca"].ToString();
            Datetime.Text = ds.Tables[0].Rows[0]["Fecha de Vto"].ToString();

            txtcod.Enabled = false;
        }

        private void borrar()
        {
            objEntArt.CodArt = txtcod.Text;
        }


        private void btguardar_Click_1(object sender, EventArgs e)
        {
            if (txtcod.Text == "" ||
          txtnom.Text == "" ||
          comboCategoria.Text == "" ||
          comboMarca.Text == "")
            {
                MessageBox.Show("Los espacios no pueden estar en blanco");
            }
            else
            {
                int nguardados = -1;
                txtBox_a_Obj();

                nguardados = objNegArt.abmarticulo("Alta", objEntArt);

                if (nguardados == -1)
                {
                    MessageBox.Show("No se pudo agregar al articulo en el registro");
                }
                else
                {
                    MessageBox.Show($"Se agrego al articulo {objEntArt.Nombre} con exito.");
                    CompletarDG();
                    Limpiar();
                }
            }
        }

        private void btmodi_Click_1(object sender, EventArgs e)
        {
            if (txtcod.Text == "" ||
          txtnom.Text == "" ||
          comboCategoria.Text == "" ||
          comboMarca.Text == "")
            {
                MessageBox.Show("Los espacios no pueden estar en blanco");
            }
            else
            {
                int nresultado = -1;
                txtBox_a_Obj();

                nresultado = objNegArt.abmarticulo("Modificar", objEntArt);// invoco la capa negocio

                if (nresultado == -1)
                {
                    MessageBox.Show("No se pudo modificar el articulo.");

                }
                else
                {
                    MessageBox.Show($"El Articulo de codigo {objEntArt.CodArt} fue modificado con exito.");
                    Limpiar();
                    CompletarDG();
                    txtcod.Enabled = true;
                    btguardar.Enabled = true;
                    btmodi.Enabled = false;
                    btdelete.Enabled = false;
                }
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (txtcod.Text == "" ||
            txtnom.Text == "" ||
            comboCategoria.Text == "" ||
            comboMarca.Text == "")
            {
                MessageBox.Show("Los espacios no pueden estar en blanco");
            }
            else
            {
                int nresultado = -1;
                borrar();

                nresultado = objNegArt.abmarticulo("Borrar", objEntArt);// invoco la capa negocio

                if (nresultado == -1)
                {
                    MessageBox.Show("No se pudo borrar el Alumno.");

                }
                else
                {
                    MessageBox.Show($"El Alumno {objEntArt.Nombre} de codigo {objEntArt.CodArt} fue borrado exitosamente.");
                    Limpiar();
                    CompletarDG();
                    txtcod.Enabled = true;
                    btguardar.Enabled = true;
                    btmodi.Enabled = false;
                    btdelete.Enabled = false;
                }
            }
        }

        private void gridArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcod.Text = gridArticulo.CurrentRow.Cells[0].Value.ToString();
            txtnom.Text = gridArticulo.CurrentRow.Cells[1].Value.ToString();
            comboCategoria.Text = gridArticulo.CurrentRow.Cells[2].Value.ToString();
            comboMarca.Text = gridArticulo.CurrentRow.Cells[3].Value.ToString();
            Datetime.Text = gridArticulo.CurrentRow.Cells[4].Value.ToString();
            txtcod.Enabled = false;
            btguardar.Enabled = false;
            btmodi.Enabled = true;
            btdelete.Enabled = true;
        }
    }

   

  
}
