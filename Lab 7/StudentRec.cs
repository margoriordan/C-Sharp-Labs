using Exercise_7c.Models.DataLayer;
using System.Xml.Linq;

namespace Exercise_7c
{
    public partial class StudentRec : Form
    {
        public StudentRec()
        {
            InitializeComponent();
        }
        StudentContext context = new StudentContext();
        Student student= new Student();

        private void findStudBtn_Click(object sender, EventArgs e)
        {
            int studID = Convert.ToInt32(studentIDtxt.Text);
            student = context.Student.Find(studID);
            studentIDtxt.Text = student.StudentId.ToString();
            firstTxt.Text = student.FirstName;
            lastTxt.Text = student.LastName;
            dobTxt.Text = ((DateTime)student.DoB).ToString("yyyy-MM-dd");
            majorTxt.Text = student.Major;
            
            displayCurrentStudent(studID);

            studentIDtxt.Focus();
            

        }

        private void displayCurrentStudent(int studID)
        {
            var currentStudent = context.Student
               .Where(c => c.StudentId == studID)
               .OrderBy(c => c.LastName)
               .Select(c => new
               {
                   c.StudentId,
                   c.LastName,
                   c.FirstName,
                   c.DoB,
                   c.Major,

               });

            dataGridView.DataSource = currentStudent.ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            student.FirstName = firstTxt.Text;
            student.LastName = lastTxt.Text;
            student.DoB = DateTime.Parse(dobTxt.Text);
            student.Major = majorTxt.Text;
            context.Student.Add(student);
            context.SaveChanges();
            dataGridView.Update();
            dataGridView.Refresh();
            displayCurrentStudent(student.StudentId);
            studentIDtxt.Text = student.StudentId.ToString();
            MessageBox.Show("Student Record Added Successfully!", "Attention!");

        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            int studId = Convert.ToInt32(studentIDtxt.Text);
            this.student.StudentId = studId;
            this.student.FirstName = firstTxt.Text;
            this.student.LastName = lastTxt.Text;
            this.student.DoB = DateTime.Parse(dobTxt.Text);
            this.student.Major = majorTxt.Text;
            context.Student.Update(student);
            context.SaveChanges();
            dataGridView.Update();
            dataGridView.Refresh();

            displayCurrentStudent(studId);


            MessageBox.Show("Student Record Updated Successfully!", "Attention!");
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result =
            MessageBox.Show($"Are you sure you want to delete {student.FirstName} {student.LastName}'s student record?", "Attention!", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                context.Student.Remove(student);
                context.SaveChanges();

                clearControls();
                DisplayAllStudents();
            }
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            this.DisplayAllStudents(); 
        }

        private void DisplayAllStudents()
        {
            var student = context.Student
                .OrderBy(c => c.LastName)
                .Select(c => new
                {
                    c.StudentId,
                    c.LastName,
                    c.FirstName,
                    c.DoB,
                    c.Major,

                });
            dataGridView.DataSource = student.ToList(); ;
            dataGridView.AutoResizeColumns();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.clearControls();

        }

        private void clearControls()
        {
            this.dataGridView.DataSource = null;
            this.dataGridView.Rows.Clear();
            studentIDtxt.Clear();
            firstTxt.Clear();
            lastTxt.Clear();
            dobTxt.Clear();
            majorTxt.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   

}