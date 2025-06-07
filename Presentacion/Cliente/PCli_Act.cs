using Entidad;
using Negocio;
using Presentacion.AAClases;
using Presentacion.Proveedor;
using System;
using System.Data;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
//Arbol de proyecto
namespace Presentacion.Cliente
{
    public partial class PCli_Act : Form//Declara Form
    {
        ValidaRut Rut = new ValidaRut(); //Declara objeto
        ECliente Ent = new ECliente();//Declara objeto
        NCliente Neg = new NCliente();//Declara objeto
        NLocCom NegCom = new NLocCom();//Declara objeto
        NLocPro NegPro = new NLocPro();//Declara objeto
        NLocReg NegReg = new NLocReg();//Declara objeto
        public PCli_Act()//Inicializa
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
        private void Cli_Act_Load(object sender, EventArgs e)//evento
        {

        }
        public void LleComReg()//Declara metodo
        {
            CBReg.DisplayMember = "Nombre";// Establece la propiedad del combo
            CBReg.ValueMember = "IdReg";// Establece la propiedad del combo
            CBReg.DataSource = NegReg.Listar();// Carga los datos
        }

        private void CargaCBPro()//Declara metodo
        {
            int IdReg = Convert.ToInt32(CBReg.SelectedValue);//Obtiene el valor seleccionado del combo
            DataTable dt = NegPro.Filtrar(IdReg);//Llama al método
            CBPro.DisplayMember = "Nombre";// Establece la propiedad del combo
            CBPro.ValueMember = "IdPro";// Establece la propiedad del combo
            CBPro.DataSource = dt;//Llena el combo
        }

        private void CargaCBCom()//Declara metodo
        {
            int IdPro = Convert.ToInt32(CBPro.SelectedValue);//Obtiene el valor seleccionado del combo
            DataTable dt = NegCom.Filtrar(IdPro);//Llama al método
            CBCom.DisplayMember = "Nombre";// Establece la propiedad del combo
            CBCom.ValueMember = "IdCom";// Establece la propiedad del combo
            CBCom.DataSource = dt;//Llena el combo
        }

        public void Validar() //Declara metodo
        {
            if ((TextNomF.Text.Trim() != TextNomI.Text.Trim()) || (TextRutF.Text.Trim() != labelRtI.Text.Trim()) || (TextComIdeF.Text.Trim() != TextComIdeI.Text.Trim()) || (TextComI.Text.Trim() != TextComF.Text.Trim()) || (TextDireF.Text.Trim() != TextDireI.Text.Trim()) || (TextGirF.Text.Trim() != TextGirI.Text.Trim()) || (TextTelF.Text.Trim() != TextTelI.Text.Trim()) || (TextEmaF.Text.Trim() != TextEmaI.Text.Trim()))// Verifica si el campo de entrada no está vacío
            {
                ButMod.Enabled = true;// Habilita el botón
                LabelRut.Enabled = false;// Deshabilita el Label
                LabelNom.Enabled = false;// Deshabilita el Label
                labelActCom.Enabled = false;// Deshabilita el Label
                LabelDir.Enabled = false;// Deshabilita el Label
                LabelTel.Enabled = false;// Deshabilita el Label
                LabelEma.Enabled = false;// Deshabilita el Label
                LabelGir.Enabled = false;// Deshabilita el Label
            }
            else//Sino
            {
                ButMod.Enabled = false;// Deshabilita el botón
                LabelRut.Enabled = true;// Habilita el Label
                LabelNom.Enabled = true;// Habilita el Label
                labelActCom.Enabled = true;// Habilita el Label
                LabelDir.Enabled = true;// Habilita el Label
                LabelTel.Enabled = true;// Habilita el Label
                LabelEma.Enabled = true;// Habilita el Label
                LabelGir.Enabled = true;// Habilita el Label
            }
        }

