using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Usine
{
    public partial class SaisieProduction : Form
    {
        public SaisieProduction()
        {
            InitializeComponent();
        }

        private void SaisieProduction_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'usineDataSet.wproduction'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.wproductionTableAdapter.Fill(this.usineDataSet.wproduction);

        }
    }
}
