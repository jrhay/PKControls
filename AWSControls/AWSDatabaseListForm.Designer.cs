namespace PortableKnowledge.Controls
{
    partial class AWSDatabaseListForm<T, D>
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
            this.editRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GbSalesforceSearch = new System.Windows.Forms.GroupBox();
            this.btnFindRecords = new System.Windows.Forms.Button();
            this.LblSearchFor = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.cmbSearchMethod = new System.Windows.Forms.ComboBox();
            this.LblSearchMethodLbl = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gvResults = new BrightIdeasSoftware.FastObjectListView();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSeperatedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAWSStatus = new System.Windows.Forms.ProgressBar();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAWSStatusMessage = new System.Windows.Forms.Label();
            this.lblAWSStatus = new System.Windows.Forms.Label();
            this.grpDatabase = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.GbSalesforceSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.grpDatabase.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editRecordToolStripMenuItem
            // 
            this.editRecordToolStripMenuItem.Name = "editRecordToolStripMenuItem";
            this.editRecordToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editRecordToolStripMenuItem.Text = "Edit Record...";
            this.editRecordToolStripMenuItem.Click += new System.EventHandler(this.EditRecordToolStripMenuItem_Click);
            // 
            // GbSalesforceSearch
            // 
            this.GbSalesforceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbSalesforceSearch.Controls.Add(this.btnFindRecords);
            this.GbSalesforceSearch.Controls.Add(this.LblSearchFor);
            this.GbSalesforceSearch.Controls.Add(this.txtSearchText);
            this.GbSalesforceSearch.Controls.Add(this.cmbSearchMethod);
            this.GbSalesforceSearch.Controls.Add(this.LblSearchMethodLbl);
            this.GbSalesforceSearch.Location = new System.Drawing.Point(9, 76);
            this.GbSalesforceSearch.Name = "GbSalesforceSearch";
            this.GbSalesforceSearch.Size = new System.Drawing.Size(403, 72);
            this.GbSalesforceSearch.TabIndex = 12;
            this.GbSalesforceSearch.TabStop = false;
            this.GbSalesforceSearch.Text = "Search";
            // 
            // btnFindRecords
            // 
            this.btnFindRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindRecords.Location = new System.Drawing.Point(311, 20);
            this.btnFindRecords.Name = "btnFindRecords";
            this.btnFindRecords.Size = new System.Drawing.Size(75, 41);
            this.btnFindRecords.TabIndex = 13;
            this.btnFindRecords.Text = "Find Records";
            this.btnFindRecords.UseVisualStyleBackColor = true;
            this.btnFindRecords.Click += new System.EventHandler(this.BtnFindRecords_Click);
            // 
            // LblSearchFor
            // 
            this.LblSearchFor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSearchFor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblSearchFor.Location = new System.Drawing.Point(146, 19);
            this.LblSearchFor.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LblSearchFor.Name = "LblSearchFor";
            this.LblSearchFor.Size = new System.Drawing.Size(145, 21);
            this.LblSearchFor.TabIndex = 7;
            this.LblSearchFor.Text = "For records containing (case-sensitive)";
            this.LblSearchFor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchText.Location = new System.Drawing.Point(146, 40);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(145, 20);
            this.txtSearchText.TabIndex = 6;
            // 
            // cmbSearchMethod
            // 
            this.cmbSearchMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchMethod.FormattingEnabled = true;
            this.cmbSearchMethod.Items.AddRange(new object[] {
            "Manufacturer",
            "Model",
            "Lamp"});
            this.cmbSearchMethod.Location = new System.Drawing.Point(20, 40);
            this.cmbSearchMethod.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cmbSearchMethod.Name = "cmbSearchMethod";
            this.cmbSearchMethod.Size = new System.Drawing.Size(111, 21);
            this.cmbSearchMethod.TabIndex = 4;
            // 
            // LblSearchMethodLbl
            // 
            this.LblSearchMethodLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblSearchMethodLbl.Location = new System.Drawing.Point(20, 19);
            this.LblSearchMethodLbl.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LblSearchMethodLbl.Name = "LblSearchMethodLbl";
            this.LblSearchMethodLbl.Size = new System.Drawing.Size(111, 21);
            this.LblSearchMethodLbl.TabIndex = 3;
            this.LblSearchMethodLbl.Text = "Search In";
            this.LblSearchMethodLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clearDatabaseToolStripMenuItem.Text = "Clear Database...";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.ClearDatabaseToolStripMenuItem_Click);
            // 
            // initializeDatabaseToolStripMenuItem
            // 
            this.initializeDatabaseToolStripMenuItem.Name = "initializeDatabaseToolStripMenuItem";
            this.initializeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.initializeDatabaseToolStripMenuItem.Text = "Initialize Database...";
            this.initializeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.InitializeDatabaseToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeDatabaseToolStripMenuItem,
            this.clearDatabaseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newRecordToolStripMenuItem,
            this.editRecordToolStripMenuItem,
            this.deleteRecordToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // newRecordToolStripMenuItem
            // 
            this.newRecordToolStripMenuItem.Name = "newRecordToolStripMenuItem";
            this.newRecordToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.newRecordToolStripMenuItem.Text = "New Record...";
            this.newRecordToolStripMenuItem.Click += new System.EventHandler(this.NewRecordToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record...";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.DeleteRecordToolStripMenuItem_Click);
            // 
            // cSVFileToolStripMenuItem1
            // 
            this.cSVFileToolStripMenuItem1.Name = "cSVFileToolStripMenuItem1";
            this.cSVFileToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cSVFileToolStripMenuItem1.Text = "CSV File...";
            this.cSVFileToolStripMenuItem1.Click += new System.EventHandler(this.CSVFileToolStripMenuItem1_Click);
            // 
            // gvResults
            // 
            this.gvResults.AllowColumnReorder = true;
            this.gvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResults.CellEditUseWholeCell = false;
            this.gvResults.ContextMenuStrip = this.contextMenuStrip1;
            this.gvResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvResults.EmptyListMsg = "No Records Found; Change search parameters or press \"Load All...\"";
            this.gvResults.EmptyListMsgFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvResults.FullRowSelect = true;
            this.gvResults.Location = new System.Drawing.Point(9, 154);
            this.gvResults.Name = "gvResults";
            this.gvResults.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.ModelDialog;
            this.gvResults.ShowGroups = false;
            this.gvResults.Size = new System.Drawing.Size(484, 337);
            this.gvResults.TabIndex = 11;
            this.gvResults.UseCompatibleStateImageBehavior = false;
            this.gvResults.View = System.Windows.Forms.View.Details;
            this.gvResults.VirtualMode = true;
            this.gvResults.SelectedIndexChanged += new System.EventHandler(this.GvResults_SelectedIndexChanged);
            this.gvResults.DoubleClick += new System.EventHandler(this.GvResults_DoubleClick);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVFileToolStripMenuItem1});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.hTMLToolStripMenuItem.Text = "HTML...";
            // 
            // tabSeperatedFileToolStripMenuItem
            // 
            this.tabSeperatedFileToolStripMenuItem.Name = "tabSeperatedFileToolStripMenuItem";
            this.tabSeperatedFileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.tabSeperatedFileToolStripMenuItem.Text = "Tab Seperated File...";
            this.tabSeperatedFileToolStripMenuItem.Click += new System.EventHandler(this.TabSeperatedFileToolStripMenuItem_Click);
            // 
            // cSVFileToolStripMenuItem
            // 
            this.cSVFileToolStripMenuItem.Name = "cSVFileToolStripMenuItem";
            this.cSVFileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cSVFileToolStripMenuItem.Text = "CSV File...";
            this.cSVFileToolStripMenuItem.Click += new System.EventHandler(this.CSVFileToolStripMenuItem_Click);
            // 
            // pbAWSStatus
            // 
            this.pbAWSStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAWSStatus.Location = new System.Drawing.Point(13, 44);
            this.pbAWSStatus.MarqueeAnimationSpeed = 50;
            this.pbAWSStatus.Name = "pbAWSStatus";
            this.pbAWSStatus.Size = new System.Drawing.Size(477, 23);
            this.pbAWSStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbAWSStatus.TabIndex = 10;
            this.pbAWSStatus.Visible = false;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadAll.Location = new System.Drawing.Point(418, 95);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(75, 41);
            this.btnLoadAll.TabIndex = 9;
            this.btnLoadAll.Text = "Load All Records";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.BtnLoadAll_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVFileToolStripMenuItem,
            this.tabSeperatedFileToolStripMenuItem,
            this.hTMLToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lblAWSStatusMessage
            // 
            this.lblAWSStatusMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAWSStatusMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAWSStatusMessage.Location = new System.Drawing.Point(9, 40);
            this.lblAWSStatusMessage.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblAWSStatusMessage.Name = "lblAWSStatusMessage";
            this.lblAWSStatusMessage.Size = new System.Drawing.Size(484, 32);
            this.lblAWSStatusMessage.TabIndex = 7;
            this.lblAWSStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAWSStatus
            // 
            this.lblAWSStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAWSStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAWSStatus.Location = new System.Drawing.Point(9, 19);
            this.lblAWSStatus.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblAWSStatus.Name = "lblAWSStatus";
            this.lblAWSStatus.Size = new System.Drawing.Size(484, 21);
            this.lblAWSStatus.TabIndex = 6;
            this.lblAWSStatus.Text = "Status";
            this.lblAWSStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDatabase
            // 
            this.grpDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatabase.Controls.Add(this.GbSalesforceSearch);
            this.grpDatabase.Controls.Add(this.gvResults);
            this.grpDatabase.Controls.Add(this.pbAWSStatus);
            this.grpDatabase.Controls.Add(this.btnLoadAll);
            this.grpDatabase.Controls.Add(this.lblAWSStatusMessage);
            this.grpDatabase.Controls.Add(this.lblAWSStatus);
            this.grpDatabase.Location = new System.Drawing.Point(0, 26);
            this.grpDatabase.Name = "grpDatabase";
            this.grpDatabase.Size = new System.Drawing.Size(499, 503);
            this.grpDatabase.TabIndex = 5;
            this.grpDatabase.TabStop = false;
            this.grpDatabase.Text = "List Database";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem2,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 76);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete...";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // AWSDatabaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 530);
            this.Controls.Add(this.grpDatabase);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AWSDatabaseListForm";
            this.Text = "AWSDatabaseListForm";
            this.GbSalesforceSearch.ResumeLayout(false);
            this.GbSalesforceSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.grpDatabase.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem editRecordToolStripMenuItem;
        private System.Windows.Forms.GroupBox GbSalesforceSearch;
        private System.Windows.Forms.Button btnFindRecords;
        private System.Windows.Forms.Label LblSearchFor;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.ComboBox cmbSearchMethod;
        private System.Windows.Forms.Label LblSearchMethodLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVFileToolStripMenuItem1;
        private BrightIdeasSoftware.FastObjectListView gvResults;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabSeperatedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVFileToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pbAWSStatus;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lblAWSStatusMessage;
        private System.Windows.Forms.Label lblAWSStatus;
        private System.Windows.Forms.GroupBox grpDatabase;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}