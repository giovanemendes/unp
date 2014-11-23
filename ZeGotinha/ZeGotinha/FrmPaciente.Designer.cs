namespace ZeGotinha
{
    partial class FrmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idpacienteLabel;
            System.Windows.Forms.Label nomepacienteLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label datanascimentoLabel;
            System.Windows.Forms.Label tiposanguineoLabel;
            System.Windows.Forms.Label fatorsanguineoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label celularLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaciente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zeGotinhaDataSet = new ZeGotinha.ZeGotinhaDataSet();
            this.idpacienteTextBox = new System.Windows.Forms.TextBox();
            this.nomepacienteTextBox = new System.Windows.Forms.TextBox();
            this.datanascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tiposanguineoTextBox = new System.Windows.Forms.TextBox();
            this.fatorsanguineoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBoxTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.pacienteTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.pacienteTableAdapter();
            this.tableAdapterManager = new ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager();
            this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pacienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoRadioButton = new System.Windows.Forms.RadioButton();
            idpacienteLabel = new System.Windows.Forms.Label();
            nomepacienteLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            datanascimentoLabel = new System.Windows.Forms.Label();
            tiposanguineoLabel = new System.Windows.Forms.Label();
            fatorsanguineoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
            this.pacienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idpacienteLabel
            // 
            idpacienteLabel.AutoSize = true;
            idpacienteLabel.Location = new System.Drawing.Point(6, 16);
            idpacienteLabel.Name = "idpacienteLabel";
            idpacienteLabel.Size = new System.Drawing.Size(77, 13);
            idpacienteLabel.TabIndex = 0;
            idpacienteLabel.Text = "Cód. Paciente:";
            // 
            // nomepacienteLabel
            // 
            nomepacienteLabel.AutoSize = true;
            nomepacienteLabel.Location = new System.Drawing.Point(115, 16);
            nomepacienteLabel.Name = "nomepacienteLabel";
            nomepacienteLabel.Size = new System.Drawing.Size(83, 13);
            nomepacienteLabel.TabIndex = 2;
            nomepacienteLabel.Text = "Nome Paciente:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(6, 65);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 4;
            sexoLabel.Text = "Sexo:";
            // 
            // datanascimentoLabel
            // 
            datanascimentoLabel.AutoSize = true;
            datanascimentoLabel.Location = new System.Drawing.Point(115, 65);
            datanascimentoLabel.Name = "datanascimentoLabel";
            datanascimentoLabel.Size = new System.Drawing.Size(92, 13);
            datanascimentoLabel.TabIndex = 6;
            datanascimentoLabel.Text = "Data Nascimento:";
            // 
            // tiposanguineoLabel
            // 
            tiposanguineoLabel.AutoSize = true;
            tiposanguineoLabel.Location = new System.Drawing.Point(6, 115);
            tiposanguineoLabel.Name = "tiposanguineoLabel";
            tiposanguineoLabel.Size = new System.Drawing.Size(85, 13);
            tiposanguineoLabel.TabIndex = 8;
            tiposanguineoLabel.Text = "Tipo Sanguineo:";
            // 
            // fatorsanguineoLabel
            // 
            fatorsanguineoLabel.AutoSize = true;
            fatorsanguineoLabel.Location = new System.Drawing.Point(115, 115);
            fatorsanguineoLabel.Name = "fatorsanguineoLabel";
            fatorsanguineoLabel.Size = new System.Drawing.Size(88, 13);
            fatorsanguineoLabel.TabIndex = 10;
            fatorsanguineoLabel.Text = "Fator Sanguineo:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(115, 169);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(6, 169);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 14;
            celularLabel.Text = "Celular:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sexoRadioButton);
            this.groupBox1.Controls.Add(this.celularMaskedTextBox);
            this.groupBox1.Controls.Add(idpacienteLabel);
            this.groupBox1.Controls.Add(this.idpacienteTextBox);
            this.groupBox1.Controls.Add(nomepacienteLabel);
            this.groupBox1.Controls.Add(this.nomepacienteTextBox);
            this.groupBox1.Controls.Add(sexoLabel);
            this.groupBox1.Controls.Add(datanascimentoLabel);
            this.groupBox1.Controls.Add(this.datanascimentoDateTimePicker);
            this.groupBox1.Controls.Add(tiposanguineoLabel);
            this.groupBox1.Controls.Add(this.tiposanguineoTextBox);
            this.groupBox1.Controls.Add(fatorsanguineoLabel);
            this.groupBox1.Controls.Add(this.fatorsanguineoTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(celularLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Paciente";
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(9, 185);
            this.celularMaskedTextBox.Mask = "(99) 0000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(103, 20);
            this.celularMaskedTextBox.TabIndex = 15;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // zeGotinhaDataSet
            // 
            this.zeGotinhaDataSet.DataSetName = "ZeGotinhaDataSet";
            this.zeGotinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idpacienteTextBox
            // 
            this.idpacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "idpaciente", true));
            this.idpacienteTextBox.Enabled = false;
            this.idpacienteTextBox.Location = new System.Drawing.Point(9, 32);
            this.idpacienteTextBox.Name = "idpacienteTextBox";
            this.idpacienteTextBox.Size = new System.Drawing.Size(103, 20);
            this.idpacienteTextBox.TabIndex = 1;
            // 
            // nomepacienteTextBox
            // 
            this.nomepacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "nomepaciente", true));
            this.nomepacienteTextBox.Location = new System.Drawing.Point(118, 32);
            this.nomepacienteTextBox.Name = "nomepacienteTextBox";
            this.nomepacienteTextBox.Size = new System.Drawing.Size(377, 20);
            this.nomepacienteTextBox.TabIndex = 3;
            // 
            // datanascimentoDateTimePicker
            // 
            this.datanascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacienteBindingSource, "datanascimento", true));
            this.datanascimentoDateTimePicker.Location = new System.Drawing.Point(118, 81);
            this.datanascimentoDateTimePicker.Name = "datanascimentoDateTimePicker";
            this.datanascimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datanascimentoDateTimePicker.TabIndex = 7;
            // 
            // tiposanguineoTextBox
            // 
            this.tiposanguineoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "tiposanguineo", true));
            this.tiposanguineoTextBox.Location = new System.Drawing.Point(9, 131);
            this.tiposanguineoTextBox.Name = "tiposanguineoTextBox";
            this.tiposanguineoTextBox.Size = new System.Drawing.Size(103, 20);
            this.tiposanguineoTextBox.TabIndex = 9;
            // 
            // fatorsanguineoTextBox
            // 
            this.fatorsanguineoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "fatorsanguineo", true));
            this.fatorsanguineoTextBox.Location = new System.Drawing.Point(118, 131);
            this.fatorsanguineoTextBox.Name = "fatorsanguineoTextBox";
            this.fatorsanguineoTextBox.Size = new System.Drawing.Size(107, 20);
            this.fatorsanguineoTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(118, 185);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(377, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxPesquisa);
            this.groupBox2.Controls.Add(this.comboBoxTipoPesquisa);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(133, 19);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(281, 20);
            this.textBoxPesquisa.TabIndex = 1;
            // 
            // comboBoxTipoPesquisa
            // 
            this.comboBoxTipoPesquisa.FormattingEnabled = true;
            this.comboBoxTipoPesquisa.Items.AddRange(new object[] {
            "Código",
            "Descrição"});
            this.comboBoxTipoPesquisa.Location = new System.Drawing.Point(6, 19);
            this.comboBoxTipoPesquisa.Name = "comboBoxTipoPesquisa";
            this.comboBoxTipoPesquisa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoPesquisa.TabIndex = 0;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alergiamotivoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doencaTableAdapter = null;
            this.tableAdapterManager.elementonaturalTableAdapter = null;
            this.tableAdapterManager.medicamentocomposicaoTableAdapter = null;
            this.tableAdapterManager.medicamentoTableAdapter = null;
            this.tableAdapterManager.medicoTableAdapter = null;
            this.tableAdapterManager.pacientealergiaTableAdapter = null;
            this.tableAdapterManager.pacientedoencaTableAdapter = null;
            this.tableAdapterManager.pacientepesoTableAdapter = null;
            this.tableAdapterManager.pacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.pacientevacinaTableAdapter = null;
            this.tableAdapterManager.posologiaTableAdapter = null;
            this.tableAdapterManager.postoTableAdapter = null;
            this.tableAdapterManager.principioativoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacinacronogramaTableAdapter = null;
            this.tableAdapterManager.vacinadoencaTableAdapter = null;
            this.tableAdapterManager.vacinaTableAdapter = null;
            // 
            // pacienteBindingNavigator
            // 
            this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
            this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pacienteBindingNavigatorSaveItem});
            this.pacienteBindingNavigator.Location = new System.Drawing.Point(12, 283);
            this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
            this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.pacienteBindingNavigator.TabIndex = 6;
            this.pacienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pacienteBindingNavigatorSaveItem
            // 
            this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
            this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
            this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacienteBindingNavigatorSaveItem.Text = "Save Data";
            this.pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacienteBindingNavigatorSaveItem_Click);
            // 
            // pacienteDataGridView
            // 
            this.pacienteDataGridView.AutoGenerateColumns = false;
            this.pacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pacienteDataGridView.DataSource = this.pacienteBindingSource;
            this.pacienteDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pacienteDataGridView.Location = new System.Drawing.Point(0, 318);
            this.pacienteDataGridView.Name = "pacienteDataGridView";
            this.pacienteDataGridView.Size = new System.Drawing.Size(527, 223);
            this.pacienteDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idpaciente";
            this.dataGridViewTextBoxColumn1.HeaderText = "idpaciente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomepaciente";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomepaciente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sexo";
            this.dataGridViewTextBoxColumn3.HeaderText = "sexo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "datanascimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "datanascimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tiposanguineo";
            this.dataGridViewTextBoxColumn5.HeaderText = "tiposanguineo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fatorsanguineo";
            this.dataGridViewTextBoxColumn6.HeaderText = "fatorsanguineo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn7.HeaderText = "email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "celular";
            this.dataGridViewTextBoxColumn8.HeaderText = "celular";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // sexoRadioButton
            // 
            this.sexoRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.pacienteBindingSource, "sexo", true));
            this.sexoRadioButton.Location = new System.Drawing.Point(9, 81);
            this.sexoRadioButton.Name = "sexoRadioButton";
            this.sexoRadioButton.Size = new System.Drawing.Size(103, 24);
            this.sexoRadioButton.TabIndex = 16;
            this.sexoRadioButton.TabStop = true;
            this.sexoRadioButton.Text = "radioButton1";
            this.sexoRadioButton.UseVisualStyleBackColor = true;
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 541);
            this.Controls.Add(this.pacienteDataGridView);
            this.Controls.Add(this.pacienteBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Paciente";
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            this.Shown += new System.EventHandler(this.FrmPaciente_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
            this.pacienteBindingNavigator.ResumeLayout(false);
            this.pacienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBoxTipoPesquisa;
        private ZeGotinhaDataSet zeGotinhaDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ZeGotinhaDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private ZeGotinhaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idpacienteTextBox;
        private System.Windows.Forms.TextBox nomepacienteTextBox;
        private System.Windows.Forms.DateTimePicker datanascimentoDateTimePicker;
        private System.Windows.Forms.TextBox tiposanguineoTextBox;
        private System.Windows.Forms.TextBox fatorsanguineoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataGridView pacienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.RadioButton sexoRadioButton;
    }
}