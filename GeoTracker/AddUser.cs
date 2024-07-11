using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeoTracker.DataAccess;
using GeoTracker.DataAccess.Abstract;
using GeoTracker.Presentation;

namespace GeoTracker
{
    public partial class AddUser : Form
    {
        private readonly IUserDal _userDal;
        public AddUser()
        {
            InitializeComponent();
            _userDal = new UserDal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User{UserName = textBox1.Text,Password = textBox2.Text};
            bool isAdded = _userDal.Add(user);
            if (isAdded)
            {
                MessageBox.Show("User added.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong,try again.");
            }

        }
    }
}
