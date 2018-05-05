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
using Themed4.Properties;

namespace Themed4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        static string GetConnectionString()
        {
            //Conecccion con la BD
            return Settings.Default.Alemana_ventasConnectionString;
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            var cubos = new SqlDataAdapter("SELECT * FROM  Cubo ORDER BY nombre", GetConnectionString());
            var dt = new DataTable();
            cubos.Fill(dt);
            c1ComboBox1.ItemsDataSource = dt;
            c1ComboBox1.ItemsDisplayMember = "nombre";
            c1ComboBox1.ItemsValueMember = "id_cubo";
            
        }

        private void c1ComboBox1_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
