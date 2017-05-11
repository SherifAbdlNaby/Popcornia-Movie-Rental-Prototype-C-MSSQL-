namespace Popcornia
{
    partial class AllComposers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.composersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popcorniaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popcorniaDataSet1 = new Popcornia.PopcorniaDataSet1();
            this.popcorniaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.composersTableAdapter = new Popcornia.PopcorniaDataSet1TableAdapters.ComposersTableAdapter();
            this.tableAdapterManager = new Popcornia.PopcorniaDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.composersIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Composers";
            this.dataGridView1.DataSource = this.popcorniaDataSet1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // composersIDDataGridViewTextBoxColumn
            // 
            this.composersIDDataGridViewTextBoxColumn.DataPropertyName = "ComposersID";
            this.composersIDDataGridViewTextBoxColumn.HeaderText = "ComposersID";
            this.composersIDDataGridViewTextBoxColumn.Name = "composersIDDataGridViewTextBoxColumn";
            this.composersIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // popcorniaDataSet1BindingSource
            // 
            this.popcorniaDataSet1BindingSource.DataSource = this.popcorniaDataSet1;
            this.popcorniaDataSet1BindingSource.Position = 0;
            // 
            // popcorniaDataSet1
            // 
            this.popcorniaDataSet1.DataSetName = "PopcorniaDataSet1";
            this.popcorniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popcorniaDataSet
            // 
            // 
            // popcorniaDataSetBindingSource
            // 
            this.popcorniaDataSetBindingSource.Position = 0;
            // 
            // composersTableAdapter
            // 
            this.composersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComposersTableAdapter = this.composersTableAdapter;
            this.tableAdapterManager.DirectorsTableAdapter = null;
            this.tableAdapterManager.FavActorsTableAdapter = null;
            this.tableAdapterManager.FavMoviesTableAdapter = null;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Popcornia.PopcorniaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // AllComposers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllComposers";
            this.Text = "AllComposers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn composersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource popcorniaDataSet1BindingSource;
        private PopcorniaDataSet1 popcorniaDataSet1;
        private System.Windows.Forms.BindingSource popcorniaDataSetBindingSource;
        private PopcorniaDataSet1TableAdapters.ComposersTableAdapter composersTableAdapter;
        private PopcorniaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}