using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FichaAnimal : Form
    {
        private bool ingDatos1 = false;
        private bool ingDatos2 = false;
        private bool ingDatos3 = false;
        //private bool btn_agreg_activo = false;

        //private Zoologico zoologico = Form1.zoologico;

        public FichaAnimal(bool verAnimal)
        {
            InitializeComponent();
            desactivarBtn();

            if (verAnimal)
            {
                dataGrid_ambos.DataSource = Zoologico.getListaAnimal();
            }
            else dataGrid_ambos.DataSource = Zoologico.getListaCuidador();

            
        }

        private void btn_FichaAnim_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_animal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void actualizarGrid()
        {
            dataGrid_ambos.DataSource = null;
            dataGrid_ambos.DataSource = Zoologico.getListaAnimal();
        }

        private bool activarBtn()
        {
            if (ingDatos1 && ingDatos2 && ingDatos3)
            {
                btn_agregar.Enabled = true;
                //btn_agregar.Focus();
                return true;
            }
            return false;
        }
        private void desactivarBtn()
        {
            if ( !activarBtn() )
            {
                btn_agregar.Enabled = false;
            }
            //if (dataGrid_ambos.SelectedRows.Count > 0)
            //{
            //    int indiceFilaSeleccionada = dataGrid_ambos.SelectedRows[0].Index;

            //    // Accede a los valores de las celdas de la fila seleccionada
            //    string valorCelda1 = dataGrid_ambos.Rows[indiceFilaSeleccionada].Cells["nombre"].Value.ToString();
            //    string valorCelda2 = dataGrid_ambos.Rows[indiceFilaSeleccionada].Cells["especie"].Value.ToString();

            //    // Puedes hacer lo que quieras con los valores de las celdas
            //    // Por ejemplo, mostrarlos en MessageBox
            //    MessageBox.Show($"Valor de la celda 1: {valorCelda1}\nValor de la celda 2: {valorCelda2}");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zoologico.getListaAnimal().Add(new Animal(box_nomb_Anim.Text, box_esp_Anim.Text, box_comi_Anim.Text));
            actualizarGrid();
            box_nomb_Anim.Text = null;
            box_esp_Anim.Text = null;
            box_comi_Anim.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(box_nomb_Anim.Text))
            {
                ingDatos1 = true;
            }
            if (string.IsNullOrWhiteSpace(box_nomb_Anim.Text))
            {
                ingDatos1 = false;
            }
            desactivarBtn();
            activarBtn();
        }

        private void box_esp_Anim_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(box_esp_Anim.Text))
            {
                ingDatos2 = true;
            }
            if (string.IsNullOrWhiteSpace(box_esp_Anim.Text))
            {
                ingDatos2 = false;
            }
            desactivarBtn();
            activarBtn();
        }

        private void box_comi_Anim_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(box_comi_Anim.Text))
            {
                ingDatos3 = true;
            }
            if (string.IsNullOrWhiteSpace(box_comi_Anim.Text))
            {
                ingDatos3 = false;
            }
            desactivarBtn();
            activarBtn();
        }
    }
}
