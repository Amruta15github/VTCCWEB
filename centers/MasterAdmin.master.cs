using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class centers_MasterAdmin : System.Web.UI.MasterPage
{
    iClass c = new iClass();
    public string rootPath, centerid;
    protected void Page_Load(object sender, EventArgs e)
    {
        rootPath = c.ReturnHttp();
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        rootPath = c.ReturnHttp();
       

        if (Session["centerMaster"] == null)
        {
            Response.Redirect("Default.aspx");
        }

        if (Session["centerMaster"] == null)
        {
            Response.Redirect("Default.aspx", false);
        }
        centerid = c.GetReqData("CentersData", "CenterName", "CenterID=" + Session["centerMaster"]).ToString() ;
       


    }
}
