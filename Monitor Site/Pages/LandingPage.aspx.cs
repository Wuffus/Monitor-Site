using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using static SQL_Class;

public partial class Pages_LandingPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            string credentialsStr = $"SELECT * FROM tblUsers " +
                $"WHERE pNumber='{Request.Form["pNumber"]}' AND password = '{Request.Form["psw"]}'";
            string detailsStr = $"SELECT * FROM tblData " +
                $"WHERE pNumber='{Request.Form["pNumber"]}'";
            DataSet credentials = GetTable(credentialsStr);


            if (credentials.Tables[0].Rows.Count > 0)
            {
                DataSet details = GetTable(detailsStr);
                Session["userName"] = details.Tables[0].Rows[0]["firstName"];
                Session["Login"] = true;
                Session["userID"] = credentials.Tables[0].Rows[0]["pNumber"];
                message.InnerHtml = "";
                Response.Redirect("/Pages/Main.aspx");
            }
            else
            {
                Session["userName"] = "Logged Out";
                Session["Login"] = false;
                Session["userID"] = -1;
                message.InnerHtml = "Invalid login";
            }
        }
    }
}