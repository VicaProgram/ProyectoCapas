using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Application = System.Windows.Forms.Application;
//Arbol de proyecto
namespace Presentacion.Producto
{
    public partial class PProd_Ing : Form //Declara el form
    {
        EProd Ent = new EProd();//Declara objeto
        NProd NegProd = new NProd();//Declara objeto
        public PProd_Ing() //Declara Metodo
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
        public void HabBotIng() // Habilita Boton
        {
            if ((TextNom.Text.Trim() != "") && (TextFeIn.Text.Trim() != "") && (TextCA.Text.Trim() != "") && (TextCAR.Text.Trim() != "") && (TextTA.Text.Trim() != "") && (TextVAPU.Text.Trim() != "")) // Verifica si el campo de entrada no está vacío
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
            if ((TextNom.Text.Trim() != "") && (TextFeIn.Text.Trim() != "") && (TextCA.Text.Trim() != "") && (TextCAR.Text.Trim() != "") && (TextTA.Text.Trim() != "") && (TextVAPU.Text.Trim() != "")) // Verifica si el campo de entrada no está vacío
            {
                ButLim.Enabled = true;// Habilita el botón
            }
            else//Sino
            {
                ButLim.Enabled = false;// Deshabilita el botón
            }
        }
        private void TextNom_TextChanged(object sender, EventArgs e) //Declara evento
        {
            if (TextNom.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextNom.TabStop = true;//permite el enfoque con Tab
                TextFeIn.TabStop = false; //no permite el enfoque con Tab
            }
            else//Si no
            {
                TextNom.TabStop = false;//no permite el enfoque con Tab
                TextFeIn.TabStop = true;//permite el enfoque con Tab
            }
            HabBotIng();//LLama metodo
        }

        private void TextFeIn_TextChanged(object sender, EventArgs e)//Declara evento
        {
            if (TextFeIn.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextFeIn.TabStop = true;//permite el enfoque con Tab
                TextCA.TabStop = false; //no permite el enfoque con Tab
            }
            else//Si no
            {
                TextFeIn.TabStop = false;//no permite el enfoque con Tab
                TextCA.TabStop = true;//permite el enfoque con Tab
            }
            HabBotIng();//LLama metodo
        }

        private void TextCA_TextChanged(object sender, EventArgs e)//Declara evento
        {
            if (TextCA.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextCA.TabStop = true;//permite el enfoque con Tab
                TextCAR.TabStop = false; //no permite el enfoque con Tab
            }
            else//Si no
            {
                TextCA.TabStop = false;//no permite el enfoque con Tab
                TextCAR.TabStop = true;//permite el enfoque con Tab
            }
            HabBotIng();//LLama metodo
        }

        private void TextCAR_TextChanged(object sender, EventArgs e)//Declara evento
        {
            if (TextCAR.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextCAR.TabStop = true;//permite el enfoque con Tab
                TextTA.TabStop = false; //no permite el enfoque con Tab
            }
            else//Si no
            {
                TextCAR.TabStop = false;//no permite el enfoque con Tab
                TextTA.TabStop = true;//permite el enfoque con Tab
            }
            HabBotIng();//LLama metodo
        }

        private void TextTA_TextChanged(object sender, EventArgs e)//Declara evento
        {
            if (TextTA.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextTA.TabStop = true;//permite el enfoque con Tab
                TextVAPU.TabStop = false; //no permite el enfoque con Tab
            }
            else//Si no
            {
                TextTA.TabStop = false;//no permite el enfoque con Tab
                TextVAPU.TabStop = true;//permite el enfoque con Tab
            }
            HabBotIng();//LLama metodo
        }

        private void TextVAPU_TextChanged(object sender, EventArgs e)//Declara evento
        {
            if (TextVAPU.Text.Trim() != "")// Verifica si el campo de entrada no está vacío
            {
                TextVAPU.TabStop = true;//permite el enfoque con Tab
            }
            else//Si no
            {
                TextVAPU.TabStop = false;//no permite el enfoque con Tab
            }
            HabBotIng();//LLama metodo
        }

