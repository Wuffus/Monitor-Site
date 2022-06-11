<%@ Application Language="C#" %>
<%@ Import Namespace="Monitor_Site" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

    void Session_Start(object sender, EventArgs e)
    {
        Session["userName"] = "";
        Session["Login"] = false;
        Session["userID"] = -1;
    }

</script>
