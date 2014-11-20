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
            frmDoenca.Show();
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicamento frmMedicamento = new FrmMedicamento();
            frmMedicamento.Show();
        }
    }
}
