
namespace Presentacion
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gridArticulo = new System.Windows.Forms.DataGridView();
            this.btguardar = new System.Windows.Forms.Button();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.Datetime = new System.Windows.Forms.DateTimePicker();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.btmodi = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Articulo";
            // 
            // gridArticulo
            // 
            this.gridArticulo.AllowUserToAddRows = false;
            this.gridArticulo.AllowUserToDeleteRows = false;
            this.gridArticulo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticulo.Location = new System.Drawing.Point(12, 224);
            this.gridArticulo.Name = "gridArticulo";
            this.gridArticulo.ReadOnly = true;
            this.gridArticulo.Size = new System.Drawing.Size(621, 214);
            this.gridArticulo.TabIndex = 1;
            this.gridArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArticulo_CellContentClick);
            // 
            // btguardar
            // 
            this.btguardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btguardar.FlatAppearance.BorderSize = 0;
            this.btguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btguardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btguardar.Location = new System.Drawing.Point(607, 61);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(116, 40);
            this.btguardar.TabIndex = 2;
            this.btguardar.Text = "Agregar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click_1);
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(135, 64);
            this.txtcod.MaxLength = 3;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(65, 20);
            this.txtcod.TabIndex = 3;
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(135, 150);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(157, 21);
            this.comboCategoria.TabIndex = 4;
            // 
            // Datetime
            // 
            this.Datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datetime.Location = new System.Drawing.Point(415, 110);
            this.Datetime.Name = "Datetime";
            this.Datetime.Size = new System.Drawing.Size(121, 20);
            this.Datetime.TabIndex = 5;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(135, 107);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(157, 20);
            this.txtnom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(326, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(326, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de Vto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(30, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(30, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo Articulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(672, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Articulo";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(415, 63);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(121, 21);
            this.comboMarca.TabIndex = 13;
            // 
            // btmodi
            // 
            this.btmodi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmodi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btmodi.Location = new System.Drawing.Point(607, 107);
            this.btmodi.Name = "btmodi";
            this.btmodi.Size = new System.Drawing.Size(116, 39);
            this.btmodi.TabIndex = 14;
            this.btmodi.Text = "Modificar";
            this.btmodi.UseVisualStyleBackColor = true;
            this.btmodi.Click += new System.EventHandler(this.btmodi_Click_1);
            // 
            // btdelete
            // 
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdelete.Location = new System.Drawing.Point(607, 152);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(116, 40);
            this.btdelete.TabIndex = 15;
            this.btdelete.Text = "Eliminar";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(30, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Para crear una nueva Categoria o Marca Presione en Categoria.";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Presentacion.Properties.Resources.cart;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(639, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btmodi);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.Datetime);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.gridArticulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridArticulo;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.DateTimePicker Datetime;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Button btmodi;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}