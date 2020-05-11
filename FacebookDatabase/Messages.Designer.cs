namespace SOFT562Week18
{
    partial class Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.messagesTableIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textcontentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isad157_lhumphriesDataSet1 = new SOFT562Week18.isad157_lhumphriesDataSet1();
            this.messagesTableAdapter = new SOFT562Week18.isad157_lhumphriesDataSet1TableAdapters.messagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isad157_lhumphriesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Messages";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.messagesTableIDDataGridViewTextBoxColumn,
            this.senderidDataGridViewTextBoxColumn,
            this.receiveridDataGridViewTextBoxColumn,
            this.dateandtimeDataGridViewTextBoxColumn,
            this.textcontentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.messagesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 286);
            this.dataGridView1.TabIndex = 10;
            // 
            // messagesTableIDDataGridViewTextBoxColumn
            // 
            this.messagesTableIDDataGridViewTextBoxColumn.DataPropertyName = "messages_Table_ID";
            this.messagesTableIDDataGridViewTextBoxColumn.HeaderText = "messages_Table_ID";
            this.messagesTableIDDataGridViewTextBoxColumn.Name = "messagesTableIDDataGridViewTextBoxColumn";
            this.messagesTableIDDataGridViewTextBoxColumn.Width = 129;
            // 
            // senderidDataGridViewTextBoxColumn
            // 
            this.senderidDataGridViewTextBoxColumn.DataPropertyName = "sender_id";
            this.senderidDataGridViewTextBoxColumn.HeaderText = "sender_id";
            this.senderidDataGridViewTextBoxColumn.Name = "senderidDataGridViewTextBoxColumn";
            this.senderidDataGridViewTextBoxColumn.Width = 78;
            // 
            // receiveridDataGridViewTextBoxColumn
            // 
            this.receiveridDataGridViewTextBoxColumn.DataPropertyName = "receiver_id";
            this.receiveridDataGridViewTextBoxColumn.HeaderText = "receiver_id";
            this.receiveridDataGridViewTextBoxColumn.Name = "receiveridDataGridViewTextBoxColumn";
            this.receiveridDataGridViewTextBoxColumn.Width = 84;
            // 
            // dateandtimeDataGridViewTextBoxColumn
            // 
            this.dateandtimeDataGridViewTextBoxColumn.DataPropertyName = "date_and_time";
            this.dateandtimeDataGridViewTextBoxColumn.HeaderText = "date_and_time";
            this.dateandtimeDataGridViewTextBoxColumn.Name = "dateandtimeDataGridViewTextBoxColumn";
            this.dateandtimeDataGridViewTextBoxColumn.Width = 102;
            // 
            // textcontentsDataGridViewTextBoxColumn
            // 
            this.textcontentsDataGridViewTextBoxColumn.DataPropertyName = "text_contents";
            this.textcontentsDataGridViewTextBoxColumn.HeaderText = "text_contents";
            this.textcontentsDataGridViewTextBoxColumn.Name = "textcontentsDataGridViewTextBoxColumn";
            this.textcontentsDataGridViewTextBoxColumn.Width = 96;
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataMember = "messages";
            this.messagesBindingSource.DataSource = this.isad157_lhumphriesDataSet1;
            // 
            // isad157_lhumphriesDataSet1
            // 
            this.isad157_lhumphriesDataSet1.DataSetName = "isad157_lhumphriesDataSet1";
            this.isad157_lhumphriesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Messages";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Messages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isad157_lhumphriesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private isad157_lhumphriesDataSet1 isad157_lhumphriesDataSet1;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private isad157_lhumphriesDataSet1TableAdapters.messagesTableAdapter messagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagesTableIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textcontentsDataGridViewTextBoxColumn;
    }
}