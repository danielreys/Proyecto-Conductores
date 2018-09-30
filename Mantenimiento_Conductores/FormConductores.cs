using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Conductores
{
    // NOTA: Los Tipos de carnet se sobreentiende que con la inicial se saben o se pueden consultar en otro sitio. Y que se deben hacer botones y advertencias para que
    // su uso sea más fácil para que cualquier usuario sea capaz de usarlo
    public partial class FormConductores : Form
    {
        public FormConductores()
        {
            InitializeComponent();

        }
        private void FormConductores_Load(object sender, EventArgs e)
        {
            bindingSourceConductores.DataSource = BD.TodosConductores(""); //filtro vacio para mostrar todas al empezar
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            bindingSourceConductores.DataSource = BD.TodosConductores(textBoxBuscar.Text); //buscar con lo que se ha escrito
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormDatosConductores fdc = new FormDatosConductores((conductor)dataGridViewConductores.SelectedRows[0].DataBoundItem); //Pasamos el objeto de 
            //conductores que queremos ver
            fdc.ShowDialog(); //mostramos la pantalla siguiente
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bindingSourceConductores.DataSource = BD.TodosConductores(textBoxBuscar.Text);  //buscar con el enter tambien
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FormDatosConductores fd = new FormDatosConductores();  // crear nuevo conductor
            fd.Show();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            bindingSourceConductores.DataSource = BD.TodosConductores(""); //actualizamos recargando el datasource del binding con un filtro vacio
        }
    }
}
