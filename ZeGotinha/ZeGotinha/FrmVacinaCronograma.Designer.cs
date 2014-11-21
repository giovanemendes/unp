namespace ZeGotinha
{
    partial class FrmVacinaCronograma
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
            System.Windows.Forms.Label idvacinacronogramaLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label valorinicialLabel;
            System.Windows.Forms.Label valorfinalLabel;
            System.Windows.Forms.Label idvacinaLabel;
            System.Windows.Forms.Label idanteriorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVacinaCronograma));
            this.vacinacronogramaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vacinacronogramaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zeGotinhaDataSet = new ZeGotinha.ZeGotinhaDataSet();
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
            this.vacinacronogramaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vacinacronogramaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idvacinacronogramaTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.valorinicialTextBox = new System.Windows.Forms.TextBox();
            this.valorfinalTextBox = new System.Windows.Forms.TextBox();
            this.idvacinaTextBox = new System.Windows.Forms.TextBox();
            this.idanteriorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBoxTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.vacinacronogramaTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.vacinacronogramaTableAdapter();
            this.tableAdapterManager = new ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager();
            idvacinacronogramaLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            valorinicialLabel = new System.Windows.Forms.Label();
            valorfinalLabel = new System.Windows.Forms.Label();
            idvacinaLabel = new System.Windows.Forms.Label();
            idanteriorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacronogramaBindingNavigator)).BeginInit();
            this.vacinacronogramaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacronogramaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacronogramaDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idvacinacronogramaLabel
            // 
            idvacinacronogramaLabel.AutoSize = true;
            idvacinacronogramaLabel.Location = new System.Drawing.Point(6, 25);
            idvacinacronogramaLabel.Name = "idvacinacronogramaLabel";
            idvacinacronogramaLabel.Size = new System.Drawing.Size(89, 13);
            idvacinacronogramaLabel.TabIndex = 15;
            idvacinacronogramaLabel.Text = "Cód. Cronograma";
            idvacinacronogramaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(115, 25);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 17;
            descricaoLabel.Text = "Descricao:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(6, 65);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 19;
            tipoLabel.Text = "Tipo:";
            // 
            // valorinicialLabel
            // 
            valorinicialLabel.AutoSize = true;
            valorinicialLabel.Location = new System.Drawing.Point(115, 65);
            valorinicialLabel.Name = "valorinicialLabel";
            valorinicialLabel.Size = new System.Drawing.Size(37, 13);
            valorinicialLabel.TabIndex = 21;
            valorinicialLabel.Text = "Início:";
            // 
            // valorfinalLabel
            // 
            valorfinalLabel.AutoSize = true;
            valorfinalLabel.Location = new System.Drawing.Point(221, 65);
            valorfinalLabel.Name = "valorfinalLabel";
            valorfinalLabel.Size = new System.Drawing.Size(26, 13);
            valorfinalLabel.TabIndex = 23;
            valorfinalLabel.Text = "Fim:";
            // 
            // idvacinaLabel
            // 
            idvacinaLabel.AutoSize = true;
            idvacinaLabel.Location = new System.Drawing.Point(6, 104);
            idvacinaLabel.Name = "idvacinaLabel";
            idvacinaLabel.Size = new System.Drawing.Size(68, 13);
            idvacinaLabel.TabIndex = 25;
            idvacinaLabel.Text = "Cód. Vacina:";
            // 
            // idanteriorLabel
            // 
            idanteriorLabel.AutoSize = true;
            idanteriorLabel.Location = new System.Drawing.Point(115, 104);
            idanteriorLabel.Name = "idanteriorLabel";
            idanteriorLabel.Size = new System.Drawing.Size(111, 13);
            idanteriorLabel.TabIndex = 27;
            idanteriorLabel.Text = "Cód. Cronog. Anterior:";
            // 
            // vacinacronogramaBindingNavigator
            // 
            this.vacinacronogramaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vacinacronogramaBindingNavigator.BindingSource = this.vacinacronogramaBindingSource;
            this.vacinacronogramaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vacinacronogramaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vacinacronogramaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.vacinacronogramaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vacinacronogramaBindingNavigatorSaveItem});
            this.vacinacronogramaBindingNavigator.Location = new System.Drawing.Point(12, 223);
            this.vacinacronogramaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vacinacronogramaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vacinacronogramaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vacinacronogramaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vacinacronogramaBindingNavigator.Name = "vacinacronogramaBindingNavigator";
            this.vacinacronogramaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vacinacronogramaBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.vacinacronogramaBindingNavigator.TabIndex = 0;
            this.vacinacronogramaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // vacinacronogramaBindingSource
            // 
            this.vacinacronogramaBindingSource.DataMember = "vacinacronograma";
            this.vacinacronogramaBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // zeGotinhaDataSet
            // 
            this.zeGotinhaDataSet.DataSetName = "ZeGotinhaDataSet";
            this.zeGotinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // vacinacronogramaBindingNavigatorSaveItem
            // 
            this.vacinacronogramaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vacinacronogramaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vacinacronogramaBindingNavigatorSaveItem.Image")));
            this.vacinacronogramaBindingNavigatorSaveItem.Name = "vacinacronogramaBindingNavigatorSaveItem";
            this.vacinacronogramaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vacinacronogramaBindingNavigatorSaveItem.Text = "Save Data";
            this.vacinacronogramaBindingNavigatorSaveItem.Click += new System.EventHandler(this.vacinacronogramaBindingNavigatorSaveItem_Click);
            // 
            // vacinacronogramaDataGridView
            // 
            this.vacinacronogramaDataGridView.AutoGenerateColumns = false;
            this.vacinacronogramaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacinacronogramaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.vacinacronogramaDataGridView.DataSource = this.vacinacronogramaBindingSource;
            this.vacinacronogramaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vacinacronogramaDataGridView.Location = new System.Drawing.Point(0, 248);
            this.vacinacronogramaDataGridView.Name = "vacinacronogramaDataGridView";
            this.vacinacronogramaDataGridView.Size = new System.Drawing.Size(527, 220);
            this.vacinacronogramaDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idvacinacronograma";
            this.dataGridViewTextBoxColumn1.HeaderText = "idvacinacronograma";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valorinicial";
            this.dataGridViewTextBoxColumn4.HeaderText = "valorinicial";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valorfinal";
            this.dataGridViewTextBoxColumn5.HeaderText = "valorfinal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idvacina";
            this.dataGridViewTextBoxColumn6.HeaderText = "idvacina";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idanterior";
            this.dataGridViewTextBoxColumn7.HeaderText = "idanterior";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(idvacinacronogramaLabel);
            this.groupBox2.Controls.Add(this.idvacinacronogramaTextBox);
            this.groupBox2.Controls.Add(descricaoLabel);
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(tipoLabel);
            this.groupBox2.Controls.Add(this.tipoTextBox);
            this.groupBox2.Controls.Add(valorinicialLabel);
            this.groupBox2.Controls.Add(this.valorinicialTextBox);
            this.groupBox2.Controls.Add(valorfinalLabel);
            this.groupBox2.Controls.Add(this.valorfinalTextBox);
            this.groupBox2.Controls.Add(idvacinaLabel);
            this.groupBox2.Controls.Add(this.idvacinaTextBox);
            this.groupBox2.Controls.Add(idanteriorLabel);
            this.groupBox2.Controls.Add(this.idanteriorTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 151);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Cronograma";
            // 
            // idvacinacronogramaTextBox
            // 
            this.idvacinacronogramaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacronogramaBindingSource, "idvacinacronograma", true));
            this.idvacinacronogramaTextBox.Enabled = false;
            this.idvacinacronogramaTextBox.Location = new System.Drawing.Point(9, 41);
            this.idvacinacronogramaTextBox.Name = "idvacinacronogramaTextBox";
            this.idvacinacronogramaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idvacinacronogramaTextBox.TabIndex = 16;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacronogramaBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(118, 41);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(365, 20);
            this.descricaoTextBox.TabIndex = 18;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacronogramaBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(9, 81);
            this.tipoTextBox.MaxLength = 1;
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoTextBox.TabIndex = 20;
            // 
            // valorinicialTextBox
            // 
            this.valorinicialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacronogramaBindingSource, "valorinicial", true));
            this.valorinicialTextBox.Location = new System.Drawing.Point(118, 81);
            this.valorinicialTextBox.Name = "valorinicialTextBox";
            this.valorinicialTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorinicialTextBox.TabIndex = 22;
            // 
            // valorfinalTextBox
            // 
            this.valorfinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacronogramaBindingSource, "valorfinal", true));
            this.valorfinalTextBox.Location = new System.Drawing.Point(224, 81);
            this.valorfinalTextBox.Name = "valorfinalTextBox";
            this.valorfinalTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorfinalTextBox.TabIndex = 24;
            // 
            // idvacinaTextBox
            // 
            this.idvacinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacronogramaBindingSource, "idvacina", true));
            this.idvacinaTextBox.Location = new System.Drawing.Point(9, 120);
            this.idvacinaTextBox.Name = "idvacinaTextBox";
            this.idvacinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idvacinaTextBox.TabIndex = 26;
            // 
            // idanteriorTextBox
            // 
            this.idanteriorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinacronogramaBindingSource, "idanterior", true));
            this.idanteriorTextBox.Location = new System.Drawing.Point(118, 120);
            this.idanteriorTextBox.Name = "idanteriorTextBox";
            this.idanteriorTextBox.Size = new System.Drawing.Size(100, 20);
            this.idanteriorTextBox.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxPesquisa);
            this.groupBox1.Controls.Add(this.comboBoxTipoPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 50);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(118, 19);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(296, 20);
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
            this.comboBoxTipoPesquisa.Size = new System.Drawing.Size(103, 21);
            this.comboBoxTipoPesquisa.TabIndex = 0;
            // 
            // vacinacronogramaTableAdapter
            // 
            this.vacinacronogramaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.pacienteTableAdapter = null;
            this.tableAdapterManager.pacientevacinaTableAdapter = null;
            this.tableAdapterManager.posologiaTableAdapter = null;
            this.tableAdapterManager.postoTableAdapter = null;
            this.tableAdapterManager.principioativoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacinacronogramaTableAdapter = this.vacinacronogramaTableAdapter;
            this.tableAdapterManager.vacinadoencaTableAdapter = null;
            this.tableAdapterManager.vacinaTableAdapter = null;
            // 
            // FrmVacinaCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.vacinacronogramaDataGridView);
            this.Controls.Add(this.vacinacronogramaBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "FrmVacinaCronograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cronograma de Vacinação";
            this.Load += new System.EventHandler(this.FrmVacinaCronograma_Load);
            this.Shown += new System.EventHandler(this.FrmVacinaCronograma_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.vacinacronogramaBindingNavigator)).EndInit();
            this.vacinacronogramaBindingNavigator.ResumeLayout(false);
            this.vacinacronogramaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacronogramaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinacronogramaDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZeGotinhaDataSet zeGotinhaDataSet;
        private System.Windows.Forms.BindingSource vacinacronogramaBindingSource;
        private ZeGotinhaDataSetTableAdapters.vacinacronogramaTableAdapter vacinacronogramaTableAdapter;
        private ZeGotinhaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vacinacronogramaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vacinacronogramaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vacinacronogramaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox idvacinacronogramaTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox valorinicialTextBox;
        private System.Windows.Forms.TextBox valorfinalTextBox;
        private System.Windows.Forms.TextBox idvacinaTextBox;
        private System.Windows.Forms.TextBox idanteriorTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBoxTipoPesquisa;
    }
}