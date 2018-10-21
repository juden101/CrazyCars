using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        String connstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CrazyCarz.mdf;Integrated Security=True";
        SqlConnection connDb = new SqlConnection(connstr);
        String sqlQuery = "INSERT INTO CAR VALUES ('" + txtRegistration.Text + "','" + txtCarType.Text + "')";
        SqlCommand sc = new SqlCommand(sqlQuery, connDb);
        connDb.Open();

        sc.ExecuteNonQuery();

        connDb.Close();
    }
}