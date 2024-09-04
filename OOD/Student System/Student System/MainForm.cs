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

        /// <summary>
        /// Validate input of TextBoxes in groupBoxAdd.
        /// </summary>
        /// <returns>
        /// True if all inputs are valid; False if one or more inputs are not valid
        /// </returns>

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

        private bool ValidateInput()
        {
            //TODO: unique PCNs
            // Check validity of input
            foreach (char c in tbPCN.Text)
                if (!char.IsNumber(c))
                {
                    MessageBox.Show("PCN should only contain numbers.");
                    return false;
                }

            foreach (char c in tbAge.Text)
                if (!char.IsNumber(c))
                {
                    MessageBox.Show("Age should only contain numbers.");
                    return false;
                }

            foreach (char c in tbYears.Text)
                if (!char.IsNumber(c))
                {
                    MessageBox.Show("'Years at school' should only contain numbers.");
                    return false;
                }

            foreach (char c in tbECs.Text)
                if (!char.IsNumber(c))
                {
                    MessageBox.Show("ECs should only contain numbers.");
                    return false;
                }

            foreach (char c in tbSalary.Text)
                if (!char.IsNumber(c))
                {
                    MessageBox.Show("Salary should only contain numbers.");
                    return false;
                }

            return true;
        }
    }
}
