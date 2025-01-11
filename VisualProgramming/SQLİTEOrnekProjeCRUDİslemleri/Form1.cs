using Microsoft.Data.Sqlite;
using SQLitePCL;
using Student8.Controller;
using Student8.Model;
using System.Data;

namespace Student8
{
    public partial class Form1 : Form
    {
        DBOperations MyDB = new DBOperations("Students8.db");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student tmp = new Student();
            tmp.Number = txtNumber.Text;
            tmp.Name = txtName.Text;
            tmp.Surname = txtSurname.Text;
            bool Result = MyDB.CreateStudent(tmp);
            if (Result)
                MessageBox.Show("Student created");
            else
                MessageBox.Show("Cannot create Student");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Student tmp = MyDB.FindStudent(txtNumber.Text);
            if (tmp == null)
                MessageBox.Show("Cannot be found Student");
            else
            {
                txtNumber.Text = tmp.Number;
                txtName.Text = tmp.Name;
                txtSurname.Text = tmp.Surname;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student tmp = new Student();
            tmp.Number = txtNumber.Text;
            tmp.Name = txtName.Text;
            tmp.Surname = txtSurname.Text;
            bool Result = MyDB.UpdateStudent(tmp);
            if (Result)
                MessageBox.Show("Student Updated");
            else
                MessageBox.Show("Cannot update Student");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student tmp = new Student();
            tmp.Number = txtNumber.Text;
            tmp.Name = txtName.Text;
            tmp.Surname = txtSurname.Text;
            bool Result = MyDB.DeleteStudent(tmp);
            if (Result)
                MessageBox.Show("Student Deleted");
            else
                MessageBox.Show("Cannot delete Student");

            txtNumber.Clear();
            txtName.Clear();
            txtSurname.Clear();
        }
    }
}
