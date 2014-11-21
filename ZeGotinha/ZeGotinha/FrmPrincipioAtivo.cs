using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeGotinha
{
    public partial class FrmPrincipioAtivo : Form
    {
        public FrmPrincipioAtivo()
        {
            InitializeComponent();
        }

        private void principioativoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.principioativoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void FrmPrincipioAtivo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.principioativo' table. You can move, or remove it, as needed.
            this.principioativoTableAdapter.Fill(this.zeGotinhaDataSet.principioativo);

        }
    }
}
