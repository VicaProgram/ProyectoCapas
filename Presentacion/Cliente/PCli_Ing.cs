using Entidad;
using Negocio;
using Presentacion.AAClases;
using Presentacion.Localidad;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
//Arbol de proyecto
namespace Presentacion.Cliente
{
    public partial class PCli_Ing : Form //Declara form
    {
        ValidaRut Rut = new ValidaRut();//Declara objeto
        ECliente Ent = new ECliente();//Declara objeto
        NLocCom NegCom = new NLocCom();//Declara objeto
        NLocPro NegPro = new NLocPro();//Declara objeto
        NLocReg NegReg = new NLocReg();//Declara objeto
        public PCli_Ing() //Inicializa
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
        private void Cli_Ing_Load(object sender, EventArgs e) //Evento
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

        public void HabBotIng() // Habilita Boton
        {
            if ((TextRut.Text.Trim() != "") && (TextNom.Text.Trim() != "") && (CBReg.Text.Trim() != "") && (CBPro.Text.Trim() != "") && (CBCom.Text.Trim() != "") && (TextDire.Text.Trim() != "") && (TextTel.Text.Trim() != "") && (TextEma.Text.Trim() != "") && (TextGir.Text.Trim() != "")) // Verifica si el campo de entrada no está vacío
            {
                ButIng.Enabled = true;// Habilita el botón
            }
            else//Sino
            {
                ButIng.Enabled = false;// Deshabilita el botón
            }
        }
        public void HabBotLim() // Habilita Boton
        {
            if ((TextRut.Text.Trim() != "") || (TextNom.Text.Trim() != "") || (CBReg.Text.Trim() != "") || (CBPro.Text.Trim() != "") || (CBCom.Text.Trim() != "") || (TextDire.Text.Trim() != "") || (TextTel.Text.Trim() != "") || (TextEma.Text.Trim() != "") || (TextGir.Text.Trim() != "")) // Verifica si el campo de entrada no está vacío
            {
                ButLim.Enabled = true;// Habilita el botón
            }
            else//Sino
            {
                ButLim.Enabled = false;// Deshabilita el botón
            }
        }

        private void TextRut_Leave(object sender, EventArgs e)
        {
            Ent.Rut = TextRut.Text;//Le da el valor
            bool respuesta = false; //Declara variable
            respuesta = Rut.validarRut(TextRut.Text);//Llama metodo

            if (respuesta == false) //Si es falso
            {
                TextRut.Clear();//Limpia texto
                MessageBox.Show("Rut Malo", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);//Muestra Mensaje
            }
            else
            {
                MessageBox.Show("Rut Bueno", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra Mensaje
                HabBotLim();//Llama metodo
                HabBotIng();//Llama metodo
            }
        }

        private void TextRut_TextChanged(object sender, EventArgs e)
        {
            if (TextRut.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextNom.TabStop = true;//permite el enfoque con Tab
                TextRut.TabStop = false; //no permite el enfoque con Tab
            }
            else//Si no
            {
                TextNom.TabStop = false;//no permite el enfoque con Tab
                TextRut.TabStop = true;//permite el enfoque con Tab
            }
            HabBotIng();//LLama metodo
        }

        private void TextNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))// Verifica si la tecla presionada es un dígito.
            {
                e.Handled = true;// Cancela la entrada.
                MessageBox.Show("Solo se permiten letras.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);// Muestra un mensaje.
            }
        }

