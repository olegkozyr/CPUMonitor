﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12.07.2017
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CPUMonitor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
		private System.Windows.Forms.Button btn_StartAcquire;
		private System.Windows.Forms.CheckBox ckb_isHistoryPerCPU;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btn_StartAcquire = new System.Windows.Forms.Button();
			this.ckb_isHistoryPerCPU = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
			this.SuspendLayout();
			// 
			// chartCPU
			// 
			chartArea1.Name = "ChartArea1";
			this.chartCPU.ChartAreas.Add(chartArea1);
			this.chartCPU.Location = new System.Drawing.Point(12, 12);
			this.chartCPU.Name = "chartCPU";
			this.chartCPU.Size = new System.Drawing.Size(534, 308);
			this.chartCPU.TabIndex = 0;
			this.chartCPU.Text = "chart1";
			// 
			// btn_StartAcquire
			// 
			this.btn_StartAcquire.Location = new System.Drawing.Point(471, 348);
			this.btn_StartAcquire.Name = "btn_StartAcquire";
			this.btn_StartAcquire.Size = new System.Drawing.Size(75, 23);
			this.btn_StartAcquire.TabIndex = 1;
			this.btn_StartAcquire.Text = "Start";
			this.btn_StartAcquire.UseVisualStyleBackColor = true;
			this.btn_StartAcquire.Click += new System.EventHandler(this.Btn_StartAcquireClick);
			// 
			// ckb_isHistoryPerCPU
			// 
			this.ckb_isHistoryPerCPU.Appearance = System.Windows.Forms.Appearance.Button;
			this.ckb_isHistoryPerCPU.Location = new System.Drawing.Point(12, 347);
			this.ckb_isHistoryPerCPU.Name = "ckb_isHistoryPerCPU";
			this.ckb_isHistoryPerCPU.Size = new System.Drawing.Size(104, 24);
			this.ckb_isHistoryPerCPU.TabIndex = 2;
			this.ckb_isHistoryPerCPU.Text = "History per CPU";
			this.ckb_isHistoryPerCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ckb_isHistoryPerCPU.UseVisualStyleBackColor = true;
			this.ckb_isHistoryPerCPU.CheckedChanged += new System.EventHandler(this.Ckb_isHistoryPerCPUCheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 383);
			this.Controls.Add(this.ckb_isHistoryPerCPU);
			this.Controls.Add(this.btn_StartAcquire);
			this.Controls.Add(this.chartCPU);
			this.Name = "MainForm";
			this.Text = "CPUMonitor";
			((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
