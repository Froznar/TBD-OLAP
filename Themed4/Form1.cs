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
        Dictionary<string, string> jer_dim;
        public Form1()
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            InitializeComponent();
            jer_dim = new Dictionary<string, string>();
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

            var jerarquias_dimensiones = new SqlDataAdapter("SELECT dimension.nombre, jerarquia.nombre, nivel FROM jerarquia INNER JOIN dimension ON dimension.id_dimension = jerarquia.id_dimension WHERE dimension.id_cubo = " + "1" + " ORDER BY dimension.nombre,nivel;", GetConnectionString());
            var jer_dim_dt = new DataTable();
            jerarquias_dimensiones.Fill(jer_dim_dt);
            foreach(DataRow row in jer_dim_dt.Rows)
            {
                jer_dim.Add(row[1].ToString(),row[0].ToString());
            }

            /*var ventas = new SqlDataAdapter("SELECT TOP 100 * FROM t_vst_ventas", GetConnectionString()); 
            var ven = new DataTable();
            ventas.Fill(ven);
            c1OlapPage1.DataSource = ven;*/
        }
        static string GetConnectionString()
        {
            //Conecccion con la BD
            return Settings.Default.Alemana_ventasConnectionString;
        }

        private void c1OlapPage1_Load(object sender, EventArgs e)
        {

        }

        private void DimJer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campos = "", medidas = "", campo = "", innerjoins = "", CCcampos = "", CCmedidas = "", medidas_raw = "";
            Dictionary<string, bool> taken = new Dictionary<string,bool>();
            bool value;
            for (int i = 0; i < DimJer.CheckedItems.Count; i++)
            {
                campo = DimJer.CheckedItems[i].ToString();
                if (campo == "montot" || campo == "cantidad")
                {
                    medidas += "sum(" + campo + ") as " + campo;
                    medidas += ",";

                    CCmedidas += "sum(CC." + campo + ") as " + campo;
                    CCmedidas += ",";

                    medidas_raw += campo;
                    medidas_raw += ",";
                }
                else
                {
                    campos += campo;
                    CCcampos += "CC." + campo;

                    if (!taken.TryGetValue(jer_dim[campo], out value))
                    {
                        innerjoins += " INNER JOIN " + jer_dim[campo] + " ON " + jer_dim[campo] + ".id_" + jer_dim[campo].Substring(2) + " = h_venta_null.id_" + jer_dim[campo].Substring(2);
                        taken.Add(jer_dim[campo], true);
                    }
                    campos += ",";
                    CCcampos += ",";
                   
                }

                Console.WriteLine(campos);
            }
            if (campos != "" && medidas != "")
            {
                medidas = medidas.Substring(0, medidas.Length - 1);
                campos = campos.Substring(0, campos.Length - 1);
                CCcampos = CCcampos.Substring(0, CCcampos.Length - 1);
                CCmedidas = CCmedidas.Substring(0, CCmedidas.Length - 1);
                medidas_raw = medidas_raw.Substring(0, medidas_raw.Length - 1);
                
                string consulta = "SELECT " + campos + "," + medidas + " FROM h_venta_final GROUP BY " + campos;
                //string consulta = "(SELECT " + campos +","+ medidas_raw + " FROM h_venta_null " + innerjoins + ")" ;
                //consulta = "SELECT " + CCcampos + "," + CCmedidas + " FROM " + consulta + " AS CC GROUP BY " + CCcampos + " ORDER BY " + CCcampos +  "; ";
                label1.Text = consulta;
                Console.WriteLine(consulta);
                var ventas = new SqlDataAdapter(consulta, GetConnectionString());
                var ven = new DataTable();
                ventas.Fill(ven);
                c1OlapPage1.DataSource = ven;
            }


        }

    }
    
}
