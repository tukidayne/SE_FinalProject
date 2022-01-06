
namespace finalproject
{
    partial class DeliveryNote
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
            this.label5 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.delivery_id = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.order_status = new System.Windows.Forms.ComboBox();
            this.payment_status = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.delivery_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.delivery_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 39);
            this.label5.TabIndex = 21;
            this.label5.Text = "GOODS DELIVERY NOTE";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(700, 184);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 38;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Delivery_ID:";
            // 
            // delivery_id
            // 
            this.delivery_id.Location = new System.Drawing.Point(134, 91);
            this.delivery_id.Name = "delivery_id";
            this.delivery_id.Size = new System.Drawing.Size(162, 22);
            this.delivery_id.TabIndex = 35;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(476, 184);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 34;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(366, 184);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 33;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Order status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Order_ID:";
            // 
            // order_id
            // 
            this.order_id.Location = new System.Drawing.Point(389, 91);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(162, 22);
            this.order_id.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(832, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Payment status:";
            // 
            // order_status
            // 
            this.order_status.FormattingEnabled = true;
            this.order_status.Items.AddRange(new object[] {
            "Being transferred",
            "Completed"});
            this.order_status.Location = new System.Drawing.Point(683, 89);
            this.order_status.Name = "order_status";
            this.order_status.Size = new System.Drawing.Size(121, 24);
            this.order_status.TabIndex = 44;
            // 
            // payment_status
            // 
            this.payment_status.FormattingEnabled = true;
            this.payment_status.Items.AddRange(new object[] {
            "Pending",
            "Paid"});
            this.payment_status.Location = new System.Drawing.Point(961, 89);
            this.payment_status.Name = "payment_status";
            this.payment_status.Size = new System.Drawing.Size(121, 24);
            this.payment_status.TabIndex = 45;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(587, 184);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 46;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delivery_table
            // 
            this.delivery_table.AllowUserToAddRows = false;
            this.delivery_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delivery_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column8});
            this.delivery_table.Location = new System.Drawing.Point(30, 225);
            this.delivery_table.Name = "delivery_table";
            this.delivery_table.RowHeadersWidth = 51;
            this.delivery_table.RowTemplate.Height = 24;
            this.delivery_table.Size = new System.Drawing.Size(1100, 259);
            this.delivery_table.TabIndex = 47;
            this.delivery_table.DoubleClick += new System.EventHandler(this.delivery_table_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S.No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delivery_ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Order_ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Delivery_date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Order status";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 180;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Payment status";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(1055, 503);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 48;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Delivery_date:";
            // 
            // delivery_date
            // 
            this.delivery_date.CustomFormat = "dd/MM/yyyy";
            this.delivery_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.delivery_date.Location = new System.Drawing.Point(134, 137);
            this.delivery_date.Name = "delivery_date";
            this.delivery_date.Size = new System.Drawing.Size(162, 22);
            this.delivery_date.TabIndex = 51;
            // 
            // DeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 538);
            this.Controls.Add(this.delivery_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.delivery_table);
            this.Controls.Add(this.update);
            this.Controls.Add(this.payment_status);
            this.Controls.Add(this.order_status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delivery_id);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.label5);
            this.Name = "DeliveryNote";
            this.Text = "DeliveryNote";
            this.Load += new System.EventHandler(this.DeliveryNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delivery_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox delivery_id;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox order_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox order_status;
        private System.Windows.Forms.ComboBox payment_status;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView delivery_table;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DateTimePicker delivery_date;
    }
}