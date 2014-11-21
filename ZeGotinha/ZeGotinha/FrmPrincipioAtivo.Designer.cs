namespace ZeGotinha
{
    partial class FrmPrincipioAtivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipioAtivo));
            System.Windows.Forms.Label idprincipioativoLabel;
            System.Windows.Forms.Label nomeprincipioativoLabel;
            this.zeGotinhaDataSet = new ZeGotinha.ZeGotinhaDataSet();
            this.principioativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.principioativoTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.principioativoTableAdapter();
            this.tableAdapterManager = new ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager();
            this.principioativoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.principioativoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.principioativoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idprincipioativoTextBox = new System.Windows.Forms.TextBox();
            this.nomeprincipioativoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idprincipioativoLabel = new System.Windows.Forms.Label();
            nomeprincipioativoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principioativoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principioativoBindingNavigator)).BeginInit();
            this.principioativoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principioativoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeGotinhaDataSet
            // 
            this.zeGotinhaDataSet.DataSetName = "ZeGotinhaDataSet";
            this.zeGotinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // principioativoBindingSource
            // 
            this.principioativoBindingSource.DataMember = "principioativo";
            this.principioativoBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // principioativoTableAdapter
            // 
            this.principioativoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.principioativoTableAdapter = this.principioativoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacinacronogramaTableAdapter = null;
            this.tableAdapterManager.vacinadoencaTableAdapter = null;
            this.tableAdapterManager.vacinaTableAdapter = null;
            // 
            // principioativoBindingNavigator
            // 
            this.principioativoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.principioativoBindingNavigator.BindingSource = this.principioativoBindingSource;
            this.principioativoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.principioativoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.principioativoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.principioativoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.principioativoBindingNavigatorSaveItem});
            this.principioativoBindingNavigator.Location = new System.Drawing.Point(12, 94);
            this.principioativoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.principioativoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.principioativoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.principioativoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.principioativoBindingNavigator.Name = "principioativoBindingNavigator";
            this.principioativoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.principioativoBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.principioativoBindingNavigator.TabIndex = 0;
            this.principioativoBindingNavigator.Text = "bindingNavigator1";
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
            // principioativoBindingNavigatorSaveItem
            // 
            this.principioativoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.principioativoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("principioativoBindingNavigatorSaveItem.Image")));
            this.principioativoBindingNavigatorSaveItem.Name = "principioativoBindingNavigatorSaveItem";
            this.principioativoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.principioativoBindingNavigatorSaveItem.Text = "Save Data";
            this.principioativoBindingNavigatorSaveItem.Click += new System.EventHandler(this.principioativoBindingNavigatorSaveItem_Click);
            // 
            // principioativoDataGridView
            // 
            this.principioativoDataGridView.AutoGenerateColumns = false;
            this.principioativoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.principioativoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.principioativoDataGridView.DataSource = this.principioativoBindingSource;
            this.principioativoDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.principioativoDataGridView.Location = new System.Drawing.Point(0, 122);
            this.principioativoDataGridView.Name = "principioativoDataGridView";
            this.principioativoDataGridView.Size = new System.Drawing.Size(348, 220);
            this.principioativoDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idprincipioativoLabel);
            this.groupBox1.Controls.Add(this.idprincipioativoTextBox);
            this.groupBox1.Controls.Add(nomeprincipioativoLabel);
            this.groupBox1.Controls.Add(this.nomeprincipioativoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Princípio Ativo";
            // 
            // idprincipioativoLabel
            // 
            idprincipioativoLabel.AutoSize = true;
            idprincipioativoLabel.Location = new System.Drawing.Point(5, 26);
            idprincipioativoLabel.Name = "idprincipioativoLabel";
            idprincipioativoLabel.Size = new System.Drawing.Size(102, 13);
            idprincipioativoLabel.TabIndex = 0;
            idprincipioativoLabel.Text = "Cód. Principio Ativo:";
            // 
            // idprincipioativoTextBox
            // 
            this.idprincipioativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.principioativoBindingSource, "idprincipioativo", true));
            this.idprincipioativoTextBox.Location = new System.Drawing.Point(113, 23);
            this.idprincipioativoTextBox.Name = "idprincipioativoTextBox";
            this.idprincipioativoTextBox.ReadOnly = true;
            this.idprincipioativoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idprincipioativoTextBox.TabIndex = 1;
            // 
            // nomeprincipioativoLabel
            // 
            nomeprincipioativoLabel.AutoSize = true;
            nomeprincipioativoLabel.Location = new System.Drawing.Point(5, 52);
            nomeprincipioativoLabel.Name = "nomeprincipioativoLabel";
            nomeprincipioativoLabel.Size = new System.Drawing.Size(108, 13);
            nomeprincipioativoLabel.TabIndex = 2;
            nomeprincipioativoLabel.Text = "Nome Principio Ativo:";
            // 
            // nomeprincipioativoTextBox
            // 
            this.nomeprincipioativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.principioativoBindingSource, "nomeprincipioativo", true));
            this.nomeprincipioativoTextBox.Location = new System.Drawing.Point(113, 49);
            this.nomeprincipioativoTextBox.Name = "nomeprincipioativoTextBox";
            this.nomeprincipioativoTextBox.Size = new System.Drawing.Size(205, 20);
            this.nomeprincipioativoTextBox.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idprincipioativo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Principio Ativo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeprincipioativo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Principio Ativo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FrmPrincipioAtivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.principioativoDataGridView);
            this.Controls.Add(this.principioativoBindingNavigator);
            this.Name = "FrmPrincipioAtivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipioAtivo";
            this.Load += new System.EventHandler(this.FrmPrincipioAtivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principioativoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principioativoBindingNavigator)).EndInit();
            this.principioativoBindingNavigator.ResumeLayout(false);
            this.principioativoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.principioativoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZeGotinhaDataSet zeGotinhaDataSet;
        private System.Windows.Forms.BindingSource principioativoBindingSource;
        private ZeGotinhaDataSetTableAdapters.principioativoTableAdapter principioativoTableAdapter;
        private ZeGotinhaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator principioativoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton principioativoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView principioativoDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idprincipioativoTextBox;
        private System.Windows.Forms.TextBox nomeprincipioativoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}