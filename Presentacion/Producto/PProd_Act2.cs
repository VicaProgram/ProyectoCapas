using Entidad;
using Negocio;
using Presentacion.Localidad;
using Presentacion.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Arbol del proyecto
namespace Presentacion.Producto
{
    public partial class PProd_Act2 : Form //Declara el form
    {
        EProd Ent = new EProd();//Declara objeto
        NProd NProd = new NProd();//Declara objeto
        public PProd_Act2() //Declara metodo
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

        public void Validar() //Declara metodo
        {
            if ((TextCArrF.Text.Trim() != TextCArrI.Text.Trim()) || (TextTActF.Text.Trim() != TextTActI.Text.Trim()))// Verifica si el campo de entrada no está vacío
            {

                ButMod.Enabled = true;// Habilita el botón
                LabelCArr.Enabled = false;// Deshabilita el Label
                LabelTAct.Enabled = false;// Deshabilita el Label
            }
            else
            {
                ButMod.Enabled = false;// Deshabilita el botón
                LabelCArr.Enabled = true;// Deshabilita el Label
                LabelTAct.Enabled = true;// Deshabilita el Label
            }
        }
        public void Cambio()//Declara metodo
        {
            LabelCArr.Enabled = true;// Habilita el Label
            LabelTAct.Enabled = true;// Habilita el Label
            TextCArrF.Enabled = false;// Deshabilita el TextBox
            TextTActF.Enabled = false;// Deshabilita el TextBox
            ButMod.Enabled = false;// Deshabilita el botón
        }

        private void ButVol_Click(object sender, EventArgs e) //Declara evento
        {
            PProd_Con ver = new PProd_Con(); //Declara objeto
            ver.ButMod.Visible = true; //Hece visible el boton
            this.Close(); //Cierra la ventana
        }

        private void ButSal_Click(object sender, EventArgs e)//Declara evento
        {
            Application.Exit();//Cierra la aplicacion
        }

        private void ButAnu_Click(object sender, EventArgs e)//Declara evento
        {
            TextCArrF.Text = TextCArrI.Text;//Le da el valor
            TextTActF.Text = TextTActI.Text;//Le da el valor
            Cambio();//Llama metodo
        }

        private void ButMod_Click(object sender, EventArgs e)//Declara evento
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //Muestra Mensaje
            string Mensaje = string.Empty; //Declara variable
            Ent.IdProd = Convert.ToInt32(TextIdProd.Text); //Le da el valor
            Ent.CArr = TextCArrF.Text;//Le da el valor
            Ent.TAct = TextTActF.Text;//Le da el valor
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                Respuesta<bool> resultado = NProd.Actualizar2(Ent);//Llama metodo
                if (resultado.estado)//Verifica si el estado de la respuesta indica éxito
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra Mensaje
                    TextCArrI.Text = TextCArrF.Text;//Le da el valor
                    TextTActI.Text = TextTActF.Text;//Le da el valor
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

        private void LabelCArr_Click(object sender, EventArgs e)//Declara evento
        {
            TextCArrF.Enabled = true; // Habilita el TextBox
        }

        private void TextCArrF_TextChanged(object sender, EventArgs e)//Declara evento
        {
            Validar(); //Llama metodo
        }

        private void LabelTAct_Click(object sender, EventArgs e)//Declara evento
        {
            TextTActF.Enabled = true; // Habilita el TextBox
        }

        private void TextTActF_TextChanged(object sender, EventArgs e)//Declara evento
        {
            Validar(); //Llama metodo
        }

        private void PProd_Act2_Load(object sender, EventArgs e)//Declara evento
        {

        }
    }
}
