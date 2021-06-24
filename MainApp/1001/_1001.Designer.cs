
namespace MainApp._1001
{
	partial class _1001
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
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1001 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonRefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1001)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1001
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1001.ChartAreas.Add(chartArea1);
			this.chart1001.Location = new System.Drawing.Point(3, 61);
			this.chart1001.Name = "chart1001";
			series1.ChartArea = "ChartArea1";
			series1.Name = "Series1";
			this.chart1001.Series.Add(series1);
			this.chart1001.Size = new System.Drawing.Size(1272, 571);
			this.chart1001.TabIndex = 0;
			this.chart1001.Text = "chart1";
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(3, 3);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(117, 37);
			this.buttonRefresh.TabIndex = 1;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// _1001
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.chart1001);
			this.Name = "_1001";
			this.Size = new System.Drawing.Size(1349, 1047);
			((System.ComponentModel.ISupportInitialize)(this.chart1001)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1001;
		private System.Windows.Forms.Button buttonRefresh;
	}
}
