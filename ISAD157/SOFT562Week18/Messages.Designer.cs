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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.messagesTableIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textcontentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isad157_lhumphriesMessages = new SOFT562Week18.isad157_lhumphriesMessages();
            this.messagesTableAdapter = new SOFT562Week18.isad157_lhumphriesMessagesTableAdapters.messagesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isad157_lhumphriesMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Messages";
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 288);
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
            this.messagesBindingSource.DataSource = this.isad157_lhumphriesMessages;
            // 
            // isad157_lhumphriesMessages
            // 
            this.isad157_lhumphriesMessages.DataSetName = "isad157_lhumphriesMessages";
            this.isad157_lhumphriesMessages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messagesTableAdapter
            // 
            this.messagesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SOFT562Week18.Properties.Resources.Screenshot_2020_05_13_at_15_571;
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isad157_lhumphriesMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private isad157_lhumphriesMessages isad157_lhumphriesMessages;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private isad157_lhumphriesMessagesTableAdapters.messagesTableAdapter messagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagesTableIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textcontentsDataGridViewTextBoxColumn;
    }
}