namespace project1
{
    partial class FormMain
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
            this.listBoxObligations = new System.Windows.Forms.ListBox();
            this.listBoxArrangements = new System.Windows.Forms.ListBox();
            this.listBoxPlans = new System.Windows.Forms.ListBox();
            this.buttonNotifications = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddObligation = new System.Windows.Forms.Button();
            this.buttonAddArrangement = new System.Windows.Forms.Button();
            this.buttonAddPlan = new System.Windows.Forms.Button();
            this.buttonRecycleBin = new System.Windows.Forms.Button();
            this.richTextBoxObligations = new System.Windows.Forms.RichTextBox();
            this.richTextBoxArrangements = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPlans = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxObligations
            // 
            this.listBoxObligations.AllowDrop = true;
            this.listBoxObligations.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxObligations.FormattingEnabled = true;
            this.listBoxObligations.ItemHeight = 16;
            this.listBoxObligations.Location = new System.Drawing.Point(12, 90);
            this.listBoxObligations.Name = "listBoxObligations";
            this.listBoxObligations.Size = new System.Drawing.Size(175, 212);
            this.listBoxObligations.TabIndex = 0;
            this.listBoxObligations.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxNotes_DragDrop);
            this.listBoxObligations.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxNotes_DragOver);
            this.listBoxObligations.DoubleClick += new System.EventHandler(this.listBoxNotes_DoubleClick);
            this.listBoxObligations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxNotes_KeyDown);
            this.listBoxObligations.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxNotes_MouseDown);
            // 
            // listBoxArrangements
            // 
            this.listBoxArrangements.AllowDrop = true;
            this.listBoxArrangements.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxArrangements.FormattingEnabled = true;
            this.listBoxArrangements.ItemHeight = 16;
            this.listBoxArrangements.Location = new System.Drawing.Point(218, 90);
            this.listBoxArrangements.Name = "listBoxArrangements";
            this.listBoxArrangements.Size = new System.Drawing.Size(175, 212);
            this.listBoxArrangements.TabIndex = 1;
            this.listBoxArrangements.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxNotes_DragDrop);
            this.listBoxArrangements.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxNotes_DragOver);
            this.listBoxArrangements.DoubleClick += new System.EventHandler(this.listBoxNotes_DoubleClick);
            this.listBoxArrangements.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxNotes_KeyDown);
            this.listBoxArrangements.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxNotes_MouseDown);
            // 
            // listBoxPlans
            // 
            this.listBoxPlans.AllowDrop = true;
            this.listBoxPlans.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPlans.FormattingEnabled = true;
            this.listBoxPlans.ItemHeight = 16;
            this.listBoxPlans.Location = new System.Drawing.Point(425, 90);
            this.listBoxPlans.Name = "listBoxPlans";
            this.listBoxPlans.Size = new System.Drawing.Size(175, 212);
            this.listBoxPlans.TabIndex = 2;
            this.listBoxPlans.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxNotes_DragDrop);
            this.listBoxPlans.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxNotes_DragOver);
            this.listBoxPlans.DoubleClick += new System.EventHandler(this.listBoxNotes_DoubleClick);
            this.listBoxPlans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxNotes_KeyDown);
            this.listBoxPlans.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxNotes_MouseDown);
            // 
            // buttonNotifications
            // 
            this.buttonNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNotifications.Location = new System.Drawing.Point(11, 478);
            this.buttonNotifications.Name = "buttonNotifications";
            this.buttonNotifications.Size = new System.Drawing.Size(121, 37);
            this.buttonNotifications.TabIndex = 4;
            this.buttonNotifications.Text = "Notifications";
            this.buttonNotifications.UseVisualStyleBackColor = true;
            this.buttonNotifications.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Obligations";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(214, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Arrangements";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(421, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Plans";
            // 
            // buttonAddObligation
            // 
            this.buttonAddObligation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddObligation.Location = new System.Drawing.Point(110, 412);
            this.buttonAddObligation.Name = "buttonAddObligation";
            this.buttonAddObligation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddObligation.TabIndex = 12;
            this.buttonAddObligation.Text = "Add";
            this.buttonAddObligation.UseVisualStyleBackColor = true;
            // 
            // buttonAddArrangement
            // 
            this.buttonAddArrangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddArrangement.Location = new System.Drawing.Point(317, 411);
            this.buttonAddArrangement.Name = "buttonAddArrangement";
            this.buttonAddArrangement.Size = new System.Drawing.Size(75, 23);
            this.buttonAddArrangement.TabIndex = 13;
            this.buttonAddArrangement.Text = "Add";
            this.buttonAddArrangement.UseVisualStyleBackColor = true;
            // 
            // buttonAddPlan
            // 
            this.buttonAddPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPlan.Location = new System.Drawing.Point(524, 411);
            this.buttonAddPlan.Name = "buttonAddPlan";
            this.buttonAddPlan.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlan.TabIndex = 14;
            this.buttonAddPlan.Text = "Add";
            this.buttonAddPlan.UseVisualStyleBackColor = true;
            // 
            // buttonRecycleBin
            // 
            this.buttonRecycleBin.AllowDrop = true;
            this.buttonRecycleBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecycleBin.Location = new System.Drawing.Point(478, 478);
            this.buttonRecycleBin.Name = "buttonRecycleBin";
            this.buttonRecycleBin.Size = new System.Drawing.Size(121, 37);
            this.buttonRecycleBin.TabIndex = 15;
            this.buttonRecycleBin.Text = "Recycle Bin";
            this.buttonRecycleBin.UseVisualStyleBackColor = true;
            this.buttonRecycleBin.Click += new System.EventHandler(this.buttonRecycleBin_Click);
            this.buttonRecycleBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonRecycleBin_DragDrop);
            this.buttonRecycleBin.DragOver += new System.Windows.Forms.DragEventHandler(this.buttonRecycleBin_DragOver);
            // 
            // richTextBoxObligations
            // 
            this.richTextBoxObligations.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxObligations.Location = new System.Drawing.Point(11, 308);
            this.richTextBoxObligations.Name = "richTextBoxObligations";
            this.richTextBoxObligations.ReadOnly = true;
            this.richTextBoxObligations.Size = new System.Drawing.Size(176, 96);
            this.richTextBoxObligations.TabIndex = 17;
            this.richTextBoxObligations.Text = "Select a note to view its description.\nDouble-click it to edit it.\nDrag it within" +
    " the control to change its priority.";
            // 
            // richTextBoxArrangements
            // 
            this.richTextBoxArrangements.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxArrangements.Location = new System.Drawing.Point(216, 308);
            this.richTextBoxArrangements.Name = "richTextBoxArrangements";
            this.richTextBoxArrangements.ReadOnly = true;
            this.richTextBoxArrangements.Size = new System.Drawing.Size(176, 96);
            this.richTextBoxArrangements.TabIndex = 18;
            this.richTextBoxArrangements.Text = "Select a note to view its description.\nDouble-click it to edit it.\nDrag it within" +
    " the control to change its priority.";
            // 
            // richTextBoxPlans
            // 
            this.richTextBoxPlans.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxPlans.Location = new System.Drawing.Point(425, 308);
            this.richTextBoxPlans.Name = "richTextBoxPlans";
            this.richTextBoxPlans.ReadOnly = true;
            this.richTextBoxPlans.Size = new System.Drawing.Size(176, 96);
            this.richTextBoxPlans.TabIndex = 19;
            this.richTextBoxPlans.Text = "Select a note to view its description.\nDouble-click it to edit it.\nDrag it within" +
    " the control to change its priority.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Visible = false;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(10, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(220, 25);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Notes App Manager";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(425, 24);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(175, 21);
            this.comboBoxSearch.TabIndex = 22;
            this.comboBoxSearch.TextChanged += new System.EventHandler(this.comboBoxSearch_TextChanged_1);
            this.comboBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearch_KeyDown);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 527);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.richTextBoxPlans);
            this.Controls.Add(this.richTextBoxArrangements);
            this.Controls.Add(this.richTextBoxObligations);
            this.Controls.Add(this.buttonRecycleBin);
            this.Controls.Add(this.buttonAddPlan);
            this.Controls.Add(this.buttonAddArrangement);
            this.Controls.Add(this.buttonAddObligation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNotifications);
            this.Controls.Add(this.listBoxPlans);
            this.Controls.Add(this.listBoxArrangements);
            this.Controls.Add(this.listBoxObligations);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Notes App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxObligations;
        private System.Windows.Forms.ListBox listBoxArrangements;
        private System.Windows.Forms.ListBox listBoxPlans;
        private System.Windows.Forms.Button buttonNotifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddObligation;
        private System.Windows.Forms.Button buttonAddArrangement;
        private System.Windows.Forms.Button buttonAddPlan;
        private System.Windows.Forms.Button buttonRecycleBin;
        private System.Windows.Forms.RichTextBox richTextBoxObligations;
        private System.Windows.Forms.RichTextBox richTextBoxArrangements;
        private System.Windows.Forms.RichTextBox richTextBoxPlans;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxSearch;
    }
}

