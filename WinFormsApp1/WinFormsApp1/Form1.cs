using System.Data; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }
        void GetStudent()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=dbSchool.accdb");
            da = new OleDbDataAdapter("SELECT * FROM Student", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"];
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student (Firstname,Lastname) values (@Firstname,@Lastname)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Firstname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Lastname", textBox3.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetStudent();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student (ID, Firstname, Lastname) values (@ID, @Firstname, @Lastname)";
            cmd = new OleDbCommand(query, con);

            // Assuming yourIDValue is a valid short text value for the ID field
            cmd.Parameters.AddWithValue("@ID", textid.Text);
            cmd.Parameters.AddWithValue("@Firstname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Lastname", textBox3.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            GetStudent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where ID=@id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetStudent();
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set Firstname=@Firstname,Lastname=@Lastname, WHERE ID=@id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@ad", textBox2.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox3.Text);
            cmd.Parameters.AddWithValue("@id", textid.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetStudent();
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set Firstname=@Firstname, Lastname=@Lastname Where ID=@id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Firstname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Lastname", textBox3.Text);
            cmd.Parameters.AddWithValue("@id", textid.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetStudent();
        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
