namespace MainApp
{
    partial class EventControl
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
			this.comboBoxIntervals = new System.Windows.Forms.ComboBox();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// comboBoxIntervals
			// 
			this.comboBoxIntervals.Dock = System.Windows.Forms.DockStyle.Top;
			this.comboBoxIntervals.FormattingEnabled = true;
			this.comboBoxIntervals.Location = new System.Drawing.Point(0, 0);
			this.comboBoxIntervals.Name = "comboBoxIntervals";
			this.comboBoxIntervals.Size = new System.Drawing.Size(301, 28);
			this.comboBoxIntervals.TabIndex = 0;
			this.comboBoxIntervals.SelectedIndexChanged += new System.EventHandler(this.ComboBoxIntervals_SelectedIndexChanged);
			// 
			// listBoxEvents
			// 
			this.listBoxEvents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.ItemHeight = 20;
			this.listBoxEvents.Location = new System.Drawing.Point(0, 28);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(301, 307);
			this.listBoxEvents.TabIndex = 1;
			// 
			// EventControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.listBoxEvents);
			this.Controls.Add(this.comboBoxIntervals);
			this.Name = "EventControl";
			this.Size = new System.Drawing.Size(301, 335);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIntervals;
        private System.Windows.Forms.ListBox listBoxEvents;
    }
}
