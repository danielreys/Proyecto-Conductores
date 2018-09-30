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
    public partial class FormMateriales : Form
    {
        static bool alta;   //sirve para saber si es una alta o no
        Material aux_material = new Material(); //auxiliar para material 
        conductor cond = new conductor();       // el conductor al cual se le modificara un material o añadira uno

        public FormMateriales(conductor condu) //ALTA
        {
            InitializeComponent();
            labelDevolucion.Visible = false;   // No es visible cuando es una alta ya que el aviso la primera vez no tiene porque aparecer
            alta = true;  // es una alta por tanto true
            cond = condu;   // copiamos el conductor pasado por parámetro en nuestra variable 
        }
        public FormMateriales(Material material, conductor condu) //MODIFICACIÓN
        {
            InitializeComponent();
            aux_material = material; //copiamos el material a nuestra variable
            cond = condu;            // copiamos el conductor a nuestra variable
            if (!material.fecha_devolucion.HasValue)  // Si la fecha de devolución no tiene un value , pues sale el aviso de que se puede añadir una fecha.
            {
                labelDevolucion.Visible = true;
            }
        }

        private void FormMateriales_Load(object sender, EventArgs e)
        {
            if (!alta)  // Si no es una alta , llamamos al metodo para rellenar la información
            {
                rellenarInformacion();
                labelDevolucion.Visible = false;
            }
        }
        private void rellenarInformacion() // en este metodo llenamos con los datos proporcionados por el material que hemos seleccionado 
        {
            textBoxNombre.Text = aux_material.nombre;
            textBoxDesc.Text = aux_material.descripcion;

            string fecha_ent = aux_material.fecha_entrega.ToString("dd-MM-yyyy"); // Una vez mas tenemos que recuperar el valor en un string para luego poner-
            // lo en el value (debe ser DateTime , por eso hacemos el Parse)
            DateTime dt = DateTime.ParseExact(fecha_ent, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            dateTimePickerFechaEnt.Value = dt;

            if (aux_material.fecha_devolucion.HasValue)    // comprobamos que no es null la fecha de devolución 
            {
                string fecha_dev = aux_material.fecha_devolucion.Value.ToString("dd-MM-yyyy"); // si no lo es , contiene una fecha y realizamos el parse igual que antes
                DateTime dt2 = DateTime.ParseExact(fecha_dev, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                dateTimePickerFechaDev.Value = dt2;
            }
            else
            {
                labelDevolucion.Visible = true;  // si esta null es que no hay fecha y mostramos que tenemos la opcion de poner una fecha devolución.
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int ano_selecionado = dateTimePickerFechaEnt.Value.Year; // recogemos el año seleccionado
            if (textBoxNombre.Text.Length > 0 && textBoxDesc.Text.Length > 0 && ano_selecionado > 1990) //almenos los campos essenciales llenos y un año razonable (pueden haber registros antiguos)
            {
                if (!alta) // si es modificacion
                {
                    aux_material.nombre = textBoxNombre.Text;
                    aux_material.descripcion = textBoxDesc.Text;

                    // pasar a string con el formato para guardar en la BD 
                    string f = dateTimePickerFechaEnt.Value.ToString("yyyy-MM-dd");

                    DateTime fecha_e = new DateTime();

                    // parsear a dateTime
                    if (!DateTime.TryParse(f, out fecha_e))
                    {
                        fecha_e = Convert.ToDateTime(f, System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat);
                    }

                    //guardarlo en la variable material
                    aux_material.fecha_entrega = fecha_e;
                    // como no siempre hay fecha de devolucion y por defecto es 1990 comprobamos que sea más actual (suponiendo que ese año se fundo la empresa)
                    if (dateTimePickerFechaDev.Value.Year > 2000)
                    {
                        string d = dateTimePickerFechaDev.Value.ToString("yyyy-MM-dd");  // mismo apso que antes 

                        DateTime fecha_dev = new DateTime();

                        if (!DateTime.TryParse(d, out fecha_dev))
                        {
                            fecha_dev = Convert.ToDateTime(d, System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat);
                        }

                        aux_material.fecha_devolucion = fecha_dev;
                    }
                    string msg = BD.AcceptChanges(); // guardamos cambios
                    mostrarMensaje(msg); // mostramos el resultado
                    this.Close(); // cerramos el form
                }
                else //Alta 
                {
                    Material m = new Material(); // nuevo material
                    m.nombre = textBoxNombre.Text;
                    m.descripcion = textBoxDesc.Text;  //copiamos lo introducido
                    m.conductor_dni = cond.dni;          // asignamos el material al dni del conductor actualmente seleccionado
                    DateTime fecha_entrega = new DateTime();

                    if (!DateTime.TryParse(dateTimePickerFechaEnt.Value.ToString(), out fecha_entrega)) // parseamos el valor que esta puesto en el datePicker
                    {
                        fecha_entrega = Convert.ToDateTime(dateTimePickerFechaEnt.Value.ToString(), System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat);
                    }
                    m.fecha_entrega = fecha_entrega; // Y ponemos la fecha


                    DateTime fecha_dev = new DateTime();

                    if (dateTimePickerFechaDev.Value >= DateTime.Now.Date) //comprobamos que el año de la devolucion es igual al actual o superior 
                        // no tiene mucho sentido crear uno nuevo y poner que la devolución sería en el pasado
                    {
                        if (!DateTime.TryParse(dateTimePickerFechaDev.Value.ToString(), out fecha_dev))
                        {
                            fecha_dev = Convert.ToDateTime(dateTimePickerFechaDev.Value.ToString(), System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat);
                        }
                        m.fecha_devolucion = fecha_dev;
                    }
                    else
                    {
                        m.fecha_devolucion = null; // si no hay una fecha superior esta la por defecto y por ello null
                    }

                    cond.Material.Add(m); //metemos dentro del conductor el material con los cambios
                    string mensaje = BD.AcceptChanges(); //guardamos en la bd cambios
                    mostrarMensaje(mensaje); //mostramos mensaje del resultado
                    alta = false;
                    this.Close();  // cerramos el forms

                }

            }
        }
        private void mostrarMensaje(string mensaje) // Metodo para mostrar el resultado de operaciones
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


    }
}
