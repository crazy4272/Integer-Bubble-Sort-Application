namespace Integer_Bubble_Sort_Application
{
    partial class Form1
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
            this.CreateArrayLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthInputTextBox = new System.Windows.Forms.TextBox();
            this.MinValueTextBox = new System.Windows.Forms.TextBox();
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.MaxValueTextBox = new System.Windows.Forms.TextBox();
            this.CreateArrayButton = new System.Windows.Forms.Button();
            this.UnsortedArrayLabel = new System.Windows.Forms.Label();
            this.UnsortedArrayTextBox = new System.Windows.Forms.TextBox();
            this.BS_SortingTitleLabel = new System.Windows.Forms.Label();
            this.AscendingOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.descendingOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.SORTButton = new System.Windows.Forms.Button();
            this.SortedArrayTextBox = new System.Windows.Forms.TextBox();
            this.SortedArrayLabel = new System.Windows.Forms.Label();
            this.BS_ComparisonLabel = new System.Windows.Forms.Label();
            this.BS_ComparisonsTextBox = new System.Windows.Forms.TextBox();
            this.BS_SwapsTextBox = new System.Windows.Forms.TextBox();
            this.BS_SwapsLabel = new System.Windows.Forms.Label();
            this.manualInputCheckBox = new System.Windows.Forms.CheckBox();
            this.manualInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateArrayLabel
            // 
            this.CreateArrayLabel.AutoSize = true;
            this.CreateArrayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateArrayLabel.Location = new System.Drawing.Point(13, 13);
            this.CreateArrayLabel.Name = "CreateArrayLabel";
            this.CreateArrayLabel.Size = new System.Drawing.Size(236, 20);
            this.CreateArrayLabel.TabIndex = 0;
            this.CreateArrayLabel.Text = "CREATE ARRAY TO SORT";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(14, 49);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(56, 17);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length:";
            // 
            // LengthInputTextBox
            // 
            this.LengthInputTextBox.Location = new System.Drawing.Point(137, 46);
            this.LengthInputTextBox.Name = "LengthInputTextBox";
            this.LengthInputTextBox.Size = new System.Drawing.Size(75, 22);
            this.LengthInputTextBox.TabIndex = 2;
            this.LengthInputTextBox.Text = "20";
            // 
            // MinValueTextBox
            // 
            this.MinValueTextBox.Location = new System.Drawing.Point(137, 74);
            this.MinValueTextBox.Name = "MinValueTextBox";
            this.MinValueTextBox.Size = new System.Drawing.Size(75, 22);
            this.MinValueTextBox.TabIndex = 4;
            this.MinValueTextBox.Text = "1";
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.AutoSize = true;
            this.MinValueLabel.Location = new System.Drawing.Point(14, 77);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(109, 17);
            this.MinValueLabel.TabIndex = 5;
            this.MinValueLabel.Text = "Min Value (incl):";
            this.MinValueLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Location = new System.Drawing.Point(14, 105);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(112, 17);
            this.MaxValueLabel.TabIndex = 7;
            this.MaxValueLabel.Text = "Max Value (incl):";
            // 
            // MaxValueTextBox
            // 
            this.MaxValueTextBox.Location = new System.Drawing.Point(137, 102);
            this.MaxValueTextBox.Name = "MaxValueTextBox";
            this.MaxValueTextBox.Size = new System.Drawing.Size(75, 22);
            this.MaxValueTextBox.TabIndex = 6;
            this.MaxValueTextBox.Text = "100";
            // 
            // CreateArrayButton
            // 
            this.CreateArrayButton.Location = new System.Drawing.Point(235, 46);
            this.CreateArrayButton.Name = "CreateArrayButton";
            this.CreateArrayButton.Size = new System.Drawing.Size(75, 78);
            this.CreateArrayButton.TabIndex = 8;
            this.CreateArrayButton.Text = "Create Array";
            this.CreateArrayButton.UseVisualStyleBackColor = true;
            this.CreateArrayButton.Click += new System.EventHandler(this.CreateArrayButton_Click);
            // 
            // UnsortedArrayLabel
            // 
            this.UnsortedArrayLabel.AutoSize = true;
            this.UnsortedArrayLabel.Location = new System.Drawing.Point(14, 148);
            this.UnsortedArrayLabel.Name = "UnsortedArrayLabel";
            this.UnsortedArrayLabel.Size = new System.Drawing.Size(108, 17);
            this.UnsortedArrayLabel.TabIndex = 9;
            this.UnsortedArrayLabel.Text = "Unsorted Array:";
            // 
            // UnsortedArrayTextBox
            // 
            this.UnsortedArrayTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.UnsortedArrayTextBox.AllowDrop = true;
            this.UnsortedArrayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnsortedArrayTextBox.Location = new System.Drawing.Point(17, 168);
            this.UnsortedArrayTextBox.Multiline = true;
            this.UnsortedArrayTextBox.Name = "UnsortedArrayTextBox";
            this.UnsortedArrayTextBox.ReadOnly = true;
            this.UnsortedArrayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UnsortedArrayTextBox.ShortcutsEnabled = false;
            this.UnsortedArrayTextBox.Size = new System.Drawing.Size(293, 270);
            this.UnsortedArrayTextBox.TabIndex = 10;
            this.UnsortedArrayTextBox.TabStop = false;
            // 
            // BS_SortingTitleLabel
            // 
            this.BS_SortingTitleLabel.AutoSize = true;
            this.BS_SortingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_SortingTitleLabel.Location = new System.Drawing.Point(342, 13);
            this.BS_SortingTitleLabel.Name = "BS_SortingTitleLabel";
            this.BS_SortingTitleLabel.Size = new System.Drawing.Size(222, 20);
            this.BS_SortingTitleLabel.TabIndex = 11;
            this.BS_SortingTitleLabel.Text = "BUBBLESORT SORTING";
            // 
            // AscendingOrderRadioButton
            // 
            this.AscendingOrderRadioButton.AutoSize = true;
            this.AscendingOrderRadioButton.Location = new System.Drawing.Point(346, 44);
            this.AscendingOrderRadioButton.Name = "AscendingOrderRadioButton";
            this.AscendingOrderRadioButton.Size = new System.Drawing.Size(136, 21);
            this.AscendingOrderRadioButton.TabIndex = 12;
            this.AscendingOrderRadioButton.TabStop = true;
            this.AscendingOrderRadioButton.Text = "Ascending Order";
            this.AscendingOrderRadioButton.UseVisualStyleBackColor = true;
            this.AscendingOrderRadioButton.Click += new System.EventHandler(this.AscendingOrderRadioButton_Click);
            // 
            // descendingOrderRadioButton
            // 
            this.descendingOrderRadioButton.AutoSize = true;
            this.descendingOrderRadioButton.Location = new System.Drawing.Point(494, 44);
            this.descendingOrderRadioButton.Name = "descendingOrderRadioButton";
            this.descendingOrderRadioButton.Size = new System.Drawing.Size(145, 21);
            this.descendingOrderRadioButton.TabIndex = 13;
            this.descendingOrderRadioButton.TabStop = true;
            this.descendingOrderRadioButton.Text = "Descending Order";
            this.descendingOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // SORTButton
            // 
            this.SORTButton.Location = new System.Drawing.Point(473, 78);
            this.SORTButton.Name = "SORTButton";
            this.SORTButton.Size = new System.Drawing.Size(166, 46);
            this.SORTButton.TabIndex = 14;
            this.SORTButton.Text = "SORT";
            this.SORTButton.UseVisualStyleBackColor = true;
            this.SORTButton.Click += new System.EventHandler(this.SORTButton_Click);
            // 
            // SortedArrayTextBox
            // 
            this.SortedArrayTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SortedArrayTextBox.AllowDrop = true;
            this.SortedArrayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortedArrayTextBox.Location = new System.Drawing.Point(346, 168);
            this.SortedArrayTextBox.Multiline = true;
            this.SortedArrayTextBox.Name = "SortedArrayTextBox";
            this.SortedArrayTextBox.ReadOnly = true;
            this.SortedArrayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SortedArrayTextBox.ShortcutsEnabled = false;
            this.SortedArrayTextBox.Size = new System.Drawing.Size(293, 270);
            this.SortedArrayTextBox.TabIndex = 16;
            this.SortedArrayTextBox.TabStop = false;
            this.SortedArrayTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SortedArrayLabel
            // 
            this.SortedArrayLabel.AutoSize = true;
            this.SortedArrayLabel.Location = new System.Drawing.Point(343, 148);
            this.SortedArrayLabel.Name = "SortedArrayLabel";
            this.SortedArrayLabel.Size = new System.Drawing.Size(92, 17);
            this.SortedArrayLabel.TabIndex = 15;
            this.SortedArrayLabel.Text = "Sorted Array:";
            this.SortedArrayLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // BS_ComparisonLabel
            // 
            this.BS_ComparisonLabel.AutoSize = true;
            this.BS_ComparisonLabel.Location = new System.Drawing.Point(346, 445);
            this.BS_ComparisonLabel.Name = "BS_ComparisonLabel";
            this.BS_ComparisonLabel.Size = new System.Drawing.Size(181, 17);
            this.BS_ComparisonLabel.TabIndex = 17;
            this.BS_ComparisonLabel.Text = "Integer Comparisons Made:";
            // 
            // BS_ComparisonsTextBox
            // 
            this.BS_ComparisonsTextBox.Location = new System.Drawing.Point(533, 442);
            this.BS_ComparisonsTextBox.Name = "BS_ComparisonsTextBox";
            this.BS_ComparisonsTextBox.ReadOnly = true;
            this.BS_ComparisonsTextBox.Size = new System.Drawing.Size(106, 22);
            this.BS_ComparisonsTextBox.TabIndex = 18;
            this.BS_ComparisonsTextBox.TabStop = false;
            // 
            // BS_SwapsTextBox
            // 
            this.BS_SwapsTextBox.Location = new System.Drawing.Point(533, 470);
            this.BS_SwapsTextBox.Name = "BS_SwapsTextBox";
            this.BS_SwapsTextBox.ReadOnly = true;
            this.BS_SwapsTextBox.Size = new System.Drawing.Size(106, 22);
            this.BS_SwapsTextBox.TabIndex = 20;
            this.BS_SwapsTextBox.TabStop = false;
            // 
            // BS_SwapsLabel
            // 
            this.BS_SwapsLabel.AutoSize = true;
            this.BS_SwapsLabel.Location = new System.Drawing.Point(346, 473);
            this.BS_SwapsLabel.Name = "BS_SwapsLabel";
            this.BS_SwapsLabel.Size = new System.Drawing.Size(171, 17);
            this.BS_SwapsLabel.TabIndex = 19;
            this.BS_SwapsLabel.Text = "Integer Swaps Performed:";
            // 
            // manualInputCheckBox
            // 
            this.manualInputCheckBox.AutoSize = true;
            this.manualInputCheckBox.Location = new System.Drawing.Point(17, 445);
            this.manualInputCheckBox.Name = "manualInputCheckBox";
            this.manualInputCheckBox.Size = new System.Drawing.Size(189, 21);
            this.manualInputCheckBox.TabIndex = 21;
            this.manualInputCheckBox.Text = "Input Sequence Manually";
            this.manualInputCheckBox.UseVisualStyleBackColor = true;
            this.manualInputCheckBox.CheckedChanged += new System.EventHandler(this.manualInputCheckBox_CheckedChanged);
            // 
            // manualInputLabel
            // 
            this.manualInputLabel.AutoSize = true;
            this.manualInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualInputLabel.Location = new System.Drawing.Point(17, 472);
            this.manualInputLabel.Name = "manualInputLabel";
            this.manualInputLabel.Size = new System.Drawing.Size(292, 13);
            this.manualInputLabel.TabIndex = 22;
            this.manualInputLabel.Text = "Input to be formated as numbers followed by a single space *";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 510);
            this.Controls.Add(this.manualInputLabel);
            this.Controls.Add(this.manualInputCheckBox);
            this.Controls.Add(this.BS_SwapsTextBox);
            this.Controls.Add(this.BS_SwapsLabel);
            this.Controls.Add(this.BS_ComparisonsTextBox);
            this.Controls.Add(this.BS_ComparisonLabel);
            this.Controls.Add(this.SortedArrayTextBox);
            this.Controls.Add(this.SortedArrayLabel);
            this.Controls.Add(this.SORTButton);
            this.Controls.Add(this.descendingOrderRadioButton);
            this.Controls.Add(this.AscendingOrderRadioButton);
            this.Controls.Add(this.BS_SortingTitleLabel);
            this.Controls.Add(this.UnsortedArrayTextBox);
            this.Controls.Add(this.UnsortedArrayLabel);
            this.Controls.Add(this.CreateArrayButton);
            this.Controls.Add(this.MaxValueLabel);
            this.Controls.Add(this.MaxValueTextBox);
            this.Controls.Add(this.MinValueLabel);
            this.Controls.Add(this.MinValueTextBox);
            this.Controls.Add(this.LengthInputTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.CreateArrayLabel);
            this.Name = "Form1";
            this.Text = "Integer Bubble Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateArrayLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox LengthInputTextBox;
        private System.Windows.Forms.TextBox MinValueTextBox;
        private System.Windows.Forms.Label MinValueLabel;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.TextBox MaxValueTextBox;
        private System.Windows.Forms.Button CreateArrayButton;
        private System.Windows.Forms.Label UnsortedArrayLabel;
        private System.Windows.Forms.TextBox UnsortedArrayTextBox;
        private System.Windows.Forms.Label BS_SortingTitleLabel;
        private System.Windows.Forms.RadioButton AscendingOrderRadioButton;
        private System.Windows.Forms.RadioButton descendingOrderRadioButton;
        private System.Windows.Forms.Button SORTButton;
        private System.Windows.Forms.TextBox SortedArrayTextBox;
        private System.Windows.Forms.Label SortedArrayLabel;
        private System.Windows.Forms.Label BS_ComparisonLabel;
        private System.Windows.Forms.TextBox BS_ComparisonsTextBox;
        private System.Windows.Forms.TextBox BS_SwapsTextBox;
        private System.Windows.Forms.Label BS_SwapsLabel;
        private System.Windows.Forms.CheckBox manualInputCheckBox;
        private System.Windows.Forms.Label manualInputLabel;
    }
}