        private void TextNom_TextChanged(object sender, EventArgs e)
        {
            TextNom.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextNom.Text);// Convierte el texto a formato título
            TextNom.SelectionStart = TextNom.Text.Length;// Coloca el cursor al final del texto
            if (TextNom.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                CBReg.TabStop = true;//permite el enfoque con Tab
                TextNom.TabStop = false;//no permite el enfoque con Tab
                LleComReg();//Llama metodo
            }
            else//Si no
            {
                CBReg.TabStop = false;//no permite el enfoque con Tab
                TextNom.TabStop = true;//permite el enfoque con Tab
            }
            HabBotIng();//Llama metodo
            CBReg.Enabled = true;//Habilita el combo
            CBPro.Enabled = true;//Habilita el combo
            CBCom.Enabled = true;//Habilita el combo
        }

        private void CBReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBReg.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                CBPro.TabStop = true;//permite el enfoque con Tab
                CBReg.TabStop = false;//no permite el enfoque con Tab
                CargaCBPro();//Llama metodo
            }
            else//Si no
            {
                CBReg.TabStop = false;//no permite el enfoque con Tab
                CBPro.TabStop = true;//permite el enfoque con Tab
            }
            HabBotLim();//Llama metodo
            HabBotIng();//Llama metodo
        }

        private void CBPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBPro.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                CBCom.TabStop = true;//permite el enfoque con Tab
                CBPro.TabStop = false;//no permite el enfoque con Tab
                CargaCBCom();//Llama metodo
            }
            else//Si no
            {
                CBPro.TabStop = false;//no permite el enfoque con Tab
                CBCom.TabStop = true;//permite el enfoque con Tab
            }
            HabBotLim();//Llama metodo
            HabBotIng();//Llama metodo
        }

        private void CBCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCom.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextDire.TabStop = true;//permite el enfoque con Tab
                CBCom.TabStop = false;//no permite el enfoque con Tab
            }
            else//Si no
            {
                TextDire.TabStop = false;//no permite el enfoque con Tab
                CBCom.TabStop = true;//permite el enfoque con Tab
            }
            HabBotLim();//Llama metodo
            HabBotIng();//Llama metodo
        }

        private void TextDire_TextChanged(object sender, EventArgs e)
        {
            if (TextDire.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextTel.TabStop = true;//permite el enfoque con Tab
                TextDire.TabStop = false;//no permite el enfoque con Tab
            }
            else//Si no
            {
                TextTel.TabStop = false;//no permite el enfoque con Tab
                TextDire.TabStop = true;//permite el enfoque con Tab
            }
            HabBotLim();//Llama metodo
            HabBotIng();//Llama metodo
        }

        private void TextTel_TextChanged(object sender, EventArgs e)
        {
            if (TextTel.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextEma.TabStop = true;//permite el enfoque con Tab
                TextTel.TabStop = false;//no permite el enfoque con Tab
            }
            else//Si no
            {
                TextEma.TabStop = false;//no permite el enfoque con Tab
                TextTel.TabStop = true;//permite el enfoque con Tab
            }
            HabBotLim();//Llama metodo
            HabBotIng();//Llama metodo
        }

        private void TextEma_TextChanged(object sender, EventArgs e)
        {
            if (TextEma.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextGir.TabStop = true;//permite el enfoque con Tab
                TextEma.TabStop = false;//no permite el enfoque con Tab
            }
            else
            {
                TextGir.TabStop = false;//no permite el enfoque con Tab
                TextEma.TabStop = true;//permite el enfoque con Tab
            }
            HabBotLim();//Llama metodo
            HabBotIng();//Llama metodo
        }

        private void TextGir_TextChanged(object sender, EventArgs e)
        {
            if (TextGir.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextGir.TabStop = false;//no permite el enfoque con Tab
            }
            else//Si no
            {
                TextGir.TabStop = true;//permite el enfoque con Tab
            }
            HabBotLim();//Llama metodo
            HabBotIng();//Llama metodo 
        }

        private void ButLim_Click(object sender, EventArgs e)
        {
            TextRut.Clear();//Limpia el texto
            TextNom.Clear();//Limpia el texto
            TextDire.Clear();//Limpia el texto
            TextTel.Clear();//Limpia el texto
            TextEma.Clear();//Limpia el texto
            TextGir.Clear();//Limpia el texto
            CBReg.DataSource = null;//Limpia ComboBox
            CBPro.DataSource = null;//Limpia ComboBox
            CBCom.DataSource = null;//Limpia ComboBox
            HabBotIng();//Llama metodo
        }

        private void ButIng_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//Muestra Mensaje
            string Mensaje = string.Empty; //Declara variable
            Ent.Nombre = TextNom.Text;//Le da el valor
            Ent.Rut = TextRut.Text;//Le da el valor
            Ent.IdCom = Convert.ToInt32(CBCom.SelectedValue);//Le da el valor
            Ent.Direccion = TextDire.Text;//Le da el valor
            Ent.Tel = TextTel.Text;//Le da el valor
            Ent.Email = TextEma.Text;//Le da el valor
            Ent.Giro = TextGir.Text;//Le da el valor
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                Respuesta<bool> resultado = NCliente.Ingresar(Ent);//Llama metodo

                if (resultado.estado)//Verifica si el estado de la respuesta indica éxito
                {
                    MessageBox.Show("Ingreso fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra Mensaje
                    ButLim.PerformClick();//Simula un clic en el boton
                }
                else//Si no
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
        }

        private void ButVol_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra la ventana
        }

        private void ButSal_Click(object sender, EventArgs e)
        {
            Application.Exit();//Cierra la aplicacion
        }
    }
}
