//using Presentacion.Arriendo;
using Presentacion.Cliente;
using Presentacion.Producto;
using Presentacion.Localidad;
using Presentacion.Proveedor;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Entidad;
using Negocio;
using Presentacion.Arriendo;

//Arbol de proyecto
namespace Presentacion
{
    public partial class Menu : Form //declara form
    {
        private static ToolStripMenuItem MenuActivo = null; //Declara una variable
        private static Form FormularioActivo = null; //Declara una variable
        public Menu() //inicializa
        {
            InitializeComponent();
            ApplyModernStyles(this.Controls);
        }
        private void ApplyModernStyles(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is DataGridView) (ctrl as DataGridView).ApplyModernStyle();
                else if (ctrl is MenuStrip) (ctrl as MenuStrip).ApplyModernStyle();

                // Si el control contiene otros controles (ej: Panel, GroupBox)
                if (ctrl.HasChildren) ApplyModernStyles(ctrl.Controls);
            }
        }
        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario) //Declara metodo
        {
            if (MenuActivo != null) //Si es diferente nulo
            {
                MenuActivo.BackColor = Color.White; //Cambia color del fondo
            }
            menu.BackColor = Color.Silver; //Cambia color del fondo
            MenuActivo = menu; //Actualiza la variable
            if (FormularioActivo != null) //Verifica si hay un formulario activo
            {
                FormularioActivo.Close(); //Cierra el formulario
            }
            FormularioActivo = formulario; //Asigna el nuevo formulario
            formulario.TopLevel = false; //Hace que se muestre dentro del formulario
            formulario.FormBorderStyle = FormBorderStyle.None; //Elimina el borde del formulario
            formulario.Dock = DockStyle.Fill; //Llena cualquier espacio
            formulario.BackColor = Color.White; //Cambia color del fondo
            panel1.Controls.Add(formulario); //Agrega el formulario al panel 
            formulario.Show();//Muestra el formulario
        }
        private void toolStripMenuItem12_Click(object sender, EventArgs e)//evento
        {
            PReg ver = new PReg();//Crea una nueva instancia
            AbrirFormulario((ToolStripMenuItem)sender, new PReg()); //Llama al método AbrirFormulario
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)//evento
        {
            Application.Exit();//Cierra la aplicacion
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)//evento
        {
            PCom ver = new PCom();//Crea una nueva instancia
            AbrirFormulario((ToolStripMenuItem)sender, new PCom());//Llama al método AbrirFormulario
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)//evento
        {
            PPro ver = new PPro();//Crea una nueva instancia
            AbrirFormulario((ToolStripMenuItem)sender, new PPro());//Llama al método AbrirFormulario
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PProv_Ing ver = new PProv_Ing();//Crea una nueva instancia
            AbrirFormulario((ToolStripMenuItem)sender, new PProv_Ing());//Llama al método AbrirFormulario
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PProv_Con ver = new PProv_Con();//Crea una nueva instancia
            ver.ButMod.Visible = true; //Muestra Boton
            AbrirFormulario((ToolStripMenuItem)sender, ver);//Llama al método AbrirFormulario
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PProv_Con ver = new PProv_Con();//Crea una nueva instancia
            ver.ButEli.Visible = true; //Muestra Boton
            AbrirFormulario((ToolStripMenuItem)sender, ver);//Llama al método AbrirFormulario
        }

        private void ingresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PCli_Ing ver = new PCli_Ing();//Crea una nueva instancia
            AbrirFormulario((ToolStripMenuItem)sender, new PCli_Ing());//Llama al método AbrirFormulario
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PCli_Con ver = new PCli_Con();//Crea una nueva instancia
            ver.ButMod.Visible = true; //Muestra Boton
            AbrirFormulario((ToolStripMenuItem)sender, ver);//Llama al método AbrirFormulario
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PCli_Con ver = new PCli_Con();//Crea una nueva instancia
            ver.ButEli.Visible = true; //Muestra Boton
            AbrirFormulario((ToolStripMenuItem)sender, ver);//Llama al método AbrirFormulario
        }

        private void ingresarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PProd_Ing ver = new PProd_Ing();//Crea una nueva instancia
            AbrirFormulario((ToolStripMenuItem)sender, new PProd_Ing());//Llama al método AbrirFormulario
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PProd_Con ver = new PProd_Con();//Crea una nueva instancia
            ver.ButMod.Visible = true; //Muestra Boton
            ver.ButMod2.Visible = true; //Muestra Boton
            AbrirFormulario((ToolStripMenuItem)sender, ver);//Llama al método AbrirFormulario
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PProd_Con ver = new PProd_Con();//Crea una nueva instancia
            ver.ButEli.Visible = true; //Muestra Boton
            AbrirFormulario((ToolStripMenuItem)sender, ver);//Llama al método AbrirFormulario
        }
        private void ingresarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PArr_Ing ver = new PArr_Ing();//Crea una nueva instancia
            AbrirFormulario((ToolStripMenuItem)sender, new PArr_Ing());//Llama al método AbrirFormulario
        }
    }
}
