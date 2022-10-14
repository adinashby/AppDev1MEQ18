using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace MyFirstFirebaseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "wT9qHf3f1VG4wJ3XRSYdcOIXgCC9FGBeKA7sa44X",
            BasePath = "https://csharp-firebase-f31fd-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            } catch
            {
                MessageBox.Show("There was a problem connecting to the database.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                FullName = fullNameTxt.Text,
                StudentID = studentIDTxt.Text,
                Grade = gradeTxt.Text
            };

            var setter = client.Set("StudentList/" + studentIDTxt.Text, student);

            MessageBox.Show("Data inserted successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = client.Get("StudentList/" + studentIDTxt.Text);

            Student student = result.ResultAs<Student>();

            fullNameTxt.Text = student.FullName;
            gradeTxt.Text = student.Grade;

            MessageBox.Show("Data retrieved successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                FullName = fullNameTxt.Text,
                StudentID = studentIDTxt.Text,
                Grade = gradeTxt.Text
            };

            var setter = client.Update("StudentList/" + studentIDTxt.Text, student);

            MessageBox.Show("Data updated successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = client.Delete("StudentList/" + studentIDTxt.Text);

            MessageBox.Show("Data deleted successfully");
        }
    }
}
