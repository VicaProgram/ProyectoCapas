using System;

namespace Entidad
{
    public class ELocCom
    {
        public int ValIdCom; //Declara Variable
        public String ValNombre; //Declara Variable
        public int ValIdPro; //Declara Variable
        public ELocPro ValPro; //Declara Variable
        public int ValIdReg; //Declara Variable
        public ELocReg ValReg; //Declara Variable

        public int IdCom //Declara Propiedad
        {
            get { return ValIdCom; } //Setter
            set { ValIdCom = value; } //Getter
        }
        public String Nombre //Declara Propiedad
        {
            get { return ValNombre; } //Setter
            set { ValNombre = value; } //Getter
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
    }
}