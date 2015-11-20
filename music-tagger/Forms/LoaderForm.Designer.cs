namespace MusicTagger
{
    partial class LoaderForm
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
            this.pnlButtons = new MetroFramework.Controls.MetroPanel();
            this.progress = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnCreateNewProject = new MetroFramework.Controls.MetroButton();
            this.btnLoadProject = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.progress);
            this.pnlButtons.Controls.Add(this.btnCreateNewProject);
            this.pnlButtons.Controls.Add(this.btnLoadProject);
            this.pnlButtons.HorizontalScrollbarBarColor = true;
            this.pnlButtons.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlButtons.HorizontalScrollbarSize = 10;
            this.pnlButtons.Location = new System.Drawing.Point(58, 63);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(261, 143);
            this.pnlButtons.TabIndex = 0;
            this.pnlButtons.VerticalScrollbarBarColor = true;
            this.pnlButtons.VerticalScrollbarHighlightOnWheel = false;
            this.pnlButtons.VerticalScrollbarSize = 10;
            this.pnlButtons.Click += new System.EventHandler(this.CreateNewProjectClick);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(64, 3);
            this.progress.Maximum = 100;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(135, 132);
            this.progress.Speed = 3F;
            this.progress.TabIndex = 10;
            this.progress.TabStop = false;
            this.progress.UseSelectable = true;
            // 
            // btnCreateNewProject
            // 
            this.btnCreateNewProject.Location = new System.Drawing.Point(3, 72);
            this.btnCreateNewProject.Name = "btnCreateNewProject";
            this.btnCreateNewProject.Size = new System.Drawing.Size(254, 63);
            this.btnCreateNewProject.TabIndex = 7;
            this.btnCreateNewProject.Text = "Create New Project";
            this.btnCreateNewProject.UseSelectable = true;
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProject.Image = null;
            this.btnLoadProject.Location = new System.Drawing.Point(3, 3);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(254, 63);
            this.btnLoadProject.TabIndex = 6;
            this.btnLoadProject.Text = "Load Project";
            this.btnLoadProject.UseSelectable = true;
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.BtnLoadProjectClick);
            // 
            // LoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 238);
            this.Controls.Add(this.pnlButtons);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "LoaderForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Projects";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlButtons;
        private MetroFramework.Controls.MetroProgressSpinner progress;
        private MetroFramework.Controls.MetroButton btnCreateNewProject;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnLoadProject;
    }
}