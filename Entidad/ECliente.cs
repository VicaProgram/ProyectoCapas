using System;

namespace Entidad
{
    public class ECliente //Declara Clase
    {
        public int ValIdP_Cli; //Declara Variable
        public String ValNombre;  //Declara Variable
        public String ValRut;  //Declara Variable
        public int ValIdReg;  //Declara Variable
        public ELocReg ValReg;  //Declara Variable
        public int ValIdPro;  //Declara Variable
        public ELocPro ValPro;  //Declara Variable
        public int ValIdCom;  //Declara Variable
        public ELocCom ValCom;  //Declara Variable
        public String ValDireccion;  //Declara Variable
        public String ValTel;  //Declara Variable
        public String ValEmail;  //Declara Variable
        public String ValGiro;  //Declara Variable

        public int IdP_Cli //Declara Propiedad
        {
            get { return ValIdP_Cli; } //Setter
            set { ValIdP_Cli = value; } //Getter
        }

        public String Nombre //Declara Propiedad
        {
            get { return ValNombre; } //Setter
            set { ValNombre = value; } //Getter
        }

        public String Rut //Declara Propiedad
        {
            get { return ValRut; } //Setter
            set { ValRut = value; } //Getter
        }

        public int IdReg //Declara Propiedad
        {
            get { return ValIdReg; } //Setter
            set { ValIdReg = value; } //Getter
        }
        public ELocReg Reg //Declara Propiedad
        {
            get { return ValReg; } //Setter
            set { ValReg = value; } //Getter
        }
        public int IdPro //Declara Propiedad
        {
            get { return ValIdPro; } //Setter
            set { ValIdPro = value; } //Getter
        }

        public ELocPro Pro //Declara Propiedad
        {
            get { return ValPro; } //Setter
            set { ValPro = value; } //Getter
        }
        public int IdCom //Declara Propiedad
        {
            get { return ValIdCom; } //Setter
            set { ValIdCom = value; } //Getter
        } 

        public ELocCom Com //Declara Propiedad
        {
            get { return ValCom; } //Setter
            set { ValCom = value; } //Getter
        }

        public String Direccion //Declara Propiedad
        {
            get { return ValDireccion; } //Setter
            set { ValDireccion = value; } //Getter
        }

        public String Tel //Declara Propiedad
        {
            get { return ValTel; } //Setter
            set { ValTel = value; } //Getter
        }

        public String Email //Declara Propiedad
        {
            get { return ValEmail; }//Setter
            set { ValEmail = value; } //Getter
        }

        public String Giro //Declara Propiedad
        {
            get { return ValGiro; } //Setter
            set { ValGiro = value; } //Getter
        }
    }
}