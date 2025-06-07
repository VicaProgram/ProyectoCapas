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
    public partial class PProd_Act : Form //Declara el form
    {
        EProd Ent = new EProd();//Declara objeto
        NProd NProd = new NProd();//Declara objeto
        public PProd_Act() //Declara metodo
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
            if ((TextNomF.Text.Trim() != TextNomI.Text.Trim()) || (TextFIncF.Text.Trim() != TextFIncI.Text.Trim()) || (TextCIncF.Text.Trim() != TextCIncI.Text.Trim()) || (TextCActF.Text.Trim() != TextCActI.Text.Trim()) || (TextCArrF.Text.Trim() != TextCArrI.Text.Trim()) || (TextTActF.Text.Trim() != TextTActI.Text.Trim()) || (TextVArrF.Text.Trim() != TextVArrI.Text.Trim()))// Verifica si el campo de entrada no está vacío
            {

                ButMod.Enabled = true;// Habilita el botón
                LabelNom.Enabled = false;// Deshabilita el Label
                LabelFInc.Enabled = false;// Deshabilita el Label
                LabelCInc.Enabled = false;// Deshabilita el Label
                LabelCAct.Enabled = false;// Deshabilita el Label
                LabelCArr.Enabled = false;// Deshabilita el Label
                LabelTAct.Enabled = false;// Deshabilita el Label
                LabelVArr.Enabled = false;// Deshabilita el Label
            }
            else
            {
                ButMod.Enabled = false;// Deshabilita el botón
                LabelNom.Enabled = true;// Habilita el Label
                LabelFInc.Enabled = true;// Deshabilita el Label
                LabelCInc.Enabled = true;// Deshabilita el Label
                LabelCAct.Enabled = true;// Deshabilita el Label
                LabelCArr.Enabled = true;// Deshabilita el Label
                LabelTAct.Enabled = true;// Deshabilita el Label
                LabelVArr.Enabled = true;// Deshabilita el Label
            }
        }
        public void Cambio()//Declara metodo
        {
            LabelNom.Enabled = true;// Habilita el Label
            LabelFInc.Enabled = true;// Habilita el Label
            LabelCInc.Enabled = true;// Habilita el Label
            LabelCAct.Enabled = true;// Habilita el Label
            LabelCArr.Enabled = true;// Habilita el Label
            LabelTAct.Enabled = true;// Habilita el Label
            LabelVArr.Enabled=true;// Habilita el Label
            TextNomF.Enabled = false;// Deshabilita el TextBox
            TextFIncF.Enabled = false;// Deshabilita el TextBox
            TextCIncF.Enabled = false;// Deshabilita el TextBox
            TextCActF.Enabled = false;// Deshabilita el TextBox
            TextCArrF.Enabled = false;// Deshabilita el TextBox
            TextTActF.Enabled = false;// Deshabilita el TextBox
            TextVArrF.Enabled = false;// Deshabilita el TextBox
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
            TextNomF.Text = TextNomI.Text;//Le da el valor
            TextFIncF.Text = TextFIncI.Text;//Le da el valor
            TextCIncF.Text= TextCIncI.Text;//Le da el valor
            TextCActF.Text = TextCActI.Text;//Le da el valor
            TextCArrF.Text = TextCArrI.Text;//Le da el valor
            TextTActF.Text= TextTActI.Text;//Le da el valor
            TextVArrF.Text= TextVArrI.Text;//Le da el valor
            Cambio();//Llama metodo
        }

        private void ButMod_Click(object sender, EventArgs e)//Declara evento
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //Muestra Mensaje
            string Mensaje = string.Empty; //Declara variable
            Ent.IdProd = Convert.ToInt32(TextIdProd.Text); //Le da el valor
            Ent.Nombre = TextNomF.Text;//Le da el valor
            Ent.FInc = TextFIncF.Text;//Le da el valor
            Ent.CInc = TextCIncF.Text;//Le da el valor
            Ent.CAct = TextCActF.Text;//Le da el valor
            Ent.CArr = TextCArrF.Text;//Le da el valor
            Ent.TAct = TextTActF.Text;//Le da el valor
            Ent.VArr = TextVArrF.Text;//Le da el valor
            if (res == DialogResult.Yes)//Verifica si el usuario seleccionó "Sí" en el cuadro de diálogo.
            {
                Respuesta<bool> resultado = NProd.Actualizar(Ent);//Llama metodo
                if (resultado.estado)//Verifica si el estado de la respuesta indica éxito
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);//Muestra Mensaje
                    TextNomI.Text = TextNomF.Text;//Le da el valor
                    TextFIncI.Text = TextFIncF.Text;//Le da el valor
                    TextCIncI.Text = TextCIncF.Text;//Le da el valor
                    TextCActI.Text = TextCActF.Text;//Le da el valor
                    TextCArrI.Text = TextCArrF.Text;//Le da el valor
                    TextTActI.Text = TextTActF.Text;//Le da el valor
                    TextVArrI.Text = TextVArrF.Text;//Le da el valor
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

        private void LabelNom_Click(object sender, EventArgs e)//Declara evento
        {
            TextNomF.Enabled = true; // Habilita el TextBox
        }

        private void TextNomF_TextChanged(object sender, EventArgs e)//Declara evento
        {
            Validar(); //Llama metodo
        }

        private void LabelFInc_Click(object sender, EventArgs e)//Declara evento
        {
            TextFIncF.Enabled = true; // Habilita el TextBox
        }

        private void TextFIncF_TextChanged(object sender, EventArgs e)//Declara evento
        {
            Validar(); //Llama metodo
        }

        private void LabelCInc_Click(object sender, EventArgs e)//Declara evento
        {
            TextCIncF.Enabled = true; // Habilita el TextBox
        }

        private void TextCIncF_TextChanged(object sender, EventArgs e)//Declara evento
        {
            Validar(); //Llama metodo
        }

        private void LabelCAct_Click(object sender, EventArgs e)//Declara evento
        {
            TextCActF.Enabled = true; // Habilita el TextBox
        }

        private void TextCActF_TextChanged(object sender, EventArgs e)//Declara evento
        {
            Validar(); //Llama metodo
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

        private void LabelVArr_Click(object sender, EventArgs e)//Declara evento
        {
            TextVArrF.Enabled = true; // Habilita el TextBox
        }

        private void TextVArrF_TextChanged(object sender, EventArgs e)//Declara evento
        {
            Validar(); //Llama metodo
        }

        private void PProd_Act_Load(object sender, EventArgs e)//Declara evento
        {

        }
    }
}
