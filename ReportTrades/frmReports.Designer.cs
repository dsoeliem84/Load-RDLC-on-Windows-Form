namespace ReportTrades
{
    partial class frmReports
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
            RptViewerTrades = new Microsoft.Reporting.WinForms.ReportViewer();
            groupParameters = new GroupBox();
            btnLoadReport = new Button();
            dtpToDate = new DateTimePicker();
            label2 = new Label();
            dptFormDate = new DateTimePicker();
            Label1 = new Label();
            groupParameters.SuspendLayout();
            SuspendLayout();
            // 
            // RptViewerTrades
            // 
            RptViewerTrades.Location = new Point(0, 80);
            RptViewerTrades.Margin = new Padding(1);
            RptViewerTrades.Name = "ReportViewer";
            RptViewerTrades.ServerReport.BearerToken = null;
            RptViewerTrades.Size = new Size(1180, 715);
            RptViewerTrades.TabIndex = 0;
            // 
            // groupParameters
            // 
            groupParameters.Controls.Add(btnLoadReport);
            groupParameters.Controls.Add(dtpToDate);
            groupParameters.Controls.Add(label2);
            groupParameters.Controls.Add(dptFormDate);
            groupParameters.Controls.Add(Label1);
            groupParameters.Location = new Point(12, 12);
            groupParameters.Name = "groupParameters";
            groupParameters.Size = new Size(1163, 60);
            groupParameters.TabIndex = 1;
            groupParameters.TabStop = false;
            groupParameters.Text = "Report Parameters";
            // 
            // btnLoadReport
            // 
            btnLoadReport.Location = new Point(378, 22);
            btnLoadReport.Name = "btnLoadReport";
            btnLoadReport.Size = new Size(112, 25);
            btnLoadReport.TabIndex = 4;
            btnLoadReport.Text = "Load Report";
            btnLoadReport.UseVisualStyleBackColor = true;
            btnLoadReport.Click += btnLoadReport_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(271, 22);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(101, 23);
            dtpToDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(242, 28);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 2;
            label2.Text = "To:";
            // 
            // dptFormDate
            // 
            dptFormDate.Format = DateTimePickerFormat.Short;
            dptFormDate.Location = new Point(125, 22);
            dptFormDate.Name = "dptFormDate";
            dptFormDate.Size = new Size(101, 23);
            dptFormDate.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(6, 28);
            Label1.Name = "Label1";
            Label1.Size = new Size(113, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Trading Date From:";
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 799);
            Controls.Add(groupParameters);
            Controls.Add(RptViewerTrades);
            Name = "frmReports";
            Text = "Form Reports";
            groupParameters.ResumeLayout(false);
            groupParameters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RptViewerTrades;
        private GroupBox groupParameters;
        private Button btnLoadReport;
        private DateTimePicker dtpToDate;
        private Label label2;
        private DateTimePicker dptFormDate;
        private Label Label1;
    }
}