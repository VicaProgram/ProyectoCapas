using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EUsua
    {
        public int ValIdUsu; //Declara Variable
        public String ValNombre; //Declara Variable
        public String ValPass; //Declara Variable

        public int IdUsu //Declara Propiedad
        {
            get { return ValIdUsu; } //Setter
            set { ValIdUsu = value; } //Getter
        }

        public String Nombre //Declara Propiedad
        {
            get { return ValNombre; } //Setter
            set { ValNombre = value; } //Getter
        }

        public String Pass //Declara Propiedad
        {
            get { return ValPass; } //Setter
            set { ValPass = value; } //Getter
        }
    }
}
