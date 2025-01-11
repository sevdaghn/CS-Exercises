namespace Student7
{
    public partial class Form1 : Form

    {
        List<Student> Students = new List<Student>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("/tmp/Students.txt"))
            {
                List<String> Buffer = File.ReadAllLines("/tmp/Students.txt").ToList();
                for (int i = 0; i < Buffer.Count; i++)
                {
                    List<String> StudentInfo = Buffer[i].Split(",").ToList();
                    Student stutemp = new Student();
                    stutemp.Id = StudentInfo[0];
                    stutemp.Name = StudentInfo[1];
                    stutemp.Surname = StudentInfo[2];
                    stutemp.Age = int.Parse(StudentInfo[3]);
                    stutemp.Department = StudentInfo[4];
                    Students.Add(stutemp);
                }
            }
            lblStuCount.Text = Students.Count.ToString();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = txtNo.Text;
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = int.Parse(txtAge.Text);
            student.Department = txtDept.Text;

            Students.Add(student);
            lblStuCount.Text = Students.Count.ToString();
            WriteToFile();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String Key = txtNo.Text;
            int Index = Students.FindIndex(x => x.Id == Key);
            if (Index != -1)
            {
                Students.RemoveAt(Index);
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("No record found");
            }
            lblStuCount.Text = Students.Count.ToString();
            WriteToFile();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String  Key=txtNo.Text;
            int index=Students.FindIndex(a=>a.Id == Key);
            if(index != -1) 
            {
                txtNo.Text = Students[index].Id.ToString();
                txtName.Text = Students[index].Name;
                txtSurname.Text = Students[index].Surname;
                txtDept.Text = Students[index].Department;
                txtAge.Text = Students[index].Age.ToString();
                
;            }
            else 
            {
                MessageBox.Show("No record found");
            }
        }

        private void WriteToFile() 
        {
            String Buffer = "";

            for(int i = 0;i<Students.Count; i++)
            {
                String Student = "";
                Student = Students[i].Id+","+Students[i].Name+","+Students[i].Surname+","+Students[i].Age+","+Students[i].Department+"\n";
                Buffer=Buffer + Student;
            }
            File.WriteAllText("/tmp/Students.txt", Buffer);
            
        }
    }
}
