namespace Student_System
{
    public partial class MainForm : Form
    {
        private Administration _admin;
        public MainForm()
        {
            InitializeComponent();
            RefreshControls();
            _admin = new();
        }

        /// <summary>
        /// Disables/enables buttons depending on the state of the form
        /// </summary>
        public void RefreshControls()
        {
            // Disable "new" buttons if fields are empty
            btnAddPerson.Enabled = btnAddStudent.Enabled = btnAddTeacher.Enabled = false;

            if (!string.IsNullOrWhiteSpace(tbPCN.Text) &&
                !string.IsNullOrWhiteSpace(tbName.Text) &&
                !string.IsNullOrWhiteSpace(tbAge.Text) &&
                !string.IsNullOrWhiteSpace(tbYears.Text))
                btnAddPerson.Enabled = true;

            if (!string.IsNullOrWhiteSpace(tbECs.Text) && btnAddPerson.Enabled)
                btnAddStudent.Enabled = true;

            if (!string.IsNullOrWhiteSpace(tbSalary.Text) && btnAddPerson.Enabled)
                btnAddTeacher.Enabled = true;
        }

        /// <summary>
        /// Clears all the textboxes in a specified ControlCollection
        /// </summary>
        public void EmptyFields(ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
                if (control.GetType() == typeof(TextBox))
                    control.Text = string.Empty;
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
        }

        /// <summary>
        /// Validate input of TextBoxes in groupBoxAdd.
        /// </summary>
        /// <returns>
        /// True if all inputs are valid; False if one or more inputs are not valid
        /// </returns>
        private bool ValidateInput()
        {
            //TODO: unique PCNs
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
        /// Populate lbx with the contents of a List
        /// </summary>
        private void PopulateLbx<T>(List<T> list)
        {
            // Trying out generic type parameters
            lbx.Items.Clear();
            foreach (var l in list)
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
    }
}
