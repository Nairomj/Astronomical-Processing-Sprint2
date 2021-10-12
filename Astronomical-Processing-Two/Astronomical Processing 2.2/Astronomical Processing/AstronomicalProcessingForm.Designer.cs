
namespace Astronomical_Processing
{
    partial class AstronomicalProcessing
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
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonAddItem = new System.Windows.Forms.Button();
            this.ButtonDeleteItem = new System.Windows.Forms.Button();
            this.ButtonEditItem = new System.Windows.Forms.Button();
            this.ButtonFillData = new System.Windows.Forms.Button();
            this.TextBoxItem = new System.Windows.Forms.TextBox();
            this.ListBoxItems = new System.Windows.Forms.ListBox();
            this.ButtonSeqSearch = new System.Windows.Forms.Button();
            this.DataItem = new System.Windows.Forms.Label();
            this.CentralTendencyLabel = new System.Windows.Forms.Label();
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.MidExtremeTextBox = new System.Windows.Forms.TextBox();
            this.ModeTextBox = new System.Windows.Forms.TextBox();
            this.AverageTextBox = new System.Windows.Forms.TextBox();
            this.RangeTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(116, 49);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(141, 39);
            this.ButtonSearch.TabIndex = 0;
            this.ButtonSearch.Text = "Binary Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(263, 140);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(141, 39);
            this.ButtonSort.TabIndex = 1;
            this.ButtonSort.Text = "Bubble Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.Location = new System.Drawing.Point(116, 95);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(141, 39);
            this.ButtonAddItem.TabIndex = 2;
            this.ButtonAddItem.Text = "Add Item";
            this.ButtonAddItem.UseVisualStyleBackColor = true;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // ButtonDeleteItem
            // 
            this.ButtonDeleteItem.Location = new System.Drawing.Point(263, 95);
            this.ButtonDeleteItem.Name = "ButtonDeleteItem";
            this.ButtonDeleteItem.Size = new System.Drawing.Size(141, 39);
            this.ButtonDeleteItem.TabIndex = 3;
            this.ButtonDeleteItem.Text = "Delete Item";
            this.ButtonDeleteItem.UseVisualStyleBackColor = true;
            this.ButtonDeleteItem.Click += new System.EventHandler(this.ButtonDeleteItem_Click);
            // 
            // ButtonEditItem
            // 
            this.ButtonEditItem.Location = new System.Drawing.Point(116, 140);
            this.ButtonEditItem.Name = "ButtonEditItem";
            this.ButtonEditItem.Size = new System.Drawing.Size(141, 39);
            this.ButtonEditItem.TabIndex = 4;
            this.ButtonEditItem.Text = "Edit Item";
            this.ButtonEditItem.UseVisualStyleBackColor = true;
            this.ButtonEditItem.Click += new System.EventHandler(this.ButtonEditItem_Click);
            // 
            // ButtonFillData
            // 
            this.ButtonFillData.Location = new System.Drawing.Point(116, 185);
            this.ButtonFillData.Name = "ButtonFillData";
            this.ButtonFillData.Size = new System.Drawing.Size(288, 22);
            this.ButtonFillData.TabIndex = 5;
            this.ButtonFillData.Text = "Fill Data";
            this.ButtonFillData.UseVisualStyleBackColor = true;
            this.ButtonFillData.Click += new System.EventHandler(this.ButtonFillData_Click);
            // 
            // TextBoxItem
            // 
            this.TextBoxItem.Location = new System.Drawing.Point(21, 25);
            this.TextBoxItem.Name = "TextBoxItem";
            this.TextBoxItem.Size = new System.Drawing.Size(74, 20);
            this.TextBoxItem.TabIndex = 6;
            this.TextBoxItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxItem_KeyPress);
            // 
            // ListBoxItems
            // 
            this.ListBoxItems.FormattingEnabled = true;
            this.ListBoxItems.Location = new System.Drawing.Point(21, 51);
            this.ListBoxItems.Name = "ListBoxItems";
            this.ListBoxItems.Size = new System.Drawing.Size(74, 316);
            this.ListBoxItems.TabIndex = 7;
            this.ListBoxItems.SelectedIndexChanged += new System.EventHandler(this.ListBoxItems_SelectedIndexChanged);
            // 
            // ButtonSeqSearch
            // 
            this.ButtonSeqSearch.Location = new System.Drawing.Point(263, 49);
            this.ButtonSeqSearch.Name = "ButtonSeqSearch";
            this.ButtonSeqSearch.Size = new System.Drawing.Size(141, 39);
            this.ButtonSeqSearch.TabIndex = 8;
            this.ButtonSeqSearch.Text = "Sequential Search";
            this.ButtonSeqSearch.UseVisualStyleBackColor = true;
            this.ButtonSeqSearch.Click += new System.EventHandler(this.ButtonSeqSearch_Click);
            // 
            // DataItem
            // 
            this.DataItem.AutoSize = true;
            this.DataItem.Location = new System.Drawing.Point(18, 9);
            this.DataItem.Name = "DataItem";
            this.DataItem.Size = new System.Drawing.Size(56, 13);
            this.DataItem.TabIndex = 9;
            this.DataItem.Text = "Data Item:";
            // 
            // CentralTendencyLabel
            // 
            this.CentralTendencyLabel.AutoSize = true;
            this.CentralTendencyLabel.Location = new System.Drawing.Point(113, 221);
            this.CentralTendencyLabel.Name = "CentralTendencyLabel";
            this.CentralTendencyLabel.Size = new System.Drawing.Size(94, 13);
            this.CentralTendencyLabel.TabIndex = 10;
            this.CentralTendencyLabel.Text = "Central Tendency:";
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(116, 248);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(141, 23);
            this.ButtonMidExtreme.TabIndex = 11;
            this.ButtonMidExtreme.Text = "Mid Extreme";
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            this.ButtonMidExtreme.Click += new System.EventHandler(this.ButtonMidExtreme_Click);
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(116, 276);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(141, 23);
            this.ButtonMode.TabIndex = 12;
            this.ButtonMode.Text = "Mode";
            this.ButtonMode.UseVisualStyleBackColor = true;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(116, 302);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(141, 23);
            this.ButtonAverage.TabIndex = 13;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = true;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(116, 331);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(141, 23);
            this.ButtonRange.TabIndex = 14;
            this.ButtonRange.Text = "Range";
            this.ButtonRange.UseVisualStyleBackColor = true;
            this.ButtonRange.Click += new System.EventHandler(this.ButtonRange_Click);
            // 
            // MidExtremeTextBox
            // 
            this.MidExtremeTextBox.Location = new System.Drawing.Point(263, 248);
            this.MidExtremeTextBox.Name = "MidExtremeTextBox";
            this.MidExtremeTextBox.ReadOnly = true;
            this.MidExtremeTextBox.Size = new System.Drawing.Size(141, 20);
            this.MidExtremeTextBox.TabIndex = 15;
            // 
            // ModeTextBox
            // 
            this.ModeTextBox.Location = new System.Drawing.Point(263, 278);
            this.ModeTextBox.Name = "ModeTextBox";
            this.ModeTextBox.ReadOnly = true;
            this.ModeTextBox.Size = new System.Drawing.Size(141, 20);
            this.ModeTextBox.TabIndex = 16;
            // 
            // AverageTextBox
            // 
            this.AverageTextBox.Location = new System.Drawing.Point(263, 305);
            this.AverageTextBox.Name = "AverageTextBox";
            this.AverageTextBox.ReadOnly = true;
            this.AverageTextBox.Size = new System.Drawing.Size(141, 20);
            this.AverageTextBox.TabIndex = 17;
            // 
            // RangeTextBox
            // 
            this.RangeTextBox.Location = new System.Drawing.Point(263, 334);
            this.RangeTextBox.Name = "RangeTextBox";
            this.RangeTextBox.ReadOnly = true;
            this.RangeTextBox.Size = new System.Drawing.Size(141, 20);
            this.RangeTextBox.TabIndex = 18;
            // 
            // ClearDataButton
            // 
            this.ClearDataButton.Location = new System.Drawing.Point(21, 373);
            this.ClearDataButton.Name = "ClearDataButton";
            this.ClearDataButton.Size = new System.Drawing.Size(74, 20);
            this.ClearDataButton.TabIndex = 19;
            this.ClearDataButton.Text = "Clear Data";
            this.ClearDataButton.UseVisualStyleBackColor = true;
            this.ClearDataButton.Click += new System.EventHandler(this.ClearDataButton_Click);
            // 
            // AstronomicalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 406);
            this.Controls.Add(this.ClearDataButton);
            this.Controls.Add(this.RangeTextBox);
            this.Controls.Add(this.AverageTextBox);
            this.Controls.Add(this.ModeTextBox);
            this.Controls.Add(this.MidExtremeTextBox);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.ButtonMode);
            this.Controls.Add(this.ButtonMidExtreme);
            this.Controls.Add(this.CentralTendencyLabel);
            this.Controls.Add(this.DataItem);
            this.Controls.Add(this.ButtonSeqSearch);
            this.Controls.Add(this.ListBoxItems);
            this.Controls.Add(this.TextBoxItem);
            this.Controls.Add(this.ButtonFillData);
            this.Controls.Add(this.ButtonEditItem);
            this.Controls.Add(this.ButtonDeleteItem);
            this.Controls.Add(this.ButtonAddItem);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonSearch);
            this.Name = "AstronomicalProcessing";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonAddItem;
        private System.Windows.Forms.Button ButtonDeleteItem;
        private System.Windows.Forms.Button ButtonEditItem;
        private System.Windows.Forms.Button ButtonFillData;
        private System.Windows.Forms.TextBox TextBoxItem;
        private System.Windows.Forms.ListBox ListBoxItems;
        private System.Windows.Forms.Button ButtonSeqSearch;
        private System.Windows.Forms.Label DataItem;
        private System.Windows.Forms.Label CentralTendencyLabel;
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.TextBox MidExtremeTextBox;
        private System.Windows.Forms.TextBox ModeTextBox;
        private System.Windows.Forms.TextBox AverageTextBox;
        private System.Windows.Forms.TextBox RangeTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button ClearDataButton;
    }
}

