using System;
using System.Windows.Forms;
using Task_DelLine.EventsLib;

namespace Task_DelLine.Forms
{
    public partial class FilterProperties : Form
    {
        public event EventHandler<FilterChangeEventArgs> FilterChangeEvent;
        /// <summary>
        /// initialization FilterProperties
        /// </summary>
        public FilterProperties()
        {
            InitializeComponent();
            comboBox.Items.Add("Select cars");
            comboBox.Items.Add("Select repairmans");
            comboBox.Items.Add("Select clients");
            comboBox.Items.Add("Select tasks");
            comboBox.SelectedItem = "Select tasks";
            comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// processing button apply
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnApply_Click(object sender, EventArgs e)
        {
            EventHandler<FilterChangeEventArgs> handler = FilterChangeEvent;
            handler?.Invoke(this, new FilterChangeEventArgs(this.comboBox.SelectedItem.ToString()
                , dateStart.Value
                , dateEnd.Value
                , checkUsePct.Checked));
            this.Close();
        }
        /// <summary>
        /// flag for setting the current date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            if (isCurrentDate.Checked)
            {
                dateEnd.Value = DateTime.Now;
                dateEnd.Enabled = false;
            }
            else
                dateEnd.Enabled = true;
        }
        /// <summary>
        /// checking for a drop-down list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "Select tasks")
            {
                dateStart.Enabled = true;
                dateEnd.Enabled = true;
                isCurrentDate.Enabled = true;
                checkUsePct.Enabled = true;
            }
            else
            {
                dateStart.Enabled = false;
                dateEnd.Enabled = false;
                isCurrentDate.Enabled = false;
                checkUsePct.Enabled = false;
            }
        }
    }
}
