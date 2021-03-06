﻿namespace TerraTechModManager
{
    partial class NewMain
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
            System.Windows.Forms.Panel panel3;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Local", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Github", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Nexus Mods", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.Panel panel5;
            System.Windows.Forms.Label labelSearch;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMain));
            this.buttonDownloadMod = new System.Windows.Forms.Button();
            this.comboBoxModState = new System.Windows.Forms.ComboBox();
            this.buttonModShowDesc = new System.Windows.Forms.Button();
            this.buttonLocalModDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelModIDesc = new System.Windows.Forms.Label();
            this.labelModName = new System.Windows.Forms.Label();
            this.labelModLink = new System.Windows.Forms.Label();
            this.listViewCompactMods = new System.Windows.Forms.ListView();
            this.columnHeaderActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxModSearch = new System.Windows.Forms.TextBox();
            this.buttonLoadMoreMods = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadLatestPatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookForProgramUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadAllModUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookForModUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.githubTokenToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terraTechForumPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terraTechWikiPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTMMDownloadPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            labelSearch = new System.Windows.Forms.Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(this.buttonDownloadMod);
            panel3.Controls.Add(this.comboBoxModState);
            panel3.Controls.Add(this.buttonModShowDesc);
            panel3.Controls.Add(this.buttonLocalModDelete);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 329);
            panel3.Margin = new System.Windows.Forms.Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(585, 25);
            panel3.TabIndex = 2;
            // 
            // buttonDownloadMod
            // 
            this.buttonDownloadMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDownloadMod.Location = new System.Drawing.Point(121, 0);
            this.buttonDownloadMod.Name = "buttonDownloadMod";
            this.buttonDownloadMod.Size = new System.Drawing.Size(304, 25);
            this.buttonDownloadMod.TabIndex = 7;
            this.buttonDownloadMod.Text = "Download";
            this.buttonDownloadMod.UseVisualStyleBackColor = true;
            this.buttonDownloadMod.Click += new System.EventHandler(this.GetModFromCloud);
            // 
            // comboBoxModState
            // 
            this.comboBoxModState.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxModState.FormattingEnabled = true;
            this.comboBoxModState.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.comboBoxModState.Location = new System.Drawing.Point(0, 0);
            this.comboBoxModState.Name = "comboBoxModState";
            this.comboBoxModState.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModState.TabIndex = 6;
            this.comboBoxModState.Visible = false;
            this.comboBoxModState.SelectedIndexChanged += new System.EventHandler(this.LocalModStateChanged);
            // 
            // buttonModShowDesc
            // 
            this.buttonModShowDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonModShowDesc.Enabled = false;
            this.buttonModShowDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModShowDesc.Location = new System.Drawing.Point(425, 0);
            this.buttonModShowDesc.Name = "buttonModShowDesc";
            this.buttonModShowDesc.Size = new System.Drawing.Size(80, 25);
            this.buttonModShowDesc.TabIndex = 1;
            this.buttonModShowDesc.Text = "Description";
            this.buttonModShowDesc.UseVisualStyleBackColor = true;
            // 
            // buttonLocalModDelete
            // 
            this.buttonLocalModDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLocalModDelete.Location = new System.Drawing.Point(505, 0);
            this.buttonLocalModDelete.Name = "buttonLocalModDelete";
            this.buttonLocalModDelete.Size = new System.Drawing.Size(80, 25);
            this.buttonLocalModDelete.TabIndex = 0;
            this.buttonLocalModDelete.Text = "Delete Mod";
            this.buttonLocalModDelete.UseVisualStyleBackColor = true;
            this.buttonLocalModDelete.Visible = false;
            this.buttonLocalModDelete.Click += new System.EventHandler(this.PromptDeleteMod);
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(this.panel4);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(3, 292);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(579, 34);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelModIDesc);
            this.panel4.Controls.Add(this.labelModName);
            this.panel4.Controls.Add(this.labelModLink);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 34);
            this.panel4.TabIndex = 6;
            // 
            // labelModIDesc
            // 
            this.labelModIDesc.AutoSize = true;
            this.labelModIDesc.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelModIDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelModIDesc.Location = new System.Drawing.Point(0, 20);
            this.labelModIDesc.Name = "labelModIDesc";
            this.labelModIDesc.Size = new System.Drawing.Size(236, 13);
            this.labelModIDesc.TabIndex = 0;
            this.labelModIDesc.Text = "An inline description describing the selected mod";
            // 
            // labelModName
            // 
            this.labelModName.AutoSize = true;
            this.labelModName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelModName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelModName.Location = new System.Drawing.Point(0, 0);
            this.labelModName.Name = "labelModName";
            this.labelModName.Size = new System.Drawing.Size(51, 20);
            this.labelModName.TabIndex = 3;
            this.labelModName.Text = "Name";
            // 
            // labelModLink
            // 
            this.labelModLink.AutoSize = true;
            this.labelModLink.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelModLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelModLink.ForeColor = System.Drawing.Color.Blue;
            this.labelModLink.Location = new System.Drawing.Point(407, 0);
            this.labelModLink.Name = "labelModLink";
            this.labelModLink.Size = new System.Drawing.Size(172, 13);
            this.labelModLink.TabIndex = 5;
            this.labelModLink.Text = "A link to the site that holds the mod";
            this.labelModLink.UseWaitCursor = true;
            this.labelModLink.Click += new System.EventHandler(this.OpenModLink);
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(this.listViewCompactMods);
            panel1.Controls.Add(panel5);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(579, 283);
            panel1.TabIndex = 0;
            // 
            // listViewCompactMods
            // 
            this.listViewCompactMods.AutoArrange = false;
            this.listViewCompactMods.CheckBoxes = true;
            this.listViewCompactMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderActive,
            this.columnHeaderName,
            this.columnHeaderIDesc,
            this.columnHeaderAuthor,
            this.columnHeaderSite});
            this.listViewCompactMods.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Local";
            listViewGroup1.Name = "listViewGroupLocal";
            listViewGroup2.Header = "Github";
            listViewGroup2.Name = "listViewGroupGithub";
            listViewGroup3.Header = "Nexus Mods";
            listViewGroup3.Name = "listViewGroupNexusMods";
            this.listViewCompactMods.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.listViewCompactMods.HideSelection = false;
            this.listViewCompactMods.Location = new System.Drawing.Point(0, 20);
            this.listViewCompactMods.MultiSelect = false;
            this.listViewCompactMods.Name = "listViewCompactMods";
            this.listViewCompactMods.Size = new System.Drawing.Size(579, 263);
            this.listViewCompactMods.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewCompactMods.TabIndex = 3;
            this.listViewCompactMods.UseCompatibleStateImageBehavior = false;
            this.listViewCompactMods.View = System.Windows.Forms.View.Details;
            this.listViewCompactMods.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SetModActive);
            this.listViewCompactMods.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderActive
            // 
            this.columnHeaderActive.Text = "State";
            this.columnHeaderActive.Width = 70;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 206;
            // 
            // columnHeaderIDesc
            // 
            this.columnHeaderIDesc.Text = "Short Description";
            this.columnHeaderIDesc.Width = 199;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 85;
            // 
            // columnHeaderSite
            // 
            this.columnHeaderSite.Text = "Site";
            this.columnHeaderSite.Width = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(this.textBoxModSearch);
            panel5.Controls.Add(labelSearch);
            panel5.Controls.Add(this.buttonLoadMoreMods);
            panel5.Dock = System.Windows.Forms.DockStyle.Top;
            panel5.Location = new System.Drawing.Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(579, 20);
            panel5.TabIndex = 4;
            // 
            // textBoxModSearch
            // 
            this.textBoxModSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxModSearch.Location = new System.Drawing.Point(44, 0);
            this.textBoxModSearch.Name = "textBoxModSearch";
            this.textBoxModSearch.Size = new System.Drawing.Size(460, 20);
            this.textBoxModSearch.TabIndex = 3;
            this.textBoxModSearch.TextChanged += new System.EventHandler(this.textBoxModSearch_TextChanged);
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Dock = System.Windows.Forms.DockStyle.Left;
            labelSearch.Location = new System.Drawing.Point(0, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new System.Drawing.Size(44, 13);
            labelSearch.TabIndex = 4;
            labelSearch.Text = "Search:";
            labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoadMoreMods
            // 
            this.buttonLoadMoreMods.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLoadMoreMods.Location = new System.Drawing.Point(504, 0);
            this.buttonLoadMoreMods.Name = "buttonLoadMoreMods";
            this.buttonLoadMoreMods.Size = new System.Drawing.Size(75, 20);
            this.buttonLoadMoreMods.TabIndex = 2;
            this.buttonLoadMoreMods.Text = "Load more";
            this.buttonLoadMoreMods.UseVisualStyleBackColor = true;
            this.buttonLoadMoreMods.Visible = false;
            this.buttonLoadMoreMods.Click += new System.EventHandler(this.buttonLoadMoreMods_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxLog);
            this.splitContainer1.Size = new System.Drawing.Size(960, 378);
            this.splitContainer1.SplitterDistance = 585;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 354);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installPatchToolStripMenuItem,
            this.removePatchToolStripMenuItem,
            this.downloadLatestPatcherToolStripMenuItem,
            this.lookForProgramUpdateToolStripMenuItem,
            this.downloadAllModUpdatesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // installPatchToolStripMenuItem
            // 
            this.installPatchToolStripMenuItem.Name = "installPatchToolStripMenuItem";
            this.installPatchToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.installPatchToolStripMenuItem.Text = "Install Patch";
            this.installPatchToolStripMenuItem.Click += new System.EventHandler(this.InstallPatch);
            // 
            // removePatchToolStripMenuItem
            // 
            this.removePatchToolStripMenuItem.Name = "removePatchToolStripMenuItem";
            this.removePatchToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.removePatchToolStripMenuItem.Text = "Remove Patch";
            this.removePatchToolStripMenuItem.Click += new System.EventHandler(this.UninstallPatch);
            // 
            // downloadLatestPatcherToolStripMenuItem
            // 
            this.downloadLatestPatcherToolStripMenuItem.Name = "downloadLatestPatcherToolStripMenuItem";
            this.downloadLatestPatcherToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.downloadLatestPatcherToolStripMenuItem.Text = "Download Latest Patcher";
            this.downloadLatestPatcherToolStripMenuItem.Click += new System.EventHandler(this.DownloadPatcher);
            // 
            // lookForProgramUpdateToolStripMenuItem
            // 
            this.lookForProgramUpdateToolStripMenuItem.Name = "lookForProgramUpdateToolStripMenuItem";
            this.lookForProgramUpdateToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.lookForProgramUpdateToolStripMenuItem.Text = "Look for Program Update";
            this.lookForProgramUpdateToolStripMenuItem.Click += new System.EventHandler(this.lookForProgramUpdateToolStripMenuItem_Click);
            // 
            // downloadAllModUpdatesToolStripMenuItem
            // 
            this.downloadAllModUpdatesToolStripMenuItem.Name = "downloadAllModUpdatesToolStripMenuItem";
            this.downloadAllModUpdatesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.downloadAllModUpdatesToolStripMenuItem.Text = "Download All Mod Updates";
            this.downloadAllModUpdatesToolStripMenuItem.Click += new System.EventHandler(this.TryUpdateAll);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideLogToolStripMenuItem,
            this.skipStartToolStripMenuItem,
            this.lookForModUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.githubTokenToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.ConfigurationToolStripMenuItem_Click);
            // 
            // hideLogToolStripMenuItem
            // 
            this.hideLogToolStripMenuItem.Name = "hideLogToolStripMenuItem";
            this.hideLogToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.hideLogToolStripMenuItem.Text = "Hide Log";
            this.hideLogToolStripMenuItem.Click += new System.EventHandler(this.hideLogToolStripMenuItem_Click);
            // 
            // skipStartToolStripMenuItem
            // 
            this.skipStartToolStripMenuItem.Name = "skipStartToolStripMenuItem";
            this.skipStartToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.skipStartToolStripMenuItem.Text = "Skip Start";
            this.skipStartToolStripMenuItem.Click += new System.EventHandler(this.skipStartToolStripMenuItem_Click);
            // 
            // lookForModUpdatesToolStripMenuItem
            // 
            this.lookForModUpdatesToolStripMenuItem.Checked = true;
            this.lookForModUpdatesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lookForModUpdatesToolStripMenuItem.Enabled = false;
            this.lookForModUpdatesToolStripMenuItem.Name = "lookForModUpdatesToolStripMenuItem";
            this.lookForModUpdatesToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.lookForModUpdatesToolStripMenuItem.Text = "Look for Mod Updates";
            this.lookForModUpdatesToolStripMenuItem.Click += new System.EventHandler(this.lookForModUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // githubTokenToolStripMenuItem
            // 
            this.githubTokenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.githubTokenToolStripMenuItem.Name = "githubTokenToolStripMenuItem";
            this.githubTokenToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.githubTokenToolStripMenuItem.Text = "Github Token";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubPageToolStripMenuItem,
            this.terraTechForumPageToolStripMenuItem,
            this.terraTechWikiPageToolStripMenuItem,
            this.tTMMDownloadPageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // githubPageToolStripMenuItem
            // 
            this.githubPageToolStripMenuItem.Name = "githubPageToolStripMenuItem";
            this.githubPageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.githubPageToolStripMenuItem.Text = "Github page";
            this.githubPageToolStripMenuItem.Click += new System.EventHandler(this.githubPageToolStripMenuItem_Click);
            // 
            // terraTechForumPageToolStripMenuItem
            // 
            this.terraTechForumPageToolStripMenuItem.Name = "terraTechForumPageToolStripMenuItem";
            this.terraTechForumPageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.terraTechForumPageToolStripMenuItem.Text = "TerraTech Forum page";
            this.terraTechForumPageToolStripMenuItem.Click += new System.EventHandler(this.terraTechForumPageToolStripMenuItem_Click);
            // 
            // terraTechWikiPageToolStripMenuItem
            // 
            this.terraTechWikiPageToolStripMenuItem.Name = "terraTechWikiPageToolStripMenuItem";
            this.terraTechWikiPageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.terraTechWikiPageToolStripMenuItem.Text = "TerraTech Wiki page";
            this.terraTechWikiPageToolStripMenuItem.Click += new System.EventHandler(this.terraTechWikiPageToolStripMenuItem_Click);
            // 
            // tTMMDownloadPageToolStripMenuItem
            // 
            this.tTMMDownloadPageToolStripMenuItem.Name = "tTMMDownloadPageToolStripMenuItem";
            this.tTMMDownloadPageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.tTMMDownloadPageToolStripMenuItem.Text = "TTMM Download Page";
            this.tTMMDownloadPageToolStripMenuItem.Click += new System.EventHandler(this.tTMMDownloadPageToolStripMenuItem_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BackColor = System.Drawing.Color.Black;
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(371, 378);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // NewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 378);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewMain";
            this.Text = "TerraTech Mod Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IsClosing);
            this.Load += new System.EventHandler(this.NewMain_Load);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installPatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadLatestPatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox githubTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terraTechForumPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terraTechWikiPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tTMMDownloadPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookForModUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookForProgramUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem downloadAllModUpdatesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDownloadMod;
        private System.Windows.Forms.ComboBox comboBoxModState;
        private System.Windows.Forms.Button buttonModShowDesc;
        private System.Windows.Forms.Button buttonLocalModDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelModIDesc;
        private System.Windows.Forms.Label labelModName;
        private System.Windows.Forms.Label labelModLink;
        private System.Windows.Forms.ListView listViewCompactMods;
        private System.Windows.Forms.ColumnHeader columnHeaderActive;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderIDesc;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ColumnHeader columnHeaderSite;
        private System.Windows.Forms.TextBox textBoxModSearch;
        private System.Windows.Forms.Button buttonLoadMoreMods;
    }
}