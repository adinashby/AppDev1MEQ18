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

namespace learnFireBase
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "wT9qHf3f1VG4wJ3XRSYdcOIXgCC9FGBeKA7sa44X",
            BasePath = "https://csharp-firebase-f31fd-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            
            MyUser user = new MyUser()
            {
                Username = UsernameTbox.Text,
                Password = passTbox.Text,
                Gender = GenderCbox.Text,
                Fullname = nameTbox.Text,
                NICno = NicTbox.Text
            };

            SetResponse set = client.Set(@"Users/" + UsernameTbox.Text, user);

            MessageBox.Show("Successfully registered!");
        }
    }
}
