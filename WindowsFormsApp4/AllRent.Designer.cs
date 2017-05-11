namespace Popcornia
{
    partial class AllRent
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
            this.popcorniaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popcorniaDataSet1 = new Popcornia.PopcorniaDataSet1();
            this.rentsTableAdapter = new Popcornia.PopcorniaDataSet1TableAdapters.RentsTableAdapter();
            this.tableAdapterManager = new Popcornia.PopcorniaDataSet1TableAdapters.TableAdapterManager();
            this.rentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popcorniaDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.popcorniaDataSet11 = new Popcornia.PopcorniaDataSet1();
            this.popcorniaDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // rentsTableAdapter
            // 
            this.rentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComposersTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DirectorsTableAdapter = null;
            this.tableAdapterManager.FavActorsTableAdapter = null;
            this.tableAdapterManager.FavMoviesTableAdapter = null;
            this.tableAdapterManager.MoviesTableAdapter = null;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Popcornia.PopcorniaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // rentsBindingSource
            // 
            this.rentsBindingSource.DataMember = "Rents";
            this.rentsBindingSource.DataSource = this.popcorniaDataSet1BindingSource1;
            // 
            // popcorniaDataSet1BindingSource1
            // 
            this.popcorniaDataSet1BindingSource1.DataSource = this.popcorniaDataSet1;
            this.popcorniaDataSet1BindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.usernameDataGridViewTextBoxColumn,
            this.movieDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.paidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rentsBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // popcorniaDataSet11
            // 
            this.popcorniaDataSet11.DataSetName = "PopcorniaDataSet1";
            this.popcorniaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popcorniaDataSet11BindingSource
            // 
            this.popcorniaDataSet11BindingSource.DataSource = this.popcorniaDataSet11;
            this.popcorniaDataSet11BindingSource.Position = 0;
            // 
            // rentsBindingSource1
            // 
            this.rentsBindingSource1.DataMember = "Rents";
            this.rentsBindingSource1.DataSource = this.popcorniaDataSet11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "User ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "User ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Movie ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Movie ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // movieDataGridViewTextBoxColumn
            // 
            this.movieDataGridViewTextBoxColumn.DataPropertyName = "Movie";
            this.movieDataGridViewTextBoxColumn.HeaderText = "Movie";
            this.movieDataGridViewTextBoxColumn.Name = "movieDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Start Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Expire Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Expire Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            // 
            // AllRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllRent";
            this.Text = "AllRent";
            this.Load += new System.EventHandler(this.AllRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource popcorniaDataSet1BindingSource;
        private PopcorniaDataSet1 popcorniaDataSet1;
        private PopcorniaDataSet1TableAdapters.RentsTableAdapter rentsTableAdapter;
        private PopcorniaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource rentsBindingSource;
        private System.Windows.Forms.BindingSource popcorniaDataSet1BindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource popcorniaDataSet11BindingSource;
        private PopcorniaDataSet1 popcorniaDataSet11;
        private System.Windows.Forms.BindingSource rentsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
    }
}