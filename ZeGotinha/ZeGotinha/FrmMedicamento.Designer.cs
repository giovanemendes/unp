namespace ZeGotinha
{
    partial class FrmMedicamento
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
            System.Windows.Forms.Label idmedicamentoLabel;
            System.Windows.Forms.Label nomemedicamentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idprincipioativoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprincipioativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principioativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zeGotinhaDataSet = new ZeGotinha.ZeGotinhaDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.medicamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmedicamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprincipioativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKmedicamentocomposicaomedicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.medicamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.medicamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idmedicamentoTextBox = new System.Windows.Forms.TextBox();
            this.nomemedicamentoTextBox = new System.Windows.Forms.TextBox();
            this.medicamentocomposicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentoTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.medicamentoTableAdapter();
            this.tableAdapterManager = new ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBoxTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.medicamentocomposicaoTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.medicamentocomposicaoTableAdapter();
            this.principioativoTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.principioativoTableAdapter();
            idmedicamentoLabel = new System.Windows.Forms.Label();
            nomemedicamentoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principioativoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKmedicamentocomposicaomedicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingNavigator)).BeginInit();
            this.medicamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentocomposicaoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idmedicamentoLabel
            // 
            idmedicamentoLabel.AutoSize = true;
            idmedicamentoLabel.Location = new System.Drawing.Point(13, 20);
            idmedicamentoLabel.Name = "idmedicamentoLabel";
            idmedicamentoLabel.Size = new System.Drawing.Size(99, 13);
            idmedicamentoLabel.TabIndex = 0;
            idmedicamentoLabel.Text = "Cód. Medicamento:";
            // 
            // nomemedicamentoLabel
            // 
            nomemedicamentoLabel.AutoSize = true;
            nomemedicamentoLabel.Location = new System.Drawing.Point(13, 46);
            nomemedicamentoLabel.Name = "nomemedicamentoLabel";
            nomemedicamentoLabel.Size = new System.Drawing.Size(105, 13);
            nomemedicamentoLabel.TabIndex = 2;
            nomemedicamentoLabel.Text = "Nome Medicamento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.medicamentoDataGridView);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.medicamentoBindingNavigator);
            this.groupBox1.Controls.Add(idmedicamentoLabel);
            this.groupBox1.Controls.Add(this.idmedicamentoTextBox);
            this.groupBox1.Controls.Add(nomemedicamentoLabel);
            this.groupBox1.Controls.Add(this.nomemedicamentoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Medicamento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(361, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 180);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Princípio Ativo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprincipioativoDataGridViewTextBoxColumn1,
            this.nomeprincipioativoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.principioativoBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(348, 136);
            this.dataGridView2.TabIndex = 6;
            // 
            // idprincipioativoDataGridViewTextBoxColumn1
            // 
            this.idprincipioativoDataGridViewTextBoxColumn1.DataPropertyName = "idprincipioativo";
            this.idprincipioativoDataGridViewTextBoxColumn1.HeaderText = "idprincipioativo";
            this.idprincipioativoDataGridViewTextBoxColumn1.Name = "idprincipioativoDataGridViewTextBoxColumn1";
            this.idprincipioativoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeprincipioativoDataGridViewTextBoxColumn
            // 
            this.nomeprincipioativoDataGridViewTextBoxColumn.DataPropertyName = "nomeprincipioativo";
            this.nomeprincipioativoDataGridViewTextBoxColumn.HeaderText = "nomeprincipioativo";
            this.nomeprincipioativoDataGridViewTextBoxColumn.Name = "nomeprincipioativoDataGridViewTextBoxColumn";
            // 
            // principioativoBindingSource
            // 
            this.principioativoBindingSource.DataMember = "principioativo";
            this.principioativoBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // zeGotinhaDataSet
            // 
            this.zeGotinhaDataSet.DataSetName = "ZeGotinhaDataSet";
            this.zeGotinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add Pricipio Ativo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // medicamentoDataGridView
            // 
            this.medicamentoDataGridView.AutoGenerateColumns = false;
            this.medicamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.medicamentoDataGridView.DataSource = this.medicamentoBindingSource;
            this.medicamentoDataGridView.Location = new System.Drawing.Point(6, 108);
            this.medicamentoDataGridView.Name = "medicamentoDataGridView";
            this.medicamentoDataGridView.Size = new System.Drawing.Size(709, 162);
            this.medicamentoDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idmedicamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Medicamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomemedicamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Medicamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataMember = "medicamento";
            this.medicamentoBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(6, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 180);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Composição";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmedicamentoDataGridViewTextBoxColumn,
            this.idprincipioativoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKmedicamentocomposicaomedicamentoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 136);
            this.dataGridView1.TabIndex = 5;
            // 
            // idmedicamentoDataGridViewTextBoxColumn
            // 
            this.idmedicamentoDataGridViewTextBoxColumn.DataPropertyName = "idmedicamento";
            this.idmedicamentoDataGridViewTextBoxColumn.HeaderText = "idmedicamento";
            this.idmedicamentoDataGridViewTextBoxColumn.Name = "idmedicamentoDataGridViewTextBoxColumn";
            // 
            // idprincipioativoDataGridViewTextBoxColumn
            // 
            this.idprincipioativoDataGridViewTextBoxColumn.DataPropertyName = "idprincipioativo";
            this.idprincipioativoDataGridViewTextBoxColumn.HeaderText = "idprincipioativo";
            this.idprincipioativoDataGridViewTextBoxColumn.Name = "idprincipioativoDataGridViewTextBoxColumn";
            // 
            // fKmedicamentocomposicaomedicamentoBindingSource
            // 
            this.fKmedicamentocomposicaomedicamentoBindingSource.DataMember = "FK_medicamentocomposicao_medicamento";
            this.fKmedicamentocomposicaomedicamentoBindingSource.DataSource = this.medicamentoBindingSource;
            this.fKmedicamentocomposicaomedicamentoBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.fKmedicamentocomposicaomedicamentoBindingSource_ListChanged);
            this.fKmedicamentocomposicaomedicamentoBindingSource.PositionChanged += new System.EventHandler(this.fKmedicamentocomposicaomedicamentoBindingSource_PositionChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Composição";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // medicamentoBindingNavigator
            // 
            this.medicamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicamentoBindingNavigator.BindingSource = this.medicamentoBindingSource;
            this.medicamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicamentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicamentoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.medicamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medicamentoBindingNavigatorSaveItem});
            this.medicamentoBindingNavigator.Location = new System.Drawing.Point(16, 80);
            this.medicamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicamentoBindingNavigator.Name = "medicamentoBindingNavigator";
            this.medicamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicamentoBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.medicamentoBindingNavigator.TabIndex = 1;
            this.medicamentoBindingNavigator.Text = "bindingNavigator1";
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
            // medicamentoBindingNavigatorSaveItem
            // 
            this.medicamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicamentoBindingNavigatorSaveItem.Image")));
            this.medicamentoBindingNavigatorSaveItem.Name = "medicamentoBindingNavigatorSaveItem";
            this.medicamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicamentoBindingNavigatorSaveItem.Text = "Save Data";
            this.medicamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicamentoBindingNavigatorSaveItem_Click);
            // 
            // idmedicamentoTextBox
            // 
            this.idmedicamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "idmedicamento", true));
            this.idmedicamentoTextBox.Location = new System.Drawing.Point(118, 17);
            this.idmedicamentoTextBox.Name = "idmedicamentoTextBox";
            this.idmedicamentoTextBox.ReadOnly = true;
            this.idmedicamentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idmedicamentoTextBox.TabIndex = 1;
            // 
            // nomemedicamentoTextBox
            // 
            this.nomemedicamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "nomemedicamento", true));
            this.nomemedicamentoTextBox.Location = new System.Drawing.Point(118, 43);
            this.nomemedicamentoTextBox.Name = "nomemedicamentoTextBox";
            this.nomemedicamentoTextBox.Size = new System.Drawing.Size(253, 20);
            this.nomemedicamentoTextBox.TabIndex = 3;
            // 
            // medicamentocomposicaoBindingSource
            // 
            this.medicamentocomposicaoBindingSource.DataMember = "medicamentocomposicao";
            this.medicamentocomposicaoBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // medicamentoTableAdapter
            // 
            this.medicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alergiamotivoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doencaTableAdapter = null;
            this.tableAdapterManager.elementonaturalTableAdapter = null;
            this.tableAdapterManager.medicamentocomposicaoTableAdapter = null;
            this.tableAdapterManager.medicamentoTableAdapter = this.medicamentoTableAdapter;
            this.tableAdapterManager.medicoTableAdapter = null;
            this.tableAdapterManager.pacientealergiaTableAdapter = null;
            this.tableAdapterManager.pacientedoencaTableAdapter = null;
            this.tableAdapterManager.pacientepesoTableAdapter = null;
            this.tableAdapterManager.pacienteTableAdapter = null;
            this.tableAdapterManager.pacientevacinaTableAdapter = null;
            this.tableAdapterManager.posologiaTableAdapter = null;
            this.tableAdapterManager.postoTableAdapter = null;
            this.tableAdapterManager.principioativoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacinacronogramaTableAdapter = null;
            this.tableAdapterManager.vacinadoencaTableAdapter = null;
            this.tableAdapterManager.vacinaTableAdapter = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxPesquisa);
            this.groupBox2.Controls.Add(this.comboBoxTipoPesquisa);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 50);
            this.groupBox2.TabIndex = 4;
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
            // medicamentocomposicaoTableAdapter
            // 
            this.medicamentocomposicaoTableAdapter.ClearBeforeFill = true;
            // 
            // principioativoTableAdapter
            // 
            this.principioativoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Medicamento";
            this.Load += new System.EventHandler(this.FrmMedicamento_Load);
            this.Shown += new System.EventHandler(this.FrmMedicamento_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principioativoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKmedicamentocomposicaomedicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingNavigator)).EndInit();
            this.medicamentoBindingNavigator.ResumeLayout(false);
            this.medicamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentocomposicaoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ZeGotinhaDataSet zeGotinhaDataSet;
        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private ZeGotinhaDataSetTableAdapters.medicamentoTableAdapter medicamentoTableAdapter;
        private ZeGotinhaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicamentoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton medicamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView medicamentoDataGridView;
        private System.Windows.Forms.TextBox idmedicamentoTextBox;
        private System.Windows.Forms.TextBox nomemedicamentoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBoxTipoPesquisa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource medicamentocomposicaoBindingSource;
        private ZeGotinhaDataSetTableAdapters.medicamentocomposicaoTableAdapter medicamentocomposicaoTableAdapter;
        private System.Windows.Forms.BindingSource principioativoBindingSource;
        private ZeGotinhaDataSetTableAdapters.principioativoTableAdapter principioativoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprincipioativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKmedicamentocomposicaomedicamentoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprincipioativoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprincipioativoDataGridViewTextBoxColumn;
    }
}