using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsProjet1
{
    public class clsMaison
    {
        // variables qui vont stocker les valeurs des proprietes
        private string vNumero;
        private string vType;
        private string vModele;
        private string vProvince;
        private string vVille;
        private decimal vPrix;
        private Int16 vPieces;

        public clsMaison(string numero, string type, string modele, string province, string ville,decimal prix,Int16 pieces)
        {
            vNumero = numero;
            vType = type;
            vModele = modele;
            vProvince = province;
            vVille = ville;
            vPrix = prix;
            vPieces = pieces;
        }

        public clsMaison()
        {
            vNumero = vType = vModele = vProvince = vVille = "Non defini";
            vPieces = 0;
            vPrix = 0;
        }

        public string Numero
        {
            get { return vNumero; }
        }

        public string Type
        {
            get { return vType; }
            set { vType = value; }
        }

        public string Modele
        {
            get { return vModele; }
            set { vModele = value; }
        }
          public string Province
        {
            get { return vProvince; }
            set { vProvince = value; }
        }
          public string Ville
        {
            get { return vVille; }
            set { vVille = value; }
        }

        public decimal Prix
        {
            get { return vPrix; }
        }

        public Int16 Pieces
        {
            get { return vPieces; }
        }
        public void Inscrire()
        {
            throw new System.NotImplementedException();
        }

        public string Afficher()
        {
            string info = "Numero : " + vNumero + "\nType : " + vType +
                "\nModele : " + vModele + "\nProvince : " + vProvince + "\nVille : " + vVille + "\nPrix : " + vPrix;
            return info;
        }

      

    }
}
