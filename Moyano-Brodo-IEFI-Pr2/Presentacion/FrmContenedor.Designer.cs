
namespace Presentacion
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.principal = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.Lateral = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.principal.SuspendLayout();
            this.Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // principal
            // 
            this.principal.BackColor = System.Drawing.SystemColors.Control;
            this.principal.Controls.Add(this.PanelContenedor);
            this.principal.Controls.Add(this.Lateral);
            this.principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principal.Location = new System.Drawing.Point(0, 0);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(944, 441);
            this.principal.TabIndex = 0;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.PanelContenedor.Location = new System.Drawing.Point(177, 6);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(764, 435);
            this.PanelContenedor.TabIndex = 2;
            // 
            // Lateral
            // 
            this.Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.Lateral.Controls.Add(this.btnProductos);
            this.Lateral.Controls.Add(this.btnCategorias);
            this.Lateral.Controls.Add(this.btnInicio);
            this.Lateral.Controls.Add(this.Logo);
            this.Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lateral.Location = new System.Drawing.Point(0, 0);
            this.Lateral.Name = "Lateral";
            this.Lateral.Size = new System.Drawing.Size(171, 441);
            this.Lateral.TabIndex = 1;
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductos.Location = new System.Drawing.Point(-3, 194);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(171, 48);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategorias.Location = new System.Drawing.Point(-3, 152);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(171, 48);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categoría";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Location = new System.Drawing.Point(-3, 109);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(171, 48);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = global::Presentacion.Properties.Resources.cart;
            this.Logo.Location = new System.Drawing.Point(3, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(165, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 441);
            this.Controls.Add(this.principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.principal.ResumeLayout(false);
            this.Lateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel principal;
        private System.Windows.Forms.Panel Lateral;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnInicio;
    }
}

