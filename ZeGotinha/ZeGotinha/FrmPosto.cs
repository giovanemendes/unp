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
    public partial class FrmPosto : Form
    {
        public FrmPosto()
        {
            InitializeComponent();
        }

        private void postoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void FrmPosto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.posto' table. You can move, or remove it, as needed.
            this.postoTableAdapter.Fill(this.zeGotinhaDataSet.posto);

        }
    }
}
