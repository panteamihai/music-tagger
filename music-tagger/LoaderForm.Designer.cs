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
            this.btnLoadProject = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnCreateNewProject = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProject.Image = null;
            this.btnLoadProject.Location = new System.Drawing.Point(23, 63);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(254, 63);
            this.btnLoadProject.TabIndex = 0;
            this.btnLoadProject.Text = "Load Project";
            this.btnLoadProject.UseSelectable = true;
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.BtnLoadProjectClick);
            // 
            // btnCreateNewProject
            // 
            this.btnCreateNewProject.Location = new System.Drawing.Point(23, 132);
            this.btnCreateNewProject.Name = "btnCreateNewProject";
            this.btnCreateNewProject.Size = new System.Drawing.Size(254, 63);
            this.btnCreateNewProject.TabIndex = 1;
            this.btnCreateNewProject.Text = "Create New Project";
            this.btnCreateNewProject.UseSelectable = true;
            this.btnCreateNewProject.Click += new System.EventHandler(this.CreateNewProjectClick);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 223);
            this.Controls.Add(this.btnCreateNewProject);
            this.Controls.Add(this.btnLoadProject);
            this.Name = "Loader";
            this.Text = "Projects";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnLoadProject;
        private MetroFramework.Controls.MetroButton btnCreateNewProject;
    }
}