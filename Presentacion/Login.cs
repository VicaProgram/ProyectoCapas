using Entidad;
using Negocio;
using System;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
//Arbol de proyecto
namespace Presentacion
{

    public partial class Login : Form //declara form
    {

        ELogin Ent = new ELogin(); //Declara un objeto
        public Login() //inicializa
        {
            InitializeComponent();
            ApplyModernStyles(this.Controls);
        }
        private void ApplyModernStyles(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button) (ctrl as Button).ApplyModernStyle();
                else if (ctrl is TextBox) (ctrl as TextBox).ApplyModernStyle();
                else if (ctrl is DataGridView) (ctrl as DataGridView).ApplyModernStyle();
                else if (ctrl is MenuStrip) (ctrl as MenuStrip).ApplyModernStyle();

                // Si el control contiene otros controles (ej: Panel, GroupBox)
                if (ctrl.HasChildren) ApplyModernStyles(ctrl.Controls);
            }
        }
        public void HabBotIng() //Declara metodo
        {
            if ((textBox1.Text.Trim() != "") && (textBox2.Text.Trim() != "")) //Verifica si los campos tienen escrito
            {
                button1.Enabled = true; //Habilita boton
            }
            else //Caso contrario
            {
                button1.Enabled = false; //Deshabilita boton
            }
        }
        private void Login_Load(object sender, EventArgs e) //evento
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//evento
        {
            HabBotIng(); //Llama al metodo
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//evento
        {
            HabBotIng(); //Llama al metodo
        }

        private void button2_Click(object sender, EventArgs e)//evento
        {
            Application.Exit(); //Cierra aplicacion
        }

        private void button1_Click(object sender, EventArgs e)//evento
        {
            string Nombre = textBox1.Text; //Declara Variable
            string Pass = textBox2.Text; //Declara Variable
            NLogin Neg = new NLogin(); //Declara objeto
            int IdUsu = Neg.IngSig(Nombre, Pass); //Llama metodo
            Configuracion.Ent = new ELogin() { IdUsu = IdUsu }; //Configuracion de id

            if (IdUsu != 0) //Si la id es distinta  de 0
            {
                MessageBox.Show("Inicio de sesión exitoso"); //Muestra mensaje
                Menu MP = new Menu(); //Crea objeto
                MP.Show(); //Muestra el form
                this.Hide(); //Cierra el login
            }
            else//sino
            {
                MessageBox.Show("Usuario o contraseña incorrectos"); //Muestra mensaje
            }
        }

    }

}
