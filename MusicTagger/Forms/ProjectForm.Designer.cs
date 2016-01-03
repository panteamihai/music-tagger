namespace MusicTagger.Forms
{
    partial class ProjectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblAddNewTag = new MetroFramework.Controls.MetroLabel();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnAddFile = new MetroFramework.Controls.MetroButton();
            this.btnAddFolder = new MetroFramework.Controls.MetroButton();
            this.btnClearList = new MetroFramework.Controls.MetroButton();
            this.btnAddTag = new MetroFramework.Controls.MetroButton();
            this.txtNewTag = new MetroFramework.Controls.MetroTextBox();
            this.lblContinueWith = new MetroFramework.Controls.MetroLabel();
            this.grdContinueWithFiles = new MetroFramework.Controls.MetroGrid();
            this.lblPrecedeBy = new MetroFramework.Controls.MetroLabel();
            this.grdPrecedeByFiles = new MetroFramework.Controls.MetroGrid();
            this.grdTags = new MetroFramework.Controls.MetroGrid();
            this.bsTags = new System.Windows.Forms.BindingSource(this.components);
            this.lblTags = new MetroFramework.Controls.MetroLabel();
            this.lblFiles = new MetroFramework.Controls.MetroLabel();
            this.grdFiles = new MetroFramework.Controls.MetroGrid();
            this.bsPrecedeByFiles = new System.Windows.Forms.BindingSource(this.components);
            this.bsContinueWithFiles = new System.Windows.Forms.BindingSource(this.components);
            this.bsProjectTags = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMusicFiles = new System.Windows.Forms.BindingSource(this.components);
            this.colTag = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContinueWithFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrecedeByFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrecedeByFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContinueWithFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMusicFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblAddNewTag);
            this.metroPanel1.Controls.Add(this.lblSearch);
            this.metroPanel1.Controls.Add(this.txtSearch);
            this.metroPanel1.Controls.Add(this.btnAddFile);
            this.metroPanel1.Controls.Add(this.btnAddFolder);
            this.metroPanel1.Controls.Add(this.btnClearList);
            this.metroPanel1.Controls.Add(this.btnAddTag);
            this.metroPanel1.Controls.Add(this.txtNewTag);
            this.metroPanel1.Controls.Add(this.lblContinueWith);
            this.metroPanel1.Controls.Add(this.grdContinueWithFiles);
            this.metroPanel1.Controls.Add(this.lblPrecedeBy);
            this.metroPanel1.Controls.Add(this.grdPrecedeByFiles);
            this.metroPanel1.Controls.Add(this.grdTags);
            this.metroPanel1.Controls.Add(this.lblTags);
            this.metroPanel1.Controls.Add(this.lblFiles);
            this.metroPanel1.Controls.Add(this.grdFiles);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1036, 568);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblAddNewTag
            // 
            this.lblAddNewTag.AutoSize = true;
            this.lblAddNewTag.Location = new System.Drawing.Point(475, 546);
            this.lblAddNewTag.Name = "lblAddNewTag";
            this.lblAddNewTag.Size = new System.Drawing.Size(84, 19);
            this.lblAddNewTag.TabIndex = 16;
            this.lblAddNewTag.Text = "Add new tag";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(248, 7);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 19);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(302, 3);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(257, 23);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(101, 542);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(92, 23);
            this.btnAddFile.TabIndex = 14;
            this.btnAddFile.Text = "Add file";
            this.btnAddFile.UseSelectable = true;
            this.btnAddFile.Click += new System.EventHandler(this.BtnAddFileClick);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(3, 542);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(92, 23);
            this.btnAddFolder.TabIndex = 13;
            this.btnAddFolder.Text = "Add folder";
            this.btnAddFolder.UseSelectable = true;
            this.btnAddFolder.Click += new System.EventHandler(this.BtnAddFolderClick);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(199, 542);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(92, 23);
            this.btnClearList.TabIndex = 11;
            this.btnClearList.Text = "Clear list";
            this.btnClearList.UseSelectable = true;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearListClick);
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(744, 542);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(32, 23);
            this.btnAddTag.TabIndex = 10;
            this.btnAddTag.Text = "+";
            this.btnAddTag.UseSelectable = true;
            // 
            // txtNewTag
            // 
            // 
            // 
            // 
            this.txtNewTag.CustomButton.Image = null;
            this.txtNewTag.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtNewTag.CustomButton.Name = "";
            this.txtNewTag.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewTag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewTag.CustomButton.TabIndex = 1;
            this.txtNewTag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewTag.CustomButton.UseSelectable = true;
            this.txtNewTag.CustomButton.Visible = false;
            this.txtNewTag.Lines = new string[0];
            this.txtNewTag.Location = new System.Drawing.Point(565, 542);
            this.txtNewTag.MaxLength = 32767;
            this.txtNewTag.Name = "txtNewTag";
            this.txtNewTag.PasswordChar = '\0';
            this.txtNewTag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewTag.SelectedText = "";
            this.txtNewTag.SelectionLength = 0;
            this.txtNewTag.SelectionStart = 0;
            this.txtNewTag.Size = new System.Drawing.Size(173, 23);
            this.txtNewTag.TabIndex = 9;
            this.txtNewTag.UseSelectable = true;
            this.txtNewTag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewTag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblContinueWith
            // 
            this.lblContinueWith.AutoSize = true;
            this.lblContinueWith.Location = new System.Drawing.Point(782, 296);
            this.lblContinueWith.Name = "lblContinueWith";
            this.lblContinueWith.Size = new System.Drawing.Size(92, 19);
            this.lblContinueWith.TabIndex = 8;
            this.lblContinueWith.Text = "Continue With";
            // 
            // grdContinueWithFiles
            // 
            this.grdContinueWithFiles.AllowUserToAddRows = false;
            this.grdContinueWithFiles.AllowUserToDeleteRows = false;
            this.grdContinueWithFiles.AllowUserToResizeRows = false;
            this.grdContinueWithFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdContinueWithFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdContinueWithFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdContinueWithFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdContinueWithFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdContinueWithFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdContinueWithFiles.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdContinueWithFiles.EnableHeadersVisualStyles = false;
            this.grdContinueWithFiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdContinueWithFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdContinueWithFiles.Location = new System.Drawing.Point(782, 318);
            this.grdContinueWithFiles.Name = "grdContinueWithFiles";
            this.grdContinueWithFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdContinueWithFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdContinueWithFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdContinueWithFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContinueWithFiles.Size = new System.Drawing.Size(251, 247);
            this.grdContinueWithFiles.TabIndex = 7;
            // 
            // lblPrecedeBy
            // 
            this.lblPrecedeBy.AutoSize = true;
            this.lblPrecedeBy.Location = new System.Drawing.Point(782, 10);
            this.lblPrecedeBy.Name = "lblPrecedeBy";
            this.lblPrecedeBy.Size = new System.Drawing.Size(75, 19);
            this.lblPrecedeBy.TabIndex = 6;
            this.lblPrecedeBy.Text = "Precede By";
            // 
            // grdPrecedeByFiles
            // 
            this.grdPrecedeByFiles.AllowUserToAddRows = false;
            this.grdPrecedeByFiles.AllowUserToDeleteRows = false;
            this.grdPrecedeByFiles.AllowUserToResizeRows = false;
            this.grdPrecedeByFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPrecedeByFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdPrecedeByFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPrecedeByFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrecedeByFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdPrecedeByFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPrecedeByFiles.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdPrecedeByFiles.EnableHeadersVisualStyles = false;
            this.grdPrecedeByFiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPrecedeByFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPrecedeByFiles.Location = new System.Drawing.Point(782, 32);
            this.grdPrecedeByFiles.Name = "grdPrecedeByFiles";
            this.grdPrecedeByFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrecedeByFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdPrecedeByFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPrecedeByFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPrecedeByFiles.Size = new System.Drawing.Size(251, 261);
            this.grdPrecedeByFiles.TabIndex = 5;
            // 
            // grdTags
            // 
            this.grdTags.AllowUserToResizeRows = false;
            this.grdTags.AutoGenerateColumns = false;
            this.grdTags.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTags.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdTags.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdTags.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTag});
            this.grdTags.DataSource = this.bsTags;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTags.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdTags.EnableHeadersVisualStyles = false;
            this.grdTags.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdTags.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTags.Location = new System.Drawing.Point(565, 32);
            this.grdTags.Name = "grdTags";
            this.grdTags.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTags.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdTags.ShowCellToolTips = false;
            this.grdTags.ShowEditingIcon = false;
            this.grdTags.ShowRowErrors = false;
            this.grdTags.Size = new System.Drawing.Size(211, 504);
            this.grdTags.TabIndex = 4;
            this.grdTags.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdTags_EditingControlShowing);
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(565, 7);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(74, 19);
            this.lblTags.TabIndex = 3;
            this.lblTags.Text = "Tags on file";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(3, 7);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(34, 19);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "Files";
            // 
            // grdFiles
            // 
            this.grdFiles.AllowUserToAddRows = false;
            this.grdFiles.AllowUserToDeleteRows = false;
            this.grdFiles.AllowUserToResizeColumns = false;
            this.grdFiles.AllowUserToResizeRows = false;
            this.grdFiles.AutoGenerateColumns = false;
            this.grdFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.grdFiles.DataSource = this.bsMusicFiles;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdFiles.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdFiles.EnableHeadersVisualStyles = false;
            this.grdFiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdFiles.Location = new System.Drawing.Point(3, 32);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFiles.ShowCellToolTips = false;
            this.grdFiles.ShowEditingIcon = false;
            this.grdFiles.Size = new System.Drawing.Size(556, 504);
            this.grdFiles.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 17;
            // 
            // bsMusicFiles
            // 
            this.bsMusicFiles.DataSource = typeof(MusicTagger.Model.MusicFile);
            // 
            // colTag
            // 
            this.colTag.DataPropertyName = "Name";
            this.colTag.HeaderText = "";
            this.colTag.Name = "colTag";
            this.colTag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTag.Width = 150;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 648);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ProjectForm";
            this.Text = "Music Tagger";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectFormClosing);
            this.Shown += new System.EventHandler(this.ProjectFormShown);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContinueWithFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrecedeByFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrecedeByFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContinueWithFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMusicFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblFiles;
        private MetroFramework.Controls.MetroGrid grdFiles;
        private MetroFramework.Controls.MetroButton btnAddTag;
        private MetroFramework.Controls.MetroTextBox txtNewTag;
        private MetroFramework.Controls.MetroLabel lblContinueWith;
        private MetroFramework.Controls.MetroGrid grdContinueWithFiles;
        private MetroFramework.Controls.MetroLabel lblPrecedeBy;
        private MetroFramework.Controls.MetroGrid grdPrecedeByFiles;
        private MetroFramework.Controls.MetroLabel lblTags;
        private MetroFramework.Controls.MetroButton btnAddFile;
        private MetroFramework.Controls.MetroButton btnAddFolder;
        private MetroFramework.Controls.MetroButton btnClearList;
        private System.Windows.Forms.BindingSource bsMusicFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblAddNewTag;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.BindingSource bsTags;
        private System.Windows.Forms.BindingSource bsPrecedeByFiles;
        private System.Windows.Forms.BindingSource bsContinueWithFiles;
        private System.Windows.Forms.BindingSource bsProjectTags;
        private MetroFramework.Controls.MetroGrid grdTags;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTag;
    }
}

