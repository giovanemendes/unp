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
    public partial class FrmDoenca : Form
    {
        public FrmDoenca()
        {
            InitializeComponent();
        }

        private void doencaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doencaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void FrmDoenca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.doenca' table. You can move, or remove it, as needed.
            this.doencaTableAdapter.Fill(this.zeGotinhaDataSet.doenca);

        }
    }
}
