using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsProjet1
{
    public class clsAgent
    {
        private string vNumero;
        private string vNom;
        private string vPhone;
        private string vStatut;
        private clsListeClient vClients; 
   

    public clsAgent()
    {
        vNumero = vNom = vPhone = vStatut = "Non defini";
        vClients = new clsListeClient();
    }

    public clsAgent(string numero, string nom,string phone,string statut, clsListeClient clients)
    {
        vNumero = numero;
        vNom = nom;
        vStatut = statut;
        vPhone = phone;
        vClients = clients;
    }

    public clsAgent(string numero, string nom,string phone,string statut, string langu)
    {
        vNumero = numero;
        vNom = nom;
        vPhone = phone;
        vStatut = statut;
        vClients = new clsListeClient();
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

        public string Statut
        {
            get { return vStatut; }
            set { vStatut = value; }
        }

        public clsListeClient Clients
    {
        get { return vClients; }
        set { vClients= value; }
    }

        public string Afficher()
        {
            string info = "Numero : " + vNumero + "\nNom : " + vNom +
                "\nTel : " + vPhone + "\nStatut : " + vStatut +
                "\nClients : " + vClients.Afficher();
            return info;
        }

        public void Engager()
        {
            throw new System.NotImplementedException();
        }

        public void Renvoyer()
        {
            throw new System.NotImplementedException();
        }

    }
}
