using Entidad;
using Negocio;
using Presentacion.Cliente;
using Presentacion.Localidad;
using Presentacion.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Presentacion.Arriendo
{
    public partial class PArr_Ing : Form
    {
        public int contador = 1; //Declara variable
        public int con1=0; //Declara variable
        EArr Ent = new EArr();//Declara objeto
        EArr_Det arrDet = new EArr_Det();
        EArr_VUn arrVUn = new EArr_VUn();
        EArr_Pro arrPro = new EArr_Pro();
        NArr_Det narrDet = new NArr_Det();
        NArr_Pro narrPro = new NArr_Pro();
        NArr_VUn narrVUn = new NArr_VUn();
        public PArr_Ing()
        {
            InitializeComponent();
            ApplyModernStyles(this.Controls);
            Bus_Cli.Enabled = true;
            Bus_Prod.Enabled = false;
            Del_Ul_Prod.Enabled = false;
        }
        private void ApplyModernStyles(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is System.Windows.Forms.Button) (ctrl as System.Windows.Forms.Button).ApplyModernStyle();
                else if (ctrl is System.Windows.Forms.TextBox) (ctrl as System.Windows.Forms.TextBox).ApplyModernStyle();
                else if (ctrl is DataGridView) (ctrl as DataGridView).ApplyModernStyle();
                else if (ctrl is MenuStrip) (ctrl as MenuStrip).ApplyModernStyle();
                if (ctrl.HasChildren) ApplyModernStyles(ctrl.Controls);
            }
        }

        private void Bus_Cli_Click(object sender, EventArgs e)
        {
            PCli_Con ver = new PCli_Con();//Crea una nueva instancia
            ver.FormularioPadre = this; // Pasa la instancia
            ver.BtnSelect.Visible = true; //Muestra Boton de volver
            ver.Show();
        }

        private void Bus_Prod_Click(object sender, EventArgs e)
        {
            if (con1 < contador )
            {
                con1++;
            }
            if (contador==10)
            {
                Bus_Prod.Enabled = false;
            }
            PProd_Con ver = new PProd_Con();//Crea una nueva instancia
            ver.FormularioPadre = this; // Pasa la instancia
            ver.BtnSelect.Visible = true; //Muestra Boton de volver
            ver.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab==tabPage1)
            {
                Bus_Cli.Enabled = true;
                Bus_Prod.Enabled = false;
                Del_Ul_Prod.Enabled = false;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                Bus_Cli.Enabled = false;
                Bus_Prod.Enabled = true;
                Del_Ul_Prod.Enabled = true;
            }
        }

        private void TxtC1_TextChanged(object sender, EventArgs e)
        {
            if (TxtC1.Text=="")
            {
                TxtC1.Text="0";
            }
            double Val = Convert.ToDouble(TxtC1.Text,CultureInfo.InvariantCulture);
            double Val2 = Convert.ToDouble(TxtVU1.Text,CultureInfo.InvariantCulture);
            double resultado = Val * Val2; //Multiplica Cantidad por Valor Unitario
            TextVT1.Text = resultado.ToString("C", new CultureInfo("es-CL")); //Muestra el Valor Unitario en formato moneda
        }

        private void Del_Ul_Prod_Click(object sender, EventArgs e)
        {
            int i = con1;
            string nombreProd = "TxtProd" + i;
            string nombreIdProd = "TextIdPro" + i;
            string nombreCant = "TxtC" + i;
            string nombreVU = "TxtVU" + i;
            string nombreVT = "TextVT" + i;
            Control[] controlIdProd = Controls.Find(nombreIdProd, true); //Busca el control por nombre
            Control[] controlVT = Controls.Find(nombreVT, true); //Busca el control por nombre
            Control[] controlCant = Controls.Find(nombreCant, true); 
            Control[] controlProd = Controls.Find(nombreProd, true);
            Control[] controlVU = Controls.Find(nombreVU, true);
            if (controlIdProd.Length > 0 && controlIdProd[0] is TextBox)
                ((TextBox)controlIdProd[0]).Clear();

            if (controlProd.Length > 0 && controlProd[0] is TextBox)
                ((TextBox)controlProd[0]).Clear();

            if (controlVT.Length > 0 && controlVT[0] is TextBox)
                ((TextBox)controlVT[0]).Clear();

            if (controlCant.Length > 0 && controlCant[0] is TextBox)
                ((TextBox)controlCant[0]).Clear();

            if (controlVU.Length > 0 && controlVU[0] is TextBox)
                ((TextBox)controlVU[0]).Clear();
            if (con1>1)
            {
                con1--; //Decrementa el contador
            }
            if (contador > 1)
            {
                contador--; //Decrementa el contador
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

        private void BtnIng_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("¿Está seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            string Mensaje = string.Empty;
                Ent.IdP_Cli = Convert.ToInt32(TextIdCli.Text);
                Ent.Fech = TxtFech.Text;
                Ent.SubTotal = TextSubTo.Text;
                Ent.DescuentoTotal = TextDescuento.Text;
                Ent.IVA_Total = TextIVA.Text;
                Ent.TotalFinal = TextTotal.Text;

            arrPro.IdP_Prod1 = Convert.ToInt32(TextIdProd1.Text);
            arrPro.IdP_Prod2 = Convert.ToInt32(TextIdProd2.Text);
            arrPro.IdP_Prod3 = Convert.ToInt32(TextIdProd3.Text);
            arrPro.IdP_Prod4 = Convert.ToInt32(TextIdProd4.Text);
            arrPro.IdP_Prod5 = Convert.ToInt32(TextIdProd5.Text);
            arrPro.IdP_Prod6 = Convert.ToInt32(TextIdProd6.Text);
            arrPro.IdP_Prod7 = Convert.ToInt32(TextIdProd7.Text);
            arrPro.IdP_Prod8 = Convert.ToInt32(TextIdProd8.Text);
            arrPro.IdP_Prod9 = Convert.ToInt32(TextIdProd9.Text);
            arrPro.IdP_Prod10 = Convert.ToInt32(TextIdProd10.Text);
            arrDet.DPr1 = TxtProd1.Text;
            arrDet.DPr2 = TxtProd2.Text;
            arrDet.DPr3 = TxtProd3.Text;
            arrDet.DPr4 = TxtProd4.Text;
            arrDet.DPr5 = TxtProd5.Text;
            arrDet.DPr6 = TxtProd6.Text;
            arrDet.DPr7 = TxtProd7.Text;
            arrDet.DPr8 = TxtProd8.Text;
            arrDet.DPr9 = TxtProd9.Text;
            arrDet.DPr10 = TxtProd10.Text;
            arrVUn.VUn1 = TxtVU1.Text;
            arrVUn.VUn2 = TxtVU2.Text;
            arrVUn.VUn3 = TxtVU3.Text;
            arrVUn.VUn5 = TxtVU5.Text;
            arrVUn.VUn6 = TxtVU6.Text;
            arrVUn.VUn7 = TxtVU7.Text;
            arrVUn.VUn8 = TxtVU8.Text;
            arrVUn.VUn9 = TxtVU9.Text;
            arrVUn.VUn10 = TxtVU10.Text;

            // 5. Procesar la acción según la selección del usuario
            if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultadoDet = NArr_Det.Ingresar(arrDet);
                Respuesta<bool> resultadoVUn = NArr_VUn.Ingresar(arrVUn);
                Respuesta<bool> resultadoPro = NArr_Pro.Ingresar(arrPro);

                if (resultadoDet.estado && resultadoVUn.estado && resultadoPro.estado)
                {
                    MessageBox.Show("Ingreso fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Ent.IdADet = narrDet.ObtenerUltimoId();
                    Ent.IdAVUn = narrVUn.ObtenerUltimoId();
                    Ent.IdAPro = narrPro.ObtenerUltimoId();
                    Respuesta<bool> resultadoArr = NArr.Ingresar(Ent);
                    if (resultadoArr.estado)
                    {
                        MessageBox.Show("Ingreso fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ButLim.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Error en el ingreso de datos", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (res == DialogResult.No)
            {
                ButVol.Focus();
            }
            else if (res == DialogResult.Cancel)
            {
                ButSal.Focus();
            }
        }

        private void PArr_Ing_Load(object sender, EventArgs e)
        {

        }
    }
}
