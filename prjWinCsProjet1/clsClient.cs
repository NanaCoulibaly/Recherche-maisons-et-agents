using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsProjet1
{
    public class clsClient
    {
        private string vNumero;
        private string vNom;
        private string vAdresse;
        private string vPhone;
        private clsListeMaison vMaison;


        public clsClient()
        {
            vNumero = vNom = "Non defini";
            vMaison = new clsListeMaison();
        }

        public clsClient(string numero, string nom,string adresse,string phone, clsListeMaison maisons)
        {
            vNumero = numero;
            vNom = nom;
            vAdresse = adresse;
            vPhone = phone;
            vMaison = maisons;
        }

        public clsClient(string numero, string nom,string adresse,string phone)
        {
            vNumero = numero;
            vNom = nom;
            vAdresse = adresse;
            vPhone = phone;
            vMaison = new clsListeMaison();
        }

        public string Numero
        {
            get { return vNumero; }
        }

        public string Nom
        {
            get { return vNom; }
            set { vNom = value; }
        }

        public string Phone
        {
            get { return vPhone; }
            //   set { vPhone = value; }
        }

        public string Adresse
        {
            get { return vAdresse; }
            set { vAdresse = value; }
        }

        public clsListeMaison Maison
        {
            get { return vMaison; }
            set { vMaison = value; }
        }

        public void Inscrire()
        {
            throw new System.NotImplementedException();
        }

        public string Afficher()
        {
            string info = "Numero : " + vNumero + "\nNom : " + vNom +
                "\nAdresse : " + vAdresse +
                "\nMaisons : " + vMaison.Afficher();
            return info;
        }
    }
}
