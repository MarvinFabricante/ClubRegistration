using ClubRegistration.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();

            LoadStudentIDsAsync();

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
        }

        private async Task LoadStudentIDsAsync()
        {
            using (var register = new ClubDbContext())
            {
                var allMembers = await register.Club.ToListAsync();
                studentIDCombobox.Items.Clear();

                foreach (var member in allMembers)
                {
                    studentIDCombobox.Items.Add(member.StudentID);
                }
            }
        }

        private async Task UpdateClubMemberAsync(long studentID, string firstname, string middlename, string lastname, int age, string gender, string program)
        {
            // pull all data from postgres first
            using (var register = new ClubDbContext())
            {

                var member = await register.Club.FirstOrDefaultAsync(c => c.StudentID == studentID);

                if (member == null)
                {
                    MessageBox.Show("");
                }

                member.FirstName = firstname;
                member.MiddleName = middlename;
                member.LastName = lastname;
                member.Age = age;
                member.Gender = gender;
                member.Program = program;

                await register.SaveChangesAsync();
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

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long studentID = Convert.ToInt64(studentIDCombobox.Text);
                string firstname = firstnameTxtbox.Text;
                string middlename = middlenameTxtbox.Text;
                string lastname = lastnameTxtbox.Text;
                int age = Convert.ToInt32(ageTxtbox.Text);
                string gender = $"{genderCombobox.SelectedItem}";
                string program = $"{programCombobox.SelectedItem}";

                if (string.IsNullOrEmpty(firstname) ||
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

                UpdateClubMemberAsync(studentID, firstname, middlename, lastname, age, gender, program);
                MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please enter an integer value. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FrmClubRegistration frmClubRegistration = new FrmClubRegistration();

            frmClubRegistration.Show();

            this.Hide();

        }
    }
}
