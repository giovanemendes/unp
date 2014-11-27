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
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {            
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'zeGotinhaDataSet.paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.zeGotinhaDataSet.paciente);
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.vacina' table. You can move, or remove it, as needed.
            this.vacinaTableAdapter.Fill(this.zeGotinhaDataSet.vacina);
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.posto' table. You can move, or remove it, as needed.
            this.postoTableAdapter.Fill(this.zeGotinhaDataSet.posto);
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.doenca' table. You can move, or remove it, as needed.
            this.doencaTableAdapter.Fill(this.zeGotinhaDataSet.doenca);

            
            // listando as doenças, vacinas, peso e alergia de acordo com paciente
            filtrarDadosClinicosPaciente();
            

            // TODO: This line of code loads data into the 'zeGotinhaDataSet.pacientevacina' table. You can move, or remove it, as needed.
            //this.pacientevacinaTableAdapter.Fill(this.zeGotinhaDataSet.pacientevacina);
            
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.pacientedoenca' table. You can move, or remove it, as needed.
            //this.pacientedoencaTableAdapter.Fill(this.zeGotinhaDataSet.pacientedoenca);
            
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.pacientealergia' table. You can move, or remove it, as needed.
            //this.pacientealergiaTableAdapter.Fill(this.zeGotinhaDataSet.pacientealergia);

            // TODO: This line of code loads data into the 'zeGotinhaDataSet.pacientepeso' table. You can move, or remove it, as needed.
            //this.pacientepesoTableAdapter.Fill(this.zeGotinhaDataSet.pacientepeso);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pesquisa = textBoxPesquisa.Text.Trim();

            if (this.comboBoxTipoPesquisa.SelectedIndex == 0)
            {
                pacienteDataGridView.Rows[pacienteBindingSource.Find("idpaciente", pesquisa)].Selected = true;
                pacienteBindingSource.Position = pacienteBindingSource.Find("iddoenca", pesquisa);
            }
            else
            {
                pacienteDataGridView.Rows[pacienteBindingSource.Find("nomepaciente", pesquisa)].Selected = true;
                pacienteBindingSource.Position = pacienteBindingSource.Find("nomepaciente", pesquisa);
            }
        }

        private void FrmPaciente_Shown(object sender, EventArgs e)
        {
            this.comboBoxTipoPesquisa.SelectedIndex = 0;
        }

        private void pacienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientealergiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);
        }

        private void bindingNavigatorSaveItem2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientedoencaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);
        }

        private void bindingNavigatorSaveItem3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientevacinaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientepesoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);
        }

        private void pacienteBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            filtrarDadosClinicosPaciente();
        }

        private void filtrarDadosClinicosPaciente()
        {
            if (this.pacienteBindingSource.Current != null)
            {
                DataRowView row = (DataRowView)this.pacienteBindingSource.Current;
                Int64 idPaciente = Int64.Parse(row["idpaciente"].ToString());

                this.pacientealergiaTableAdapter.FillByIdPaciente(this.zeGotinhaDataSet.pacientealergia, idPaciente);
                this.pacientedoencaTableAdapter.FillByIdPaciente(this.zeGotinhaDataSet.pacientedoenca, idPaciente);
                this.pacientevacinaTableAdapter.FillByIdPaciente(this.zeGotinhaDataSet.pacientevacina, idPaciente);
                this.pacientepesoTableAdapter.FillByIdPaciente(this.zeGotinhaDataSet.pacientepeso, idPaciente);
            }
        }

        private void bindingNavigatorAddNewItem4_Click(object sender, EventArgs e)
        {
            this.datapesagemMaskedTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
