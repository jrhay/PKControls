using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using BrightIdeasSoftware;
using CsvHelper;
using RealDAWSFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableKnowledge.Controls
{
    public partial class AWSDatabaseListForm<T, D> : Form where T: IAWSDatabaseRecord, new() where D: RealDAWSDatabase<T>
    {
        RealDAWSDatabase<T> Database;
        List<T> RecordList;
        String RecordNames;
        Type RecordEditFormType;
        PresentationQualityAccess Access;

        public AWSDatabaseListForm()
        {
            InitializeComponent();
        }

        public AWSDatabaseListForm(RealDAWSDatabase<T> database, AmazonDynamoDBClient dBClient, DynamoDBContext dBContext, String recordNames, SearchType[] SearchTypes, Dictionary<String, String> Columns, Type recordEditFormType, PresentationQualityAccess Access) : this()
        {
            InitFields(database, dBClient, dBContext, recordNames, SearchTypes, Columns, recordEditFormType, Access);
        }

        public void InitFields(RealDAWSDatabase<T> database, AmazonDynamoDBClient dBClient, DynamoDBContext dBContext, String recordNames, SearchType[] SearchTypes, Dictionary<String, String> Columns, Type recordEditFormType, PresentationQualityAccess Access)
        {
            this.Database = database;
            this.RecordList = new List<T>();
            this.RecordNames = recordNames;
            this.RecordEditFormType = recordEditFormType;

            SetRoleMode(false);

            grpDatabase.Text = RecordNames + " Database";
            btnLoadAll.Text = "Load All " + RecordNames;
            btnFindRecords.Text = "Find " + RecordNames;

            this.Text = RecordNames;

            int defWidth = gvResults.Width / Columns.Count();
            foreach (string key in Columns.Keys)
            {
                OLVColumn Col = new OLVColumn(key, Columns[key]);
                Col.Width = defWidth;

                int pos = Col.AspectName.IndexOf(':');
                if (pos > 0)
                {
                    float fsize = 0;
                    if (float.TryParse(Col.AspectName.Substring(pos+1), out fsize))
                    {
                        Col.AspectName = Col.AspectName.Substring(0, pos);
                        Col.Width = (int)((fsize / 100f) * (float)gvResults.Width);
                    }
                }

                if (key.IndexOf('?') > 0)
                {
                    gvResults.UseSubItemCheckBoxes = true;
                    Col.CheckBoxes = true;
                }

                gvResults.AllColumns.Add(Col);
            }
            gvResults.RebuildColumns();

            _ = Init(dBClient, dBContext, SearchTypes, Access);
            BtnLoadAll_Click(null, null);
        }

        public void SetGroupingRecord(String ColumnAspect)
        {
            OLVColumn matchColumn = null;
            if (!String.IsNullOrEmpty(ColumnAspect))
                foreach (OLVColumn col in gvResults.AllColumns)
                {
                    if (col.AspectName.Equals(ColumnAspect))
                        matchColumn = col;
                }

            if (matchColumn != null)
                gvResults.AlwaysGroupByColumn = matchColumn;

            gvResults.ShowGroups = (matchColumn != null);
        }

        private async Task Init(AmazonDynamoDBClient dBClient, DynamoDBContext dBContext, SearchType[] SearchTypes, PresentationQualityAccess Access)
        {
            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen(Color.FromArgb(128, Color.LightSeaGreen), 2);
            rbd.BoundsPadding = new Size(1, 1);
            rbd.CornerRounding = 4.0f;

            gvResults.HotItemStyle = new HotItemStyle();
            gvResults.HotItemStyle.Decoration = rbd;

            await Task.Run(() =>
            {
                StartAWSOperation("Contacting AWS...");
                Database.Connect(dBClient, dBContext,
                                (bool isSuccess, string Message) =>
                                {
                                    EndAWSOperation(isSuccess ? "Connected to AWS!" : "Unable to connect to AWS: " + Message);
                                });
            });

            StartAWSOperation("Verifying AWS database...");
            await Database.Verify(
                (bool isSuccess, string Message) =>
                {
                    SetSearchButtons(isSuccess);
                    EndAWSOperation(isSuccess ? "Ready" : Message);
                }
            );

            cmbSearchMethod.Items.Clear();
            cmbSearchMethod.Items.AddRange(SearchTypes);

            SetRoleMode(Access.isAdmin);
            this.Access = Access;
        }

        private void SetRoleMode(bool isAdmin)
        {
            gvResults.ContextMenuStrip = isAdmin ? contextMenuStrip1 : null;
            importToolStripMenuItem.Visible = isAdmin;
            databaseToolStripMenuItem.Visible = isAdmin;
        }

        public void StartAWSOperation(string Message)
        {
            if (pbAWSStatus.InvokeRequired)
                pbAWSStatus.BeginInvoke(new MethodInvoker(delegate () { StartAWSOperation(Message); }));
            else
            {
                SetRecordButtons(false);

                pbAWSStatus.Visible = true;
                lblAWSStatus.Text = Message;
                lblAWSStatusMessage.Text = null;
            }
        }

        public void EndAWSOperation(string StatusMessage)
        {
            if (pbAWSStatus.InvokeRequired)
                pbAWSStatus.BeginInvoke(new MethodInvoker(delegate () { EndAWSOperation(StatusMessage); }));
            else
            {
                pbAWSStatus.Visible = false;
                lblAWSStatus.Text = "Status";
                lblAWSStatusMessage.Text = StatusMessage;
            }
        }

        private void UpdateResultDisplay()
        {
            if (gvResults.InvokeRequired)
                gvResults.BeginInvoke(new MethodInvoker(delegate () { UpdateResultDisplay(); }));
            else
                gvResults.Refresh();
        }

        private void ShowResults(List<T> records)
        {
            if (gvResults.InvokeRequired)
                gvResults.BeginInvoke(new MethodInvoker(delegate () { ShowResults(records); }));
            else
            {
                gvResults.ClearObjects();
                RecordList = records;
                if (records != null)
                    gvResults.SetObjects(records);
            }
        }

        private void UpdateRecordDisplay(T record, Boolean RemoveRecord = false)
        {
            if (gvResults.InvokeRequired)
                gvResults.BeginInvoke(new MethodInvoker(delegate () { UpdateRecordDisplay(record, RemoveRecord); }));
            else
            {
                bool Found = false;
                if (RemoveRecord)
                {
                    if (RecordList != null)
                        RecordList.Remove(record);
                    gvResults.Objects = RecordList;
                }
                else
                {
                    if (RecordList == null)
                        RecordList = new List<T>();

                    for (int i = 0; i < RecordList.Count; i++)
                    {
                        if (RecordList[i].ID.Equals(record.ID))
                        {
                            RecordList[i] = record;
                            Found = true;
                            gvResults.BuildList(true);
                            break;
                        }
                    }
                    if (!Found)
                    {
                        RecordList.Add(record);
                        gvResults.Objects = RecordList;
                    }
                }
            }
        }

        private void SetSearchButtons(Boolean isEnabled)
        {
            if (btnLoadAll.InvokeRequired)
            {
                btnLoadAll.BeginInvoke(new MethodInvoker(delegate () { SetSearchButtons(isEnabled); }));
            }
            else
            {
                btnLoadAll.Enabled = isEnabled;
                btnFindRecords.Enabled = isEnabled;
            }
        }

        private void SetRecordButtons(Boolean isEnabled)
        {
            editRecordToolStripMenuItem.Enabled = isEnabled;
            editToolStripMenuItem.Enabled = isEnabled;

            deleteRecordToolStripMenuItem.Enabled = isEnabled;
            deleteToolStripMenuItem.Enabled = isEnabled;
        }

        private async Task LoadAllRecords()
        {
            if (!Database.IsConnected)
            {
                EndAWSOperation("Unable to get " + RecordNames + ": Can not contact AWS");
                return;
            }

            await Task.Run(async () =>
            {
                StartAWSOperation("Getting all " + RecordNames + "...");
                List<T> records = await Database.GetAllRecords(
                    (bool isSuccess, string Message) =>
                    {
                        EndAWSOperation(isSuccess ? "Downloaded all " + RecordNames : "Unable to get " + RecordNames + ": " + Message);
                    }
                );

                ShowResults(records);
            });
        }

        private async void BtnLoadAll_Click(object sender, EventArgs e)
        {
            await LoadAllRecords();
        }

        private async void InitializeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will attempt to create a " + RecordNames + " database in AWS. Any existing data will not be affected. Create new database?",
                        "Create New Database", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                StartAWSOperation("Creating " + RecordNames + " Table...");
                await Database.CreateDatabase(
                    (bool isSuccess, string Message) =>
                    {
                        SetSearchButtons(isSuccess);
                        EndAWSOperation(isSuccess ? "Ready" : Message);
                    }
                );
            }
        }

        private async void ClearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will remove ALL " + RecordNames + ".  There is no undo.  Clear Entire Database?",
                "Clear Entire Database", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                StartAWSOperation("Clearing Database...");
                await Database.RemoveDatabase(
                    (bool isSuccess, string Message) =>
                    {
                        if (isSuccess)
                            ShowResults(null);
                        EndAWSOperation(isSuccess ? RecordNames + " Cleared" : "Unable to clear " + RecordNames + ": " + Message);
                    });
            }
        }

        private async Task EditRecord(T record, bool force = false)
        {
            Form frmItem = (Form)Activator.CreateInstance(RecordEditFormType, new object[] { record });
            if (force || (frmItem.ShowDialog() == DialogResult.OK))
            {
                await Task.Run(async () =>
                {
                    StartAWSOperation("Saving Record \"" + record.ID + "\"...");
                    await Database.SaveRecord(record,
                        (bool isSuccess, string Message) =>
                        {
                            if (isSuccess)
                                UpdateRecordDisplay(record);
                            EndAWSOperation(isSuccess ? record.ID + " saved in database" : "Unable to save record: " + Message);
                        }
                   );
                });
            }
        }

        private async Task DeleteRecord(T record)
        {
            await Task.Run(async () =>
            {
                StartAWSOperation("Removing Record...");
                await Database.DeleteRecord(record,
                    (bool isSuccess, string Message) =>
                    {
                        if (isSuccess)
                            UpdateRecordDisplay(record, true);
                        EndAWSOperation(isSuccess ? "Removed record from database" : "Unable to remove record: " + Message);
                    }
                );
            });
        }

        private async void BtnFindRecords_Click(object sender, EventArgs e)
        {
            if (!Database.IsConnected)
            {
                EndAWSOperation("Unable to search " + RecordNames + ": Can not contact AWS");
                return;
            }

            string searchIndex = cmbSearchMethod.SelectedIndex >= 0 ? ((SearchType)cmbSearchMethod.SelectedItem).AttributeName : null;
            await Task.Run(async () =>
            {
                StartAWSOperation("Searching " + RecordNames + "...");
                List<T> records = await Database.GetAllRecords(
                    (bool isSuccess, string Message) =>
                    {
                        EndAWSOperation(isSuccess ? "Downloaded maching " + RecordNames : "Unable to get " + RecordNames + ": " + Message);
                    },
                    searchIndex, txtSearchText.Text
                );

                ShowResults(records);
            });
        }


        private async Task AddRecord(Boolean force = false)
        {
            await EditRecord(new T(), force);
        }

        private async Task AddRecord(T newRecord, Boolean force = false)
        {
            if (newRecord == null)
                await AddRecord(force);
            else
                await EditRecord(newRecord, force);
        }

        private async void NewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AddRecord();
        }

        private async void EditRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gvResults.SelectedIndex >= 0)
                await EditRecord((T)gvResults.GetItem(gvResults.SelectedIndex).RowObject);
        }

        private async void DeleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gvResults.SelectedIndex >= 0)
            {
                T Record = (T)gvResults.GetItem(gvResults.SelectedIndex).RowObject;
                if (MessageBox.Show("Delete " + Record.ID + "?  There is no undo.", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    await DeleteRecord(Record);
            }
        }

        private void GvResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRecordButtons(gvResults.SelectedIndex >= 0);
        }

        private void GvResults_DoubleClick(object sender, EventArgs e)
        {
            if (Access.isAdmin)
                EditRecordToolStripMenuItem_Click(sender, e);
        }

        private async Task ExportData(OLVExporter.ExportFormat format, string ext, string filter)
        {
            if (gvResults.InvokeRequired)
            {
                gvResults.BeginInvoke(new MethodInvoker(async delegate () { await ExportData(format, ext, filter); }));
            }
            else
            {
                SaveFileDialog dlgExport = new SaveFileDialog();
                dlgExport.FileName = RecordNames + "-" + DateTime.Now.ToLongDateString() + ext;
                dlgExport.Filter = filter;
                if (dlgExport.ShowDialog() == DialogResult.OK)
                {
                    StartAWSOperation("Exporting to " + dlgExport.FileName);
                    await Task.Run(() =>
                    {
                        try
                        {
                            OLVExporter exporter = new OLVExporter(gvResults, gvResults.FilteredObjects);

                            string csv = string.Empty;
                            csv = exporter.ExportTo(format);

                            using (StreamWriter sw = new StreamWriter(dlgExport.FileName))
                                sw.Write(csv);

                            EndAWSOperation("Data saved to " + dlgExport.FileName);
                        }
                        catch (Exception e)
                        {
                            EndAWSOperation("Unable to export data: " + e.Message);
                        }
                    });
                }
            }
        }

        private async Task ImportRecords(IEnumerable<T> records)
        {
            if (gvResults.InvokeRequired)
            {
                gvResults.BeginInvoke(new MethodInvoker(async delegate () { await ImportRecords(records); }));
            }
            else
            {
                int Count = 0;
                Boolean ReplaceAll = false;
                Boolean KeepAll = false;
                foreach (T record in records)
                {
                    record.MakeIDIfMissing();
                    if (!String.IsNullOrEmpty(record.ID))
                    {
                        T match = RecordList.Where(i => i.ID.Equals(record.ID)).FirstOrDefault();
                        if (match != null)
                        {
                            DialogResult Result = MessageBox.Show("Replace " + match.ID + "?", "Duplicate Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Result == DialogResult.No)
                                continue;
                            await DeleteRecord(match);
                        }
                        await AddRecord(record, true);
                        Count++;
                    }
                }
                EndAWSOperation(Count + " new " + RecordNames +" imported.");
            }
        }

        private async Task ImportData(OLVExporter.ExportFormat format, string ext, string filter)
        {
            if (gvResults.InvokeRequired)
            {
                gvResults.BeginInvoke(new MethodInvoker(async delegate () { await ExportData(format, ext, filter); }));
            }
            else
            {
                OpenFileDialog dlgImport = new OpenFileDialog();
                dlgImport.FileName = "*" + ext;
                dlgImport.Filter = filter;
                if (dlgImport.ShowDialog() == DialogResult.OK)
                {
                    StartAWSOperation("Importing From " + dlgImport.FileName);
                    await Task.Run(async () =>
                    {
                        try
                        {
                            List<T> records = new List<T>();
                            using (StreamReader csvFile = new StreamReader(dlgImport.FileName))
                            using (CsvReader csvData = new CsvReader(csvFile))
                            {
                                csvData.Configuration.HeaderValidated = null;
                                csvData.Configuration.MissingFieldFound = null;
                                foreach (T record in csvData.GetRecords<T>())
                                    records.Add(record);
                            }
                            await ImportRecords(records);
                            EndAWSOperation("Data read from " + dlgImport.FileName);
                        }
                        catch (Exception e)
                        {
                            EndAWSOperation("Unable to import data: " + e.Message);
                        }
                    });
                }
            }
        }

        private async void CSVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ExportData(OLVExporter.ExportFormat.CSV, ".csv", "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*");
        }

        private async void TabSeperatedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ExportData(OLVExporter.ExportFormat.TabSeparated, ".tsv", "TSV Files (*.tsv)|*.tsv|All Files (*.*)|*.*");
        }

        private async void HTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await ExportData(OLVExporter.ExportFormat.HTML, ".html", "HTML Files (*.htm?)|*.htm?|All Files (*.*)|*.*");
        }

        private async void CSVFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            await LoadAllRecords();
            await ImportData(OLVExporter.ExportFormat.CSV, ".csv", "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*");
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRecordToolStripMenuItem_Click(sender, e);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRecordToolStripMenuItem_Click(sender, e);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRecordToolStripMenuItem_Click(sender, e);
        }
    }
}
