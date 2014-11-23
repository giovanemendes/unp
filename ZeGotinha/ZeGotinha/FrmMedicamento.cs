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
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.principioativo' table. You can move, or remove it, as needed.
            this.principioativoTableAdapter.Fill(this.zeGotinhaDataSet.principioativo);
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.medicamentocomposicao' table. You can move, or remove it, as needed.
            this.medicamentocomposicaoTableAdapter.Fill(this.zeGotinhaDataSet.medicamentocomposicao);
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.medicamento' table. You can move, or remove it, as needed.
            this.medicamentoTableAdapter.Fill(this.zeGotinhaDataSet.medicamento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pesquisa = textBoxPesquisa.Text.Trim();

            if (this.comboBoxTipoPesquisa.SelectedIndex == 0)
            {
                medicamentoDataGridView.Rows[medicamentoBindingSource.Find("idmedicamento", pesquisa)].Selected = true;
                medicamentoBindingSource.Position = medicamentoBindingSource.Find("idmedicamento", pesquisa);
            }
            else
            {
                medicamentoDataGridView.Rows[medicamentoBindingSource.Find("nomemedicamento", pesquisa)].Selected = true;
                medicamentoBindingSource.Position = medicamentoBindingSource.Find("nomemedicamento", pesquisa);
            }
        }

        private void FrmMedicamento_Shown(object sender, EventArgs e)
        {
            this.comboBoxTipoPesquisa.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPrincipioAtivo frmPrincipioAtivo = new FrmPrincipioAtivo();
            frmPrincipioAtivo.ShowDialog();

            this.principioativoTableAdapter.Fill(this.zeGotinhaDataSet.principioativo);
            this.principioativoBindingSource.MoveLast();
        }

        private void fKmedicamentocomposicaomedicamentoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            carregarGridPrincipioAtivo();
        }

        private void carregarGridPrincipioAtivo() 
        {
            try
            {
                DataRowView linha = (DataRowView)fKmedicamentocomposicaomedicamentoBindingSource.Current;
                this.principioativoBindingSource.Filter = "idprincipioativo = " + linha["idprincipioativo"].ToString();
            }catch(Exception ex)
            {
                //MessageBox.Show("Não foi possível selecionar o Princípio Ativo \n" + ex.Message, "Erro");
            }
        }

        private void fKmedicamentocomposicaomedicamentoBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            carregarGridPrincipioAtivo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmComposicaoMedicamento frmComposicaoMedicamento = new FrmComposicaoMedicamento();
            frmComposicaoMedicamento.ShowDialog();

            carregarGridComposicaoMedicamento();
        }

        public void carregarGridComposicaoMedicamento()
        {
            try
            {
                this.medicamentocomposicaoBindingSource.Filter = "idprincipioativo > 0";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possível selecionar o Princípio Ativo \n" + ex.Message, "Erro");
            }
        }
    }
}
