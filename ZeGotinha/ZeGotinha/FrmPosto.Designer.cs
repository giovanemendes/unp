namespace ZeGotinha
{
    partial class FrmPosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPosto));
            System.Windows.Forms.Label idpostoLabel;
            System.Windows.Forms.Label nomepostoLabel;
            System.Windows.Forms.Label tipopostoLabel;
            this.zeGotinhaDataSet = new ZeGotinha.ZeGotinhaDataSet();
            this.postoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postoTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.postoTableAdapter();
            this.tableAdapterManager = new ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager();
            this.postoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.postoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.postoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idpostoTextBox = new System.Windows.Forms.TextBox();
            this.nomepostoTextBox = new System.Windows.Forms.TextBox();
            this.tipopostoTextBox = new System.Windows.Forms.TextBox();
            idpostoLabel = new System.Windows.Forms.Label();
            nomepostoLabel = new System.Windows.Forms.Label();
            tipopostoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoBindingNavigator)).BeginInit();
            this.postoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeGotinhaDataSet
            // 
            this.zeGotinhaDataSet.DataSetName = "ZeGotinhaDataSet";
            this.zeGotinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postoBindingSource
            // 
            this.postoBindingSource.DataMember = "posto";
            this.postoBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // postoTableAdapter
            // 
            this.postoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.postoTableAdapter = this.postoTableAdapter;
            this.tableAdapterManager.principioativoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacinacronogramaTableAdapter = null;
            this.tableAdapterManager.vacinadoencaTableAdapter = null;
            this.tableAdapterManager.vacinaTableAdapter = null;
            // 
            // postoBindingNavigator
            // 
            this.postoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postoBindingNavigator.BindingSource = this.postoBindingSource;
            this.postoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.postoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.postoBindingNavigatorSaveItem});
            this.postoBindingNavigator.Location = new System.Drawing.Point(12, 88);
            this.postoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postoBindingNavigator.Name = "postoBindingNavigator";
            this.postoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postoBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.postoBindingNavigator.TabIndex = 0;
            this.postoBindingNavigator.Text = "bindingNavigator1";
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
            // postoBindingNavigatorSaveItem
            // 
            this.postoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postoBindingNavigatorSaveItem.Image")));
            this.postoBindingNavigatorSaveItem.Name = "postoBindingNavigatorSaveItem";
            this.postoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.postoBindingNavigatorSaveItem.Text = "Save Data";
            this.postoBindingNavigatorSaveItem.Click += new System.EventHandler(this.postoBindingNavigatorSaveItem_Click);
            // 
            // postoDataGridView
            // 
            this.postoDataGridView.AutoGenerateColumns = false;
            this.postoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.postoDataGridView.DataSource = this.postoBindingSource;
            this.postoDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postoDataGridView.Location = new System.Drawing.Point(0, 116);
            this.postoDataGridView.Name = "postoDataGridView";
            this.postoDataGridView.Size = new System.Drawing.Size(410, 228);
            this.postoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idposto";
            this.dataGridViewTextBoxColumn1.HeaderText = "idposto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeposto";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeposto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipoposto";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipoposto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idpostoLabel);
            this.groupBox1.Controls.Add(this.idpostoTextBox);
            this.groupBox1.Controls.Add(nomepostoLabel);
            this.groupBox1.Controls.Add(this.nomepostoTextBox);
            this.groupBox1.Controls.Add(tipopostoLabel);
            this.groupBox1.Controls.Add(this.tipopostoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Posto";
            // 
            // idpostoLabel
            // 
            idpostoLabel.AutoSize = true;
            idpostoLabel.Location = new System.Drawing.Point(13, 22);
            idpostoLabel.Name = "idpostoLabel";
            idpostoLabel.Size = new System.Drawing.Size(44, 13);
            idpostoLabel.TabIndex = 0;
            idpostoLabel.Text = "idposto:";
            // 
            // idpostoTextBox
            // 
            this.idpostoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postoBindingSource, "idposto", true));
            this.idpostoTextBox.Location = new System.Drawing.Point(81, 19);
            this.idpostoTextBox.Name = "idpostoTextBox";
            this.idpostoTextBox.ReadOnly = true;
            this.idpostoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idpostoTextBox.TabIndex = 1;
            // 
            // nomepostoLabel
            // 
            nomepostoLabel.AutoSize = true;
            nomepostoLabel.Location = new System.Drawing.Point(13, 48);
            nomepostoLabel.Name = "nomepostoLabel";
            nomepostoLabel.Size = new System.Drawing.Size(62, 13);
            nomepostoLabel.TabIndex = 2;
            nomepostoLabel.Text = "nomeposto:";
            // 
            // nomepostoTextBox
            // 
            this.nomepostoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postoBindingSource, "nomeposto", true));
            this.nomepostoTextBox.Location = new System.Drawing.Point(81, 45);
            this.nomepostoTextBox.Name = "nomepostoTextBox";
            this.nomepostoTextBox.Size = new System.Drawing.Size(299, 20);
            this.nomepostoTextBox.TabIndex = 3;
            // 
            // tipopostoLabel
            // 
            tipopostoLabel.AutoSize = true;
            tipopostoLabel.Location = new System.Drawing.Point(212, 22);
            tipopostoLabel.Name = "tipopostoLabel";
            tipopostoLabel.Size = new System.Drawing.Size(53, 13);
            tipopostoLabel.TabIndex = 4;
            tipopostoLabel.Text = "tipoposto:";
            // 
            // tipopostoTextBox
            // 
            this.tipopostoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postoBindingSource, "tipoposto", true));
            this.tipopostoTextBox.Location = new System.Drawing.Point(280, 19);
            this.tipopostoTextBox.Name = "tipopostoTextBox";
            this.tipopostoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipopostoTextBox.TabIndex = 5;
            // 
            // FrmPosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.postoDataGridView);
            this.Controls.Add(this.postoBindingNavigator);
            this.Name = "FrmPosto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPosto";
            this.Load += new System.EventHandler(this.FrmPosto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postoBindingNavigator)).EndInit();
            this.postoBindingNavigator.ResumeLayout(false);
            this.postoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZeGotinhaDataSet zeGotinhaDataSet;
        private System.Windows.Forms.BindingSource postoBindingSource;
        private ZeGotinhaDataSetTableAdapters.postoTableAdapter postoTableAdapter;
        private ZeGotinhaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton postoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView postoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idpostoTextBox;
        private System.Windows.Forms.TextBox nomepostoTextBox;
        private System.Windows.Forms.TextBox tipopostoTextBox;
    }
}