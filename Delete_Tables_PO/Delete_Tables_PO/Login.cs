using System;
using System.Windows.Forms;
using Delete_Tables_PO.TableModuel;
using Delete_Tables_PO.FileModuel;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Data.Sql;

namespace Delete_Tables_PO
{
    public partial class Login : Form
    {
        #region Property
        private TableHandling th;
        private string path = "";
		private List<string> listConnect;
        #endregion

        #region Method

        //Default contructor
        public Login()
        {
            InitializeComponent();
			listConnect = new List<string>();
            th = new TableHandling();
			//new line code
			DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();
			foreach (DataRow row in table.Rows)
			{
				foreach (DataColumn dataColumn in table.Columns)
				{
					if (dataColumn.ColumnName == "ServerName")
					{
						listConnect.Add(row[dataColumn.ColumnName].ToString());
					}
				}
			}
			comboBoxIP.DataSource = listConnect;
            //Get path of app
            path = Path.GetDirectoryName(Application.ExecutablePath) + "\\UserInfo.txt";
			// line curent code
			//if (File.Exists(path) == true)
			//new line code
			string pathRememberMe = Path.GetDirectoryName(Application.ExecutablePath) + "\\rememberme.txt";
			bool check=false;
			if (File.Exists(pathRememberMe) == true)
			{
				string[] info = FileHandling.ReadFile(pathRememberMe);
				if(info[0]=="true")
				{
					check = true;
				}
			}
            if (File.Exists(path) == true&&check)
            {
				checkBoxRememberMe.Checked = true;
				//line curent code
                string[] info = FileHandling.ReadFile(path);

                if (info.Length == 3)
                {
					//new line code
					comboBoxIP.Text = info[0];
					//line curent code
                    //txtIP.Text = info[0];
                    txtUserName.Text = info[1];
                    txtPassword.Text = info[2];
                }
            }
        }

        //Login event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
				//new line code
				th.SetConnection(comboBoxIP.Text, txtUserName.Text, txtPassword.Text, "");
				string[] UserInfo = new string[] { comboBoxIP.Text, txtUserName.Text, txtUserName.Text };
				string ConnectionString = "Data Source=" + comboBoxIP.Text + ";User Id=" + txtUserName.Text + ";Password=" + txtUserName.Text;				
				//line curent code
                //th.SetConnection(txtIP.Text, txtUserName.Text, txtPassword.Text,"");

                //string[] UserInfo = new string[] { txtIP.Text, txtUserName.Text, txtPassword.Text };
				//new line code
				if (checkBoxRememberMe.Checked == true)
				{
					string[] boolean=new string[]{"true"};
					FileHandling.WriteFile(boolean, "rememberme.txt");
					//line curent code
					FileHandling.WriteFile(UserInfo, "UserInfo.txt");
					//new line code
				}else
				{
					string[] boolean = new string[] { "false" };
					FileHandling.WriteFile(boolean, "rememberme.txt");
				}
				SqlConnection con = new SqlConnection(ConnectionString);
				con.Open();
				con.Close();
				//line curent code
                DeleteTable dt = new DeleteTable();

                this.Hide();
				
               // dt.IP = txtIP.Text;
				//new line code
				dt.IP = comboBoxIP.Text;
				//line curent code
                dt.UserName = txtUserName.Text;
                dt.Password = txtPassword.Text;
                dt.ShowDialog();

            }
            catch (Exception)
            {

                MessageBox.Show("Something wrong! Please retype input");
            }
        }

        //Exit Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Close form Event
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
