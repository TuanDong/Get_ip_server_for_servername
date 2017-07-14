using System;
using System.Linq;
using System.Windows.Forms;
using Delete_Tables_PO.TableModuel;
using Delete_Tables_PO.FileModuel;
using System.IO;
using Delete_Tables_PO.FO_Moduel;

namespace Delete_Tables_PO
{
    public partial class DeleteTable : Form
    {
        #region Property
        private TableHandling th;

        public string IP, UserName, Password, type;
        #endregion

        #region Method

        //Default contructor
        public DeleteTable()
        {
            InitializeComponent();
            th = new TableHandling();
        }

        //Delete table event
        private void btnStart_Click(object sender, EventArgs e)
        {
			try
			{
				th.SetConnection(IP, UserName, Password, cbDatabase.Text);
				if(checkBoxDeleteWhere.Checked==true)
					{
						th.DeleteTable_Where(textBoxName.Text, textBoxWhere.Text);
					}
						// Get table dynamic table
						if (!String.IsNullOrWhiteSpace(txtTableName.Text) && !String.IsNullOrEmpty(txtTableName.Text))
						{
							FileHandling.WriteFile(txtTableName.Text.Split(','), cbDatabase.Text + ".txt");
						}

						// Add table to list 
						foreach (string tbName in txtTableName.Text.Split(','))
						{
							if (!String.IsNullOrEmpty(tbName) && !String.IsNullOrWhiteSpace(tbName))
							{
								th.TableNames.Add(tbName);
							}
						}

						

						th.DeleteTable(type);
						MessageBox.Show("Success!");
			}
			catch (Exception)
			{

				MessageBox.Show("Something wrong!");
			}

        }

        //Close form event
        private void DeleteTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rdFO_CheckedChanged(object sender, EventArgs e)
        {
			type = rdFO.Text;
			FO fo = new FO();
			th.TableNames = fo.FO_List();
			groupDelete.Enabled = true;
            Reset_cbDatabase();
        }

        private void rdPO_CheckedChanged(object sender, EventArgs e)
        {
            type = rdPO.Text;
			groupDelete.Enabled = true;
            Reset_cbDatabase();
        }

        private void rdAccount_CheckedChanged(object sender, EventArgs e)
        {
            type = rdAccount.Text;
			groupDelete.Enabled = true;
            Reset_cbDatabase();
        }

        private void Reset_cbDatabase()
        {
            th.SetConnection(IP, UserName, Password, type);
            cbDatabase.DataSource = null;
            cbDatabase.DataSource = th.GetListData(type);
        }

        //Checkbox event
        private void cbAddTable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddTable.Checked == true)
            {
                txtTableName.Enabled = true;

                string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\"+cbDatabase.Text+".txt";

                if (File.Exists(path) == true)
                {
                    foreach (string table in FileHandling.ReadFile(path))
                    {
                        if (table == FileHandling.ReadFile(path).Last())
                        {
                            txtTableName.Text += table;
                        }
                        else
                        {
                            txtTableName.Text += table + ",";
                        }
                    }
                }
                else
                {
                    txtTableName.Text = "";
                }
            }
            else
            {
                txtTableName.Enabled = false;
                txtTableName.Text = "";
            }
        }

        //Back login event
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            Login log = new Login();
            log.Show();
        }

        #endregion		

		private void checkBoxDeleteWhere_CheckedChanged(object sender, EventArgs e)
		{
			groupBoxDeleteWhere.Enabled = true;
		}
    }
}
