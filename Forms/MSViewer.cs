using Microsoft.Office.Interop.Excel;
using NLog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_DelLine.BDSQLServer;
using Task_DelLine.EventsLib;
using Task_DelLine.Forms;
using System.Linq;

namespace Task_DelLine
{
    public partial class MSViewer : Form
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();
        SqlConnection sqlConnection;
        DataSet dataSet;

        #region initialization MSViewer
        /// <summary>
        /// initialization
        /// </summary>
        public MSViewer()
        {
            InitializeComponent();

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            log.Info("Application was launched.");
        }
        #endregion

        #region Connection Button
        /// <summary>
        /// Creating a database connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.Debug("Getting Connection ...");
            sqlConnection = DBUtils.GetDBConnection();
            try
            {
                log.Debug("Openning Connection ...");
                await sqlConnection.OpenAsync();
                log.Info("Connection successful!");
                MessageBox.Show("Connection successful!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filterToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                log.Error("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SetFilter Button
        /// <summary>
        /// select view from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterProperties setFilterForm = new FilterProperties();
            setFilterForm.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(this.OnFilterChangeEvent);
            setFilterForm.Show();
        }
        /// <summary>
        /// event for getting data from FilterProperties form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void OnFilterChangeEvent(object sender, FilterChangeEventArgs e)
        {
            try
            {
                switch (e.Param)
                {
                    case "Select cars":
                        dataSet = await DBUtils.GetDataSetAsync($"SELECT * from CarView"
                            , sqlConnection, "Car");
                        break;
                    case "Select repairmans":
                        dataSet = await DBUtils.GetDataSetAsync($"SELECT * from RepairmanView"
                                , sqlConnection, "Repairman");
                        break;
                    case "Select clients":
                        dataSet = await DBUtils.GetDataSetAsync($"SELECT * from ClientView"
                                , sqlConnection, "Client");
                        break;
                    case "Select tasks":
                        if (e.IsPct)
                            dataSet = await DBUtils.GetDataSetAsync($"SELECT * from func_GetTaskWithPct('{e.DateStart}', '{e.DateEnd}')"
                                , sqlConnection, "TaskForCar");
                        else dataSet = await DBUtils.GetDataSetAsync($"SELECT * from func_GetTask('{e.DateStart}', '{e.DateEnd}')"
                                , sqlConnection, "TaskForCar");
                        break;
                    default:
                        if (e.IsPct)
                            dataSet = await DBUtils.GetDataSetAsync($"SELECT * from func_GetTaskWithPct('{e.DateStart}', '{e.DateEnd}')"
                                , sqlConnection, "TaskForCar");
                        else dataSet = await DBUtils.GetDataSetAsync($"SELECT * from func_GetTask('{e.DateStart}', '{e.DateEnd}')"
                                , sqlConnection, "TaskForCar");
                        break;
                }
                bindingSource.DataSource = dataSet.Tables[0];
                bindingNavigator.BindingSource = bindingSource;
                dataGridView.DataSource = bindingSource;
                dataGridView.Columns[0].Visible = false;
                saveAsToolStripMenuItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
            }
            catch (Exception ex)
            {
                log.Error("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region AddItem Button
        /// <summary>
        /// Add item from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            log.Debug("Open window AddItemForm...");
            AddItem setAddItemForm = new AddItem();
            setAddItemForm.AddItemChangeEvent += new EventHandler<AddItemChangeEventArgs>(this.OnAddItemChangeEvent);
            setAddItemForm.Show();
            log.Debug("Open window AddItemForm end.");
        }
        /// <summary>
        /// event for getting data from additem form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void OnAddItemChangeEvent(object sender, AddItemChangeEventArgs e)
        {
            log.Debug("OnAddItemChangeEvent starting...");
            SqlCommand command = new SqlCommand("INSERT INTO TaskForCar VALUES(@CarId, @RepairmanId, @VehicleMalfunction, @Cost, @StartDate, @FinishDate)", sqlConnection);
            command.Parameters.AddWithValue("@CarId", e.CarId);
            command.Parameters.AddWithValue("@RepairmanId", e.RepairmanId);
            command.Parameters.AddWithValue("@VehicleMalfunction", e.VehicleMalfunction);
            command.Parameters.AddWithValue("@Cost", e.Cost);
            command.Parameters.AddWithValue("@StartDate", e.DateStart);
            if (e.IsDone)
                command.Parameters.AddWithValue("@FinishDate", e.DateEnd);
            else
                command.Parameters.AddWithValue("@FinishDate", DBNull.Value);
            log.Trace($"Param:{command.Parameters}, from query {command.CommandText}");
            try
            {
                log.Debug($"command:ExecuteNonQueryAsync() in table:{dataSet.Tables[0].TableName} starting...");
                int ans = await command.ExecuteNonQueryAsync();
                MessageBox.Show($"Item was added.", "Successful");
                log.Info($"Item was added successful. Operation code({ans})");
            }
            catch (Exception ex)
            {
                log.Error("Add error: " + ex.Message);
                MessageBox.Show("Add error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                command.Dispose();
            }
        }
        #endregion

        #region Clear Button
        /// <summary>
        /// clear binding source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.Debug("Clear binding source starting...");
                bindingSource.DataSource = null;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                log.Info("Clear binding source completed successfully.");
            }
            catch (Exception ex)
            {
                log.Error("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Save file to excel button
        /// <summary>
        /// Save gridtable in Exel table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.Debug("Open save as window...");
            SaveFileDialog SFD = new SaveFileDialog
            {
                Title = ("Сохранить как..."),
                Filter = "XLSX Document (*.xlsx)| *.xlsx|" +
                "XLTM Document (*.xltm)| *.xltm|" +
                "XML Document (*.xml)| *.xml| " +
                "All Files (*.*)|*.*",
                OverwritePrompt = true
            };
            if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                log.Debug("Apply filename...");
                await SaveFileToExel(SFD.FileName);
            }
        }
        /// <summary>
        /// Task for save file to Excel document
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        private Task SaveFileToExel(string FileName)
        {
            return Task.Run(()=> {
                try
                {
                    log.Debug("Starting save to excel...");
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook book;
                    Worksheet table;

                    //Book.
                    book = app.Workbooks.Add(System.Reflection.Missing.Value);
                    //Table.
                    table = (Microsoft.Office.Interop.Excel.Worksheet)book.Worksheets.get_Item(1);

                    for (int i = 0; i < dataGridView.ColumnCount; i++)
                    {
                        table.Cells[1, i + 1] = dataGridView.Columns[i].HeaderCell.Value;
                    }

                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.ColumnCount; j++)
                        {
                            table.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                        }
                    }
                    table.Columns.AutoFit();
                    string ext = FileName.Substring(FileName.LastIndexOf('.'));
                    if (ext == ".xltm")
                        book.SaveAs(FileName, XlFileFormat.xlOpenXMLTemplateMacroEnabled);
                    else
                        book.SaveAs(FileName);
                    app.Visible = true;
                    //app.UserControl = true;
                    log.Info("Save exel file successful!");
                }
                catch (Exception ex)
                {
                    log.Error("Error: " + ex.Message);
                    MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
        #endregion

        #region Form closing event
        /// <summary>
        /// closes connection to ensure data retention
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            log.Info("MSViewer Form Closed");
        }
        #endregion

        #region Disconnect Button
        /// <summary>
        /// closes the connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                log.Debug("Starting disconnect from MS SQL...");
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                    log.Debug("Connection was established earlier");
                }
                else log.Debug("Connection was not established earlier");
                filterToolStripMenuItem.Enabled = false;
                disconnectToolStripMenuItem.Enabled = false;
                MessageBox.Show("Disconnect successful!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                log.Info("Disconnect complete successful!");
            }
            catch (Exception ex)
            {
                log.Error("Error in \"DisconnectToolStripMenuItem_Click\": " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Delete item button
        /// <summary>
        /// delete data from table and database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            log.Debug("trying to delete item...");
            try
            {
                if (dataGridView.CurrentRow == null)
                    throw new Exception("Row was not selected!");
                int rowIndex = dataGridView.CurrentRow.Index + 1;
                string idRow = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
                try
                {
                    if (idRow == "") throw new Exception("This item cannot be deleted!");
                    DialogResult result = MessageBox.Show("Do you want delete item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string name = dataSet.Tables[0].TableName;
                        SqlCommand command = new SqlCommand($"DELETE FROM {name} WHERE {name}Id = @id", sqlConnection);
                        command.Parameters.AddWithValue("@Id", idRow);
                        log.Debug($"SQL COMMAND: {command.CommandText} | Id={idRow}");
                        try
                        {
                            log.Debug("Sending request to server...");
                            int ans = await command.ExecuteNonQueryAsync();
                            log.Info($"Item:{idRow} want to remove successful. Operation code({ans})");
                            MessageBox.Show($"Item:{idRow} want to remove.", "Successful");
                            bindingSource.RemoveCurrent();
                        }
                        catch (Exception ex)
                        {
                            log.Error("Delete error: " + ex.Message);
                            MessageBox.Show("Delete error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            command.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Warn("Warning: " + ex.Message);
                    MessageBox.Show("Warning: " + ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Warn("Warning: " + ex.Message);
                MessageBox.Show("Warning: " + ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Default Button
        /// <summary>
        /// Open default view TaskForCar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.Debug("Trying select from DefaultView...");
            try
            {
                log.Debug("Accessing the database...");
                //dataSet = await DBUtils.GetDataSetAsync("SELECT TOP(500) * from DefaultView"
                //                , sqlConnection, "TaskForCar");
                CarServiceDBDataContext data = new CarServiceDBDataContext();
                log.Debug("DataSet load in SQL succses");
                //bindingSource.DataSource = dataSet.Tables[0];
                bindingSource.DataSource = data.CarView;
                bindingNavigator.BindingSource = bindingSource;
                dataGridView.DataSource = bindingSource;
                dataGridView.Columns[0].Visible = false;
                saveAsToolStripMenuItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
                log.Info("DefaultView load successfully.");
            }
            catch (Exception ex)
            {
                log.Error("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
