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
    public partial class FrmElementoNatural : Form
    {
        public FrmElementoNatural()
        {
            InitializeComponent();
        }

        private void elementonaturalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.elementonaturalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void FrmElementoNatural_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.elementonatural' table. You can move, or remove it, as needed.
            this.elementonaturalTableAdapter.Fill(this.zeGotinhaDataSet.elementonatural);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pesquisa = textBoxPesquisa.Text.Trim();

            if (this.comboBoxTipoPesquisa.SelectedIndex == 0)
            {
                elementonaturalDataGridView.Rows[elementonaturalBindingSource.Find("idelementonatural", pesquisa)].Selected = true;
                elementonaturalBindingSource.Position = elementonaturalBindingSource.Find("idelementonatural", pesquisa);
            }
            else
            {
                elementonaturalDataGridView.Rows[elementonaturalBindingSource.Find("nomeelementonatural", pesquisa)].Selected = true;
                elementonaturalBindingSource.Position = elementonaturalBindingSource.Find("nomeelementonatural", pesquisa);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.nomeelementonaturalTextBox.Focus();
        }

        private void FrmElementoNatural_Shown(object sender, EventArgs e)
        {
            this.comboBoxTipoPesquisa.SelectedIndex = 0;
        }
    }
}
