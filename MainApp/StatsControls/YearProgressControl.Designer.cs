
namespace MainApp.Reports
{
	partial class YearProgressControl
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.chartYearProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartYearProgress)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(4, 4);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(102, 38);
			this.buttonRefresh.TabIndex = 31;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
			// 
			// chartYearProgress
			// 
			chartArea1.Name = "ChartArea1";
			this.chartYearProgress.ChartAreas.Add(chartArea1);
			this.chartYearProgress.Location = new System.Drawing.Point(4, 48);
			this.chartYearProgress.Name = "chartYearProgress";
			this.chartYearProgress.Size = new System.Drawing.Size(1560, 873);
			this.chartYearProgress.TabIndex = 32;
			this.chartYearProgress.Text = "chart1";
			// 
			// YearProgressControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chartYearProgress);
			this.Controls.Add(this.buttonRefresh);
			this.Name = "YearProgressControl";
			this.Size = new System.Drawing.Size(1717, 1079);
			((System.ComponentModel.ISupportInitialize)(this.chartYearProgress)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartYearProgress;
	}
}
