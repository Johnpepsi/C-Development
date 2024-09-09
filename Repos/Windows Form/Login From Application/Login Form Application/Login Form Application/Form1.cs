using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Login_Form_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=JOHNPEPSI\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = text_username.Text;
            user_password = text_password.Text;

            try
            {
                String querry = "SELECT * from Login_new WHERE username = '" + text_username.Text + "' AND password = '" + text_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0) ;
                {
                    username = text_username.Text;
                    user_password = text_password.Text;

                    // page that needed to be load next
                    MenuForm form2 = new MenuForm();
                    form2.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_username.Clear();
                    text_password.Clear();

                    //to focus username
                    text_username.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            { 
                con.Close();
            }
        }
    }
}