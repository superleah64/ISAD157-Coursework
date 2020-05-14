namespace SOFT562Week18
{
    partial class Friends
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isad157_lhumphriesDataSet = new SOFT562Week18.isad157_lhumphriesDataSet();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendsTableAdapter = new SOFT562Week18.isad157_lhumphriesDataSetTableAdapters.friendsTableAdapter();
            this.friendTableIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frienduseridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isad157_lhumphriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Friends";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.friendTableIDDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.frienduseridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.friendsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(247, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 195);
            this.dataGridView1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SOFT562Week18.Properties.Resources.Screenshot_2020_05_13_at_15_571;
            this.pictureBox1.Location = new System.Drawing.Point(26, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // isad157_lhumphriesDataSet
            // 
            this.isad157_lhumphriesDataSet.DataSetName = "isad157_lhumphriesDataSet";
            this.isad157_lhumphriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataMember = "friends";
            this.friendsBindingSource.DataSource = this.isad157_lhumphriesDataSet;
            // 
            // friendsTableAdapter
            // 
            this.friendsTableAdapter.ClearBeforeFill = true;
            // 
            // friendTableIDDataGridViewTextBoxColumn
            // 
            this.friendTableIDDataGridViewTextBoxColumn.DataPropertyName = "friend_Table_ID";
            this.friendTableIDDataGridViewTextBoxColumn.HeaderText = "friend_Table_ID";
            this.friendTableIDDataGridViewTextBoxColumn.Name = "friendTableIDDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // frienduseridDataGridViewTextBoxColumn
            // 
            this.frienduseridDataGridViewTextBoxColumn.DataPropertyName = "friend_user_id";
            this.frienduseridDataGridViewTextBoxColumn.HeaderText = "friend_user_id";
            this.frienduseridDataGridViewTextBoxColumn.Name = "frienduseridDataGridViewTextBoxColumn";
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Friends";
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.Friends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isad157_lhumphriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private isad157_lhumphriesDataSet isad157_lhumphriesDataSet;
        private System.Windows.Forms.BindingSource friendsBindingSource;
        private isad157_lhumphriesDataSetTableAdapters.friendsTableAdapter friendsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn friendTableIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frienduseridDataGridViewTextBoxColumn;
    }
}