namespace ZeGotinha
{
    partial class FrmElementoNatural
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmElementoNatural));
            System.Windows.Forms.Label idelementonaturalLabel;
            System.Windows.Forms.Label nomeelementonaturalLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBoxTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zeGotinhaDataSet = new ZeGotinha.ZeGotinhaDataSet();
            this.elementonaturalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementonaturalTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.elementonaturalTableAdapter();
            this.tableAdapterManager = new ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager();
            this.elementonaturalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.elementonaturalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.elementonaturalDataGridView = new System.Windows.Forms.DataGridView();
            this.idelementonaturalTextBox = new System.Windows.Forms.TextBox();
            this.nomeelementonaturalTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idelementonaturalLabel = new System.Windows.Forms.Label();
            nomeelementonaturalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementonaturalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementonaturalBindingNavigator)).BeginInit();
            this.elementonaturalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementonaturalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxPesquisa);
            this.groupBox1.Controls.Add(this.comboBoxTipoPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 50);
            this.groupBox1.TabIndex = 22;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(idelementonaturalLabel);
            this.groupBox2.Controls.Add(this.idelementonaturalTextBox);
            this.groupBox2.Controls.Add(nomeelementonaturalLabel);
            this.groupBox2.Controls.Add(this.nomeelementonaturalTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 76);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Elemento Natural";
            // 
            // zeGotinhaDataSet
            // 
            this.zeGotinhaDataSet.DataSetName = "ZeGotinhaDataSet";
            this.zeGotinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementonaturalBindingSource
            // 
            this.elementonaturalBindingSource.DataMember = "elementonatural";
            this.elementonaturalBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // elementonaturalTableAdapter
            // 
            this.elementonaturalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alergiamotivoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doencaTableAdapter = null;
            this.tableAdapterManager.elementonaturalTableAdapter = this.elementonaturalTableAdapter;
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
            this.tableAdapterManager.vacinacronogramaTableAdapter = null;
            this.tableAdapterManager.vacinadoencaTableAdapter = null;
            this.tableAdapterManager.vacinaTableAdapter = null;
            // 
            // elementonaturalBindingNavigator
            // 
            this.elementonaturalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.elementonaturalBindingNavigator.BindingSource = this.elementonaturalBindingSource;
            this.elementonaturalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.elementonaturalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.elementonaturalBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.elementonaturalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.elementonaturalBindingNavigatorSaveItem});
            this.elementonaturalBindingNavigator.Location = new System.Drawing.Point(12, 148);
            this.elementonaturalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.elementonaturalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.elementonaturalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.elementonaturalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.elementonaturalBindingNavigator.Name = "elementonaturalBindingNavigator";
            this.elementonaturalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.elementonaturalBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.elementonaturalBindingNavigator.TabIndex = 23;
            this.elementonaturalBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // elementonaturalBindingNavigatorSaveItem
            // 
            this.elementonaturalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.elementonaturalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("elementonaturalBindingNavigatorSaveItem.Image")));
            this.elementonaturalBindingNavigatorSaveItem.Name = "elementonaturalBindingNavigatorSaveItem";
            this.elementonaturalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.elementonaturalBindingNavigatorSaveItem.Text = "Save Data";
            this.elementonaturalBindingNavigatorSaveItem.Click += new System.EventHandler(this.elementonaturalBindingNavigatorSaveItem_Click);
            // 
            // elementonaturalDataGridView
            // 
            this.elementonaturalDataGridView.AutoGenerateColumns = false;
            this.elementonaturalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementonaturalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.elementonaturalDataGridView.DataSource = this.elementonaturalBindingSource;
            this.elementonaturalDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.elementonaturalDataGridView.Location = new System.Drawing.Point(0, 173);
            this.elementonaturalDataGridView.Name = "elementonaturalDataGridView";
            this.elementonaturalDataGridView.Size = new System.Drawing.Size(525, 220);
            this.elementonaturalDataGridView.TabIndex = 23;
            // 
            // idelementonaturalLabel
            // 
            idelementonaturalLabel.AutoSize = true;
            idelementonaturalLabel.Location = new System.Drawing.Point(10, 25);
            idelementonaturalLabel.Name = "idelementonaturalLabel";
            idelementonaturalLabel.Size = new System.Drawing.Size(116, 13);
            idelementonaturalLabel.TabIndex = 0;
            idelementonaturalLabel.Text = "Cód. Elemento Natural:";
            // 
            // idelementonaturalTextBox
            // 
            this.idelementonaturalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementonaturalBindingSource, "idelementonatural", true));
            this.idelementonaturalTextBox.Enabled = false;
            this.idelementonaturalTextBox.Location = new System.Drawing.Point(138, 22);
            this.idelementonaturalTextBox.Name = "idelementonaturalTextBox";
            this.idelementonaturalTextBox.Size = new System.Drawing.Size(100, 20);
            this.idelementonaturalTextBox.TabIndex = 1;
            // 
            // nomeelementonaturalLabel
            // 
            nomeelementonaturalLabel.AutoSize = true;
            nomeelementonaturalLabel.Location = new System.Drawing.Point(10, 51);
            nomeelementonaturalLabel.Name = "nomeelementonaturalLabel";
            nomeelementonaturalLabel.Size = new System.Drawing.Size(122, 13);
            nomeelementonaturalLabel.TabIndex = 2;
            nomeelementonaturalLabel.Text = "Nome Elemento Natural:";
            // 
            // nomeelementonaturalTextBox
            // 
            this.nomeelementonaturalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.elementonaturalBindingSource, "nomeelementonatural", true));
            this.nomeelementonaturalTextBox.Location = new System.Drawing.Point(138, 48);
            this.nomeelementonaturalTextBox.Name = "nomeelementonaturalTextBox";
            this.nomeelementonaturalTextBox.Size = new System.Drawing.Size(357, 20);
            this.nomeelementonaturalTextBox.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idelementonatural";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Eemento Natural";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeelementonatural";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Elemento Natural";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FrmElementoNatural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 393);
            this.Controls.Add(this.elementonaturalDataGridView);
            this.Controls.Add(this.elementonaturalBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "FrmElementoNatural";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Elemento Natural";
            this.Load += new System.EventHandler(this.FrmElementoNatural_Load);
            this.Shown += new System.EventHandler(this.FrmElementoNatural_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementonaturalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementonaturalBindingNavigator)).EndInit();
            this.elementonaturalBindingNavigator.ResumeLayout(false);
            this.elementonaturalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementonaturalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBoxTipoPesquisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private ZeGotinhaDataSet zeGotinhaDataSet;
        private System.Windows.Forms.BindingSource elementonaturalBindingSource;
        private ZeGotinhaDataSetTableAdapters.elementonaturalTableAdapter elementonaturalTableAdapter;
        private ZeGotinhaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator elementonaturalBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton elementonaturalBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idelementonaturalTextBox;
        private System.Windows.Forms.TextBox nomeelementonaturalTextBox;
        private System.Windows.Forms.DataGridView elementonaturalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}