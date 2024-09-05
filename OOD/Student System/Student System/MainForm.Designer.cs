namespace Student_System
{
    partial class MainForm
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
            groupBoxAdd = new GroupBox();
            btnAddTeacher = new Button();
            btnAddStudent = new Button();
            btnAddPerson = new Button();
            tbSalary = new TextBox();
            tbECs = new TextBox();
            tbYears = new TextBox();
            tbAge = new TextBox();
            tbName = new TextBox();
            tbPCN = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnShowPersons = new Button();
            btnShowStudents = new Button();
            btnShowTeachers = new Button();
            lbx = new ListBox();
            groupBoxSearch = new GroupBox();
            label7 = new Label();
            tbInfo = new TextBox();
            btnSelect = new Button();
            groupBoxManage = new GroupBox();
            nudECs = new NumericUpDown();
            lblSelectedPerson = new Label();
            label8 = new Label();
            btnAddECs = new Button();
            btnCelebrate = new Button();
            btnPromote = new Button();
            btnNewYear = new Button();
            btnShowAll = new Button();
            groupBoxAdd.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBoxManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudECs).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAdd
            // 
            groupBoxAdd.Controls.Add(btnAddTeacher);
            groupBoxAdd.Controls.Add(btnAddStudent);
            groupBoxAdd.Controls.Add(btnAddPerson);
            groupBoxAdd.Controls.Add(tbSalary);
            groupBoxAdd.Controls.Add(tbECs);
            groupBoxAdd.Controls.Add(tbYears);
            groupBoxAdd.Controls.Add(tbAge);
            groupBoxAdd.Controls.Add(tbName);
            groupBoxAdd.Controls.Add(tbPCN);
            groupBoxAdd.Controls.Add(label5);
            groupBoxAdd.Controls.Add(label6);
            groupBoxAdd.Controls.Add(label4);
            groupBoxAdd.Controls.Add(label3);
            groupBoxAdd.Controls.Add(label2);
            groupBoxAdd.Controls.Add(label1);
            groupBoxAdd.Location = new Point(12, 12);
            groupBoxAdd.Name = "groupBoxAdd";
            groupBoxAdd.Size = new Size(760, 177);
            groupBoxAdd.TabIndex = 999;
            groupBoxAdd.TabStop = false;
            groupBoxAdd.Text = "Add Person";
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(504, 143);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(237, 23);
            btnAddTeacher.TabIndex = 8;
            btnAddTeacher.Text = "New Teacher";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(256, 143);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(237, 23);
            btnAddStudent.TabIndex = 7;
            btnAddStudent.Text = "New Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(6, 143);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(237, 23);
            btnAddPerson.TabIndex = 6;
            btnAddPerson.Text = "New Person";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // tbSalary
            // 
            tbSalary.Location = new Point(606, 103);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(135, 23);
            tbSalary.TabIndex = 5;
            tbSalary.TextChanged += TextboxTextChanged;
            // 
            // tbECs
            // 
            tbECs.Location = new Point(358, 103);
            tbECs.Name = "tbECs";
            tbECs.Size = new Size(135, 23);
            tbECs.TabIndex = 4;
            tbECs.TextChanged += TextboxTextChanged;
            // 
            // tbYears
            // 
            tbYears.Location = new Point(108, 103);
            tbYears.Name = "tbYears";
            tbYears.Size = new Size(135, 23);
            tbYears.TabIndex = 3;
            tbYears.TextChanged += TextboxTextChanged;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(108, 74);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(135, 23);
            tbAge.TabIndex = 2;
            tbAge.TextChanged += TextboxTextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(108, 45);
            tbName.Name = "tbName";
            tbName.Size = new Size(135, 23);
            tbName.TabIndex = 1;
            tbName.TextChanged += TextboxTextChanged;
            // 
            // tbPCN
            // 
            tbPCN.Location = new Point(108, 16);
            tbPCN.Name = "tbPCN";
            tbPCN.Size = new Size(135, 23);
            tbPCN.TabIndex = 0;
            tbPCN.TextChanged += TextboxTextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 106);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 2;
            label5.Text = "Salary:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 48);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 2;
            label6.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 106);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 2;
            label4.Text = "ECs:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 106);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Years at School:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "PCN:";
            // 
            // btnShowPersons
            // 
            btnShowPersons.Location = new Point(18, 195);
            btnShowPersons.Name = "btnShowPersons";
            btnShowPersons.Size = new Size(171, 23);
            btnShowPersons.TabIndex = 9;
            btnShowPersons.Text = "Show All Persons";
            btnShowPersons.UseVisualStyleBackColor = true;
            btnShowPersons.Click += btnShowPersons_Click;
            // 
            // btnShowStudents
            // 
            btnShowStudents.Location = new Point(206, 195);
            btnShowStudents.Name = "btnShowStudents";
            btnShowStudents.Size = new Size(171, 23);
            btnShowStudents.TabIndex = 10;
            btnShowStudents.Text = "Show All Students";
            btnShowStudents.UseVisualStyleBackColor = true;
            btnShowStudents.Click += btnShowStudents_Click;
            // 
            // btnShowTeachers
            // 
            btnShowTeachers.Location = new Point(394, 195);
            btnShowTeachers.Name = "btnShowTeachers";
            btnShowTeachers.Size = new Size(171, 23);
            btnShowTeachers.TabIndex = 11;
            btnShowTeachers.Text = "Show All Teachers";
            btnShowTeachers.UseVisualStyleBackColor = true;
            btnShowTeachers.Click += btnShowTeachers_Click;
            // 
            // lbx
            // 
            lbx.FormattingEnabled = true;
            lbx.ItemHeight = 15;
            lbx.Location = new Point(12, 224);
            lbx.Name = "lbx";
            lbx.Size = new Size(760, 184);
            lbx.TabIndex = 12;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(label7);
            groupBoxSearch.Controls.Add(tbInfo);
            groupBoxSearch.Controls.Add(btnSelect);
            groupBoxSearch.Location = new Point(12, 414);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(200, 140);
            groupBoxSearch.TabIndex = 999;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 19);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 0;
            label7.Text = "PCN:";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(50, 16);
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(135, 23);
            tbInfo.TabIndex = 14;
            tbInfo.TextChanged += tbInfo_TextChanged;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(10, 45);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(175, 23);
            btnSelect.TabIndex = 15;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // groupBoxManage
            // 
            groupBoxManage.Controls.Add(nudECs);
            groupBoxManage.Controls.Add(lblSelectedPerson);
            groupBoxManage.Controls.Add(label8);
            groupBoxManage.Controls.Add(btnAddECs);
            groupBoxManage.Controls.Add(btnCelebrate);
            groupBoxManage.Controls.Add(btnPromote);
            groupBoxManage.Controls.Add(btnNewYear);
            groupBoxManage.Location = new Point(218, 414);
            groupBoxManage.Name = "groupBoxManage";
            groupBoxManage.Size = new Size(554, 140);
            groupBoxManage.TabIndex = 999;
            groupBoxManage.TabStop = false;
            groupBoxManage.Text = "Manage Person";
            // 
            // nudECs
            // 
            nudECs.Location = new Point(6, 18);
            nudECs.Name = "nudECs";
            nudECs.Size = new Size(50, 23);
            nudECs.TabIndex = 16;
            // 
            // lblSelectedPerson
            // 
            lblSelectedPerson.AutoSize = true;
            lblSelectedPerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedPerson.Location = new Point(273, 19);
            lblSelectedPerson.Name = "lblSelectedPerson";
            lblSelectedPerson.Size = new Size(107, 15);
            lblSelectedPerson.TabIndex = 20;
            lblSelectedPerson.Text = "lblSelectedPerson";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(213, 19);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 5;
            label8.Text = "Selected:";
            // 
            // btnAddECs
            // 
            btnAddECs.Location = new Point(62, 16);
            btnAddECs.Name = "btnAddECs";
            btnAddECs.Size = new Size(119, 23);
            btnAddECs.TabIndex = 17;
            btnAddECs.Text = "Add ECs";
            btnAddECs.UseVisualStyleBackColor = true;
            btnAddECs.Click += btnAddECs_Click;
            // 
            // btnCelebrate
            // 
            btnCelebrate.Location = new Point(6, 45);
            btnCelebrate.Name = "btnCelebrate";
            btnCelebrate.Size = new Size(175, 23);
            btnCelebrate.TabIndex = 18;
            btnCelebrate.Text = "Celebrate Birthday";
            btnCelebrate.UseVisualStyleBackColor = true;
            btnCelebrate.Click += btnCelebrate_Click;
            // 
            // btnPromote
            // 
            btnPromote.Location = new Point(6, 74);
            btnPromote.Name = "btnPromote";
            btnPromote.Size = new Size(175, 23);
            btnPromote.TabIndex = 19;
            btnPromote.Text = "Promote";
            btnPromote.UseVisualStyleBackColor = true;
            btnPromote.Click += btnPromote_Click;
            // 
            // btnNewYear
            // 
            btnNewYear.Location = new Point(6, 103);
            btnNewYear.Name = "btnNewYear";
            btnNewYear.Size = new Size(175, 23);
            btnNewYear.TabIndex = 20;
            btnNewYear.Text = "Start New Schoolyear";
            btnNewYear.UseVisualStyleBackColor = true;
            btnNewYear.Click += btnNewYear_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(582, 195);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(171, 23);
            btnShowAll.TabIndex = 12;
            btnShowAll.Text = "Show Everyone";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 601);
            Controls.Add(btnShowAll);
            Controls.Add(groupBoxManage);
            Controls.Add(groupBoxSearch);
            Controls.Add(lbx);
            Controls.Add(groupBoxAdd);
            Controls.Add(btnShowTeachers);
            Controls.Add(btnShowStudents);
            Controls.Add(btnShowPersons);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "MainForm";
            groupBoxAdd.ResumeLayout(false);
            groupBoxAdd.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBoxManage.ResumeLayout(false);
            groupBoxManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudECs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAdd;
        private TextBox tbPCN;
        private Label label2;
        private Label label1;
        private TextBox tbYears;
        private TextBox tbAge;
        private TextBox tbName;
        private Label label6;
        private Label label3;
        private TextBox tbSalary;
        private TextBox tbECs;
        private Label label5;
        private Label label4;
        private Button btnAddTeacher;
        private Button btnAddStudent;
        private Button btnAddPerson;
        private Button btnShowPersons;
        private Button btnShowStudents;
        private Button btnShowTeachers;
        private ListBox lbx;
        private GroupBox groupBoxSearch;
        private GroupBox groupBoxManage;
        private Label label7;
        private TextBox tbInfo;
        private Button btnSelect;
        private Label label8;
        private Button btnAddECs;
        private Button btnCelebrate;
        private Button btnPromote;
        private Button btnNewYear;
        private Label lblSelectedPerson;
        private Button btnShowAll;
        private NumericUpDown nudECs;
    }
}