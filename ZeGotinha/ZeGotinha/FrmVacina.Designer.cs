namespace ZeGotinha
{
    partial class FrmVacina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVacina));
            System.Windows.Forms.Label idvacinaLabel;
            System.Windows.Forms.Label nomevacinaLabel;
            this.zeGotinhaDataSet = new ZeGotinha.ZeGotinhaDataSet();
            this.vacinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacinaTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.vacinaTableAdapter();
            this.tableAdapterManager = new ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager();
            this.vacinaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vacinaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vacinaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idvacinaTextBox = new System.Windows.Forms.TextBox();
            this.nomevacinaTextBox = new System.Windows.Forms.TextBox();
            idvacinaLabel = new System.Windows.Forms.Label();
            nomevacinaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinaBindingNavigator)).BeginInit();
            this.vacinaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacinaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeGotinhaDataSet
            // 
            this.zeGotinhaDataSet.DataSetName = "ZeGotinhaDataSet";
            this.zeGotinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacinaBindingSource
            // 
            this.vacinaBindingSource.DataMember = "vacina";
            this.vacinaBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // vacinaTableAdapter
            // 
            this.vacinaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.vacinacronogramaTableAdapter = null;
            this.tableAdapterManager.vacinadoencaTableAdapter = null;
            this.tableAdapterManager.vacinaTableAdapter = this.vacinaTableAdapter;
            // 
            // vacinaBindingNavigator
            // 
            this.vacinaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vacinaBindingNavigator.BindingSource = this.vacinaBindingSource;
            this.vacinaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vacinaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vacinaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.vacinaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vacinaBindingNavigatorSaveItem});
            this.vacinaBindingNavigator.Location = new System.Drawing.Point(9, 91);
            this.vacinaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vacinaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vacinaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vacinaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vacinaBindingNavigator.Name = "vacinaBindingNavigator";
            this.vacinaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vacinaBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.vacinaBindingNavigator.TabIndex = 0;
            this.vacinaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // vacinaBindingNavigatorSaveItem
            // 
            this.vacinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vacinaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vacinaBindingNavigatorSaveItem.Image")));
            this.vacinaBindingNavigatorSaveItem.Name = "vacinaBindingNavigatorSaveItem";
            this.vacinaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.vacinaBindingNavigatorSaveItem.Text = "Save Data";
            this.vacinaBindingNavigatorSaveItem.Click += new System.EventHandler(this.vacinaBindingNavigatorSaveItem_Click_1);
            // 
            // vacinaDataGridView
            // 
            this.vacinaDataGridView.AutoGenerateColumns = false;
            this.vacinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacinaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.vacinaDataGridView.DataSource = this.vacinaBindingSource;
            this.vacinaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vacinaDataGridView.Location = new System.Drawing.Point(0, 119);
            this.vacinaDataGridView.Name = "vacinaDataGridView";
            this.vacinaDataGridView.Size = new System.Drawing.Size(410, 214);
            this.vacinaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idvacina";
            this.dataGridViewTextBoxColumn1.HeaderText = "idvacina";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomevacina";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomevacina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idvacinaLabel);
            this.groupBox1.Controls.Add(this.idvacinaTextBox);
            this.groupBox1.Controls.Add(nomevacinaLabel);
            this.groupBox1.Controls.Add(this.nomevacinaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Vacina";
            // 
            // idvacinaLabel
            // 
            idvacinaLabel.AutoSize = true;
            idvacinaLabel.Location = new System.Drawing.Point(17, 22);
            idvacinaLabel.Name = "idvacinaLabel";
            idvacinaLabel.Size = new System.Drawing.Size(68, 13);
            idvacinaLabel.TabIndex = 0;
            idvacinaLabel.Text = "Cód. Vacina:";
            // 
            // idvacinaTextBox
            // 
            this.idvacinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinaBindingSource, "idvacina", true));
            this.idvacinaTextBox.Location = new System.Drawing.Point(91, 19);
            this.idvacinaTextBox.Name = "idvacinaTextBox";
            this.idvacinaTextBox.ReadOnly = true;
            this.idvacinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idvacinaTextBox.TabIndex = 1;
            // 
            // nomevacinaLabel
            // 
            nomevacinaLabel.AutoSize = true;
            nomevacinaLabel.Location = new System.Drawing.Point(17, 48);
            nomevacinaLabel.Name = "nomevacinaLabel";
            nomevacinaLabel.Size = new System.Drawing.Size(74, 13);
            nomevacinaLabel.TabIndex = 2;
            nomevacinaLabel.Text = "Nome Vacina:";
            // 
            // nomevacinaTextBox
            // 
            this.nomevacinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacinaBindingSource, "nomevacina", true));
            this.nomevacinaTextBox.Location = new System.Drawing.Point(91, 45);
            this.nomevacinaTextBox.Name = "nomevacinaTextBox";
            this.nomevacinaTextBox.Size = new System.Drawing.Size(289, 20);
            this.nomevacinaTextBox.TabIndex = 3;
            // 
            // FrmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vacinaDataGridView);
            this.Controls.Add(this.vacinaBindingNavigator);
            this.Name = "FrmVacina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVacina";
            this.Load += new System.EventHandler(this.FrmVacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacinaBindingNavigator)).EndInit();
            this.vacinaBindingNavigator.ResumeLayout(false);
            this.vacinaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacinaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZeGotinhaDataSet zeGotinhaDataSet;
        private System.Windows.Forms.BindingSource vacinaBindingSource;
        private ZeGotinhaDataSetTableAdapters.vacinaTableAdapter vacinaTableAdapter;
        private ZeGotinhaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vacinaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vacinaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vacinaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idvacinaTextBox;
        private System.Windows.Forms.TextBox nomevacinaTextBox;

    }
}