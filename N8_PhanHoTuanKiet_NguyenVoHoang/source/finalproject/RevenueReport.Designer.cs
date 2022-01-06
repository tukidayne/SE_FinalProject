
namespace finalproject
{
    partial class RevenueReport
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
            this.month = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.view_report = new System.Windows.Forms.Button();
            this.revenue_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.revenue_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 39);
            this.label5.TabIndex = 22;
            this.label5.Text = "REVENUE REPORT";
            // 
            // month
            // 
            this.month.CustomFormat = "MM/yyyy";
            this.month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month.Location = new System.Drawing.Point(330, 73);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(147, 22);
            this.month.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Month:";
            // 
            // view_report
            // 
            this.view_report.Location = new System.Drawing.Point(308, 111);
            this.view_report.Name = "view_report";
            this.view_report.Size = new System.Drawing.Size(142, 23);
            this.view_report.TabIndex = 32;
            this.view_report.Text = "View report";
            this.view_report.UseVisualStyleBackColor = true;
            this.view_report.Click += new System.EventHandler(this.view_report_Click);
            // 
            // revenue_table
            // 
            this.revenue_table.AllowUserToAddRows = false;
            this.revenue_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revenue_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.revenue_table.Location = new System.Drawing.Point(41, 151);
            this.revenue_table.Name = "revenue_table";
            this.revenue_table.RowHeadersWidth = 51;
            this.revenue_table.RowTemplate.Height = 24;
            this.revenue_table.Size = new System.Drawing.Size(641, 333);
            this.revenue_table.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Month";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Year";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Revenue";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 513);
            this.Controls.Add(this.revenue_table);
            this.Controls.Add(this.view_report);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "RevenueReport";
            this.Text = "RevenueReport";
            ((System.ComponentModel.ISupportInitialize)(this.revenue_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button view_report;
        private System.Windows.Forms.DataGridView revenue_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}