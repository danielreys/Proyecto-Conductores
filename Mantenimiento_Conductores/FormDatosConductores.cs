using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Conductores
{
    public partial class FormDatosConductores : Form
    {
        static bool Alta;  //bool que sirve para comprobar si venimos a una alta o a una modificacion
        conductor aux = new conductor(); // variable auxiliar para guardar los cambios realizados

        public FormDatosConductores() //alta
        {
            InitializeComponent();
            Alta = true;
        }
        public FormDatosConductores(conductor c) //modificacion
        {
            InitializeComponent();
            aux = c;    // copiamos el conductor seleccionado en nuestra variable
            textBoxDNI.ReadOnly = true;  // readOnly para no poder modificar el DNI porque es Primary Key  
        }
        private void FormDatosConductores_Load(object sender, EventArgs e)
        {
            if (!Alta)     // en el Load si no es una alta llenamos los datos del conductor y sus materiales correspondientes
            {
                rellenarInformacion();
                materialBindingSource.DataSource = aux.Material.ToList();
            }
        }
        private void rellenarInformacion()
        {
            textBoxDNI.Text = aux.dni;                  //Copiamos los datos a txtbox para poder enseñarlos por pantalla
            textBoxNombre.Text = aux.nombre;
            textBoxApellido.Text = aux.apellido;
            textBoxTipoCarnet.Text = aux.tipo_carnet;

            string fecha = aux.fecha_nac.ToString("dd-MM-yyyy");              //Pasamos la fecha a formato string dd-MM-yyyy
            DateTime dt = DateTime.ParseExact(fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture);         //luego Parse a fecha
            dateTimePickerFechaN.Value = dt;      // e igualamos al value del dataTimePicker para que aparezca así
        }


        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            if (Alta)                // Si es alta
            {
                conductor c = new conductor();
                c.dni = textBoxDNI.Text;                    //copiamos todos los datos
                c.nombre = textBoxNombre.Text;
                c.apellido = textBoxApellido.Text;
                c.tipo_carnet = textBoxTipoCarnet.Text;

                string f = dateTimePickerFechaN.Value.ToString("yyyy-MM-dd"); // en el caso de la fecha tenemos que volver a pasar de DateTime a string

                DateTime fecha = new DateTime();

                if (!DateTime.TryParse(f, out fecha))           //Aqui parseamos el string a DateTime (se hace dos conversiones porque el formato que ->
                    // lee la base de datos es yyyy-MM-dd aunque nosotros veamos dd-MM-yyyy.
                {
                    fecha = Convert.ToDateTime(f, System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat);
                }

                c.fecha_nac = fecha; //igualamos la fecha 
                string mensaje = BD.InsertConductor(c);  // insertamos en la base de datos
                mostrarMensaje(mensaje);  //mostramos mensaje recibido de la consulta LINQ
                Alta = false; // ponemos false para que si volvemos a entrar se reinicie
                this.Close();  // cerramos el form de la alta
            }


            else if (!Alta)  // si es modificacion
            {
                aux.dni = textBoxDNI.Text;           // copiamos los datos
                aux.nombre = textBoxNombre.Text;
                aux.apellido = textBoxApellido.Text;
                aux.tipo_carnet = textBoxTipoCarnet.Text;

                string f = dateTimePickerFechaN.Value.ToString("yyyy-MM-dd"); //pasamos a string 

                DateTime fecha = new DateTime();

                if (!DateTime.TryParse(f, out fecha))       // lo mismo de antes primero pasamos al formato de la BD y ahora lo ponemos en una variable dateTime
                {
                    fecha = Convert.ToDateTime(f, System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat);
                }

                aux.fecha_nac = fecha;


                string msg = BD.AcceptChanges(); // Al ser Linq al modificar unicamente le damos a acceptChanges sin tener que hacer una query update 
                mostrarMensaje(msg); //mostrar mensaje
                this.Close();  // cerrar form
            }
        }

        private void mostrarMensaje(string mensaje)  // Nos avisa si ha ido bien o no y cual es el mensaje recibido de error
        {
            if (mensaje == "")
            {
                MessageBox.Show("Correcto", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormMateriales fmateriales = new FormMateriales((Material)dataGridViewMaterial.SelectedRows[0].DataBoundItem, aux); // si hacemos ->
            //doble click entonces abrimos el material en el siguiente form
            fmateriales.ShowDialog();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterial.SelectedRows.Count > 0) // verifica que se haya seleccionado almenos una linea
            {
                DialogResult dialogResult = MessageBox.Show("Estas seguro que quieres eliminar este material?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) // si aceptas se borra dicho material (object) y se guardan los cambios en la BD
                {
                    BD.BorrarMaterial((Material)dataGridViewMaterial.SelectedRows[0].DataBoundItem);
                    BD.AcceptChanges();
                }
                else if (dialogResult == DialogResult.No) // sino no se borra nisiquiera
                {
                    MessageBox.Show("Eliminación cancelada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FormMateriales fm_nuevo = new FormMateriales(aux);  // abre otro form para  crear un material en un conductor (enviamos este)
            fm_nuevo.ShowDialog();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            materialBindingSource.DataSource = aux.Material.ToList();  // actualizamos la lista de materiales volviendo a acceder a los materiales del
            //conductor actual
        }
    }
}
