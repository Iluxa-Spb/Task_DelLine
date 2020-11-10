namespace Task_DelLine.Forms
{
    partial class FilterProperties
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.TextDateStart = new System.Windows.Forms.Label();
            this.textDateEnd = new System.Windows.Forms.Label();
            this.textSortBy = new System.Windows.Forms.Label();
            this.checkUsePct = new System.Windows.Forms.CheckBox();
            this.isCurrentDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 37);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(327, 21);
            this.comboBox.TabIndex = 3;
            this.comboBox.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_SelectionChangeCommitted);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(266, 155);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(73, 20);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(12, 107);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(148, 20);
            this.dateStart.TabIndex = 5;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(191, 107);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(148, 20);
            this.dateEnd.TabIndex = 6;
            // 
            // TextDateStart
            // 
            this.TextDateStart.AutoSize = true;
            this.TextDateStart.Location = new System.Drawing.Point(9, 91);
            this.TextDateStart.Name = "TextDateStart";
            this.TextDateStart.Size = new System.Drawing.Size(30, 13);
            this.TextDateStart.TabIndex = 7;
            this.TextDateStart.Text = "From";
            // 
            // textDateEnd
            // 
            this.textDateEnd.AutoSize = true;
            this.textDateEnd.Location = new System.Drawing.Point(188, 91);
            this.textDateEnd.Name = "textDateEnd";
            this.textDateEnd.Size = new System.Drawing.Size(38, 13);
            this.textDateEnd.TabIndex = 8;
            this.textDateEnd.Text = "Before";
            // 
            // textSortBy
            // 
            this.textSortBy.AutoSize = true;
            this.textSortBy.Location = new System.Drawing.Point(9, 21);
            this.textSortBy.Name = "textSortBy";
            this.textSortBy.Size = new System.Drawing.Size(49, 13);
            this.textSortBy.TabIndex = 9;
            this.textSortBy.Text = "Sort by...";
            // 
            // checkUsePct
            // 
            this.checkUsePct.AutoSize = true;
            this.checkUsePct.Location = new System.Drawing.Point(12, 144);
            this.checkUsePct.Name = "checkUsePct";
            this.checkUsePct.Size = new System.Drawing.Size(116, 17);
            this.checkUsePct.TabIndex = 10;
            this.checkUsePct.Text = "Show percentage?";
            this.checkUsePct.UseVisualStyleBackColor = true;
            // 
            // isCurrentDate
            // 
            this.isCurrentDate.AutoSize = true;
            this.isCurrentDate.Location = new System.Drawing.Point(191, 133);
            this.isCurrentDate.Name = "isCurrentDate";
            this.isCurrentDate.Size = new System.Drawing.Size(84, 17);
            this.isCurrentDate.TabIndex = 11;
            this.isCurrentDate.Text = "Current date";
            this.isCurrentDate.UseVisualStyleBackColor = true;
            this.isCurrentDate.CheckedChanged += new System.EventHandler(this.IsCurrentDate_CheckedChanged);
            // 
            // FilterProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 181);
            this.Controls.Add(this.isCurrentDate);
            this.Controls.Add(this.checkUsePct);
            this.Controls.Add(this.textSortBy);
            this.Controls.Add(this.textDateEnd);
            this.Controls.Add(this.TextDateStart);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.comboBox);
            this.Name = "FilterProperties";
            this.Text = "FilterProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label TextDateStart;
        private System.Windows.Forms.Label textDateEnd;
        private System.Windows.Forms.Label textSortBy;
        private System.Windows.Forms.CheckBox checkUsePct;
        private System.Windows.Forms.CheckBox isCurrentDate;
    }
}