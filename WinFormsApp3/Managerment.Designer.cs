namespace WinFormsApp3
{
    partial class Managerment
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
            txtManagerment = new Label();
            dgvListStudent = new DataGridView();
            txtName = new TextBox();
            txtAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtID = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtAccountName = new TextBox();
            txtBrandName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSearchBrand = new TextBox();
            label8 = new Label();
            btnSearch = new Button();
            btnShowAll = new Button();
            txtBankAccountID = new TextBox();
            label9 = new Label();
            txtOpenDate = new TextBox();
            txtTypeID = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cBTypeName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).BeginInit();
            SuspendLayout();
            // 
            // txtManagerment
            // 
            txtManagerment.AutoSize = true;
            txtManagerment.Location = new Point(317, 16);
            txtManagerment.Name = "txtManagerment";
            txtManagerment.Size = new Size(141, 15);
            txtManagerment.TabIndex = 0;
            txtManagerment.Text = "Welcome to our program";
            txtManagerment.Click += txtManagerment_Click;
            // 
            // dgvListStudent
            // 
            dgvListStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudent.Location = new Point(12, 64);
            dgvListStudent.Name = "dgvListStudent";
            dgvListStudent.RowTemplate.Height = 25;
            dgvListStudent.Size = new Size(372, 300);
            dgvListStudent.TabIndex = 1;
            dgvListStudent.CellContentClick += dgvListStudent_CellContentClick;
            dgvListStudent.CellDoubleClick += dgvListStudent_CellDoubleClick;
            dgvListStudent.CellMouseClick += dgvListStudent_CellMouseClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(457, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(312, 23);
            txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(457, 139);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(312, 23);
            txtAge.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 104);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 139);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(532, 168);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(613, 168);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(457, 75);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(312, 23);
            txtID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 75);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 10;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 46);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 11;
            label4.Text = "Student Manager";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(492, 307);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(277, 23);
            txtAccountName.TabIndex = 13;
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(492, 336);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(277, 23);
            txtBrandName.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 307);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 17;
            label5.Text = "Account name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 336);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 18;
            label6.Text = "Brand name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(253, 46);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 19;
            label7.Text = "Bank Account Manager";
            // 
            // txtSearchBrand
            // 
            txtSearchBrand.Location = new Point(457, 243);
            txtSearchBrand.Name = "txtSearchBrand";
            txtSearchBrand.Size = new Size(231, 23);
            txtSearchBrand.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(457, 225);
            label8.Name = "label8";
            label8.Size = new Size(127, 15);
            label8.TabIndex = 21;
            label8.Text = "Search by Brand Name";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(694, 243);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(694, 214);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 23;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // txtBankAccountID
            // 
            txtBankAccountID.Location = new Point(492, 278);
            txtBankAccountID.Name = "txtBankAccountID";
            txtBankAccountID.ReadOnly = true;
            txtBankAccountID.Size = new Size(277, 23);
            txtBankAccountID.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 281);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 25;
            label9.Text = "ID";
            // 
            // txtOpenDate
            // 
            txtOpenDate.Location = new Point(492, 365);
            txtOpenDate.Name = "txtOpenDate";
            txtOpenDate.ReadOnly = true;
            txtOpenDate.Size = new Size(277, 23);
            txtOpenDate.TabIndex = 26;
            // 
            // txtTypeID
            // 
            txtTypeID.Location = new Point(49, 373);
            txtTypeID.Name = "txtTypeID";
            txtTypeID.ReadOnly = true;
            txtTypeID.Size = new Size(335, 23);
            txtTypeID.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(401, 368);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 28;
            label10.Text = "Open Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 373);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 29;
            label11.Text = "Type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(401, 397);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 30;
            label12.Text = "label12";
            // 
            // cBTypeName
            // 
            cBTypeName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cBTypeName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBTypeName.FormattingEnabled = true;
            cBTypeName.Location = new Point(492, 394);
            cBTypeName.Name = "cBTypeName";
            cBTypeName.Size = new Size(277, 23);
            cBTypeName.TabIndex = 31;
            cBTypeName.SelectedIndexChanged += cBTypeName_SelectedIndexChanged;
            // 
            // Managerment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 450);
            Controls.Add(cBTypeName);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtTypeID);
            Controls.Add(txtOpenDate);
            Controls.Add(label9);
            Controls.Add(txtBankAccountID);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(label8);
            Controls.Add(txtSearchBrand);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtBrandName);
            Controls.Add(txtAccountName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(dgvListStudent);
            Controls.Add(txtManagerment);
            Name = "Managerment";
            Text = "Managerment";
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtManagerment;
        private DataGridView dgvListStudent;
        private TextBox txtName;
        private TextBox txtAge;
        private Label label1;
        private Label label2;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtID;
        private Label label3;
        private Label label4;
        private TextBox txtAccountName;
        private TextBox txtBrandName;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSearchBrand;
        private Label label8;
        private Button btnSearch;
        private Button btnShowAll;
        private TextBox txtBankAccountID;
        private Label label9;
        private TextBox txtOpenDate;
        private TextBox txtTypeID;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cBTypeName;
    }
}