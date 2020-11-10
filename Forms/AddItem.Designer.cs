namespace Task_DelLine.Forms
{
    partial class AddItem
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
            this.btnApply = new System.Windows.Forms.Button();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.TextDateStart = new System.Windows.Forms.Label();
            this.textDateEnd = new System.Windows.Forms.Label();
            this.isDone = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textVehicle = new System.Windows.Forms.TextBox();
            this.textCarId = new System.Windows.Forms.TextBox();
            this.textRepairmanId = new System.Windows.Forms.TextBox();
            this.textCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(281, 270);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(73, 20);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(12, 212);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(148, 20);
            this.dateStart.TabIndex = 6;
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Location = new System.Drawing.Point(206, 212);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(148, 20);
            this.dateEnd.TabIndex = 7;
            // 
            // TextDateStart
            // 
            this.TextDateStart.AutoSize = true;
            this.TextDateStart.Location = new System.Drawing.Point(9, 196);
            this.TextDateStart.Name = "TextDateStart";
            this.TextDateStart.Size = new System.Drawing.Size(55, 13);
            this.TextDateStart.TabIndex = 8;
            this.TextDateStart.Text = "Start Date";
            // 
            // textDateEnd
            // 
            this.textDateEnd.AutoSize = true;
            this.textDateEnd.Location = new System.Drawing.Point(203, 196);
            this.textDateEnd.Name = "textDateEnd";
            this.textDateEnd.Size = new System.Drawing.Size(60, 13);
            this.textDateEnd.TabIndex = 9;
            this.textDateEnd.Text = "Finish Date";
            // 
            // isDone
            // 
            this.isDone.AutoSize = true;
            this.isDone.Location = new System.Drawing.Point(206, 238);
            this.isDone.Name = "isDone";
            this.isDone.Size = new System.Drawing.Size(95, 17);
            this.isDone.TabIndex = 12;
            this.isDone.Text = "Work is done?";
            this.isDone.UseVisualStyleBackColor = true;
            this.isDone.CheckedChanged += new System.EventHandler(this.IsDone_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Car id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Repairman id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vehicle Malfunction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cost";
            // 
            // textVehicle
            // 
            this.textVehicle.Location = new System.Drawing.Point(115, 64);
            this.textVehicle.MaxLength = 500;
            this.textVehicle.Multiline = true;
            this.textVehicle.Name = "textVehicle";
            this.textVehicle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textVehicle.Size = new System.Drawing.Size(239, 103);
            this.textVehicle.TabIndex = 20;
            // 
            // textCarId
            // 
            this.textCarId.Location = new System.Drawing.Point(115, 12);
            this.textCarId.MaxLength = 15;
            this.textCarId.Name = "textCarId";
            this.textCarId.Size = new System.Drawing.Size(239, 20);
            this.textCarId.TabIndex = 21;
            this.textCarId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCarId_KeyPress);
            // 
            // textRepairmanId
            // 
            this.textRepairmanId.Location = new System.Drawing.Point(115, 38);
            this.textRepairmanId.MaxLength = 15;
            this.textRepairmanId.Name = "textRepairmanId";
            this.textRepairmanId.Size = new System.Drawing.Size(239, 20);
            this.textRepairmanId.TabIndex = 22;
            this.textRepairmanId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextRepairmanId_KeyPress);
            // 
            // textCost
            // 
            this.textCost.Location = new System.Drawing.Point(115, 173);
            this.textCost.MaxLength = 15;
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(239, 20);
            this.textCost.TabIndex = 23;
            this.textCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCost_KeyPress);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 301);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.textRepairmanId);
            this.Controls.Add(this.textCarId);
            this.Controls.Add(this.textVehicle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isDone);
            this.Controls.Add(this.textDateEnd);
            this.Controls.Add(this.TextDateStart);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.btnApply);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label TextDateStart;
        private System.Windows.Forms.Label textDateEnd;
        private System.Windows.Forms.CheckBox isDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textVehicle;
        private System.Windows.Forms.TextBox textCarId;
        private System.Windows.Forms.TextBox textRepairmanId;
        private System.Windows.Forms.TextBox textCost;
    }
}