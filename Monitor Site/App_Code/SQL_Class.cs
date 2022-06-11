using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SQL_Class
/// </summary>
public static class SQL_Class
{
    public static DataSet GetTable (string SQLStr)
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection (connectionString);
        SqlCommand cmd = new SqlCommand(SQLStr, con);

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        return ds;
    }

    public static string BuildTable (DataTable dt)
    {
        string str = "<table class='dataTable' align='center'>";
        str += "<tr>";
        
        foreach (DataColumn col in dt.Columns)
        {
            str += "<td>" + col.ColumnName + "</td>";
        }

        foreach (DataRow dr in dt.Rows)
        {
            str += "<tr>";
            
            foreach (DataColumn column in dt.Columns)
            {
                str += "<td>" + dr[column] + "</td>";
            }
            str += "</tr>";
        }
        str += "</tr>";
        str += "</table>";
        return str;
    }
}