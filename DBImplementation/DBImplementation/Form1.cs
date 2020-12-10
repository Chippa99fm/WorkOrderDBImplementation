using MySqlConnector;
using System;
using System.Windows.Forms;

namespace DBImplementation
{
	public partial class Form1 : Form
	{
        UsersInfo usersInfo = new UsersInfo();
        public enum users { WORKER,MANAGER,HR,ADMIN }
        String userName = users.MANAGER.ToString();
        String pass = "";
		public Form1()
		{
			InitializeComponent();      
		}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = password.Text;
        }
        private void loginUser_TextChanged(object sender, EventArgs e)
        {
            userName = loginUser.Text;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=db_new;password=12345;";
            string getUserInfo = "call get_worker_type('"+userName+"','"+pass+"');";
            string userType;
            int userId;
            MySqlDataReader reader;
            try
            {
                reader = MysqlManager.executeQuery(connStr, getUserInfo);
                userType = reader.GetString(1).ToUpper();
                userId = reader.GetInt16(0);
                string userConnection = "server=localhost;user=" + userType + ";database=db_new;password=" + usersInfo.getPassword(userType) + ";";

                switch (userType)
                {
                    case "HR": new HR(userConnection).Show(); break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Login error [" + err.Message + "]");
                return;

            }
            MessageBox.Show(userName + ", Welcome\nAccess level - "+ userType, "Successful login");                   
        }    
    }
}