        public void Cambio()//Declara metodo
        {
            LabelRut.Enabled = true;// Habilita el Label
            LabelNom.Enabled = true;// Habilita el Label
            labelActCom.Enabled = true;// Habilita el Label
            LabelDir.Enabled = true;// Habilita el Label
            LabelTel.Enabled = true;// Habilita el Label
            LabelEma.Enabled = true;// Habilita el Label
            LabelGir.Enabled = true;// Habilita el Label
            TextNomF.Enabled = false;// Deshabilita el TextBox
            TextRutF.Enabled = false;// Deshabilita el TextBox
            TextDireF.Enabled = false;// Deshabilita el TextBox
            TextTelF.Enabled = false;// Deshabilita el TextBox
            TextEmaF.Enabled = false;// Deshabilita el TextBox
            TextGirF.Enabled = false;// Deshabilita el TextBox
            ButMod.Enabled = false;// Deshabilita el botón
            labelActReg.Enabled = false;// Deshabilita el Label
            CBReg.Enabled = false; // Deshabilita el ComboBox
            labelAcPro.Enabled = false;// Deshabilita el Label
            CBPro.Enabled = false;// Deshabilita el ComboBox
            labelComActual.Enabled = false;// Deshabilita el Label
            CBCom.Enabled = false;// Deshabilita el ComboBox
        }

        private void LabelEma_Click(object sender, EventArgs e)//Evento
        {
            TextEmaF.Enabled = true; // Habilita el TextBox
        }

        private void TextEma_TextChanged(object sender, EventArgs e)//Evento
        {
            Validar(); //Llama metodo
        }

        private void ButAnu_Click(object sender, EventArgs e)//Evento
        {
            TextNomF.Text = TextNomI.Text; //Le da el valor
            TextRutF.Text = labelRtI.Text;//Le da el valor
            TextComF.Text = TextComIdeI.Text;//Le da el valor
            TextComF.Text = TextComI.Text;//Le da el valor
            TextDireF.Text = TextDireI.Text;//Le da el valor
            TextTelF.Text = TextTelI.Text;//Le da el valor
            TextEmaF.Text = TextEmaI.Text;//Le da el valor
            TextGirF.Text = TextGirI.Text;//Le da el valor
            Cambio();//Llama metodo
        }

        private void ButVol_Click(object sender, EventArgs e)//Evento
        {
            PProv_Con ver = new PProv_Con(); //Declara objeto
            ver.ButMod.Visible = true; //Hece visible el boton
            this.Close(); //Cierra la ventana
        }

        private void ButSal_Click(object sender, EventArgs e)//Evento
        {
            Application.Exit(); //Cierra la aplicacion
        }

        private void ButMod_Click(object sender, EventArgs e)//Evento
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //Muestra Mensaje
            string Mensaje = string.Empty; //Declara variable
            Ent.IdP_Cli = Convert.ToInt32(TextIdCli.Text); //Le da el valor
            Ent.Nombre = TextNomF.Text;//Le da el valor
            Ent.Rut = TextRutF.Text;//Le da el valor
            Ent.IdCom = Convert.ToInt32(TextComIdeF.Text);//Le da el valor
            Ent.Direccion = TextDireF.Text;//Le da el valor
            Ent.Tel = TextTelF.Text;//Le da el valor
            Ent.Email = TextEmaF.Text;//Le da el valor
            Ent.Giro = TextGirF.Text;//Le da el valor
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                Respuesta<bool> resultado = NCliente.Actualizar(Ent);//Llama metodo
                if (resultado.estado)//Verifica si el estado de la respuesta indica éxito
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra Mensaje
                    TextNomI.Text = TextNomF.Text;//Le da el valor
                    labelRtI.Text = TextRutF.Text;//Le da el valor
                    TextComIdeI.Text = TextComIdeF.Text;//Le da el valor
                    TextComI.Text = TextComF.Text;//Le da el valor
                    TextDireI.Text = TextDireF.Text;//Le da el valor
                    TextTelI.Text = TextTelF.Text;//Le da el valor
                    TextEmaI.Text = TextEmaF.Text;//Le da el valor
                    TextGirI.Text = TextGirF.Text;//Le da el valor
                }
                else//Sino
                {
                    MessageBox.Show(Mensaje);//Muestra Mensaje
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
            Cambio();//Llama metodo
            Validar();//Llama metodo
        }

