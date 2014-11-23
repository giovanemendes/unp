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
    public partial class FrmComposicaoMedicamento : Form
    {
        public FrmComposicaoMedicamento()
        {
            InitializeComponent();
        }

        private void medicamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void FrmComposicaoMedicamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.principioativo' table. You can move, or remove it, as needed.
            this.principioativoTableAdapter.Fill(this.zeGotinhaDataSet.principioativo);
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.medicamento' table. You can move, or remove it, as needed.
            this.medicamentoTableAdapter.Fill(this.zeGotinhaDataSet.medicamento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int medicamento, principioAtivo;
            DataRowView linha;

            linha = (DataRowView) medicamentoBindingSource.Current;
            medicamento = Int32.Parse(linha["idmedicamento"].ToString());
            
            linha = (DataRowView) principioativoBindingSource.Current;
            principioAtivo = Int32.Parse(linha["idprincipioativo"].ToString());

            try
            {
                this.medicamentocomposicaoTableAdapter1.Insert(medicamento, principioAtivo);
                MessageBox.Show("Composição criada com sucesso!", "Confirmação");
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possível salvar a composição \n Verifique se já existe \n" + ex.Message, "Erro");
            }
        }
    }
}
