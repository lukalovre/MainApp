namespace MainApp.Collection.Games
{
	partial class AddGameCollectionControl
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
			this.comboBoxClient = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxPriceInRSD = new System.Windows.Forms.TextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.numericUpDownHLTBTime = new System.Windows.Forms.NumericUpDown();
			this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
			this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.checkBoxPlanToPlay = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.checkBoxPhysicalCopy = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBoxGotFree = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1001 = new System.Windows.Forms.CheckBox();
			this.checkBoxNew = new System.Windows.Forms.CheckBox();
			this.checkBoxExpansion = new System.Windows.Forms.CheckBox();
			this.textBoxEdition = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHLTBTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxClient
			// 
			this.comboBoxClient.FormattingEnabled = true;
			this.comboBoxClient.Location = new System.Drawing.Point(3, 108);
			this.comboBoxClient.Name = "comboBoxClient";
			this.comboBoxClient.Size = new System.Drawing.Size(81, 21);
			this.comboBoxClient.TabIndex = 52;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(90, 111);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(33, 13);
			this.label9.TabIndex = 51;
			this.label9.Text = "Client";
			// 
			// textBoxPriceInRSD
			// 
			this.textBoxPriceInRSD.Location = new System.Drawing.Point(3, 276);
			this.textBoxPriceInRSD.Name = "textBoxPriceInRSD";
			this.textBoxPriceInRSD.Size = new System.Drawing.Size(54, 20);
			this.textBoxPriceInRSD.TabIndex = 50;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(3, 250);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(54, 20);
			this.textBoxPrice.TabIndex = 49;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(138, 361);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 48;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// numericUpDownHLTBTime
			// 
			this.numericUpDownHLTBTime.Location = new System.Drawing.Point(3, 325);
			this.numericUpDownHLTBTime.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownHLTBTime.Name = "numericUpDownHLTBTime";
			this.numericUpDownHLTBTime.Size = new System.Drawing.Size(48, 20);
			this.numericUpDownHLTBTime.TabIndex = 47;
			// 
			// comboBoxPlatform
			// 
			this.comboBoxPlatform.FormattingEnabled = true;
			this.comboBoxPlatform.Location = new System.Drawing.Point(3, 81);
			this.comboBoxPlatform.Name = "comboBoxPlatform";
			this.comboBoxPlatform.Size = new System.Drawing.Size(81, 21);
			this.comboBoxPlatform.TabIndex = 45;
			// 
			// numericUpDownYear
			// 
			this.numericUpDownYear.Location = new System.Drawing.Point(3, 55);
			this.numericUpDownYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownYear.Name = "numericUpDownYear";
			this.numericUpDownYear.Size = new System.Drawing.Size(52, 20);
			this.numericUpDownYear.TabIndex = 44;
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(177, 20);
			this.textBoxTitle.TabIndex = 43;
			this.textBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitleTextChanged);
			// 
			// checkBoxPlanToPlay
			// 
			this.checkBoxPlanToPlay.AutoSize = true;
			this.checkBoxPlanToPlay.Checked = true;
			this.checkBoxPlanToPlay.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxPlanToPlay.Location = new System.Drawing.Point(3, 302);
			this.checkBoxPlanToPlay.Name = "checkBoxPlanToPlay";
			this.checkBoxPlanToPlay.Size = new System.Drawing.Size(81, 17);
			this.checkBoxPlanToPlay.TabIndex = 42;
			this.checkBoxPlanToPlay.Text = "Plan to play";
			this.checkBoxPlanToPlay.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(61, 327);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 13);
			this.label8.TabIndex = 41;
			this.label8.Text = "HLTB time";
			// 
			// checkBoxPhysicalCopy
			// 
			this.checkBoxPhysicalCopy.AutoSize = true;
			this.checkBoxPhysicalCopy.Location = new System.Drawing.Point(3, 181);
			this.checkBoxPhysicalCopy.Name = "checkBoxPhysicalCopy";
			this.checkBoxPhysicalCopy.Size = new System.Drawing.Size(91, 17);
			this.checkBoxPhysicalCopy.TabIndex = 40;
			this.checkBoxPhysicalCopy.Text = "Physical copy";
			this.checkBoxPhysicalCopy.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(63, 279);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 13);
			this.label7.TabIndex = 39;
			this.label7.Text = "Price in RSD";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(63, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 38;
			this.label6.Text = "Price";
			// 
			// checkBoxGotFree
			// 
			this.checkBoxGotFree.AutoSize = true;
			this.checkBoxGotFree.Location = new System.Drawing.Point(3, 204);
			this.checkBoxGotFree.Name = "checkBoxGotFree";
			this.checkBoxGotFree.Size = new System.Drawing.Size(64, 17);
			this.checkBoxGotFree.TabIndex = 37;
			this.checkBoxGotFree.Text = "Got free";
			this.checkBoxGotFree.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(90, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 35;
			this.label3.Text = "Platform";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "Year";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(186, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 33;
			this.label1.Text = "Title";
			// 
			// checkBox1001
			// 
			this.checkBox1001.AutoSize = true;
			this.checkBox1001.Location = new System.Drawing.Point(3, 227);
			this.checkBox1001.Name = "checkBox1001";
			this.checkBox1001.Size = new System.Drawing.Size(50, 17);
			this.checkBox1001.TabIndex = 53;
			this.checkBox1001.Text = "1001";
			this.checkBox1001.UseVisualStyleBackColor = true;
			// 
			// checkBoxNew
			// 
			this.checkBoxNew.AutoSize = true;
			this.checkBoxNew.Location = new System.Drawing.Point(3, 158);
			this.checkBoxNew.Name = "checkBoxNew";
			this.checkBoxNew.Size = new System.Drawing.Size(48, 17);
			this.checkBoxNew.TabIndex = 54;
			this.checkBoxNew.Text = "New";
			this.checkBoxNew.UseVisualStyleBackColor = true;
			// 
			// checkBoxExpansion
			// 
			this.checkBoxExpansion.AutoSize = true;
			this.checkBoxExpansion.Location = new System.Drawing.Point(3, 135);
			this.checkBoxExpansion.Name = "checkBoxExpansion";
			this.checkBoxExpansion.Size = new System.Drawing.Size(75, 17);
			this.checkBoxExpansion.TabIndex = 55;
			this.checkBoxExpansion.Text = "Expansion";
			this.checkBoxExpansion.UseVisualStyleBackColor = true;
			// 
			// textBoxEdition
			// 
			this.textBoxEdition.Location = new System.Drawing.Point(3, 29);
			this.textBoxEdition.Name = "textBoxEdition";
			this.textBoxEdition.Size = new System.Drawing.Size(100, 20);
			this.textBoxEdition.TabIndex = 56;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(109, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 57;
			this.label4.Text = "Edition";
			// 
			// AddGameCollection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxEdition);
			this.Controls.Add(this.checkBoxExpansion);
			this.Controls.Add(this.checkBoxNew);
			this.Controls.Add(this.checkBox1001);
			this.Controls.Add(this.comboBoxClient);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBoxPriceInRSD);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.numericUpDownHLTBTime);
			this.Controls.Add(this.comboBoxPlatform);
			this.Controls.Add(this.numericUpDownYear);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.checkBoxPlanToPlay);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.checkBoxPhysicalCopy);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.checkBoxGotFree);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddGameCollection";
			this.Size = new System.Drawing.Size(225, 391);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHLTBTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxClient;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxPriceInRSD;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.NumericUpDown numericUpDownHLTBTime;
		private System.Windows.Forms.ComboBox comboBoxPlatform;
		private System.Windows.Forms.NumericUpDown numericUpDownYear;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.CheckBox checkBoxPlanToPlay;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox checkBoxPhysicalCopy;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox checkBoxGotFree;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1001;
		private System.Windows.Forms.CheckBox checkBoxNew;
		private System.Windows.Forms.CheckBox checkBoxExpansion;
		private System.Windows.Forms.TextBox textBoxEdition;
		private System.Windows.Forms.Label label4;
	}
}
