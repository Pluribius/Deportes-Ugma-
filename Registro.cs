using System;
using System.Windows.Forms;

namespace ugma1
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        #region seleccion de edad

        // al  seleccionar un bloque de edad los demas se excluyen
        private void rdEdadA_CheckedChanged(object sender, EventArgs e)
        {
            rdEdadB.Checked = false;
            rdEdadC.Checked = false;
        }

        private void rdEdadB_CheckedChanged(object sender, EventArgs e)
        {
            rdEdadA.Checked = false;
            rdEdadC.Checked = false;
        }

        private void rdEdadC_CheckedChanged(object sender, EventArgs e)
        {
            rdEdadB.Checked = false;
            rdEdadA.Checked = false;
        }

        #endregion seleccion de edad

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            #region validacion de opciones vacias


            if (string.IsNullOrEmpty(txt_nombre.Text) || txt_nombre.Text == "Nombre")
            {
                // El TextBox está vacío
                // Aquí puedes agregar el código para mostrar un mensaje o realizar alguna otra acción
                MessageBox.Show("Por favor, ingresa un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            bool edad_valida = false;



            
            if (rdEdadA.Checked) edad_valida = true;
            if (rdEdadB.Checked) edad_valida = true;
            if (rdEdadC.Checked) edad_valida = true;

            if (!edad_valida)
            {
                MessageBox.Show("Por favor seleciona tu grupo de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                // Verificamos si hay algún elemento seleccionado
                if (chk_deporte.CheckedItems.Count == 0)
            {
                // Si no hay elementos seleccionados, mostramos un mensaje de error
                MessageBox.Show("Debe seleccionar al menos una disciplina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (box_camisetas.SelectedIndex == -1)
            {
                // Si no se ha seleccionado ninguna opción, mostramos un mensaje de error
                MessageBox.Show("Debe seleccionar una opción de camiseta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion validacion de opciones vacias

            #region definicion de actividades

            //Eventos para Menores de 18 Años:
            string[] act_A = {"Mini Maratón Infantil: Atletismo",
                            "Competencia de Natación Libre: Natación",
                            "Carrera de Bicicletas sin Pedales: Ciclismo",
                            "Levantamiento de Pesas Adaptado: Levantamiento de pesas" };
            //Eventos para la Categoría de 18 a 40 Años:
            string[] act_B = {
                              "Carrera de Obstáculos Spartan Race: Atletismo ",
                              "Natación en Aguas Abiertas: Natación",
                              "Ciclismo de Montaña Cross Country: Ciclismo",
                              "Levantamiento de Pesas Olímpico: Levantamiento de pesas"
};
            //Eventos para Mayores de 40 Años:
            string[] act_C = {
                                "Caminata Rápida: Atletismo",
                                 "Natación Terapéutica: Natación",
                                 "Ciclo Indoor: Ciclismo",
                                 "Fuerza con Máquinas: Levantamiento de Pesas"
    
};
            #endregion definicion de actividades

            #region arbol de decisiones actividades
            richTextBox1.Clear();
            if (rdEdadA.Checked)
            {
                richTextBox1.Text+=("Eventos para Menores de 18 Años:" + Environment.NewLine);
                foreach (var itemSeleccionado in chk_deporte.CheckedItems)
                {
                    // Obtener el índice del elemento seleccionado
                    int indice = chk_deporte.Items.IndexOf(itemSeleccionado);
                    richTextBox1.Text += ("--" + act_A[indice] + Environment.NewLine);
                }
            }
            if (rdEdadB.Checked)
            {
                richTextBox1.Text += ("Eventos para la Categoría de 18 a 40 Años:" + Environment.NewLine);
                foreach (var itemSeleccionado in chk_deporte.CheckedItems)
                {
                    // Obtener el índice del elemento seleccionado
                    int indice = chk_deporte.Items.IndexOf(itemSeleccionado);
                    richTextBox1.Text += ("--" + act_B[indice] + Environment.NewLine);
                }
            }
            if (rdEdadC.Checked)
            {
                richTextBox1.Text += ("Eventos para Mayores de 40 Años:" + Environment.NewLine);
                foreach (var itemSeleccionado in chk_deporte.CheckedItems)
                {
                    // Obtener el índice del elemento seleccionado
                    int indice = chk_deporte.Items.IndexOf(itemSeleccionado);
                    richTextBox1.Text += ("--" + act_C[indice] + Environment.NewLine);
                }
            
        }


            #endregion
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            rdEdadA.Checked = false;
            rdEdadB.Checked = false;
            rdEdadC.Checked = false;

            foreach (int i in chk_deporte.CheckedIndices)
            {
                chk_deporte.SetItemChecked(i, false);
            }

            richTextBox1.ResetText();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            btn_registrarse_Click(sender, e);
            // Obtener el nombre
            string nombre = txt_nombre.Text;

            // Obtener talla de camiseta
            string camiseta= box_camisetas.SelectedItem.ToString();

            // Obtener el grupo de edad desde el RichTextBox
            string grupoEdad = richTextBox1.Text;

            // Construir el mensaje a mostrar
            string mensaje = "Nombre: " + nombre + "\n" +
                            "Grupo de edad: " + grupoEdad + "\n" +
                            "Camiseta: " + camiseta + "\n";

            // Mostrar el mensaje en un cuadro de diálogo
            MessageBox.Show(mensaje, "Información del participante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cancelar_Click(sender, e);
        }
    }

    
}