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
            // TODO: This line of code loads data into the 'zeGotinhaDataSet.paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.zeGotinhaDataSet.paciente);

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

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.idpacienteTextBox1.Text = idpacienteTextBox.Text;
        }

        private void pacienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zeGotinhaDataSet);

        }
    }
}
