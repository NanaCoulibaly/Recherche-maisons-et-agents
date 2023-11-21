using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsProjet1
{
    public class clsListeMaison
    {
        //declaration de collection pour stocker les agents
        Dictionary<string, clsMaison> maListe;

        public clsListeMaison()
        {
            maListe = new Dictionary<string, clsMaison>();
        }

        public int Quantite
        {
            get { return maListe.Count; }
        }

        public Dictionary<string, clsMaison>.ValueCollection Elements
        {
            get { return maListe.Values; }
        }

        public bool Ajouter(clsMaison unemaison)
        {
            if (maListe.ContainsKey(unemaison.Numero) == false)
            {
                maListe.Add(unemaison.Numero, unemaison);
                return true;
            }
            else { return false; }

        }

        public bool Supprimer(string numero)
        {
            return maListe.Remove(numero);
        }

       

        public bool Louer(string numero)
        {
            throw new System.NotImplementedException();
        }

        public bool Acheter(clsMaison msn)
        {
            throw new System.NotImplementedException();
        }

        public bool Vendre(string numero)
        {
            throw new System.NotImplementedException();
        }

        public clsMaison Trouver(string numero)
        {
            if (maListe.ContainsKey(numero) == true)
            {
                return maListe[numero];
            }
            else { return null; }
        }

        public bool Existe(string numero)
        {
            return maListe.ContainsKey(numero);
        }

        public string Afficher()
        {
            string info = "\n---Liste Clients ---\n";
            foreach (clsMaison msn in maListe.Values)
            {
                info += msn.Afficher() + "\n";
            }
            return info;
        }

    }
}
