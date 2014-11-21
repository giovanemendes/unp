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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void doençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoenca frmDoenca = new FrmDoenca();
            frmDoenca.ShowDialog();
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicamento frmMedicamento = new FrmMedicamento();
            frmMedicamento.ShowDialog();
        }

        private void vacinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVacina frmVacina = new FrmVacina();
            frmVacina.ShowDialog();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedico frmMedico = new FrmMedico();
            frmMedico.ShowDialog();
        }

        private void postoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPosto frmPosto = new FrmPosto();
            frmPosto.ShowDialog();
        }

        private void princípioAtivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipioAtivo frmPrincipioAtivo = new FrmPrincipioAtivo();
            frmPrincipioAtivo.ShowDialog();
        }

        private void cronogramaVacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVacinaCronograma frmVacinaCronograma = new FrmVacinaCronograma();
            frmVacinaCronograma.ShowDialog();
        }

        private void elementoNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElementoNatural frmElementoNatural = new FrmElementoNatural();
            frmElementoNatural.ShowDialog();
        }
    }
}
