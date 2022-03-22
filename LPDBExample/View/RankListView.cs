using LPDBExample.Controller;
using LPDBExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPDBExample.View
{
    public partial class RankListView : Form
    {
        ShowLPDBController showLPDBController = new ShowLPDBController();
        public RankListView()
        {
            InitializeComponent();
        }

        private void RankListView_Load(object sender, EventArgs e)
        {
                dgvRanks.DataSource = showLPDBController.GetAll();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void RefreshTable() 
        {
            dgvRanks.DataSource = showLPDBController.GetAll();        
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EloTable eloTable = new EloTable();
            eloTable.Rank = rankName.Text;
            eloTable.Price = int.Parse(rankPrice.Text);
            showLPDBController.CreateRank(eloTable);
            RefreshTable();
        }
    }
}
