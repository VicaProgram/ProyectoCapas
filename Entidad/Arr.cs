using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EArr
    {
        public int ValIdArr;
        public int ValIdP_Cli;
        public ECliente ValCli;
        public String ValFech;
        public int ValIdAPro;
        public EArr_Pro ValAPro;
        public int ValIdADet;
        public EArr_Det ValADet;
        public int ValIdAVUn;
        public EArr_VUn ValAVUn;
        public String SubTo;
        public String Descuento;
        public String IVA;
        public String Total;

        public int IdArr
        {
            get { return ValIdArr; }
            set { ValIdArr = value; }
        }
        public int IdP_Cli
        {
            get { return ValIdP_Cli; }
            set { ValIdP_Cli = value; }
        }
        public ECliente Cli
        {
            get { return ValCli; }
            set { ValCli = value; }
        }
        public String Fech
        {
            get { return ValFech; }
            set { ValFech = value; }
        }
        public int IdAPro
        {
            get { return ValIdAPro; }
            set { ValIdAPro = value; }
        }
        public EArr_Pro APro
        {
            get { return ValAPro; }
            set { ValAPro = value; }
        }
        public int IdADet
        {
            get { return ValIdADet; }
            set { ValIdADet = value; }
        }
        public EArr_Det ADet
        {
            get { return ValADet; }
            set { ValADet = value; }
        }
        public int IdAVUn
        {
            get { return ValIdAVUn; }
            set { ValIdAVUn = value; }
        }
        public EArr_VUn AVUn
        {
            get { return ValAVUn; }
            set { ValAVUn = value; }
        }
        public String SubTotal
        {
            get { return SubTo; }
            set { SubTo = value; }
        }
        public String DescuentoTotal
        {
            get { return Descuento; }
            set { Descuento = value; }
        }
        public String IVA_Total
        {
            get { return IVA; }
            set { IVA = value; }
        }
        public String TotalFinal
        {
            get { return Total; }
            set { Total = value; }
        }

    }
}
