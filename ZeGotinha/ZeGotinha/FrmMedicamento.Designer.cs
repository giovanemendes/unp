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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicamento));
            System.Windows.Forms.Label idmedicamentoLabel;
            System.Windows.Forms.Label nomemedicamentoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zeGotinhaDataSet = new ZeGotinha.ZeGotinhaDataSet();
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentoTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.medicamentoTableAdapter();
            this.tableAdapterManager = new ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager();
            this.medicamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.medicamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medicamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmedicamentoTextBox = new System.Windows.Forms.TextBox();
            this.nomemedicamentoTextBox = new System.Windows.Forms.TextBox();
            idmedicamentoLabel = new System.Windows.Forms.Label();
            nomemedicamentoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingNavigator)).BeginInit();
            this.medicamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idmedicamentoLabel);
            this.groupBox1.Controls.Add(this.idmedicamentoTextBox);
            this.groupBox1.Controls.Add(nomemedicamentoLabel);
            this.groupBox1.Controls.Add(this.nomemedicamentoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Medicamento";
            // 
            // zeGotinhaDataSet
            // 
            this.zeGotinhaDataSet.DataSetName = "ZeGotinhaDataSet";
            this.zeGotinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataMember = "medicamento";
            this.medicamentoBindingSource.DataSource = this.zeGotinhaDataSet;
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
            this.medicamentoBindingNavigator.Location = new System.Drawing.Point(12, 89);
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
            // medicamentoBindingNavigatorSaveItem
            // 
            this.medicamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicamentoBindingNavigatorSaveItem.Image")));
            this.medicamentoBindingNavigatorSaveItem.Name = "medicamentoBindingNavigatorSaveItem";
            this.medicamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.medicamentoBindingNavigatorSaveItem.Text = "Save Data";
            this.medicamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicamentoBindingNavigatorSaveItem_Click);
            // 
            // medicamentoDataGridView
            // 
            this.medicamentoDataGridView.AutoGenerateColumns = false;
            this.medicamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.medicamentoDataGridView.DataSource = this.medicamentoBindingSource;
            this.medicamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.medicamentoDataGridView.Location = new System.Drawing.Point(0, 120);
            this.medicamentoDataGridView.Name = "medicamentoDataGridView";
            this.medicamentoDataGridView.Size = new System.Drawing.Size(410, 220);
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
            // idmedicamentoLabel
            // 
            idmedicamentoLabel.AutoSize = true;
            idmedicamentoLabel.Location = new System.Drawing.Point(13, 20);
            idmedicamentoLabel.Name = "idmedicamentoLabel";
            idmedicamentoLabel.Size = new System.Drawing.Size(99, 13);
            idmedicamentoLabel.TabIndex = 0;
            idmedicamentoLabel.Text = "Cód. Medicamento:";
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
            // nomemedicamentoLabel
            // 
            nomemedicamentoLabel.AutoSize = true;
            nomemedicamentoLabel.Location = new System.Drawing.Point(13, 46);
            nomemedicamentoLabel.Name = "nomemedicamentoLabel";
            nomemedicamentoLabel.Size = new System.Drawing.Size(105, 13);
            nomemedicamentoLabel.TabIndex = 2;
            nomemedicamentoLabel.Text = "Nome Medicamento:";
            // 
            // nomemedicamentoTextBox
            // 
            this.nomemedicamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "nomemedicamento", true));
            this.nomemedicamentoTextBox.Location = new System.Drawing.Point(118, 43);
            this.nomemedicamentoTextBox.Name = "nomemedicamentoTextBox";
            this.nomemedicamentoTextBox.Size = new System.Drawing.Size(253, 20);
            this.nomemedicamentoTextBox.TabIndex = 3;
            // 
            // FrmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 340);
            this.Controls.Add(this.medicamentoDataGridView);
            this.Controls.Add(this.medicamentoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMedicamento";
            this.Text = "FrmMedicamento";
            this.Load += new System.EventHandler(this.FrmMedicamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingNavigator)).EndInit();
            this.medicamentoBindingNavigator.ResumeLayout(false);
            this.medicamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}