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
    public partial class FrmCategorias : Form
    {
        public Categoria objEntCategoria = new Categoria();
        public NegCategorias objNegCategorias = new NegCategorias();

        public FrmCategorias()
        {
            InitializeComponent();
            LlenarDGVCategoria();
        }
        #region Metodos
        //LLena el DataGridView con los datos
        private void LlenarDGVCategoria()
        {
           dgvCategorias.Rows.Clear();

            DataSet dds = new DataSet();

            dds = objNegCategorias.listadoCategorias("Todos");

            if (dds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow ddr in dds.Tables[0].Rows)
                {
                    //cambiar valor visible de Vigencia
                    if (ddr[3].ToString() == "S")
                    {
                        ddr[3] = "Vigente";
                    }
                    if (ddr[3].ToString() == "N")
                    {
                        ddr[3] = "No Vigente";
                    }
                    if (ddr[3].ToString() == "X")
                    {
                        ddr[3] = "No Aplica";
                    }
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc.
                    dgvCategorias.Rows.Add(ddr[0], ddr[1], ddr[2], ddr[3].ToString());

                }
            }
            else
               
                lblMensaje.Text = "No hay Categorias cargadas en el sistema";
        }
        //Prepara el objeto a enviar a la capa de Negocio
        private void TxtBox_a_Obj() 
        {
            objEntCategoria.Categoria = txtCategoria.Text;
            objEntCategoria.Marca = txtMarca.Text;
            objEntCategoria.Vigente = ValorVigencia();
        }
        //trae el objeto de la capa de negocios y lo envia al formulario
        private void Obj_a_Txt()
        {
            txtCategoria.Text = objEntCategoria.Categoria.ToString();
            txtMarca.Text = objEntCategoria.Marca.ToString();
            //Le da un valor al radiobutom segun lo indicado en el DGV
            if (dgvCategorias.CurrentRow.Cells[3].FormattedValue.Equals("No Aplica"))
            {
                rbNoVigente.Checked = false;
                rbVigente.Checked = false;
            }
            if (dgvCategorias.CurrentRow.Cells[3].FormattedValue.Equals("Vigente"))
            {
                rbVigente.Checked = true;
            }
            else
            {
                rbVigente.Checked = false;
            }
            if (dgvCategorias.CurrentRow.Cells[3].FormattedValue.Equals("No Vigente"))
            {
                rbNoVigente.Checked = true;
            }
            else
            {
                rbNoVigente.Checked = false;
            }
        }
        //Le da un valor a vigencia segun el radiobutom
        private char ValorVigencia()
        {
            char ValorVigencia = char.Parse("X");
            if (this.rbVigente.Checked)
            {
                ValorVigencia = char.Parse("S");
            }
            if (this.rbNoVigente.Checked)
            {
                ValorVigencia = char.Parse("N");
            }
            return ValorVigencia;
        }
        //trae el valor del DGV y lo envia al Capa de Entidad
        private void Dgv_a_Obj()
        {
            if (dgvCategorias.CurrentRow.Cells[0].Value.ToString() != string.Empty)
            {
                objEntCategoria.Id = Convert.ToInt32(dgvCategorias.CurrentRow.Cells[0].Value);
            }

            if (dgvCategorias.CurrentRow.Cells[1].Value.ToString() != string.Empty)
            {
                objEntCategoria.Categoria = Convert.ToString(dgvCategorias.CurrentRow.Cells[1].Value);
            }
            if (dgvCategorias.CurrentRow.Cells[2].Value.ToString() != string.Empty)
            {
                objEntCategoria.Marca = Convert.ToString(dgvCategorias.CurrentRow.Cells[2].Value);
            }
        }
        //Limpia el formulario
        private void Limpiar()
        {
            txtCategoria.Text = string.Empty;
            txtMarca.Text = string.Empty;
            rbNoVigente.Checked = false;
            rbVigente.Checked = false;
        }

        private void ValidaDatos(int Grabados)
        {
            switch (Validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(groupBoxA, "");
                        InfGrabar(Grabados);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(groupBoxA, "Deben estar completos todos los campos");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(groupBoxA, "La categoria debe ser ingresada solo con letras");
                        break;
                    }

            }

            int Validaciones()
            {
                if ((txtCategoria.Text == string.Empty) || (txtMarca.Text == string.Empty))
                {
                    return 1;
                }
                else
                {

                    if (!(txtCategoria.Text.All(Char.IsLetter)) )
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        private void InfGrabar(int Grabados)
        {
            switch (Grabados)
            {
                case 1:
                    {
                        int nGrabados = -1;
                        //llamo al método que carga los datos del objeto
                        TxtBox_a_Obj();
                        //invoco a la capa de negocio
                        nGrabados = objNegCategorias.ambCategorias("Agregar", objEntCategoria);
                        if (nGrabados == -1)
                            lblMensaje.Text = " No pudo grabar la Categoria en el sistema";
                        else
                        {
                            MessageBox.Show(" Se cargó la categoria " + objEntCategoria.Categoria + " con éxito.", "Aviso");
                            LlenarDGVCategoria();
                            Limpiar();
                        }
                        break;
                    }
                case 2:
                    {
                        int nResultado = -1;
                        TxtBox_a_Obj();
                        nResultado = objNegCategorias.ambCategorias("Modificar", objEntCategoria);
                        //invoco a la capa de negocio
                        if (nResultado != -1)
                        {
                            MessageBox.Show("La categoria " + objEntCategoria.Categoria + "  fue Modificada con éxito", "Aviso");                            
                            LlenarDGVCategoria();
                            Limpiar();
                        }
                        else
                            lblMensaje.Text = "Se produjo un error al intentar modificar la Categoria";
                        break;
                    }

                case 3:
                    {
                        int nEliminados = -1;
                        //llamo al método que carga los datos del objeto
                        TxtBox_a_Obj();
                        nEliminados = objNegCategorias.ambCategorias("Eliminar", objEntCategoria);
                        //invoco a la capa de negocio
                        if (nEliminados == -1)
                            lblMensaje.Text = " No pudo Eliminar la Categoria en el sistema";
                        else
                        {
                            MessageBox.Show(" Se eliminó la categoria " + objEntCategoria.Categoria + " con éxito.", "Aviso");                            
                            Limpiar();
                            LlenarDGVCategoria();
                        }
                        break;
                    }
            }
        }

        #endregion

        #region Eventos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int Grabados = 1;
            ValidaDatos(Grabados);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int Grabados = 2;
            ValidaDatos(Grabados);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int Grabados = 3;
            ValidaDatos(Grabados);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_a_Obj();
            Obj_a_Txt();
        }




        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
