using MusicTagger.Model;

namespace MusicTagger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTags = new System.Windows.Forms.BindingSource(this.components);
            this.lblTags = new MetroFramework.Controls.MetroLabel();
            this.lblFiles = new MetroFramework.Controls.MetroLabel();
            this.grdFiles = new MetroFramework.Controls.MetroGrid();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMusicFiles = new System.Windows.Forms.BindingSource(this.components);
            this.bsPrecedeByFiles = new System.Windows.Forms.BindingSource(this.components);
            this.bsContinueWithFiles = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContinueWithFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrecedeByFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMusicFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrecedeByFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContinueWithFiles)).BeginInit();
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
            this.btnAddTag.Click += new System.EventHandler(this.AddProjectTagClick);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdContinueWithFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grdContinueWithFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdContinueWithFiles.DefaultCellStyle = dataGridViewCellStyle14;
            this.grdContinueWithFiles.EnableHeadersVisualStyles = false;
            this.grdContinueWithFiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdContinueWithFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdContinueWithFiles.Location = new System.Drawing.Point(782, 318);
            this.grdContinueWithFiles.Name = "grdContinueWithFiles";
            this.grdContinueWithFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdContinueWithFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrecedeByFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdPrecedeByFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPrecedeByFiles.DefaultCellStyle = dataGridViewCellStyle17;
            this.grdPrecedeByFiles.EnableHeadersVisualStyles = false;
            this.grdPrecedeByFiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPrecedeByFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPrecedeByFiles.Location = new System.Drawing.Point(782, 32);
            this.grdPrecedeByFiles.Name = "grdPrecedeByFiles";
            this.grdPrecedeByFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrecedeByFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grdPrecedeByFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPrecedeByFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPrecedeByFiles.Size = new System.Drawing.Size(251, 261);
            this.grdPrecedeByFiles.TabIndex = 5;
            // 
            // grdTags
            // 
            this.grdTags.AllowUserToResizeColumns = false;
            this.grdTags.AllowUserToResizeRows = false;
            this.grdTags.AutoGenerateColumns = false;
            this.grdTags.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTags.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdTags.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdTags.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grdTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag});
            this.grdTags.DataSource = this.bsTags;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTags.DefaultCellStyle = dataGridViewCellStyle20;
            this.grdTags.EnableHeadersVisualStyles = false;
            this.grdTags.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdTags.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTags.Location = new System.Drawing.Point(565, 32);
            this.grdTags.Name = "grdTags";
            this.grdTags.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTags.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.grdTags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTags.ShowCellToolTips = false;
            this.grdTags.ShowEditingIcon = false;
            this.grdTags.Size = new System.Drawing.Size(211, 504);
            this.grdTags.TabIndex = 4;
            // 
            // Tag
            // 
            this.Tag.DataPropertyName = "Name";
            this.Tag.HeaderText = "";
            this.Tag.Name = "Tag";
            this.Tag.ReadOnly = true;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grdFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.grdFiles.DataSource = this.bsMusicFiles;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdFiles.DefaultCellStyle = dataGridViewCellStyle23;
            this.grdFiles.EnableHeadersVisualStyles = false;
            this.grdFiles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdFiles.Location = new System.Drawing.Point(3, 32);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
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
            ((System.ComponentModel.ISupportInitialize)(this.bsMusicFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrecedeByFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContinueWithFiles)).EndInit();
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
        private MetroFramework.Controls.MetroGrid grdTags;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
    }
}

