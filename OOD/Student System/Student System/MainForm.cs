namespace Student_System
{
    public partial class MainForm : Form
    {
        private Administration _admin;
        private Person _selectedPerson;

        public MainForm()
        {
            InitializeComponent();
            RefreshControls();
            lblSelectedPerson.Text = string.Empty;
            _admin = new();
            DebugData();
            PopulateLbx();
        }

        /// <summary>
        /// Disables/enables buttons depending on the state of the form
        /// </summary>
        public void RefreshControls()
        {
            btnAddPerson.Enabled = btnAddStudent.Enabled = btnAddTeacher.Enabled = btnAddECs.Enabled = btnCelebrate.Enabled = btnPromote.Enabled = btnNewYear.Enabled = false;
            // Disable "new" buttons if fields are empty

            if (!string.IsNullOrWhiteSpace(tbPCN.Text) &&
                !string.IsNullOrWhiteSpace(tbName.Text) &&
                !string.IsNullOrWhiteSpace(tbAge.Text) &&
                !string.IsNullOrWhiteSpace(tbYears.Text))
                btnAddPerson.Enabled = true;

            if (!string.IsNullOrWhiteSpace(tbECs.Text) && btnAddPerson.Enabled)
                btnAddStudent.Enabled = true;

            if (!string.IsNullOrWhiteSpace(tbSalary.Text) && btnAddPerson.Enabled)
                btnAddTeacher.Enabled = true;

            // Disable Managing buttons if no person is selected
            if (_selectedPerson != null)
            {
                if (_selectedPerson.GetType() == typeof(Person))
                    btnNewYear.Enabled = btnCelebrate.Enabled = true;

                if (_selectedPerson.GetType() == typeof(Student))
                    btnNewYear.Enabled = btnCelebrate.Enabled = btnAddECs.Enabled = true;

                else if (_selectedPerson.GetType() == typeof(Teacher))
                    btnNewYear.Enabled = btnCelebrate.Enabled = btnPromote.Enabled = true;
            }
        }

        /// <summary>
        /// Clears all the textboxes in a specified ControlCollection
        /// </summary>
        public void EmptyFields(Control.ControlCollection controlCollection)
        {
            //foreach (Control control in controlCollection)        // Old code
            //    if (control.GetType() == typeof(TextBox))
            //        control.Text = string.Empty;

            Control[] tbControls = controlCollection.OfType<TextBox>().ToArray();       // Woah! Really like this line
            foreach (TextBox t in tbControls)
                t.Text = String.Empty;
        }

        private void TextboxTextChanged(object sender, EventArgs e)
        {
            RefreshControls();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            int pcn = Convert.ToInt32(tbPCN.Text);
            string fullName = tbName.Text;
            int age = Convert.ToInt32(tbAge.Text);
            int yearsAtSchool = Convert.ToInt32(tbYears.Text);

            Person p = new Person(fullName, age, pcn, yearsAtSchool);
            _admin.Persons.Add(p);
            MessageBox.Show("Successfully added a new person:\n\n" + p);
            PopulateLbx();
            EmptyFields(groupBoxAdd.Controls);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            int pcn = Convert.ToInt32(tbPCN.Text);
            string fullName = tbName.Text;
            int age = Convert.ToInt32(tbAge.Text);
            int yearsAtSchool = Convert.ToInt32(tbYears.Text);
            int ECs = Convert.ToInt32(tbECs.Text);

            Student s = new Student(ECs, fullName, age, pcn, yearsAtSchool);
            _admin.Students.Add(s);
            MessageBox.Show("Successfully added a new student:\n\n" + s);
            PopulateLbx();
            EmptyFields(groupBoxAdd.Controls);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            int pcn = Convert.ToInt32(tbPCN.Text);
            string fullName = tbName.Text;
            int age = Convert.ToInt32(tbAge.Text);
            int yearsAtSchool = Convert.ToInt32(tbYears.Text);
            double salary = Convert.ToDouble(tbSalary.Text);

            Teacher t = new Teacher(0, salary, fullName, age, pcn, yearsAtSchool);
            _admin.Teachers.Add(t);
            MessageBox.Show("Successfully added a new teacher:\n\n" + t);
            PopulateLbx();
            EmptyFields(groupBoxAdd.Controls);
        }

        /// <summary>
        /// Validate input of TextBoxes in groupBoxAdd.
        /// </summary>
        /// <returns>
        /// True if all inputs are valid; False if one or more inputs are not valid
        /// </returns>
        private bool ValidateInput()
        {
            // Old code below, trying out lambda for the first time :D

            // Before:
            //foreach (char c in tbPCN.Text)
            //    if (!char.IsNumber(c))
            //    {
            //        MessageBox.Show("PCN should only contain numbers.");
            //        return false;
            //    }

            // After:
            if (tbPCN.Text.Any(c => !char.IsNumber(c)))
            {
                MessageBox.Show("PCN should only contain numbers.");
                return false;
            }

            // Check if PCN is unique
            int newPcn = Convert.ToInt32(tbPCN.Text);
            if (_admin.Persons.Any(p => p.Pcn == newPcn) ||
                _admin.Students.Any(s => s.Pcn == newPcn) ||
                _admin.Teachers.Any(t => t.Pcn == newPcn))
            {
                MessageBox.Show("PCN must be unique.");
                return false;
            }

            if (tbAge.Text.Any(c => !char.IsNumber(c)))
            {
                MessageBox.Show("Age should only contain numbers.");
                return false;
            }

            if (tbYears.Text.Any(c => !char.IsNumber(c)))
            {
                MessageBox.Show("'Years at school' should only contain numbers.");
                return false;
            }

            if (tbECs.Text.Any(c => !char.IsNumber(c)))
            {
                MessageBox.Show("ECs should only contain numbers.");
                return false;
            }

            if (tbSalary.Text.Any(c => !char.IsNumber(c)))
            {
                MessageBox.Show("Salary should only contain numbers.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Populate lbx with all persons/teachers/students
        /// </summary>
        private void PopulateLbx()
        {
            lbx.Items.Clear();
            foreach (Person p in _admin.Persons)
                lbx.Items.Add(p);
            foreach (Student s in _admin.Students)
                lbx.Items.Add(s);
            foreach (Teacher t in _admin.Teachers)
                lbx.Items.Add(t);
        }

        /// <summary>
        /// Populate lbx with the contents of a specific List
        /// </summary>
        private void PopulateLbx<T>(List<T> list)       // Trying out generic type parameters
        {
            lbx.Items.Clear();
            foreach (T l in list)
                lbx.Items.Add(l);
        }

        private void btnShowPersons_Click(object sender, EventArgs e)       //NOTE: wish I could somehow pass the list to add through the EventArgs or something...
        {
            PopulateLbx<Person>(_admin.Persons);    // Very cool!
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            PopulateLbx<Student>(_admin.Students);
        }

        private void btnShowTeachers_Click(object sender, EventArgs e)
        {
            PopulateLbx<Teacher>(_admin.Teachers);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PopulateLbx();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _selectedPerson = (Person)lbx.SelectedItem;
            lblSelectedPerson.Text = _selectedPerson.ToString();
            //Note: So I can store any object that inherits from Person in a variable of type person?
            //      If so that's a pretty neat usecase for using inheritance...
            //      I suppose I've noticed this already when I used the Control.ControlCollection subclass earlier.

            RefreshControls();
        }

        private void DebugData()
        {
            _admin.Persons.Add(new Person("John Doe", 26, 1, 3));
            _admin.Students.Add(new Student(34513442, "Rody Jansen", 23, 514216, 1));
            _admin.Teachers.Add(new Teacher(JobPosition.TEACHER3, 280000, "Albert Einstein", 69, 420, 50));
        }

        private void btnAddECs_Click(object sender, EventArgs e)
        {
            Student selected = (Student)_selectedPerson;
            selected.AddECs((int)nudECs.Value);
            lblSelectedPerson.Text = _selectedPerson.ToString();
        }

        private void btnCelebrate_Click(object sender, EventArgs e)
        {
            _selectedPerson.CelebrateBirthday();
            lblSelectedPerson.Text = _selectedPerson.ToString();
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            Teacher selected = (Teacher)_selectedPerson;
            selected.Promote();
            lblSelectedPerson.Text = _selectedPerson.ToString();
        }

        private void btnNewYear_Click(object sender, EventArgs e)
        {
            _selectedPerson.StartAnotherSchoolYear();
            lblSelectedPerson.Text = _selectedPerson.ToString();
        }

        private void tbInfo_TextChanged(object sender, EventArgs e)
        {
            lbx.Items.Clear();
            lbx.Items.AddRange(_admin.Persons.Where(p => p.Pcn.ToString().StartsWith(tbInfo.Text)).ToArray());
            lbx.Items.AddRange(_admin.Students.Where(s => s.Pcn.ToString().StartsWith(tbInfo.Text)).ToArray());
            lbx.Items.AddRange(_admin.Teachers.Where(t => t.Pcn.ToString().StartsWith(tbInfo.Text)).ToArray());
        }
    }
}
