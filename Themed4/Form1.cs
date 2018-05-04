using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Themed4.Properties;

namespace Themed4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var jerarquias = new SqlDataAdapter("SELECT nombre FROM Jerarquia", GetConnectionString());
            var dc = new DataTable();
            jerarquias.Fill(dc);
            //var manejador = c1FlexPivotPage1.FlexPivotEngine;
            foreach (DataRow row in dc.Rows)
            {
                string name = row["nombre"].ToString();
                DimJer.Items.Add(name);
               // manejador.FilterFields.Add(name);
            }

            var dimensiones = new SqlDataAdapter("SELECT nombre FROM Hecho", GetConnectionString());
            var dim = new DataTable();
            dimensiones.Fill(dim);
            foreach (DataRow row in dim.Rows)
            {
                string name = row["nombre"].ToString();                
                DimJer.Items.Add(name);
                //manejador.FilterFields.Add(name);
            }
            var ventas = new SqlDataAdapter("SELECT TOP 100 * FROM t_vst_ventas", GetConnectionString());
            var ven = new DataTable();
            ventas.Fill(ven);
            c1OlapPage1.DataSource = ven;
        }
        static string GetConnectionString()
        {
            //Conecccion con la BD
            return Settings.Default.MetadataTestConnectionString;
        }

        private void c1OlapPage1_Load(object sender, EventArgs e)
        {

        }

        private void DimJer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campos="";
            for(int i = 0;i<DimJer.CheckedItems.Count;i++)
            {
                campos += DimJer.CheckedItems[i].ToString();
                if(i!= DimJer.CheckedItems.Count-1) campos += ",";
                Console.WriteLine(campos);
            }
            if(campos!="")
            {
                string consulta = "SELECT " + campos + " FROM t_vst_ventas";
                Console.WriteLine(consulta);
                var ventas = new SqlDataAdapter(consulta, GetConnectionString());
                var ven = new DataTable();
                ventas.Fill(ven);
                c1OlapPage1.DataSource = ven;
            }
            

        }

    }
    
}
