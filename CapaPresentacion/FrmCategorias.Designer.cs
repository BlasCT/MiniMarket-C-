namespace CapaPresentacion
{
    partial class FrmCategorias
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
            this.tbPrincipal = new System.Windows.Forms.TabControl();
            this.tbListado = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.codigo_ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarListado = new System.Windows.Forms.Button();
            this.txtBuscarListado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMantenimiento = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbPrincipal.SuspendLayout();
            this.tbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tbMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.tbListado);
            this.tbPrincipal.Controls.Add(this.tbMantenimiento);
            this.tbPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.SelectedIndex = 0;
            this.tbPrincipal.Size = new System.Drawing.Size(740, 260);
            this.tbPrincipal.TabIndex = 0;
            // 
            // tbListado
            // 
            this.tbListado.Controls.Add(this.dgvData);
            this.tbListado.Controls.Add(this.btnBuscarListado);
            this.tbListado.Controls.Add(this.txtBuscarListado);
            this.tbListado.Controls.Add(this.label2);
            this.tbListado.Location = new System.Drawing.Point(4, 22);
            this.tbListado.Name = "tbListado";
            this.tbListado.Padding = new System.Windows.Forms.Padding(3);
            this.tbListado.Size = new System.Drawing.Size(732, 234);
            this.tbListado.TabIndex = 0;
            this.tbListado.Text = "Listado";
            this.tbListado.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_ca,
            this.descripcion_ca,
            this.estado});
            this.dgvData.Location = new System.Drawing.Point(53, 48);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(527, 124);
            this.dgvData.TabIndex = 7;
            // 
            // codigo_ca
            // 
            this.codigo_ca.HeaderText = "Codigo";
            this.codigo_ca.Name = "codigo_ca";
            this.codigo_ca.ReadOnly = true;
            // 
            // descripcion_ca
            // 
            this.descripcion_ca.HeaderText = "Descripcion";
            this.descripcion_ca.Name = "descripcion_ca";
            this.descripcion_ca.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // btnBuscarListado
            // 
            this.btnBuscarListado.Location = new System.Drawing.Point(299, 22);
            this.btnBuscarListado.Name = "btnBuscarListado";
            this.btnBuscarListado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarListado.TabIndex = 6;
            this.btnBuscarListado.Text = "Buscar";
            this.btnBuscarListado.UseVisualStyleBackColor = true;
            // 
            // txtBuscarListado
            // 
            this.txtBuscarListado.Location = new System.Drawing.Point(92, 22);
            this.txtBuscarListado.Name = "txtBuscarListado";
            this.txtBuscarListado.Size = new System.Drawing.Size(201, 20);
            this.txtBuscarListado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar:";
            // 
            // tbMantenimiento
            // 
            this.tbMantenimiento.Controls.Add(this.btnGuardar);
            this.tbMantenimiento.Controls.Add(this.btnCancelar);
            this.tbMantenimiento.Controls.Add(this.txtCategoria);
            this.tbMantenimiento.Controls.Add(this.label1);
            this.tbMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tbMantenimiento.Name = "tbMantenimiento";
            this.tbMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tbMantenimiento.Size = new System.Drawing.Size(732, 234);
            this.tbMantenimiento.TabIndex = 1;
            this.tbMantenimiento.Text = "Mantenimiento";
            this.tbMantenimiento.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(207, 54);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(126, 54);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(81, 17);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(201, 20);
            this.txtCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(16, 289);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 38);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(97, 289);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 38);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(178, 289);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 38);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(259, 289);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 38);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(340, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.tbPrincipal);
            this.Name = "FrmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.tbPrincipal.ResumeLayout(false);
            this.tbListado.ResumeLayout(false);
            this.tbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tbMantenimiento.ResumeLayout(false);
            this.tbMantenimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbPrincipal;
        private System.Windows.Forms.TabPage tbListado;
        private System.Windows.Forms.TabPage tbMantenimiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnBuscarListado;
        private System.Windows.Forms.TextBox txtBuscarListado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}