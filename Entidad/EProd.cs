using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EProd//Declara Clase
    {
        public int ValIdProd;//Declara Variable
        public String ValNombre;//Declara Variable
        public String ValFInc;//Declara Variable
        public String ValCInc;//Declara Variable
        public String ValCAct;//Declara Variable
        public String ValCArr;//Declara Variable
        public String ValTAct;//Declara Variable
        public String ValVArr;//Declara Variable

        public int IdProd//Declara Propiedad
        {
            get { return ValIdProd; } //Setter
            set { ValIdProd = value; } //Getter
        }

        public String Nombre//Declara Propiedad
        { 
            get { return ValNombre; }//Setter
            set { ValNombre = value; }//Getter
        }

        public String FInc//Declara Propiedad
        {
            get { return ValFInc; }//Setter
            set { ValFInc = value; }//Getter
        }
        public String CInc//Declara Propiedad
        {
            get { return ValCInc; }//Setter
            set { ValCInc = value; }//Getter
        }
        public String CAct//Declara Propiedad
        {
            get { return ValCAct; }//Setter
            set { ValCAct = value; }//Getter
        }
        public String CArr//Declara Propiedad
        {
            get { return ValCArr; }//Setter
            set { ValCArr = value; }//Getter
        }
        public String TAct//Declara Propiedad
        {
            get { return ValTAct; }//Setter
            set { ValTAct = value; }//Getter
        }
        public String VArr//Declara Propiedad
        {
            get { return ValVArr; }//Setter
            set { ValVArr = value; }//Getter
        }
    }
}
