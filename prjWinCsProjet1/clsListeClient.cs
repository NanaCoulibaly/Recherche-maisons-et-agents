using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsProjet1
{
    public class clsListeClient
    {
        //declaration de collection pour stocker les agents
        Dictionary<string, clsClient> maListe;

        public clsListeClient()
        {
            maListe = new Dictionary<string, clsClient>();
        }

        public int Quantite
        {
            get { return maListe.Count; }
        }

        public Dictionary<string, clsClient>.ValueCollection Elements
        {
            get { return maListe.Values; }
        }

        public bool Ajouter(clsClient unClient)
        {
            if (maListe.ContainsKey(unClient.Numero) == false)
            {
                maListe.Add(unClient.Numero, unClient);
                return true;
            }
            else { return false; }

        }

        public bool Supprimer(string numero)
        {
            return maListe.Remove(numero);
        }

        public clsClient Trouver(string numero)
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
            string info = "\n---Liste Maisons ---\n";
            foreach (clsClient msn in maListe.Values)
            {
                info += msn.Afficher() + "\n";
            }
            return info;
        }
    }
}
