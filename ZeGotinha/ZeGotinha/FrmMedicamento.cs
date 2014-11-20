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
    public partial class FrmMedicamento : Form
    {
        public FrmMedicamento()
        {
            InitializeComponent();
        }

        private void medicamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void FrmMedicamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.medicamento' table. You can move, or remove it, as needed.
            this.medicamentoTableAdapter.Fill(this.zeGotinhaDataSet.medicamento);

        }
    }
}
