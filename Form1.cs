using Npgsql;
using System.Data;
using System.Xml.Serialization;

namespace WinFormsApp_taskDB
{
    public partial class Project : Form
    {
        public string connectionString =
            @"Host=localhost;Username=postgres;Port=5432;
             Database=exam; Password=1200;";

        private NpgsqlConnection connection;
        private NpgsqlDataAdapter sqlDataAdapter;
        public Project()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id";
            dataGridView1.DataSource = GetData(sql);
            View2.DataSource = GetData(sql);
            CourseData.DataSource = GetData("select * from Subject");
            ViewForData.DataSource = GetData(sql);
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
        }
        private DataTable GetData(string name)
        {
            DataTable dt = new DataTable();
            using (connection = new NpgsqlConnection(connectionString))
            {
                sqlDataAdapter = new NpgsqlDataAdapter(name, connection);
                sqlDataAdapter.Fill(dt);
                return dt;
            }
        }
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = GetData("select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id");
        }
        private async void UpdateTable_Click(object sender, EventArgs e)
        {
            var id = textBox5.Text;
            var Name = textBox6.Text;
            var age = textBox7.Text;
            var Course = textBox8.Text;
            var sql = $"insert into students (first_name,age,subject_id) values({Name},{age},{Course});";
            if (id == "")
            {
                string message = "Siz id kiritmadingiz!!!";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                return;
            }
            if (dataGridView1 != null)
            {
                if (Name != "")
                {
                    string result = "";
                    foreach (char c in Name)
                    {
                        if (char.IsLetter(c))
                        {
                            result += c;
                        }
                    }
                    dataGridView1.DataSource = GetData($"update students set first_name = '{result}' where id = {id}");
                }
                if (age != "")
                {
                    dataGridView1.DataSource = GetData($"update students set age = {age} where id = {id}");
                }
                if (Course != "")
                {
                    if (Course == "1" || Course == "2" || Course == "3" || Course == "4" || Course == "5" || Course == "6" || Course == "7")
                    {
                        dataGridView1.DataSource = GetData($"update students set subject_id = {Course} where id = {id}");
                    }
                    dataGridView1.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id where s.id = {id}");

                }
                if (Name == "" || age == "" || Course == "" || id == "")
                {
                    if (id != "")
                    {
                        textBox5.Text = null;
                    }
                    dataGridView1.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id");

                }

                textBox7.Text = null;
                textBox8.Text = null;
                textBox6.Text = null;
                k.Text = null;
                dataGridView1.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id");
                if (Name != "" || age != "" || Course != "")
                {
                    string message1 = "Malumotlar Yangilandi!";
                    string title1 = "Close Window";
                    MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                    DialogResult result1 = MessageBox.Show(message1, title1, buttons1);

                }
                else
                {
                    string message1 = "Yangi malumotlarni kiritmadingiz";
                    string title1 = "Close Window";
                    MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                    DialogResult result1 = MessageBox.Show(message1, title1, buttons1);

                }

                return;
            }
        }
        private async void textBox5_TextChanged(object sender, EventArgs e)
        {
            var Id = textBox5.Text;
            int number;
            bool isNumber = int.TryParse(Id, out number);

            if (Id == "")
            {
                dataGridView1.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by  s.id ,s.age , s.first_name , c.subject_name;");
            }
            if (textBox5.Text != "")
            {
                if (!isNumber)
                {
                    textBox5.Text = null;
                    return;
                }
                dataGridView1.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id where s.id = {Id}");

            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            CourseData.DataSource = GetData("select * from Subject");
            dataGridView1.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by  s.id ,s.age , s.first_name , c.subject_name;");
            View2.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id");
            ViewForData.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id");
            //  dataGridView1.DataSource = GetData($"select current_time() s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id ");

        }
        private void Submit_Click(object sender, EventArgs e)
        {
            var id = textBox5.Text;
            var Course = textBox4.Text;
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                string message = "Malumotlar ohirgacha kiritilmadi!!!";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                return;
            }
            if (textBox4.Text == "1" || textBox4.Text == "2" || textBox4.Text == "3"  || textBox4.Text == "4" || textBox4.Text == "5" || textBox4.Text == "6" || textBox4.Text == "7")
            {
                string result = "";
                foreach (char c in textBox2.Text)
                {
                    if (char.IsLetter(c))
                    {
                        result += c;
                    }
                }
                var sql = $"insert into students (first_name, age,subject_id) values('{result}',{textBox3.Text},{textBox4.Text});";
                dataGridView1.DataSource = GetData(sql);
                textBox4.Text = null;
                textBox3.Text = null;
                textBox2.Text = null;
                dataGridView1.DataSource = GetData("select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id");

                string message1 = "Malumotlar qoshildi!";
                string title1 = "Close Window";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                DialogResult result1 = MessageBox.Show(message1, title1, buttons1);
                return;
            }
            else
            {
                textBox4.Text = null;
                string message = "";
                string title = "Bunday kursimiz yo'q!!!";
                DialogResult result = MessageBox.Show("Siz kurslarimizni ko'rishni holaysizmi?", "Savol", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.DataSource = GetData("select * from Subject");
                }
                else
                {
                    return;
                }
                //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                //DialogResult result = MessageBox.Show(message, title, buttons);

                return;
            }


        }
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            View2.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id");

        }
        private void IdDelete_TextChanged(object sender, EventArgs e)
        {
            var Id = IdDelete.Text;
            int number;
            bool isNumber = int.TryParse(Id, out number);

            if (IdDelete.Text != "")
            {
                if (!isNumber)
                {
                    IdDelete.Text = null;
                    return;
                }
                dataGridView1.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id where s.id = {Id}");
                ViewForData.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id where s.id = {Id}");

            }
            if(Id == "")
                {
             ViewForData.DataSource = GetData("select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id");
            dataGridView1.DataSource = GetData("select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id");

            }
         

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var Name = textBox2.Text;
            dataGridView1.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id where first_name like '%{Name}%'");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var Id = textBox3.Text;
            int number;
            var age = textBox3.Text;
            var ag1 = textBox3.Text.ToString();
            bool isNumber = int.TryParse(Id, out number);
            if (age == "")
            {
                dataGridView1.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id ;");
            }
            if (!isNumber)
            {
                textBox3.Text = string.Empty;
                return;
            }
            if (age != "")
            {
                dataGridView1.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id where s.age = {age};");
            }

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var Id = textBox4.Text;
            int number;
            bool isNumber = int.TryParse(Id, out number);
            if (Id == "")
            {
                dataGridView1.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by  s.id ,s.age , s.first_name , c.subject_name;");

            }
            if (isNumber)
            {
                dataGridView1.DataSource = GetData($"select * from Subject where id = {Id}");

            }
            else
            {
                textBox4.Text = string.Empty;
                return;
            }

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            var Id = textBox7.Text;
            int number;
            bool isNumber = int.TryParse(Id, out number);
            if (!isNumber)
            {
                textBox7.Text = string.Empty;
                return;
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            var Id = textBox8.Text;
            int number;
            bool isNumber = int.TryParse(Id, out number);
            if (!isNumber)
            {
                textBox8.Text = string.Empty;
                return;
            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            var id = IdDelete.Text;
            ViewForData.DataSource = GetData("select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id");
            dataGridView1.DataSource = GetData("select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id");
            if (id !=  "")
            {
            var sql = $"DELETE FROM students where id = {IdDelete.Text};"; 
            string message = "";
                string title = "Malumotni ochirmoqchimisiz?";
                DialogResult result = MessageBox.Show("Malumotni ochirmoqchimisiz?", "Savol", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    GetData(sql);
                    IdDelete.Text = null;
                    string message1 = "";
                    string title1 = "";
                    DialogResult result1 = MessageBox.Show("Malumotlar o'chirildi", "Savol", MessageBoxButtons.OK);

                }
                else
                {
                    return;
                }

                dataGridView1.DataSource = GetData("select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id");
            ViewForData.DataSource = GetData("select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id");
            }
            ViewForData.DataSource = GetData("select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id");
            dataGridView1.DataSource = GetData("select s.id,s.first_name ,c.subject_name ,s.age from students s join subject c on s.subject_id = c.id");




        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CourseData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CourseData.DataSource = GetData("select * from Course");
        }
        private void Time_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData($"select current_time() s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id ");
        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by  s.id, s.first_name , c.subject_name;");
            ViewForData.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by  s.id, s.first_name , c.subject_name;");
            View2.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by  s.id, s.first_name , c.subject_name;");
        }
        private void GroupByName_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by s.first_name , c.subject_name;");
            View2.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by s.first_name , c.subject_name;");
            ViewForData.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by s.first_name , c.subject_name;");
        }
        private async void OrderByName_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by  c.subject_name;");
            View2.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by  c.subject_name;");
            ViewForData.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by  c.subject_name;");
        }
        private void GroupByage_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by s.age, s.id, s.first_name , c.subject_name;");
            View2.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by s.age, s.id, s.first_name , c.subject_name;");
             ViewForData.DataSource = GetData("select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  order by s.age, s.id, s.first_name , c.subject_name;");
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (textBox6.Text == "1" || textBox6.Text == "2" || textBox6.Text == "3" || textBox6.Text == "4" || textBox6.Text == "5" || textBox6.Text == "6" || textBox6.Text == "7" || textBox6.Text == "8" || textBox6.Text == "9" || textBox6.Text == "0" )
                {
                    textBox6.Text = "";
                }
            }

        }
        private void ViewForData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private async void Search_TextChanged(object sender, EventArgs e)
        {
            var search = Search.Text;
            dataGridView1.DataSource = GetData($"select s.id, s.first_name, c.subject_name, s.age from students s join subject c on s.subject_id = c.id  where first_name like '%{search}%';");
        }

        private void OldName_Click(object sender, EventArgs e)
        {
        }

        private async void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (k.Text.Length == 1)
            {
                k.Text.ToUpper();
            }
            var Name = k.Text;
            dataGridView1.DataSource = GetData($"select s.id,s.first_name,c.subject_name,s.age from students s join subject c on s.subject_id = c.id where first_name like '%{k.Text}%'");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NewName_Click(object sender, EventArgs e)
        {

        }
    }
}
