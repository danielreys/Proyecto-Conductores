namespace Mantenimiento_Conductores
{
    partial class FormMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateriales));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaEnt = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaDev = new System.Windows.Forms.DateTimePicker();
            this.labelDevolucion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de entrega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha devolución";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(206, 46);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(272, 24);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesc.Location = new System.Drawing.Point(206, 88);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(272, 24);
            this.textBoxDesc.TabIndex = 5;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(317, 268);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(161, 27);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar y Guardar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // dateTimePickerFechaEnt
            // 
            this.dateTimePickerFechaEnt.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFechaEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaEnt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaEnt.Location = new System.Drawing.Point(206, 128);
            this.dateTimePickerFechaEnt.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFechaEnt.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaEnt.Name = "dateTimePickerFechaEnt";
            this.dateTimePickerFechaEnt.Size = new System.Drawing.Size(272, 24);
            this.dateTimePickerFechaEnt.TabIndex = 18;
            this.dateTimePickerFechaEnt.Value = new System.DateTime(2018, 9, 30, 0, 0, 0, 0);
            // 
            // dateTimePickerFechaDev
            // 
            this.dateTimePickerFechaDev.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFechaDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaDev.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaDev.Location = new System.Drawing.Point(206, 171);
            this.dateTimePickerFechaDev.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFechaDev.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaDev.Name = "dateTimePickerFechaDev";
            this.dateTimePickerFechaDev.Size = new System.Drawing.Size(272, 24);
            this.dateTimePickerFechaDev.TabIndex = 19;
            this.dateTimePickerFechaDev.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // labelDevolucion
            // 
            this.labelDevolucion.AutoSize = true;
            this.labelDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDevolucion.Location = new System.Drawing.Point(34, 219);
            this.labelDevolucion.Name = "labelDevolucion";
            this.labelDevolucion.Size = new System.Drawing.Size(444, 18);
            this.labelDevolucion.TabIndex = 20;
            this.labelDevolucion.Text = "No hay fecha para devolución ,  puede seleccionar una ↑  ";
            // 
            // FormMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Mantenimiento_Conductores.Properties.Resources.fondo_pantalla;
            this.ClientSize = new System.Drawing.Size(556, 326);
            this.Controls.Add(this.labelDevolucion);
            this.Controls.Add(this.dateTimePickerFechaDev);
            this.Controls.Add(this.dateTimePickerFechaEnt);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material";
            this.Load += new System.EventHandler(this.FormMateriales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEnt;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDev;
        private System.Windows.Forms.Label labelDevolucion;
    }
}