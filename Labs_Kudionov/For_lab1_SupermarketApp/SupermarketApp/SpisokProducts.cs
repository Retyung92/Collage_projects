using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketApp
{


    public partial class Spisokproductov : Form
    {

        string connectionString = "Data Source=desktop-80r1eus;Initial Catalog=supermarket;Integrated Security=True";
        public Spisokproductov()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Spisokproductov_Load(object sender, EventArgs e)
        {
            comboBoxProducts.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT name FROM products", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxProducts.Items.Add(reader["name"].ToString());
                }
            }
        }
        private bool productsLoaded = false;
        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productsLoaded) return;

            comboBoxProducts.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT name FROM products", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxProducts.Items.Add(reader["name"].ToString());
                }
            }

            productsLoaded = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedItem != null)
            {
                listAddProducts.Items.Add(comboBoxProducts.SelectedItem.ToString());
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listAddProducts.Items.Clear();
            textBoxTotal.Text = "";
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var item in listAddProducts.Items)
                {
                    SqlCommand cmd = new SqlCommand("SELECT price FROM products WHERE name = @name", conn);
                    cmd.Parameters.AddWithValue("@name", item.ToString());
                    total += (decimal)cmd.ExecuteScalar();
                }
            }
            textBoxTotal.Text = total.ToString("C");
        }
    }
}