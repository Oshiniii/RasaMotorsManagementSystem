﻿namespace RasaMotorsManagementSystem.Inventory
{
    partial class StockInReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerStockIn = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StockInDataSet = new RasaMotorsManagementSystem.Inventory.StockInDataSet();
            this.restockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restockTableAdapter = new RasaMotorsManagementSystem.Inventory.StockInDataSetTableAdapters.restockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StockInDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerStockIn
            // 
            this.reportViewerStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StocksDataSet";
            reportDataSource1.Value = this.restockBindingSource;
            this.reportViewerStockIn.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerStockIn.LocalReport.ReportEmbeddedResource = "RasaMotorsManagementSystem.Inventory.StockIn.rdlc";
            this.reportViewerStockIn.Location = new System.Drawing.Point(0, 0);
            this.reportViewerStockIn.Name = "reportViewerStockIn";
            this.reportViewerStockIn.ServerReport.BearerToken = null;
            this.reportViewerStockIn.Size = new System.Drawing.Size(800, 450);
            this.reportViewerStockIn.TabIndex = 0;
            // 
            // StockInDataSet
            // 
            this.StockInDataSet.DataSetName = "StockInDataSet";
            this.StockInDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restockBindingSource
            // 
            this.restockBindingSource.DataMember = "restock";
            this.restockBindingSource.DataSource = this.StockInDataSet;
            // 
            // restockTableAdapter
            // 
            this.restockTableAdapter.ClearBeforeFill = true;
            // 
            // StockInReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerStockIn);
            this.Name = "StockInReport";
            this.Text = "StockInReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockInReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockInDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewerStockIn;
        public StockInDataSetTableAdapters.restockTableAdapter restockTableAdapter;
        public System.Windows.Forms.BindingSource restockBindingSource;
        public StockInDataSet StockInDataSet;
    }
}