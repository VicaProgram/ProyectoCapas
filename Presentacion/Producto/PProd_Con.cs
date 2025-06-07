using Entidad;
using Negocio;
using Presentacion.AAClases;
using Presentacion.Arriendo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Arbol de proyecto
namespace Presentacion.Producto
{
    public partial class PProd_Con : Form //Declara form
    {
        public PArr_Ing FormularioPadre { get; set; }

        public PProd_Con() //Declara metodo
        {
            InitializeComponent();
            ApplyModernStyles(this.Controls);
        }
        private void ApplyModernStyles(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is System.Windows.Forms.Button) (ctrl as System.Windows.Forms.Button).ApplyModernStyle();
                else if (ctrl is System.Windows.Forms.TextBox) (ctrl as System.Windows.Forms.TextBox).ApplyModernStyle();
                else if (ctrl is DataGridView) (ctrl as DataGridView).ApplyModernStyle();
                else if (ctrl is MenuStrip) (ctrl as MenuStrip).ApplyModernStyle();

                // Si el control contiene otros controles (ej: Panel, GroupBox)
                if (ctrl.HasChildren) ApplyModernStyles(ctrl.Controls);
            }
        }

        EProd Ent = new EProd();//Declara objeto
        NProd NProd = new NProd();//Declara objeto
        private void PProd_Con_Load(object sender, EventArgs e)//Declara evento
        {
            foreach (DataGridViewColumn columna in Grilla.Columns)// Itera sobre cada columna en la grilla
            {

                if (columna.Visible == true && columna.Name != "Selec")// Si la columna es visible y no es "Selec"
                {
                    ComboBus.Items.Add(new Filtrar() { Valor = columna.Name, Texto = columna.HeaderText }); // Agrega opciones de filtrado al combo.
                }
            }
            ComboBus.DisplayMember = "Texto";// Establece la propiedad para mostrar en el combo
            ComboBus.ValueMember = "Valor";// Establece la propiedad para mostrar en el combo
            ComboBus.SelectedIndex = 0;// Selecciona el primer ítem del combo
            CarDat();//Llama metodo
        }
        public void CarDat()//Declara metodo
        {
            try//Bloque try
            {
                Grilla.Rows.Clear();// Limpia las filas de la grilla.
                List<EProd> Listar = new NProd().Listar();// Obtiene la lista.
                foreach (EProd item in Listar)// Itera sobre cada item obtenido.
                {
                    Grilla.Rows.Add(new object[] { "", item.IdProd, item.Nombre, item.FInc, item.CInc, item.CAct,item.CArr, item.TAct, item.VArr});// Agrega una fila en la grilla.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// Muestra un mensaje en caso de error
            }
            Grilla.ClearSelection();// Limpia la selección de la grilla
        }
        public void ResetGrid()  //Declara metodo
        {
            foreach (DataGridViewRow row in Grilla.Rows)// Itera sobre cada item.
            {
                row.Visible = true; //Muestra la fila
            }
        }
        private void TextBus_KeyPress(object sender, KeyPressEventArgs e)//Evento
        {

        }

        private void TextBus_TextChanged(object sender, EventArgs e)//Evento
        {
            TextBus.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextBus.Text);// Convierte el texto a formato título
            TextBus.SelectionStart = TextBus.Text.Length;// Coloca el cursor al final del texto
        }

        private void ButBus_Click(object sender, EventArgs e)//Evento
        {
            string columnaFiltro = ((Filtrar)ComboBus.SelectedItem).Valor.ToString(); // Obtiene la columna seleccionada.
            if (Grilla.Rows.Count > 0)// Verifica si hay filas en la grilla.
            {
                foreach (DataGridViewRow row in Grilla.Rows)// Itera sobre cada fila de la grilla.
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TextBus.Text.Trim().ToUpper()))// Verifica si la celda contiene el texto buscado.
                        row.Visible = true;// Muestra la fila si cumple la condición.
                    else//En caso contrario
                        row.Visible = false;// Oculta la fila si no cumple.
                }
            }
        }

        private void ButLimBus_Click(object sender, EventArgs e)//Evento
        {
            TextBus.Text = "";// Limpia el texto
            CarDat();// Llama al método
        }
        private void Grilla_DoubleClick(object sender, EventArgs e)//Evento
        {
            ButMod.Enabled = true;// Habilita el botón
            BtnSelect.Enabled = true;// Habilita el botón
            ButMod2.Enabled = true;// Habilita el botón
            ButEli.Enabled = true;// Habilita el botón
            TextIdCli.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString(); //Le da el valor
        }
        private void ButEli_Click(object sender, EventArgs e)//Evento
        {
            var res = MessageBox.Show("¿Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//Muestra un mensaje
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                int Id;//Declara una variable
                if (int.TryParse(TextIdCli.Text, out Id))//verifica si el texto ingresado se puede convertir en numero
                {
                    Respuesta<bool> resultado = NProd.Eliminar(Id);//Llama al método
                    if (resultado.estado)//Verifica si el estado de la respuesta indica éxito
                    {
                        MessageBox.Show("La eliminación se realizó correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra un mensaje
                    }
                    else //Sino
                    {
                        MessageBox.Show("No se pudo eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Muestra un mensaje
                    }
                }
                else //Sino
                {
                    MessageBox.Show("Seleccione un registro válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra un mensaje
                }
            }
            else if (res == DialogResult.No)//Verifica si el usuario seleccionó "No" en el cuadro de diálogo.
            {
                ButVol.Focus();//Coloca el foco en el botón
            }
            else if (res == DialogResult.Cancel)//Verifica si el usuario seleccionó "Cancelar" en el cuadro de diálogo.
            {
                ButSal.Focus();//Coloca el foco en el botón
            }
            Grilla.Rows.Clear();//Limpia todas las filas de la grilla
            CarDat();//Llama al método
        }

        private void ButVol_Click(object sender, EventArgs e)//Evento
        {
            this.Close();//Cierra la ventana
        }

        private void ButSal_Click(object sender, EventArgs e)//Evento
        {
            Application.Exit();//Cierra la aplicacion
        }

        private void ButMod_Click(object sender, EventArgs e)//Declara evento
        {
            PProd_Act pasar = new PProd_Act(); //Declara variable
            pasar.TextIdProd.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString(); //Le da el valor
            pasar.TextNomF.Text= this.Grilla.CurrentRow.Cells[2].Value.ToString();//Le da el valor
            pasar.TextNomI.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString();//Le da el valor
            pasar.TextFIncF.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString();//Le da el valor
            pasar.TextFIncI.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString();//Le da el valor
            pasar.TextCIncF.Text = this.Grilla.CurrentRow.Cells[4].Value.ToString();//Le da el valor
            pasar.TextCIncI.Text = this.Grilla.CurrentRow.Cells[4].Value.ToString();//Le da el valor
            pasar.TextCActF.Text = this.Grilla.CurrentRow.Cells[5].Value.ToString();//Le da el valor
            pasar.TextCActI.Text = this.Grilla.CurrentRow.Cells[5].Value.ToString();//Le da el valor
            pasar.TextCArrF.Text = this.Grilla.CurrentRow.Cells[6].Value.ToString();//Le da el valor
            pasar.TextCArrI.Text = this.Grilla.CurrentRow.Cells[6].Value.ToString();//Le da el valor
            pasar.TextTActF.Text = this.Grilla.CurrentRow.Cells[7].Value.ToString();//Le da el valor
            pasar.TextTActI.Text = this.Grilla.CurrentRow.Cells[7].Value.ToString();//Le da el valor
            pasar.TextVArrF.Text = this.Grilla.CurrentRow.Cells[8].Value.ToString();//Le da el valor
            pasar.TextVArrI.Text = this.Grilla.CurrentRow.Cells[8].Value.ToString();//Le da el valor
            pasar.LabelNom.Enabled = true; //Habilita Label
            pasar.LabelFInc.Enabled = true; //Habilita Label
            pasar.LabelCInc.Enabled = true; //Habilita Label
            pasar.LabelCAct.Enabled = true; //Habilita Label
            pasar.LabelCArr.Enabled = true; //Habilita Label
            pasar.LabelTAct.Enabled = true; //Habilita Label
            pasar.LabelVArr.Enabled = true; //Habilita Label
            pasar.Show(); //Muestra el form
            ButMod.Enabled = false;// Deshabilita el botón
            ButEli.Enabled = false;// Deshabilita el botón
            this.Close(); //Cierra la ventana
        }

        private void ButMod2_Click(object sender, EventArgs e)
        {
            PProd_Act2 pasar = new PProd_Act2(); //Declara variable
            pasar.TextIdProd.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString(); //Le da el valor
            pasar.LabelNomF.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString();//Le da el valor
            pasar.LabelFIncF.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString();//Le da el valor
            pasar.LabelCIncF.Text = this.Grilla.CurrentRow.Cells[4].Value.ToString();//Le da el valor
            pasar.LabelCActF.Text = this.Grilla.CurrentRow.Cells[5].Value.ToString();//Le da el valor
            pasar.TextCArrF.Text = this.Grilla.CurrentRow.Cells[6].Value.ToString();//Le da el valor
            pasar.TextCArrI.Text = this.Grilla.CurrentRow.Cells[6].Value.ToString();//Le da el valor
            pasar.TextTActF.Text = this.Grilla.CurrentRow.Cells[7].Value.ToString();//Le da el valor
            pasar.TextTActI.Text = this.Grilla.CurrentRow.Cells[7].Value.ToString();//Le da el valor
            pasar.LabelVArrF.Text = this.Grilla.CurrentRow.Cells[8].Value.ToString();//Le da el valor
            pasar.LabelNom.Enabled = true; //Habilita Label
            pasar.LabelFInc.Enabled = true; //Habilita Label
            pasar.LabelCInc.Enabled = true; //Habilita Label
            pasar.LabelCAct.Enabled = true; //Habilita Label
            pasar.LabelCArr.Enabled = true; //Habilita Label
            pasar.LabelTAct.Enabled = true; //Habilita Label
            pasar.LabelVArr.Enabled = true; //Habilita Label
            pasar.Show(); //Muestra el form
            ButMod.Enabled = false;// Deshabilita el botón
            ButEli.Enabled = false;// Deshabilita el botón
            this.Close(); //Cierra la ventana
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            // Verificar que el contador no se pase de 10
            if (FormularioPadre != null && FormularioPadre.contador <= 10)
            {
                // Obtener el índice actual
                int i = FormularioPadre.contador;

                // Construir los nombres dinámicos de los controles
                string nombreId = "TextIdProd" + i;
                string nombreProd = "TxtProd" + i;
                string nombreVU = "TxtVU" + i;

                // Buscar los controles en el formulario padre
                Control[] controlId = FormularioPadre.Controls.Find(nombreId, true);
                Control[] controlProd = FormularioPadre.Controls.Find(nombreProd, true);
                Control[] controlVU = FormularioPadre.Controls.Find(nombreVU, true);

                // Asignar los valores si los controles existen
                if (controlId.Length > 0 && controlId[0] is TextBox)
                {
                    ((TextBox)controlId[0]).Text = this.Grilla.CurrentRow.Cells[1].Value.ToString();
                }
                if (controlProd.Length > 0 && controlProd[0] is TextBox)
                {
                    ((TextBox)controlProd[0]).Text = this.Grilla.CurrentRow.Cells[2].Value.ToString();
                }
                if (controlVU.Length > 0 && controlVU[0] is TextBox)
                {
                    ((TextBox)controlVU[0]).Text = this.Grilla.CurrentRow.Cells[8].Value.ToString();
                }

                // Incrementar el contador de productos
                FormularioPadre.contador++;

                // Si el contador alcanza 11, mostrar un mensaje de advertencia
                if (FormularioPadre.contador > 10)
                {
                    MessageBox.Show("¡Has alcanzado el límite de productos!");
                }
            }

            // Cerrar el formulario hijo
            this.Close();
        }
    }
}
