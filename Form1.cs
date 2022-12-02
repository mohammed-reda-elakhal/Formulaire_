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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String content;
        SqlConnection connexion = new SqlConnection("Data Source=DESKTOP-NMEA8DS;Initial Catalog=Etudiant;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (nomText.Text == "" && prenomText.Text == "" && filiéreText.Text == "" && annéeText.Text == "")
            {
                    MessageBox.Show("Inserer les information ");
            }else
            {
            connexion.Open();
                SqlCommand cmd = new SqlCommand("Insert into insert_data values (@nom,@prenom,@filiére,@année)", connexion);
                cmd.Parameters.AddWithValue("@nom", nomText.Text);
                cmd.Parameters.AddWithValue("@prenom", prenomText.Text);
                cmd.Parameters.AddWithValue("@filiére", filiéreText.Text);
                cmd.Parameters.AddWithValue("@année", int.Parse(annéeText.Text));
                idText.Clear();
                nomText.Clear();
                prenomText.Clear();
                filiéreText.Clear();
                annéeText.Clear();
                cmd.ExecuteNonQuery();

                connexion.Close();
                MessageBox.Show("saved Appuyez sur Confirm pour voir la mise à jour");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (nomText.Text == "" && prenomText.Text == "" && filiéreText.Text == "" && annéeText.Text == "" && idText.Text=="")
            {
                MessageBox.Show("Inserer les information ");
            }
            else

                connexion.Open();
            SqlCommand cmd = new SqlCommand("Update insert_data set nom=@nom , prenom=@prenom , filiére=@filiére , année=@année where Id=@Id", connexion);
            cmd.Parameters.AddWithValue("@Id", int.Parse(idText.Text));
            cmd.Parameters.AddWithValue("@nom", nomText.Text);
            cmd.Parameters.AddWithValue("@prenom", prenomText.Text);
            cmd.Parameters.AddWithValue("@filiére", filiéreText.Text);
            cmd.Parameters.AddWithValue("@année", int.Parse(annéeText.Text));
            idText.Clear();
            nomText.Clear();
            prenomText.Clear();
            filiéreText.Clear();
            annéeText.Clear();
            cmd.ExecuteNonQuery();
            connexion.Close();
            MessageBox.Show("Updated Appuyez sur Confirm pour voir la mise à jour");

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idText.Text == " ")
            {
                connexion.Open();
                SqlCommand cmd = new SqlCommand("Delete insert_data where Id=@Id", connexion);
                cmd.Parameters.AddWithValue("@Id", int.Parse(idText.Text));
                cmd.ExecuteNonQuery();
                connexion.Close();
                MessageBox.Show("Deleted Appuyez sur Confirm pour voir la mise à jour");
            }
            else
                MessageBox.Show("Inserer Id de la ligne ");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            connexion.Open();

            SqlCommand cmd = new SqlCommand("select * From insert_data",connexion);
            cmd.Parameters.AddWithValue("@Id", int.Parse(idText.Text));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connexion.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idText.Clear();
            nomText.Clear();
            prenomText.Clear();
            filiéreText.Clear();
            annéeText.Clear();
        }

        private void viewAllBtn_Click(object sender, EventArgs fe)
        {
            connexion.Open();

            SqlCommand cmd = new SqlCommand("select * From insert_data", connexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connexion.Close();

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            newBtn.Enabled = false;
            idText.Enabled = true;
            nomText.Enabled = true;
            prenomText.Enabled = true;
            filiéreText.Enabled = true; 
            annéeText.Enabled = true;
            deleteBtn.Enabled=true;
            insertBtn.Enabled=true;
            viewAllBtn.Enabled=true;
            deleteBtn.Enabled = true;
            updateBtn.Enabled = true;
        }

        private void nomText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
