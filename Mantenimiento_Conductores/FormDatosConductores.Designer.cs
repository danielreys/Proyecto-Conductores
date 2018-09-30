namespace Mantenimiento_Conductores
{
    partial class FormDatosConductores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosConductores));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewMaterial = new System.Windows.Forms.DataGridView();
            this.buttonGrabar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTipoCarnet = new System.Windows.Forms.TextBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaN = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idmaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conductordniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conductorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(171, 58);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(243, 24);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(171, 110);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(243, 24);
            this.textBoxApellido.TabIndex = 4;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(640, 58);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(243, 24);
            this.textBoxDNI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(489, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Nac.";
            // 
            // dataGridViewMaterial
            // 
            this.dataGridViewMaterial.AllowUserToAddRows = false;
            this.dataGridViewMaterial.AllowUserToDeleteRows = false;
            this.dataGridViewMaterial.AutoGenerateColumns = false;
            this.dataGridViewMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaterial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMaterial.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmaterialDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaentregaDataGridViewTextBoxColumn,
            this.fechadevolucionDataGridViewTextBoxColumn,
            this.conductordniDataGridViewTextBoxColumn,
            this.conductorDataGridViewTextBoxColumn});
            this.dataGridViewMaterial.DataSource = this.materialBindingSource;
            this.dataGridViewMaterial.Location = new System.Drawing.Point(47, 277);
            this.dataGridViewMaterial.MultiSelect = false;
            this.dataGridViewMaterial.Name = "dataGridViewMaterial";
            this.dataGridViewMaterial.ReadOnly = true;
            this.dataGridViewMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterial.Size = new System.Drawing.Size(869, 291);
            this.dataGridViewMaterial.TabIndex = 8;
            this.dataGridViewMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterial_CellDoubleClick);
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrabar.Location = new System.Drawing.Point(642, 186);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(131, 23);
            this.buttonGrabar.TabIndex = 12;
            this.buttonGrabar.Text = "Grabar Datos Conductor";
            this.buttonGrabar.UseVisualStyleBackColor = true;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo de Carnet (el de mayor nivel)";
            // 
            // textBoxTipoCarnet
            // 
            this.textBoxTipoCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipoCarnet.Location = new System.Drawing.Point(489, 149);
            this.textBoxTipoCarnet.Name = "textBoxTipoCarnet";
            this.textBoxTipoCarnet.Size = new System.Drawing.Size(44, 24);
            this.textBoxTipoCarnet.TabIndex = 14;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(799, 585);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(98, 23);
            this.buttonNuevo.TabIndex = 10;
            this.buttonNuevo.Text = "Nuevo Material";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(663, 585);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(110, 23);
            this.buttonBorrar.TabIndex = 9;
            this.buttonBorrar.Text = "Borrar Material";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(535, 585);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 16;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // dateTimePickerFechaN
            // 
            this.dateTimePickerFechaN.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFechaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaN.Location = new System.Drawing.Point(640, 110);
            this.dateTimePickerFechaN.MaxDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFechaN.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaN.Name = "dateTimePickerFechaN";
            this.dateTimePickerFechaN.Size = new System.Drawing.Size(243, 24);
            this.dateTimePickerFechaN.TabIndex = 17;
            this.dateTimePickerFechaN.Value = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Datos Conductor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Materiales";
            // 
            // idmaterialDataGridViewTextBoxColumn
            // 
            this.idmaterialDataGridViewTextBoxColumn.DataPropertyName = "id_material";
            this.idmaterialDataGridViewTextBoxColumn.HeaderText = "id_material";
            this.idmaterialDataGridViewTextBoxColumn.Name = "idmaterialDataGridViewTextBoxColumn";
            this.idmaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmaterialDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaentregaDataGridViewTextBoxColumn
            // 
            this.fechaentregaDataGridViewTextBoxColumn.DataPropertyName = "fecha_entrega";
            this.fechaentregaDataGridViewTextBoxColumn.HeaderText = "fecha_entrega";
            this.fechaentregaDataGridViewTextBoxColumn.Name = "fechaentregaDataGridViewTextBoxColumn";
            this.fechaentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadevolucionDataGridViewTextBoxColumn
            // 
            this.fechadevolucionDataGridViewTextBoxColumn.DataPropertyName = "fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.HeaderText = "fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.Name = "fechadevolucionDataGridViewTextBoxColumn";
            this.fechadevolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conductordniDataGridViewTextBoxColumn
            // 
            this.conductordniDataGridViewTextBoxColumn.DataPropertyName = "conductor_dni";
            this.conductordniDataGridViewTextBoxColumn.HeaderText = "conductor_dni";
            this.conductordniDataGridViewTextBoxColumn.Name = "conductordniDataGridViewTextBoxColumn";
            this.conductordniDataGridViewTextBoxColumn.ReadOnly = true;
            this.conductordniDataGridViewTextBoxColumn.Visible = false;
            // 
            // conductorDataGridViewTextBoxColumn
            // 
            this.conductorDataGridViewTextBoxColumn.DataPropertyName = "conductor";
            this.conductorDataGridViewTextBoxColumn.HeaderText = "conductor";
            this.conductorDataGridViewTextBoxColumn.Name = "conductorDataGridViewTextBoxColumn";
            this.conductorDataGridViewTextBoxColumn.ReadOnly = true;
            this.conductorDataGridViewTextBoxColumn.Visible = false;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Mantenimiento_Conductores.Material);
            // 
            // FormDatosConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Mantenimiento_Conductores.Properties.Resources.fondo_pantalla;
            this.ClientSize = new System.Drawing.Size(1005, 632);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerFechaN);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBoxTipoCarnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.dataGridViewMaterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDatosConductores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDatosConductores";
            this.Load += new System.EventHandler(this.FormDatosConductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewMaterial;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTipoCarnet;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conductordniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conductorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}