        private void LabelRut_Click(object sender, EventArgs e)//Evento
        {
            TextRutF.Enabled = true; // Habilita el TextBox
        }

        private void TextRutF_Leave(object sender, EventArgs e)//Evento
        {
            Ent.Rut = TextRutF.Text; //Le da valor
            bool respuesta = false;//Declara variable
            respuesta = Rut.validarRut(TextRutF.Text);//Llama metodo
            if (respuesta == false)//Si es falso
            {
                TextRutF.Clear();//Limpia texto
                MessageBox.Show("Rut Malo", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);//Muestra Mensaje
            }
            else//Sino
            {
                MessageBox.Show("Rut Bueno", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra Mensaje
                Validar();//Llama el metodo
            }
        }

        private void LabelNom_Click(object sender, EventArgs e)//Evento
        {
            TextNomF.Enabled = true;// Habilita el TextBox
        }

        private void TextNomF_KeyPress(object sender, KeyPressEventArgs e)//Evento
        {
            if (char.IsNumber(e.KeyChar))// Verifica si la tecla presionada es un dígito.
            {
                e.Handled = true;// Cancela la entrada.
                MessageBox.Show("solo se permiten letras");// Muestra un mensaje.
            }
        }

        private void TextNomF_TextChanged(object sender, EventArgs e)//Evento
        {
            TextNomF.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextNomF.Text);// Convierte el texto a formato título
            TextNomF.SelectionStart = TextNomF.Text.Length;// Coloca el cursor al final del texto
            Validar();//Llama el metodo
        }

        private void LabelTel_Click(object sender, EventArgs e)//Evento
        {
            TextTelF.Enabled = true;// Habilita el TextBox
        }

        private void TextTelF_TextChanged(object sender, EventArgs e)//Evento
        {
            Validar();//Llama el metodo
        }

        private void labelAct_Click(object sender, EventArgs e)//Evento
        {
            LleComReg();//Llama el metodo
            labelActReg.Enabled = true;// Habilita el Label
            CBReg.Enabled = true; // Habilita el ComboBox
            labelAcPro.Enabled = true; // Habilita el label
            CBPro.Enabled = true; // Habilita el ComboBox
            labelComActual.Enabled = true; // Habilita el label
            CBCom.Enabled = true; // Habilita el ComboBox
        }

        private void CBReg_SelectedIndexChanged(object sender, EventArgs e)//Evento
        {
            CargaCBPro();//Llama el metodo
        }

        private void CBPro_SelectedIndexChanged(object sender, EventArgs e)//Evento
        {
            CargaCBCom();//Llama el metodo
        }

        private void CBCom_SelectedIndexChanged(object sender, EventArgs e)//Evento
        {
            TextComF.Text = CBCom.Text; //Le da el valor
            TextComIdeF.Text = Convert.ToString(CBCom.SelectedValue); //Le da el valor
            Validar();//Llama el metodo
        }

        private void LabelDir_Click(object sender, EventArgs e)//Evento
        {
            TextDireF.Enabled = true;// Habilita el TextBox
        }

        private void TextDireF_TextChanged(object sender, EventArgs e)//Evento
        {
            Validar();//Llama el metodo
        }

        private void LabelGir_Click(object sender, EventArgs e)//Evento
        {
            TextGirF.Enabled = true;// Habilita el TextBox
        }

        private void TextGirF_TextChanged(object sender, EventArgs e)//Evento
        {
            Validar();//Llama el metodo
        }


    }
}
