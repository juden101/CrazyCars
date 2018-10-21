using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowCarDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillNumberList();
        }
    }

    private void FillNumberList()
    {
        String sqlQuery = "SELECT RegistrationNumber FROM CAR ORDER BY RegistrationNumber";

        String connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CrazyCarz.mdf;Integrated Security=True";
        SqlConnection connDb = new SqlConnection(connstr);

        SqlCommand sc = new SqlCommand(sqlQuery, connDb);

        connDb.Open();

        SqlDataReader reader = sc.ExecuteReader();

        while (reader.Read())
        {
            ListItem item = new ListItem();
            item.Text = reader["RegistrationNumber"].ToString();

            listNumbers.Items.Add(item);
        }

        connDb.Close();
    }

    private void GetCarType()
    {

        String sqlQuery = "SELECT CarType FROM CAR where RegistrationNumber = '" + listNumbers.SelectedItem.Text + "' ORDER BY CarType ";
        String connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CrazyCarz.mdf;Integrated Security=True";
        SqlConnection connDb = new SqlConnection(connstr);
        SqlCommand sc = new SqlCommand(sqlQuery, connDb);
        connDb.Open();
        SqlDataReader reader = sc.ExecuteReader();

        if (reader.Read())
        {
            lblCarType.Text = reader["CarType"].ToString();
        }

    }


    protected void btnGetcartype_Click(object sender, EventArgs e)
    {
        GetCarType();
    }
}