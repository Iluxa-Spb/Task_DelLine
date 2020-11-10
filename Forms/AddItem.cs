using NLog;
using System;
using System.Windows.Forms;
using Task_DelLine.EventsLib;

namespace Task_DelLine.Forms
{
    public partial class AddItem : Form
    {
        public EventHandler<AddItemChangeEventArgs> AddItemChangeEvent;

        public static Logger Log { get; } = LogManager.GetCurrentClassLogger();

        public AddItem()
        {
            InitializeComponent();
        }
        /// <summary>
        /// processing button apply
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (textCarId.Text == "" || textCost.Text == "" || textRepairmanId.Text == "" || textVehicle.Text == "")
            {
                Log.Warn("Warning: not all lines are filled!");
                MessageBox.Show("Warning: not all lines are filled!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EventHandler<AddItemChangeEventArgs> handler = AddItemChangeEvent;
                handler?.Invoke(this, new AddItemChangeEventArgs(int.Parse(textCarId.Text)
                    , int.Parse(textRepairmanId.Text)
                    , textVehicle.Text
                    , int.Parse(textCost.Text)
                    , dateStart.Value
                    , dateEnd.Value
                    , isDone.Checked));
                this.Close();
            }
        }
        /// <summary>
        /// checking for entering numeric values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextCarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        /// <summary>
        /// checking for entering numeric values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextRepairmanId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        /// <summary>
        /// checking for entering numeric values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        /// <summary>
        /// checking current date setting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsDone_CheckedChanged(object sender, EventArgs e)
        {
            if (isDone.Checked) dateEnd.Enabled = true;
            else dateEnd.Enabled = false;
        }
    }
}