
namespace MainApp.StatsControls
{
	partial class Total
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonrefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(3, 56);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(1560, 873);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// buttonrefresh
			// 
			this.buttonrefresh.Location = new System.Drawing.Point(3, 3);
			this.buttonrefresh.Name = "buttonrefresh";
			this.buttonrefresh.Size = new System.Drawing.Size(102, 38);
			this.buttonrefresh.TabIndex = 32;
			this.buttonrefresh.Text = "Refresh";
			this.buttonrefresh.UseVisualStyleBackColor = true;
			// 
			// Total
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonrefresh);
			this.Controls.Add(this.chart1);
			this.Name = "Total";
			this.Size = new System.Drawing.Size(1775, 1127);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonrefresh;
    }
}
