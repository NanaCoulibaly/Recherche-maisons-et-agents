using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsProjet1
{
    public class clsListeAgent
    {
        //declaration de collection pour stocker les agents
        Dictionary<string, clsAgent> maListe;

        public clsListeAgent()
        {
            maListe = new Dictionary<string, clsAgent>();
        }

        public int Quantite
        {
            get { return maListe.Count; }
        }

        public Dictionary<string, clsAgent>.ValueCollection Elements
        {
            get { return maListe.Values; }
        }

        public bool Ajouter(clsAgent unagent)
        {
            if (maListe.ContainsKey(unagent.Numero) == false)
            {
                maListe.Add(unagent.Numero, unagent);
                return true;
            }
            else { return false; }

        }

        public bool Supprimer(string numero)
        {
            return maListe.Remove(numero);
        }

        public clsAgent Trouver(string numero)
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
            foreach (clsAgent ag in maListe.Values)
            {
                info += ag.Afficher() + "\n";
            }
            return info;
        }

    }
}
