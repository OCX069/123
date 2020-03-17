using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace esoft
{
   
        public partial class Vxod : Form
        {
            string connectionString;
            string Login;
            string Password;
            public Vxod()
            {
                InitializeComponent();
                connectionString = ConfigurationManager.ConnectionStrings["esoft.Properties.Settings._16is32ConnectionString"].ConnectionString;
            }
        
            private void button1_Click(object sender, EventArgs e)
            {
                Login = loginTB.Text.Trim();
                Password = passTB.Text.Trim();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    Int32 countUser = 0;
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "SELECT COUNT (*) FROM [dbo].[User] WHERE Login = @Login AND Password = @Password";
                    command.Connection = connection;

                    command.Parameters.Add("@Login", SqlDbType.VarChar);
                    command.Parameters["@Login"].Value = Login;

                    command.Parameters.Add("@Password", SqlDbType.VarChar);
                    command.Parameters["@Password"].Value = Password;

                    try
                    {
                        connection.Open();
                        countUser = (Int32)command.ExecuteScalar();
                        if (countUser == 1)
                        {
                            MessageBox.Show("Авторизация успешна.");
                            Administr f2 = new Administr();
                            f2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(" Ошибка авторизации.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gl_Load(object sender, EventArgs e)
        {

        }
    }
}
