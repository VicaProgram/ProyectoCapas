using Entidad;
using Negocio;
using Presentacion.AAClases;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
//Arbol de proyecto
namespace Presentacion.Localidad
{
    public partial class PReg : Form //declara form
    {
        ELocReg Ent = new ELocReg();//Declara objeto
        NLocReg Neg = new NLocReg();//Declara objeto
        public PReg()//inicializa
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

        private void PReg_Load(object sender, EventArgs e)//Cuando carga
        {
            foreach (DataGridViewColumn columna in Grilla.Columns)// Itera sobre cada columna en la grilla
            {

                if (columna.Visible == true && columna.Name != "Selec") // Si la columna es visible y no es "Selec"
                {
                    ComboBusReg.Items.Add(new Filtrar() { Valor = columna.Name, Texto = columna.HeaderText });// Agrega opciones de filtrado al combo
                }
            }
            ComboBusReg.DisplayMember = "Texto";// Establece la propiedad para mostrar en el combo
            ComboBusReg.ValueMember = "Valor";// Establece la propiedad para mostrar en el combo
            ComboBusReg.SelectedIndex = 0;// Selecciona el primer ítem del combo
            CarDat();//Llama metodo

        }
        public void CarDat()//Declara metodo
        {
            try//Bloque try
            {
                Grilla.Rows.Clear();// Limpia las filas de la grilla.
                List<ELocReg> Listar = new NLocReg().Listar();// Obtiene la lista de comunas.
                foreach (ELocReg item in Listar)// Itera sobre cada item obtenido.
                {
                    Grilla.Rows.Add(new object[] { "", item.IdReg, item.Nombre });// Agrega una fila en la grilla.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// Muestra un mensaje en caso de error
            }
            Grilla.ClearSelection();// Limpia la selección de la grilla
        }

        public void Validar()
        {
            if (TextIngMod.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                ButIng.Enabled = true;// Habilita el botón
                ButMod.Enabled = true;// Habilita el botón
                ButEli.Enabled = true;// Habilita el botón
            }
            else
            {
                ButIng.Enabled = false;// Deshabilita el botón
                ButMod.Enabled = false;// Deshabilita el botón
                ButEli.Enabled = false;// Deshabilita el botón
            }
        }
        public void ResetGrid()//Declara metodo
        {
            foreach (DataGridViewRow row in Grilla.Rows)// Itera sobre cada fila en la grilla.
            {
                row.Visible = true;// Establece la visibilidad de cada fila como verdadera.
            }
        }
        public void Check_funciones()//Declara metodo
        {
            CheckIng.CheckState = CheckState.Unchecked;// Desmarca la casilla
            CheckMod.CheckState = CheckState.Unchecked;// Desmarca la casilla
            CheckEli.CheckState = CheckState.Unchecked;// Desmarca la casilla
            CheckIng.Enabled = true;// Habilita la casilla
            CheckMod.Enabled = false;// Deshabilita la casilla
            CheckEli.Enabled = false;// Deshabilita la casilla
        }
        private void Grilla_DoubleClick(object sender, EventArgs e)//evento
        {
            textId.Clear();// Limpia el campo
            TextIngMod.Clear();// Limpia el campo
            CheckMod.Enabled = true;// Habilita la casilla
            CheckEli.Enabled = true;// Habilita la casilla
            CheckIng.CheckState = CheckState.Unchecked;// Desmarca la casilla
            CheckIng.Enabled = false;// Deshabilita la casilla
            CheckMod.CheckState = CheckState.Unchecked;// Desmarca la casilla
            CheckEli.CheckState = CheckState.Unchecked;// Desmarca la casilla
            textId.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString();// Carga los datos
            TextIngMod.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString();// Carga los datos
        }

        private void ButBus_Click(object sender, EventArgs e)//evento
        {
            string columnaFiltro = ((Filtrar)ComboBusReg.SelectedItem).Valor.ToString();// Obtiene la columna seleccionada.

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

        private void TextBus_TextChanged(object sender, EventArgs e)//evento
        {
            TextBus.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextBus.Text);// Convierte el texto a formato título
            TextBus.SelectionStart = TextBus.Text.Length;// Coloca el cursor al final del texto
            Validar();// Llama al método
        }

        private void ButLimBus_Click(object sender, EventArgs e)//evento
        {
            TextBus.Text = "";// Limpia el texto
            CarDat();// Llama al método
        }

        private void CheckIng_CheckedChanged(object sender, EventArgs e)//evento
        {
            if (CheckIng.CheckState == CheckState.Checked)// Si la casilla está marcada
            {
                CheckMod.CheckState = CheckState.Unchecked;// Desmarca la casilla
                CheckEli.CheckState = CheckState.Unchecked;// Desmarca la casilla
                label7.Text = "Ingresar Región:";// Cambia el texto
                TextIngMod.Enabled = true;// Habilita el campo
                TextIngMod.Clear();// Limpia el campo
                textId.Clear();// Limpia el campo
                ButIng.Visible = true;// Hace visible el botón
            }
            else
            {
                label7.Text = "";// Limpia el texto
                ButIng.Visible = false;// Oculta el botón 
            }
            Validar();//Llama al metodo
        }

        private void CheckMod_CheckedChanged(object sender, EventArgs e)//evento
        {
            if (CheckMod.CheckState == CheckState.Checked)// Si la casilla está marcada
            {
                CheckIng.CheckState = CheckState.Unchecked;// Desmarca la casilla
                CheckEli.CheckState = CheckState.Unchecked;// Desmarca la casilla
                label7.Text = "Actualizar Región:";// Cambia el texto
                TextIngMod.Enabled = true;// Habilita el campo
                ButMod.Visible = true;// Hace visible el botón
            }
            else
            {
                label7.Text = "";// Limpia el texto
                ButMod.Visible = false;// Oculta el botón 
            }
            Validar();//Llama al metodo
        }

        private void CheckEli_CheckedChanged(object sender, EventArgs e)//evento
        {
            if (CheckEli.CheckState == CheckState.Checked)// Si la casilla está marcada
            {
                CheckIng.CheckState = CheckState.Unchecked;// Desmarca la casilla
                CheckMod.CheckState = CheckState.Unchecked;// Desmarca la casilla
                label7.Text = "Eliminar Región:";// Cambia el texto
                TextIngMod.Enabled = false;// Habilita el campo
                ButEli.Visible = true;// Hace visible el botón
            }
            else
            {
                label7.Text = "";// Limpia el texto
                ButEli.Visible = false;// Oculta el botón 
            }
            Validar(); //Llama al metodo
        }

        private void TextIngMod_KeyPress(object sender, KeyPressEventArgs e)//evento
        {
            if (char.IsDigit(e.KeyChar))//Verifica si la tecla presionada es un dígito
            {
                e.Handled = true;//Cancela la entrada
                MessageBox.Show("Solo se permiten letras.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);//Muestra un mensaje
            }
        }

        private void TextIngMod_TextChanged(object sender, EventArgs e)//evento
        {
            TextIngMod.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextIngMod.Text);//Convierte el texto ingresado a formato de título
            TextIngMod.SelectionStart = TextIngMod.Text.Length; //Coloca el cursor al final del texto
            Validar();//Llama al metodo
        }

        private void ButMod_Click(object sender, EventArgs e)//evento
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//Muestra un mensaje
            Ent.IdReg = Convert.ToInt32(textId.Text);//Convierte el texto ingresado
            Ent.Nombre = TextIngMod.Text;//Asigna el texto ingresado
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                Respuesta<bool> resultado = NLocReg.Actualizar(Ent);//Llama al método
                if (resultado.estado)//Verifica si el estado de la respuesta indica éxito
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra un mensaje
                    ButLim.PerformClick();//Simula un clic en el boton
                }
                else
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra un mensaje
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

