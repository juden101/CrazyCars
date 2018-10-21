using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListCars : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String sqlQuery = "SELECT CarType FROM CAR ORDER BY CarType";

        String connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CrazyCarz.mdf;Integrated Security=True";
        SqlConnection connDb = new SqlConnection(connstr);

        SqlCommand sc = new SqlCommand(sqlQuery, connDb);

        connDb.Open();

        SqlDataReader reader = sc.ExecuteReader();

        while (reader.Read())
        {
            ListItem item = new ListItem();
            item.Text = reader["CarType"].ToString();

            listCarTypes.Items.Add(item);
        }

        connDb.Close();

    }
}