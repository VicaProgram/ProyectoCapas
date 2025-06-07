using Entidad;
using Negocio;
using Presentacion.AAClases;
using Presentacion.Arriendo;
using Presentacion.Proveedor;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
//Arbol de proyecto
namespace Presentacion.Cliente
{
    public partial class PCli_Con : Form//Declara Form
    {

        public PCli_Con()//Inicializa
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
        public PArr_Ing FormularioPadre { get; set; }
        ECliente Ent = new ECliente();//Declara objeto
        NCliente Neg = new NCliente();//Declara objeto
        NLocCom NegCom = new NLocCom();//Declara objeto
        NLocPro NegPro = new NLocPro();//Declara objeto
        NLocReg NegReg = new NLocReg();//Declara objeto
        private void PCli_Con_Load(object sender, EventArgs e)//evento
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
                List<ECliente> Listar = new NCliente().Listar();// Obtiene la lista.
                foreach (ECliente item in Listar)// Itera sobre cada item obtenido.
                {
                    Grilla.Rows.Add(new object[] { "", item.IdP_Cli, item.Nombre, item.Rut, item.IdCom, item.Com.Nombre, item.Direccion, item.Tel, item.Email, item.Giro });// Agrega una fila en la grilla.
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
            ButEli.Enabled = true;// Habilita el botón
            BtnSelect.Enabled = true; // Habilita el botón de selección
            TextIdCli.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString(); //Le da el valor
        }

        private void ButMod_Click(object sender, EventArgs e)//Evento
        {
            PCli_Act pasar = new PCli_Act(); //Declara Objeto
            pasar.TextIdCli.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString(); //Le da el valor
            pasar.TextNomF.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString(); //Le da el valor
            pasar.TextNomI.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString(); //Le da el valor
            pasar.TextRutF.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString(); //Le da el valor
            pasar.labelRtI.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString(); //Le da el valor
            pasar.TextComIdeF.Text = this.Grilla.CurrentRow.Cells[4].Value.ToString(); //Le da el valor
            pasar.TextComIdeI.Text = this.Grilla.CurrentRow.Cells[4].Value.ToString(); //Le da el valor
            pasar.TextComI.Text = this.Grilla.CurrentRow.Cells[5].Value.ToString(); //Le da el valor
            pasar.TextComF.Text = this.Grilla.CurrentRow.Cells[5].Value.ToString(); //Le da el valor
            pasar.TextDireF.Text = this.Grilla.CurrentRow.Cells[6].Value.ToString(); //Le da el valor
            pasar.TextDireI.Text = this.Grilla.CurrentRow.Cells[6].Value.ToString(); //Le da el valor
            pasar.TextTelF.Text = this.Grilla.CurrentRow.Cells[7].Value.ToString(); //Le da el valor
            pasar.TextTelI.Text = this.Grilla.CurrentRow.Cells[7].Value.ToString(); //Le da el valor
            pasar.TextEmaF.Text = this.Grilla.CurrentRow.Cells[8].Value.ToString(); //Le da el valor
            pasar.TextEmaI.Text = this.Grilla.CurrentRow.Cells[8].Value.ToString(); //Le da el valor
            pasar.TextGirF.Text = this.Grilla.CurrentRow.Cells[9].Value.ToString(); //Le da el valor
            pasar.TextGirI.Text = this.Grilla.CurrentRow.Cells[9].Value.ToString(); //Le da el valor
            pasar.LabelRut.Enabled = true; //Habilita Label
            pasar.LabelNom.Enabled = true;//Habilita Label
            pasar.labelActCom.Enabled = true;//Habilita Label
            pasar.LabelDir.Enabled = true;//Habilita Label
            pasar.LabelTel.Enabled = true;//Habilita Label
            pasar.LabelEma.Enabled = true;//Habilita Label
            pasar.LabelGir.Enabled = true;//Habilita Label
            pasar.Show(); //Muestra el form
            ButMod.Enabled = false;// Deshabilita el botón
            ButEli.Enabled = false;// Deshabilita el botón
            this.Close(); //Cierra la ventana
        }

        private void ButEli_Click(object sender, EventArgs e)//Evento
        {
            var res = MessageBox.Show("¿Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//Muestra un mensaje
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                int Id;//Declara una variable
                if (int.TryParse(TextIdCli.Text, out Id))//verifica si el texto ingresado se puede convertir en numero
                {
                    Respuesta<bool> resultado = NCliente.Eliminar(Id);//Llama al método
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

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (FormularioPadre != null)
            {
                FormularioPadre.TextIdCli.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString();
                FormularioPadre.TextNomF.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString();
                FormularioPadre.TextRutF.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString();
                FormularioPadre.TextDireF.Text = this.Grilla.CurrentRow.Cells[6].Value.ToString();
                FormularioPadre.TextComIdeF.Text = this.Grilla.CurrentRow.Cells[4].Value.ToString();
                FormularioPadre.TextTelF.Text = this.Grilla.CurrentRow.Cells[7].Value.ToString();
                FormularioPadre.TextGirF.Text = this.Grilla.CurrentRow.Cells[9].Value.ToString();
                FormularioPadre.TxtFech.Text = DateTime.Today.ToShortDateString();
            }
            this.Close(); //Cierra la ventana
        }
    }
}
