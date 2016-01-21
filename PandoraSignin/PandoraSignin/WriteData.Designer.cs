namespace PandoraSignin
{
    partial class WriteData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteData));
            this.userInfoDataSet1 = new PandoraSignin.UserInfoDataSet1();
            this.userLoginTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLoginTableTableAdapter = new PandoraSignin.UserInfoDataSet1TableAdapters.UserLoginTableTableAdapter();
            this.tableAdapterManager = new PandoraSignin.UserInfoDataSet1TableAdapters.TableAdapterManager();
            this.userLoginTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.userLoginTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userLoginTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTableBindingNavigator)).BeginInit();
            this.userLoginTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfoDataSet1
            // 
            this.userInfoDataSet1.DataSetName = "UserInfoDataSet1";
            this.userInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userLoginTableBindingSource
            // 
            this.userLoginTableBindingSource.DataMember = "UserLoginTable";
            this.userLoginTableBindingSource.DataSource = this.userInfoDataSet1;
            // 
            // userLoginTableTableAdapter
            // 
            this.userLoginTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PandoraSignin.UserInfoDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserLoginTableTableAdapter = this.userLoginTableTableAdapter;
            // 
            // userLoginTableBindingNavigator
            // 
            this.userLoginTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userLoginTableBindingNavigator.BindingSource = this.userLoginTableBindingSource;
            this.userLoginTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userLoginTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userLoginTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.userLoginTableBindingNavigatorSaveItem});
            this.userLoginTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userLoginTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userLoginTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userLoginTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userLoginTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userLoginTableBindingNavigator.Name = "userLoginTableBindingNavigator";
            this.userLoginTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userLoginTableBindingNavigator.Size = new System.Drawing.Size(595, 25);
            this.userLoginTableBindingNavigator.TabIndex = 0;
            this.userLoginTableBindingNavigator.Text = "bindingNavigator1";
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
            // userLoginTableBindingNavigatorSaveItem
            // 
            this.userLoginTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userLoginTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userLoginTableBindingNavigatorSaveItem.Image")));
            this.userLoginTableBindingNavigatorSaveItem.Name = "userLoginTableBindingNavigatorSaveItem";
            this.userLoginTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.userLoginTableBindingNavigatorSaveItem.Text = "Save Data";
            this.userLoginTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.userLoginTableBindingNavigatorSaveItem_Click);
            // 
            // userLoginTableDataGridView
            // 
            this.userLoginTableDataGridView.AutoGenerateColumns = false;
            this.userLoginTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userLoginTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.userLoginTableDataGridView.DataSource = this.userLoginTableBindingSource;
            this.userLoginTableDataGridView.Location = new System.Drawing.Point(12, 28);
            this.userLoginTableDataGridView.Name = "userLoginTableDataGridView";
            this.userLoginTableDataGridView.Size = new System.Drawing.Size(571, 292);
            this.userLoginTableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn1.HeaderText = "username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn2.HeaderText = "password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // WriteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 332);
            this.Controls.Add(this.userLoginTableDataGridView);
            this.Controls.Add(this.userLoginTableBindingNavigator);
            this.Name = "WriteData";
            this.Text = "WriteData";
            this.Load += new System.EventHandler(this.WriteData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTableBindingNavigator)).EndInit();
            this.userLoginTableBindingNavigator.ResumeLayout(false);
            this.userLoginTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserInfoDataSet1 userInfoDataSet1;
        private System.Windows.Forms.BindingSource userLoginTableBindingSource;
        private UserInfoDataSet1TableAdapters.UserLoginTableTableAdapter userLoginTableTableAdapter;
        private UserInfoDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userLoginTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton userLoginTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView userLoginTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}