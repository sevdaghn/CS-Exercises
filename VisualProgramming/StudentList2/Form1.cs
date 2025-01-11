namespace Student8
{
    public partial class Form1 : Form
    {
        private List<Student> Students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("/tmp/students.txt"))
            {
                List<String> Lines = File.ReadAllLines("/tmp/students.txt").ToList();
                foreach(String Line in Lines)
                {
                    List<String> StudentInfo=Line.Split(",").ToList();
                    Student tmp=new Student();
                    tmp.Id = StudentInfo[0];
                    tmp.Name = StudentInfo[1];
                    tmp.Surname = StudentInfo[2];
                    tmp.Age= int.Parse(StudentInfo[3]);
                    tmp.Department = StudentInfo[4];
                    Students.Add(tmp);
                }
            }

            lblRecordCount.Text = Students.Count.ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student tmp = new Student();
            tmp.Id = txtNumber.Text;
            tmp.Name = txtName.Text;
            tmp.Surname = txtSurname.Text;
            tmp.Age = int.Parse(txtAge.Text);
            tmp.Department = txtDepartment.Text;

            Students.Add(tmp);
            lblRecordCount.Text = Students.Count.ToString();
            WriteToFile();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String Key = txtNumber.Text;

            int FoundIndex = Students.FindIndex(x => x.Id == Key);

            if (FoundIndex == -1)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                txtNumber.Text = Students[FoundIndex].Id;
                txtName.Text = Students[FoundIndex].Name;
                txtSurname.Text = Students[FoundIndex].Surname;
                txtAge.Text = Students[FoundIndex].Age.ToString();
                txtDepartment.Text = Students[FoundIndex].Department;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String Key = txtNumber.Text;

            int FoundIndex = Students.FindIndex(x => x.Id == Key);
            if (FoundIndex != -1)
            {
                Students.RemoveAt(FoundIndex);
            }
            lblRecordCount.Text = Students.Count.ToString();
            WriteToFile();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int CINdex = Students.FindIndex(x => x.Id == txtNumber.Text);
            if (CINdex > 0)
            {
                --CINdex;
            }
            txtNumber.Text = Students[CINdex].Id;
            txtName.Text = Students[CINdex].Name;
            txtSurname.Text = Students[CINdex].Surname;
            txtAge.Text = Students[CINdex].Age.ToString();
            txtDepartment.Text = Students[CINdex].Department;
        }

        private void btnForw_Click(object sender, EventArgs e)
        {
            int CINdex = Students.FindIndex(x => x.Id == txtNumber.Text);
            if (CINdex >= Students.Count)
            {
                CINdex = Students.Count;
            }
            else
                ++CINdex;

            txtNumber.Text = Students[CINdex].Id;
            txtName.Text = Students[CINdex].Name;
            txtSurname.Text = Students[CINdex].Surname;
            txtAge.Text = Students[CINdex].Age.ToString();
            txtDepartment.Text = Students[CINdex].Department;
        }

        private void WriteToFile() 
        {
            String Buffer = "";
            foreach(Student student in Students) 
            {
                String tmp = "";
                tmp=student.Id+","+student.Name+","+student.Surname+","+student.Age+","+student.Department+"\n";
                Buffer += tmp;
            
            }
            File.WriteAllText("/tmp/students.txt", Buffer);
        }
    }
}
