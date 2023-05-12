using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DataConnection
/// </summary>
public abstract class DataConnection
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\veri.mdf;Integrated Security=True");

    public SqlConnection con { get { return conn; } }

    public void ConOpen()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

    }

    public void ConClose()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }

    }

}