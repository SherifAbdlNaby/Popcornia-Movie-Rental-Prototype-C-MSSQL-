namespace Popcornia
{
    partial class AllRoles
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
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popcorniaDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.popcorniaDataSet1 = new Popcornia.PopcorniaDataSet1();
            this.popcorniaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Popcornia.PopcorniaDataSet1TableAdapters.RolesTableAdapter();
            this.tableAdapterManager = new Popcornia.PopcorniaDataSet1TableAdapters.TableAdapterManager();
            this.popcorniaDataSet2 = new Popcornia.PopcorniaDataSet1();
            this.popcorniaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleDataGridViewTextBoxColumn,
            this.actorDataGridViewTextBoxColumn,
            this.movieDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Roles";
            this.dataGridView1.DataSource = this.popcorniaDataSet1BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // actorDataGridViewTextBoxColumn
            // 
            this.actorDataGridViewTextBoxColumn.DataPropertyName = "Actor";
            this.actorDataGridViewTextBoxColumn.HeaderText = "Actor";
            this.actorDataGridViewTextBoxColumn.Name = "actorDataGridViewTextBoxColumn";
            // 
            // movieDataGridViewTextBoxColumn
            // 
            this.movieDataGridViewTextBoxColumn.DataPropertyName = "Movie";
            this.movieDataGridViewTextBoxColumn.HeaderText = "Movie";
            this.movieDataGridViewTextBoxColumn.Name = "movieDataGridViewTextBoxColumn";
            // 
            // popcorniaDataSet1BindingSource1
            // 
            this.popcorniaDataSet1BindingSource1.DataSource = this.popcorniaDataSet1;
            this.popcorniaDataSet1BindingSource1.Position = 0;
            // 
            // popcorniaDataSet1
            // 
            this.popcorniaDataSet1.DataSetName = "PopcorniaDataSet1";
            this.popcorniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popcorniaDataSet1BindingSource
            // 
            this.popcorniaDataSet1BindingSource.DataSource = this.popcorniaDataSet1;
            this.popcorniaDataSet1BindingSource.Position = 0;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Popcornia.PopcorniaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // popcorniaDataSet2
            // 
            this.popcorniaDataSet2.DataSetName = "PopcorniaDataSet2";
            this.popcorniaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popcorniaDataSet2BindingSource
            // 
            this.popcorniaDataSet2BindingSource.DataSource = this.popcorniaDataSet2;
            this.popcorniaDataSet2BindingSource.Position = 0;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.popcorniaDataSet1BindingSource;
            // 
            // AllRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllRoles";
            this.Text = "AllRoles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource popcorniaDataSet1BindingSource;
        private PopcorniaDataSet1 popcorniaDataSet1;
        private PopcorniaDataSet1TableAdapters.RolesTableAdapter rolesTableAdapter;
        private PopcorniaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource popcorniaDataSet2BindingSource;
        private PopcorniaDataSet1 popcorniaDataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource popcorniaDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieDataGridViewTextBoxColumn;
    }
}