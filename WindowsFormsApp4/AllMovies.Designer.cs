using System.Data.SqlClient;
namespace Popcornia
{
    partial class AllMovies
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
            this.popcorniaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popcorniaDataSet1 = new Popcornia.PopcorniaDataSet1();
            this.popcorniaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new Popcornia.PopcorniaDataSet1TableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new Popcornia.PopcorniaDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popcorniaDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // popcorniaDataSetBindingSource
            // 
            this.popcorniaDataSetBindingSource.Position = 0;
            // 
            // popcorniaDataSet
            // 
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
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn1,
            this.genreDataGridViewTextBoxColumn1,
            this.directorDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.composerDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.moviesBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 259);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // movieIDDataGridViewTextBoxColumn1
            // 
            this.movieIDDataGridViewTextBoxColumn1.DataPropertyName = "MovieID";
            this.movieIDDataGridViewTextBoxColumn1.HeaderText = "MovieID";
            this.movieIDDataGridViewTextBoxColumn1.Name = "movieIDDataGridViewTextBoxColumn1";
            this.movieIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            // 
            // genreDataGridViewTextBoxColumn1
            // 
            this.genreDataGridViewTextBoxColumn1.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn1.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn1.Name = "genreDataGridViewTextBoxColumn1";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // producerDataGridViewTextBoxColumn
            // 
            this.producerDataGridViewTextBoxColumn.DataPropertyName = "Producer";
            this.producerDataGridViewTextBoxColumn.HeaderText = "Producer";
            this.producerDataGridViewTextBoxColumn.Name = "producerDataGridViewTextBoxColumn";
            // 
            // composerDataGridViewTextBoxColumn
            // 
            this.composerDataGridViewTextBoxColumn.DataPropertyName = "Composer";
            this.composerDataGridViewTextBoxColumn.HeaderText = "Composer";
            this.composerDataGridViewTextBoxColumn.Name = "composerDataGridViewTextBoxColumn";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.popcorniaDataSet1BindingSource1;
            // 
            // popcorniaDataSet1BindingSource1
            // 
            this.popcorniaDataSet1BindingSource1.DataSource = this.popcorniaDataSet1;
            this.popcorniaDataSet1BindingSource1.Position = 0;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(612, 215);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(119, 32);
            this.Update.TabIndex = 2;
            this.Update.Text = "Save";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // AllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 259);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView2);
            this.Name = "AllMovies";
            this.Text = "AllMovies";
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource popcorniaDataSetBindingSource;
        private System.Windows.Forms.BindingSource popcorniaDataSet1BindingSource;
        private PopcorniaDataSet1 popcorniaDataSet1;
        private PopcorniaDataSet1TableAdapters.MoviesTableAdapter moviesTableAdapter;
        private PopcorniaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn composerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn composerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private System.Windows.Forms.BindingSource popcorniaDataSet1BindingSource1;
        private System.Windows.Forms.Button Update;
    }
}