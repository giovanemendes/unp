namespace ZeGotinha
{
    partial class FrmDoenca
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
            System.Windows.Forms.Label iddoencaLabel;
            System.Windows.Forms.Label nomedoencaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoenca));
            this.zeGotinhaDataSet = new ZeGotinha.ZeGotinhaDataSet();
            this.doencaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doencaTableAdapter = new ZeGotinha.ZeGotinhaDataSetTableAdapters.doencaTableAdapter();
            this.tableAdapterManager = new ZeGotinha.ZeGotinhaDataSetTableAdapters.TableAdapterManager();
            this.doencaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.doencaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.doencaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iddoencaTextBox = new System.Windows.Forms.TextBox();
            this.nomedoencaTextBox = new System.Windows.Forms.TextBox();
            iddoencaLabel = new System.Windows.Forms.Label();
            nomedoencaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doencaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doencaBindingNavigator)).BeginInit();
            this.doencaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doencaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iddoencaLabel
            // 
            iddoencaLabel.AutoSize = true;
            iddoencaLabel.Location = new System.Drawing.Point(6, 22);
            iddoencaLabel.Name = "iddoencaLabel";
            iddoencaLabel.Size = new System.Drawing.Size(70, 13);
            iddoencaLabel.TabIndex = 0;
            iddoencaLabel.Text = "Cód. Doença";
            // 
            // nomedoencaLabel
            // 
            nomedoencaLabel.AutoSize = true;
            nomedoencaLabel.Location = new System.Drawing.Point(6, 48);
            nomedoencaLabel.Name = "nomedoencaLabel";
            nomedoencaLabel.Size = new System.Drawing.Size(76, 13);
            nomedoencaLabel.TabIndex = 2;
            nomedoencaLabel.Text = "Nome Doença";
            // 
            // zeGotinhaDataSet
            // 
            this.zeGotinhaDataSet.DataSetName = "ZeGotinhaDataSet";
            this.zeGotinhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doencaBindingSource
            // 
            this.doencaBindingSource.DataMember = "doenca";
            this.doencaBindingSource.DataSource = this.zeGotinhaDataSet;
            // 
            // doencaTableAdapter
            // 
            this.doencaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alergiamotivoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doencaTableAdapter = this.doencaTableAdapter;
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
            this.tableAdapterManager.vacinaTableAdapter = null;
            // 
            // doencaBindingNavigator
            // 
            this.doencaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doencaBindingNavigator.BindingSource = this.doencaBindingSource;
            this.doencaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doencaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doencaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.doencaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doencaBindingNavigatorSaveItem});
            this.doencaBindingNavigator.Location = new System.Drawing.Point(12, 94);
            this.doencaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doencaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doencaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doencaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doencaBindingNavigator.Name = "doencaBindingNavigator";
            this.doencaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doencaBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.doencaBindingNavigator.TabIndex = 0;
            this.doencaBindingNavigator.Text = "bindingNavigator1";
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
            // doencaBindingNavigatorSaveItem
            // 
            this.doencaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doencaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doencaBindingNavigatorSaveItem.Image")));
            this.doencaBindingNavigatorSaveItem.Name = "doencaBindingNavigatorSaveItem";
            this.doencaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.doencaBindingNavigatorSaveItem.Text = "Save Data";
            this.doencaBindingNavigatorSaveItem.Click += new System.EventHandler(this.doencaBindingNavigatorSaveItem_Click);
            // 
            // doencaDataGridView
            // 
            this.doencaDataGridView.AutoGenerateColumns = false;
            this.doencaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doencaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.doencaDataGridView.DataSource = this.doencaBindingSource;
            this.doencaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doencaDataGridView.Location = new System.Drawing.Point(0, 122);
            this.doencaDataGridView.Name = "doencaDataGridView";
            this.doencaDataGridView.Size = new System.Drawing.Size(348, 220);
            this.doencaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iddoenca";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Doença";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomedoenca";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição Doença";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(iddoencaLabel);
            this.groupBox1.Controls.Add(this.iddoencaTextBox);
            this.groupBox1.Controls.Add(nomedoencaLabel);
            this.groupBox1.Controls.Add(this.nomedoencaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Doença";
            // 
            // iddoencaTextBox
            // 
            this.iddoencaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doencaBindingSource, "iddoenca", true));
            this.iddoencaTextBox.Location = new System.Drawing.Point(84, 19);
            this.iddoencaTextBox.Name = "iddoencaTextBox";
            this.iddoencaTextBox.ReadOnly = true;
            this.iddoencaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iddoencaTextBox.TabIndex = 1;
            // 
            // nomedoencaTextBox
            // 
            this.nomedoencaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doencaBindingSource, "nomedoenca", true));
            this.nomedoencaTextBox.Location = new System.Drawing.Point(84, 45);
            this.nomedoencaTextBox.Name = "nomedoencaTextBox";
            this.nomedoencaTextBox.Size = new System.Drawing.Size(226, 20);
            this.nomedoencaTextBox.TabIndex = 3;
            // 
            // FrmDoenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doencaDataGridView);
            this.Controls.Add(this.doencaBindingNavigator);
            this.Name = "FrmDoenca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Doenças";
            this.Load += new System.EventHandler(this.FrmDoenca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zeGotinhaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doencaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doencaBindingNavigator)).EndInit();
            this.doencaBindingNavigator.ResumeLayout(false);
            this.doencaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doencaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZeGotinhaDataSet zeGotinhaDataSet;
        private System.Windows.Forms.BindingSource doencaBindingSource;
        private ZeGotinhaDataSetTableAdapters.doencaTableAdapter doencaTableAdapter;
        private ZeGotinhaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doencaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton doencaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView doencaDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox iddoencaTextBox;
        private System.Windows.Forms.TextBox nomedoencaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}