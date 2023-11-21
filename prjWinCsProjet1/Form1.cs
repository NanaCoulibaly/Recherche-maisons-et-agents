using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsProjet1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //  clsCompagnie maCompagnie;
        clsCompagnie maCompagnie;
        private void Form1_Load(object sender, EventArgs e)
        {
            clsListeAgent lesagents = clsProvenance2Dinfos.tousLesAgents();
            maCompagnie = new clsCompagnie("Remax","21 hochelaga","Ouvert",lesagents, "12345678");

            clsListeAgent agents = clsProvenance2Dinfos.tousLesAgents();
            MessageBox.Show(agents.Afficher());
        }
    }
}
