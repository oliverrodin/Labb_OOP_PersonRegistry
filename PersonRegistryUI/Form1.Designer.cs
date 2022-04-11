namespace PersonRegistryUI
{
    partial class PersonRegistryForm
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
            this.PersonRegistryLabel = new System.Windows.Forms.Label();
            this.NewPersonGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.PersonsGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.MergeButton = new System.Windows.Forms.Button();
            this.PersonsListBox = new System.Windows.Forms.ListBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchValue = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.NewPersonGroupBox.SuspendLayout();
            this.PersonsGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonRegistryLabel
            // 
            this.PersonRegistryLabel.AutoSize = true;
            this.PersonRegistryLabel.BackColor = System.Drawing.Color.White;
            this.PersonRegistryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonRegistryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PersonRegistryLabel.Location = new System.Drawing.Point(5, 9);
            this.PersonRegistryLabel.Name = "PersonRegistryLabel";
            this.PersonRegistryLabel.Size = new System.Drawing.Size(207, 37);
            this.PersonRegistryLabel.TabIndex = 0;
            this.PersonRegistryLabel.Text = "Person Registry";
            // 
            // NewPersonGroupBox
            // 
            this.NewPersonGroupBox.BackColor = System.Drawing.Color.White;
            this.NewPersonGroupBox.Controls.Add(this.AddButton);
            this.NewPersonGroupBox.Controls.Add(this.FemaleRadioButton);
            this.NewPersonGroupBox.Controls.Add(this.MaleRadioButton);
            this.NewPersonGroupBox.Controls.Add(this.LastNameValue);
            this.NewPersonGroupBox.Controls.Add(this.FirstNameValue);
            this.NewPersonGroupBox.Controls.Add(this.GenderLabel);
            this.NewPersonGroupBox.Controls.Add(this.LastNameLabel);
            this.NewPersonGroupBox.Controls.Add(this.FirstNameLabel);
            this.NewPersonGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPersonGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPersonGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.NewPersonGroupBox.Location = new System.Drawing.Point(12, 49);
            this.NewPersonGroupBox.Name = "NewPersonGroupBox";
            this.NewPersonGroupBox.Size = new System.Drawing.Size(423, 185);
            this.NewPersonGroupBox.TabIndex = 1;
            this.NewPersonGroupBox.TabStop = false;
            this.NewPersonGroupBox.Text = "New Person";
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(219, 113);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(186, 42);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRadioButton.Location = new System.Drawing.Point(87, 130);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(78, 25);
            this.FemaleRadioButton.TabIndex = 6;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MaleRadioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MaleRadioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MaleRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRadioButton.Location = new System.Drawing.Point(19, 130);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(62, 25);
            this.MaleRadioButton.TabIndex = 5;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // LastNameValue
            // 
            this.LastNameValue.BackColor = System.Drawing.Color.White;
            this.LastNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LastNameValue.Location = new System.Drawing.Point(219, 63);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(186, 29);
            this.LastNameValue.TabIndex = 4;
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.BackColor = System.Drawing.Color.White;
            this.FirstNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FirstNameValue.Location = new System.Drawing.Point(19, 63);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(186, 29);
            this.FirstNameValue.TabIndex = 3;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(15, 105);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(68, 21);
            this.GenderLabel.TabIndex = 2;
            this.GenderLabel.Text = "Gender :";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(215, 39);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(91, 21);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name :";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(15, 39);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(93, 21);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name :";
            // 
            // PersonsGroupBox
            // 
            this.PersonsGroupBox.BackColor = System.Drawing.Color.White;
            this.PersonsGroupBox.Controls.Add(this.RemoveButton);
            this.PersonsGroupBox.Controls.Add(this.MergeButton);
            this.PersonsGroupBox.Controls.Add(this.PersonsListBox);
            this.PersonsGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PersonsGroupBox.Location = new System.Drawing.Point(12, 240);
            this.PersonsGroupBox.Name = "PersonsGroupBox";
            this.PersonsGroupBox.Size = new System.Drawing.Size(423, 332);
            this.PersonsGroupBox.TabIndex = 2;
            this.PersonsGroupBox.TabStop = false;
            this.PersonsGroupBox.Text = "Persons";
            // 
            // RemoveButton
            // 
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(219, 284);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(186, 38);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MergeButton
            // 
            this.MergeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MergeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.MergeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.MergeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeButton.Location = new System.Drawing.Point(19, 284);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(186, 38);
            this.MergeButton.TabIndex = 8;
            this.MergeButton.Text = "Merge";
            this.MergeButton.UseVisualStyleBackColor = true;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // PersonsListBox
            // 
            this.PersonsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonsListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonsListBox.FormattingEnabled = true;
            this.PersonsListBox.ItemHeight = 21;
            this.PersonsListBox.Location = new System.Drawing.Point(19, 43);
            this.PersonsListBox.Name = "PersonsListBox";
            this.PersonsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PersonsListBox.Size = new System.Drawing.Size(386, 233);
            this.PersonsListBox.TabIndex = 0;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchValue);
            this.SearchGroupBox.Controls.Add(this.SearchLabel);
            this.SearchGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SearchGroupBox.Location = new System.Drawing.Point(12, 578);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(423, 64);
            this.SearchGroupBox.TabIndex = 3;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // SearchValue
            // 
            this.SearchValue.BackColor = System.Drawing.Color.White;
            this.SearchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SearchValue.Location = new System.Drawing.Point(169, 27);
            this.SearchValue.Name = "SearchValue";
            this.SearchValue.Size = new System.Drawing.Size(236, 29);
            this.SearchValue.TabIndex = 8;
            this.SearchValue.TextChanged += new System.EventHandler(this.SearchValue_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(15, 29);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(148, 21);
            this.SearchLabel.TabIndex = 8;
            this.SearchLabel.Text = "First or Last Name : ";
            // 
            // PersonRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 654);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.PersonsGroupBox);
            this.Controls.Add(this.NewPersonGroupBox);
            this.Controls.Add(this.PersonRegistryLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonRegistryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Registry ";
            this.NewPersonGroupBox.ResumeLayout(false);
            this.NewPersonGroupBox.PerformLayout();
            this.PersonsGroupBox.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonRegistryLabel;
        private System.Windows.Forms.GroupBox NewPersonGroupBox;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.GroupBox PersonsGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.ListBox PersonsListBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.TextBox SearchValue;
        private System.Windows.Forms.Label SearchLabel;
    }
}

