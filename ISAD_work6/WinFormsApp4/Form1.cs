using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;
using static System.Net.WebRequestMethods;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataSet ds;
        int rno = 0;
        MemoryStream ms;
        byte[] photo_aray;
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=Stud.accdb");
            loaddata();
            showdata();
        }
        void loaddata()
        {
            adapter = new OleDbDataAdapter("select * from student", con);
            ds = new DataSet();
            adapter.Fill(ds, "student");
        }
        void showdata()
        {
            textBox1.Text = ds.Tables[0].Rows[rno][0].ToString();
            textBox2.Text = ds.Tables[0].Rows[rno][1].ToString();
            textBox3.Text = ds.Tables[0].Rows[rno][2].ToString();
            pictureBox1.Image = null;
            if (ds.Tables[0].Rows[rno][3] != System.DBNull.Value)
            {
                photo_aray = (byte[])ds.Tables[0].Rows[rno][3];
                MemoryStream ms = new MemoryStream(photo_aray);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
        void conv_photo()
        {
            if (pictureBox1.Image != null)
            {
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }
        private void insert_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("insert into student(sno,sname,course,photo) " +
                  "values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "',@photo)", con);
            conv_photo();
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            if (n > 0)
            {
                MessageBox.Show("record inserted");
                loaddata();
                rno++;
            }
            else
                MessageBox.Show("insertion failed");
        }
        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Enter sno:", "Search", "1", 100, 100);
                if (int.TryParse(input, out int n))
                {
                    DataRow[] foundRows = ds.Tables[0].Select($"sno = {n}");
                    if (foundRows.Length > 0)
                    {
                        DataRow drow = foundRows[0];
                        rno = ds.Tables[0].Rows.IndexOf(drow);
                        textBox1.Text = drow[0].ToString();
                        textBox2.Text = drow[1].ToString();
                        textBox3.Text = drow[2].ToString();
                        pictureBox1.Image = null;
                        if (drow[3] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])drow[3];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input. Please enter a valid number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("update student set sname='" + textBox2.Text + "', course='" 
                  + textBox3.Text + "', photo=@photo where sno=" + textBox1.Text, con);
            conv_photo();
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            if (n > 0)
            {
                MessageBox.Show("Record Updated");
                loaddata();
            }
            else
                MessageBox.Show("Updation Failed");
        }
        private void delete_Click(object sender, EventArgs e)
        {
            //cmd = new OleDbCommand("delete from student where sno=" + textBox1.Text, con);
            cmd = new OleDbCommand("delete from student where sno=@sno", con);
            cmd.Parameters.AddWithValue("@sno", textBox1.Text);
            con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            if (n > 0)
            {
                MessageBox.Show("Record Deleted");
                loaddata();
                rno = 0;
                showdata();
            }
            else
                MessageBox.Show("Deletion Failed");
        }
        private void claer_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void first_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                rno = 0;
                showdata();
                MessageBox.Show("First Record");
            }
            else
                MessageBox.Show("No records");
        }
        private void previous_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (rno > 0)
                {
                    rno--;
                    showdata();
                }
                else
                    MessageBox.Show("First Record");
            }
            else
                MessageBox.Show("No records");
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (rno < ds.Tables[0].Rows.Count - 1)
                {
                    rno++;
                    showdata();
                }
                else
                    MessageBox.Show("Last Record");
            }
            else
                MessageBox.Show("No records");
        }
        private void last_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                rno = ds.Tables[0].Rows.Count - 1;
                showdata();
                MessageBox.Show("Last Record");
            }
            else
                MessageBox.Show("No records");
        }
    }
}