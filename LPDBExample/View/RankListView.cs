using LPDBExample.Controller;
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

    }
}