        private void ButIng_Click(object sender, EventArgs e)//Declara evento
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);//Muestra Mensaje
            string Mensaje = string.Empty; //Declara variable
            Ent.Nombre = TextNom.Text;//Le da el valor
            Ent.FInc = TextFeIn.Text;//Le da el valor
            Ent.CInc = TextCA.Text;//Le da el valor
            Ent.CArr = TextCAR.Text;//Le da el valor
            Ent.TAct = TextTA.Text;//Le da el valor
            Ent.VArr = TextVAPU.Text;//Le da el valor
            Ent.CAct = TextCA.Text;
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                Respuesta<bool> resultado = NProd.Ingresar(Ent);//Llama metodo

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

        private void ButVol_Click(object sender, EventArgs e)//Declara evento
        {
            this.Close();//Cierra la ventana
        }

        private void ButLim_Click(object sender, EventArgs e)//Declara evento
        {
            TextNom.Clear();//Limpia el textbox
            TextFeIn.Clear();//Limpia el textbox
            TextCA.Clear();//Limpia el textbox
            TextCAR.Clear();//Limpia el textbox
            TextTA.Clear();//Limpia el textbox
            TextVAPU.Clear();//Limpia el textbox
            HabBotIng();//Llama metodo
        }

        private void ButSal_Click(object sender, EventArgs e)//Declara evento
        {
            Application.Exit();//Cierra la aplicacion
        }

        private void PProd_Ing_Load(object sender, EventArgs e)//Declara evento
        {
            TextFeIn.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void TextNom_KeyPress(object sender, KeyPressEventArgs e)//Declara evento
        {
            if (char.IsDigit(e.KeyChar))// Verifica si la tecla presionada es un dígito.
            {
                e.Handled = true;// Cancela la entrada.
                MessageBox.Show("Solo se permiten letras.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);// Muestra un mensaje.
            }
        }

        private void TextFeIn_KeyPress(object sender, KeyPressEventArgs e)//Declara evento
        {
            if (char.IsLetter(e.KeyChar))// Verifica si la tecla presionada es una letra.
            {
                e.Handled = true;// Cancela la entrada.
                MessageBox.Show("Solo se permiten numeros.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);// Muestra un mensaje.
            }
        }

        private void TextCA_KeyPress(object sender, KeyPressEventArgs e)//Declara evento
        {
            if (char.IsLetter(e.KeyChar))// Verifica si la tecla presionada es una letra.
            {
                e.Handled = true;// Cancela la entrada.
                MessageBox.Show("Solo se permiten numeros.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);// Muestra un mensaje.
            }
        }

        private void TextCAR_KeyPress(object sender, KeyPressEventArgs e)//Declara evento
        {
            if (char.IsLetter(e.KeyChar))// Verifica si la tecla presionada es una letra.
            {
                e.Handled = true;// Cancela la entrada.
                MessageBox.Show("Solo se permiten numeros.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);// Muestra un mensaje.
            }
        }

        private void TextTA_KeyPress(object sender, KeyPressEventArgs e)//Declara evento
        {
            if (char.IsLetter(e.KeyChar))// Verifica si la tecla presionada es una letra.
            {
                e.Handled = true;// Cancela la entrada.
                MessageBox.Show("Solo se permiten numeros.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);// Muestra un mensaje.
            }
        }

        private void TextVAPU_KeyPress(object sender, KeyPressEventArgs e)//Declara evento
        {
            if (char.IsLetter(e.KeyChar))// Verifica si la tecla presionada es una letra.
            {
                e.Handled = true;// Cancela la entrada.
                MessageBox.Show("Solo se permiten numeros.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);// Muestra un mensaje.
            }
        }
    }
}
