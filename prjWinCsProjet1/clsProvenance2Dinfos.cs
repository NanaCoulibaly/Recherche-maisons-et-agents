using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Emit;
using System.Data;
using System.Data.OleDb;

namespace prjWinCsProjet1
{
    public static class clsProvenance2Dinfos
    {

        public static clsListeClient tousLesClients(string numAgent)
        {
            clsListeClient touslesClients = new clsListeClient();
            OleDbConnection mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\NaNa\Documents\RemaxDB.mdb");
            mycon.Open();
            string sql = "SELECT Numero,Nom,Nip,Statut ";
            sql += " FROM Clients WHERE ReferAgents='" + numAgent + "'";
            OleDbCommand mycmd = new OleDbCommand(sql, mycon);
            OleDbDataReader myRder = mycmd.ExecuteReader();
            while (myRder.Read() == true)
            {
                string num = myRder["Numero"].ToString();
                string nom = myRder["Nom"].ToString();
                string nip = myRder["Nip"].ToString();
                string stat = myRder["Statut"].ToString();
              //  string adres = myRder["Adresse"].ToString();
              /*  string tel = myRder["Phone"].ToString();*/ clsClient clt = new clsClient(num, nom, nip,stat);
                touslesClients.Ajouter(clt);
            }
            myRder.Close();
            mycon.Close();
            return touslesClients;
        }

        public static clsListeAgent tousLesAgents()
        {
            clsListeAgent touslesAgents = new clsListeAgent();
            OleDbConnection mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\NaNa\Documents\RemaxDB.mdb");
            mycon.Open();
            string sql = "SELECT Numero,Nom,Genre,Ville,Langue from Agents";
            OleDbCommand mycmd = new OleDbCommand(sql, mycon);
            OleDbDataReader myRder = mycmd.ExecuteReader();
            while (myRder.Read() == true)
            {
                string num = myRder["Numero"].ToString();
                string nom = myRder["Nom"].ToString();
                string genre = myRder["Genre"].ToString();
                string vil = myRder["Ville"].ToString();
                string langu = myRder["Langue"].ToString();
                /*string tel = myRder["Phone"].ToString();*/
                clsAgent agt = new clsAgent(num, nom, genre, vil, langu);
                touslesAgents.Ajouter(agt);
            }
            myRder.Close();
            mycon.Close();
            return touslesAgents;
        }

        public static clsListeMaison toutesLesMaisons(string numClient)
        {
            clsListeMaison toutesLesMaisons = new clsListeMaison();
            OleDbConnection mycon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\NaNa\Documents\RemaxDB.mdb");
            mycon.Open();
            string sql = " SELECT Numero,Type,Modele,Province,Ville,Prix,Pieces ";
           sql += "from Maisons WHERE ReferClients = '"  + numClient + "'";
            OleDbCommand mycmd = new OleDbCommand(sql, mycon);
            OleDbDataReader myRder1 = mycmd.ExecuteReader();
            while (myRder1.Read() == true)
            {
                string num = myRder1["Numero"].ToString();
                string type = myRder1["Type"].ToString();           
                string mod = myRder1["Modele"].ToString();
                string prov = myRder1["Province"].ToString();
                string vil = myRder1["Ville"].ToString();
                decimal prix = Convert.ToDecimal(myRder1["Prix"]);
               Int16 piece = Convert.ToInt16(myRder1["Pieces"]);
               
                clsMaison msn = new clsMaison(num, type, mod, prov,vil, prix,piece);
                toutesLesMaisons.Acheter(msn);
            }
            myRder1.Close();
            mycon.Close();
            return toutesLesMaisons;
        }



    }
}