        private void ButEli_Click(object sender, EventArgs e)//evento
        {
            var res = MessageBox.Show("¿Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//Muestra un mensaje
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                int Id;//Declara una variable
                if (int.TryParse(textId.Text, out Id))//verifica si el texto ingresado se puede convertir en numero
                {
                    Respuesta<bool> resultado = NLocReg.Eliminar(Id);//Llama al método
                    if (resultado.estado)//Verifica si el estado de la respuesta indica éxito
                    {
                        MessageBox.Show("La eliminación se realizó correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra un mensaje
                        ButLim.PerformClick();//Simula un clic en el boton
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Muestra un mensaje
                    }
                }
                else
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

        private void ButIng_Click(object sender, EventArgs e)//evento
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//Muestra un mensaje
            Ent.Nombre = TextIngMod.Text;//Asigna el texto ingresado
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                Respuesta<bool> resultado = NLocReg.Ingresar(Ent);//Llama al método

                if (resultado.estado)//Verifica si el estado de la respuesta indica éxito
                {
                    MessageBox.Show("Ingreso fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra un mensaje
                    ButLim.PerformClick();//Simula un clic en el boton
                }
                else
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra un mensaje
                }
            }
            else if (res == DialogResult.No)//Verifica si el usuario seleccionó "No" en el cuadro de diálogo.
            {
                ButVol.Focus(); //Coloca el foco en el botón 
            }
            else if (res == DialogResult.Cancel)//Verifica si el usuario seleccionó "Cancelar" en el cuadro de diálogo.
            {
                ButSal.Focus(); //Coloca el foco en el botón 
            }
            Grilla.Rows.Clear(); //Limpia todas las filas de la grilla
            CarDat();//Llama al método
        }

        private void ButLim_Click(object sender, EventArgs e)//evento
        {
            textId.Clear();//Limpia el texto
            TextIngMod.Clear();//Limpia el texto
            TextIngMod.Enabled = false;//Desactiva el textbox
            TextBus.Text = "";//Limpia el texto
            ResetGrid();//Llama metodo
            Check_funciones();//Llama metodo
            CarDat();//Llama metodo
            Validar();//Llama metodo
        }

        private void ButVol_Click(object sender, EventArgs e)//evento
        {
            this.Close();//Cierra la ventana
        }

        private void ButSal_Click(object sender, EventArgs e)//evento
        {
            Application.Exit();//Cierra la aplicacion
        }

        private void ComboBusReg_SelectedIndexChanged(object sender, EventArgs e)//evento
        {
            Validar();//Llama metodo
        }
        private void Grilla_DoubleClick_1(object sender, EventArgs e)//evento
        {
            textId.Clear();// Limpia el campo
            TextIngMod.Clear();// Limpia el campo
            CheckMod.Enabled = true;// Habilita la casilla
            CheckEli.Enabled = true;// Habilita la casilla
            CheckIng.CheckState = CheckState.Unchecked;// Desmarca la casilla
            CheckIng.Enabled = false;// Deshabilita la casilla
            CheckMod.CheckState = CheckState.Unchecked;// Desmarca la casilla
            CheckEli.CheckState = CheckState.Unchecked;// Desmarca la casilla
            textId.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString();// Carga los datos
            TextIngMod.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString();// Carga los datos
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
