using ClubRegistration.Data;
using ClubRegistration.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        public FrmClubRegistration()
        {
            #region -- Display data and contents when loading --
            InitializeComponent();
            table.Columns.Add("StudentID", "Student ID");
            table.Columns.Add("Program", "Program");
            table.Columns.Add("FirstName", "First Name");
            table.Columns.Add("MiddleName", "Middle Name");
            table.Columns.Add("LastName", "Last Name");
            table.Columns.Add("Gender", "Gender");
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.Load += async (s, e) => await GetAllClubMembersAsync();

            List<string> programs = new List<string>()
            {
                "BS in Computer Science",
                "BS in Information Technology",
                "BS in Hospitalitity Management",
                "BS in Computer Engineering",
                "BS in Business Administration",
                "BA in Multimedia Arts",
            };

            foreach (string program in programs)
            {
                programCombobox.Items.Add(program);
            }

            List<string> genders = new List<string>()
            {
                "Male",
                "Female"
            };

            foreach (string gender in genders)
            {
                genderCombobox.Items.Add(gender);
            }
            #endregion
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
            this.Hide();
            frmUpdateMember.Show();
        }

        public async Task RegisterClubMemberAsync(long studentID, string firstname, string middlename, string lastname, int age, string gender, string program)
        {
            using (var register = new ClubDbContext())
            {
                var newClubMember = new Club
                {
                    StudentID = studentID,
                    FirstName = firstname,
                    MiddleName = middlename,
                    LastName = lastname,
                    Age = age,
                    Gender = gender,
                    Program = program
                };

                await register.Club.AddAsync(newClubMember);
                await register.SaveChangesAsync();
            }
        }

        private async Task GetAllClubMembersAsync()
        {
            using (var register = new ClubDbContext())
            {
                var members = await register.Club.ToArrayAsync();
                table.Rows.Clear();


                foreach (var member in members)
                {
                    table.Rows.Add(
                        member.StudentID,
                        member.FirstName ?? "Default",
                        member.MiddleName ?? "Default",
                        member.LastName ?? "Default",
                        member.Age,
                        member.Gender ?? "Default",
                        member.Program ?? "Default");
                }
            }
        }

        private bool AreInputsValid(string firstname, string middlename, string lastname, string gender, string program)
        {
            string pattern = "^[a-zA-Z ,.]+$";

            return Regex.IsMatch(firstname, pattern) &&
                   Regex.IsMatch(middlename, pattern) &&
                   Regex.IsMatch(lastname, pattern) &&
                   Regex.IsMatch(gender, pattern) &&
                   Regex.IsMatch(program, pattern);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long studentID = Convert.ToInt64(studentIDTextbox.Text);
                string firstname = firstnameTxtbox.Text;
                string middlename = middlenameTxtbox.Text;
                string lastname = lastnameTxtbox.Text;
                int age = Convert.ToInt32(ageTxtbox.Text);
                string gender = $"{genderCombobox.SelectedItem}";
                string program = $"{programCombobox.SelectedItem}";

                if (studentID < 0 ||
                    string.IsNullOrEmpty(firstname) ||
                    string.IsNullOrEmpty(middlename) ||
                    string.IsNullOrEmpty(lastname) ||
                    age < 0 ||
                    string.IsNullOrEmpty(gender) ||
                    string.IsNullOrEmpty(program))
                {
                    MessageBox.Show($"Data cannot be empty or below 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!AreInputsValid(firstname, middlename, lastname, gender, program))
                {
                    MessageBox.Show("Invalid input! Only letters, spaces, commas, and periods are allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RegisterClubMemberAsync(studentID, firstname, middlename, lastname, age, gender, program);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please enter an integer value. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            GetAllClubMembersAsync();
        }
    }
}
