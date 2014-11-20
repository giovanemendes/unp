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
    public partial class FrmVacina : Form
    {
        public FrmVacina()
        {
            InitializeComponent();
        }

        private void vacinaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacinaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void FrmVacina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.vacina' table. You can move, or remove it, as needed.
            this.vacinaTableAdapter.Fill(this.zeGotinhaDataSet.vacina);
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.vacina' table. You can move, or remove it, as needed.
            this.vacinaTableAdapter.Fill(this.zeGotinhaDataSet.vacina);

        }

        private void vacinaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vacinaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }
    }
}
