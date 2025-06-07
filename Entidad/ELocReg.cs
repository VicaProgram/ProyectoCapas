using System;

namespace Entidad
{
    public class ELocReg
    {
        public int ValIdReg; //Declara Variable
        public String ValNombre; //Declara Variable

        public int IdReg //Declara Propiedad
        {
            get { return ValIdReg; } //Setter
            set { ValIdReg = value; } //Getter
        }

        public String Nombre //Declara Propiedad
        {
            get { return ValNombre; } //Setter
            set { ValNombre = value; } //Getter
        }
    }
}