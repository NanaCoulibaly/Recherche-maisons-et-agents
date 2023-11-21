using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsProjet1
{
    public class clsCompagnie

    {
        private string vNom;
        private string vAdresse;
        private string vStatut;
        private string vPhone;
        private clsListeAgent vAgents;

        public clsCompagnie()
        {
            vNom = vPhone = vAdresse = vStatut = "Non defini";
            vAgents = new clsListeAgent();
        }

        public clsCompagnie(string nom, string adresse, string statut, clsListeAgent agents, string phone)
        {
            vNom = nom;
            vAdresse = adresse;
            vStatut = statut;
            vAgents = agents;
            vPhone = phone;
        }

        public string Nom
        {
            get { return vNom; }
            set { vNom = value; }
        }

        public string Adresse
        {
            get { return vAdresse; }
            set { vAdresse = value; }
        }

        public string Statut
        {
            get { return vStatut; }
            set { vStatut = value; }
        }

        public string Phone
        {
            get { return vPhone; }

        }

         public clsListeAgent Agents
         {
             get { return vAgents; }
             set { vAgents = value; }
         }

        public string Afficher()
        {
            throw new System.NotImplementedException();
        }

        public void Ouvrir()
        {
            throw new System.NotImplementedException();
        }

        public void Fermer()
        {
            vStatut = "fermer";
        }
    }
}
