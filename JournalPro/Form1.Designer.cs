namespace JournalPro
{
    partial class Form1
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NewEntryPage = new System.Windows.Forms.TabPage();
            this.button_addEntry = new System.Windows.Forms.Button();
            this.ProjectList_NewEntry = new System.Windows.Forms.ComboBox();
            this.NewProjectPage = new System.Windows.Forms.TabPage();
            this.textbox_ProjectName = new System.Windows.Forms.TextBox();
            this.ViewEntryPage = new System.Windows.Forms.TabPage();
            this.ViewProjectPage = new System.Windows.Forms.TabPage();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_AddProject = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_PopulateProjectList = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.NewEntryPage.SuspendLayout();
            this.NewProjectPage.SuspendLayout();
            this.ViewProjectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(93, 279);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(12, 279);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(260, 163);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.NewEntryPage);
            this.tabControl1.Controls.Add(this.NewProjectPage);
            this.tabControl1.Controls.Add(this.ViewEntryPage);
            this.tabControl1.Controls.Add(this.ViewProjectPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(283, 261);
            this.tabControl1.TabIndex = 6;
            // 
            // NewEntryPage
            // 
            this.NewEntryPage.Controls.Add(this.button_addEntry);
            this.NewEntryPage.Controls.Add(this.ProjectList_NewEntry);
            this.NewEntryPage.Controls.Add(this.textBox1);
            this.NewEntryPage.Controls.Add(this.label1);
            this.NewEntryPage.Controls.Add(this.label2);
            this.NewEntryPage.Location = new System.Drawing.Point(4, 22);
            this.NewEntryPage.Name = "NewEntryPage";
            this.NewEntryPage.Padding = new System.Windows.Forms.Padding(3);
            this.NewEntryPage.Size = new System.Drawing.Size(275, 235);
            this.NewEntryPage.TabIndex = 0;
            this.NewEntryPage.Text = "New Entry";
            this.NewEntryPage.UseVisualStyleBackColor = true;
            // 
            // button_addEntry
            // 
            this.button_addEntry.Location = new System.Drawing.Point(191, 19);
            this.button_addEntry.Name = "button_addEntry";
            this.button_addEntry.Size = new System.Drawing.Size(75, 23);
            this.button_addEntry.TabIndex = 7;
            this.button_addEntry.Text = "Add Entry";
            this.button_addEntry.UseVisualStyleBackColor = true;
            // 
            // ProjectList_NewEntry
            // 
            this.ProjectList_NewEntry.FormattingEnabled = true;
            this.ProjectList_NewEntry.Location = new System.Drawing.Point(3, 19);
            this.ProjectList_NewEntry.Name = "ProjectList_NewEntry";
            this.ProjectList_NewEntry.Size = new System.Drawing.Size(182, 21);
            this.ProjectList_NewEntry.TabIndex = 6;
            // 
            // NewProjectPage
            // 
            this.NewProjectPage.Controls.Add(this.button_AddProject);
            this.NewProjectPage.Controls.Add(this.textbox_ProjectName);
            this.NewProjectPage.Location = new System.Drawing.Point(4, 22);
            this.NewProjectPage.Name = "NewProjectPage";
            this.NewProjectPage.Padding = new System.Windows.Forms.Padding(3);
            this.NewProjectPage.Size = new System.Drawing.Size(275, 235);
            this.NewProjectPage.TabIndex = 1;
            this.NewProjectPage.Text = "New Project";
            this.NewProjectPage.UseVisualStyleBackColor = true;
            // 
            // textbox_ProjectName
            // 
            this.textbox_ProjectName.Location = new System.Drawing.Point(6, 6);
            this.textbox_ProjectName.Name = "textbox_ProjectName";
            this.textbox_ProjectName.Size = new System.Drawing.Size(181, 20);
            this.textbox_ProjectName.TabIndex = 0;
            // 
            // ViewEntryPage
            // 
            this.ViewEntryPage.Location = new System.Drawing.Point(4, 22);
            this.ViewEntryPage.Name = "ViewEntryPage";
            this.ViewEntryPage.Size = new System.Drawing.Size(446, 235);
            this.ViewEntryPage.TabIndex = 2;
            this.ViewEntryPage.Text = "View Entries";
            this.ViewEntryPage.UseVisualStyleBackColor = true;
            // 
            // ViewProjectPage
            // 
            this.ViewProjectPage.Controls.Add(this.button_PopulateProjectList);
            this.ViewProjectPage.Controls.Add(this.listView1);
            this.ViewProjectPage.Location = new System.Drawing.Point(4, 22);
            this.ViewProjectPage.Name = "ViewProjectPage";
            this.ViewProjectPage.Size = new System.Drawing.Size(275, 235);
            this.ViewProjectPage.TabIndex = 3;
            this.ViewProjectPage.Text = "View Projects";
            this.ViewProjectPage.UseVisualStyleBackColor = true;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(JournalPro.Project);
            // 
            // button_AddProject
            // 
            this.button_AddProject.Location = new System.Drawing.Point(193, 6);
            this.button_AddProject.Name = "button_AddProject";
            this.button_AddProject.Size = new System.Drawing.Size(76, 22);
            this.button_AddProject.TabIndex = 1;
            this.button_AddProject.Text = "Add Project";
            this.button_AddProject.UseVisualStyleBackColor = true;
            this.button_AddProject.Click += new System.EventHandler(this.button_AddProject_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(198, 229);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // button_PopulateProjectList
            // 
            this.button_PopulateProjectList.Location = new System.Drawing.Point(204, 3);
            this.button_PopulateProjectList.Name = "button_PopulateProjectList";
            this.button_PopulateProjectList.Size = new System.Drawing.Size(68, 24);
            this.button_PopulateProjectList.TabIndex = 1;
            this.button_PopulateProjectList.Text = "Populate";
            this.button_PopulateProjectList.UseVisualStyleBackColor = true;
            this.button_PopulateProjectList.Click += new System.EventHandler(this.button_PopulateProjectList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 314);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.NewEntryPage.ResumeLayout(false);
            this.NewEntryPage.PerformLayout();
            this.NewProjectPage.ResumeLayout(false);
            this.NewProjectPage.PerformLayout();
            this.ViewProjectPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage NewEntryPage;
        private System.Windows.Forms.TabPage NewProjectPage;
        private System.Windows.Forms.TabPage ViewEntryPage;
        private System.Windows.Forms.TabPage ViewProjectPage;
        private System.Windows.Forms.ComboBox ProjectList_NewEntry;
        private System.Windows.Forms.Button button_addEntry;
        private System.Windows.Forms.TextBox textbox_ProjectName;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.Button button_AddProject;
        private System.Windows.Forms.Button button_PopulateProjectList;
        private System.Windows.Forms.ListView listView1;
    }
}

