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
            // 
            // txtName
            // 
            txtName.Location = new Point(457, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(312, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
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
            label4.Location = new Point(140, 46);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 11;
            label4.Text = "Student Manager";
            // 
            // Managerment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Load += Managerment_Load;
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
    }
}