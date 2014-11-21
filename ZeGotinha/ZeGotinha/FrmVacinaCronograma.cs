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
    public partial class FrmVacinaCronograma : Form
    {
        public FrmVacinaCronograma()
        {
            InitializeComponent();
        }

        private void vacinacronogramaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacinacronogramaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void FrmVacinaCronograma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.vacinacronograma' table. You can move, or remove it, as needed.
            this.vacinacronogramaTableAdapter.Fill(this.zeGotinhaDataSet.vacinacronograma);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            descricaoTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmVacinaCronograma_Shown(object sender, EventArgs e)
        {
            this.comboBoxTipoPesquisa.SelectedIndex = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String pesquisa = textBoxPesquisa.Text.Trim();

            if (this.comboBoxTipoPesquisa.SelectedIndex == 0)
            {
                vacinacronogramaDataGridView.Rows[vacinacronogramaBindingSource.Find("idvacinacronograma", pesquisa)].Selected = true;
                vacinacronogramaBindingSource.Position = vacinacronogramaBindingSource.Find("idvacinacronograma", pesquisa);
            }
            else
            {
                vacinacronogramaDataGridView.Rows[vacinacronogramaBindingSource.Find("descricao", pesquisa)].Selected = true;
                vacinacronogramaBindingSource.Position = vacinacronogramaBindingSource.Find("descricao", pesquisa);
            }
        }

        private void allVacinaCronogramaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vacinacronogramaTableAdapter.AllVacinaCronograma(this.zeGotinhaDataSet.vacinacronograma);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
