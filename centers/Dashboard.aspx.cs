using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class centers_Dashboard : System.Web.UI.Page
{
    iClass c = new iClass();
    public string[] arrCounts = new string[30];
    protected void Page_Load(object sender, EventArgs e)
    {
        GetCount();
    }

    protected void GetCount()
    {
        try
        {
            arrCounts[0] = c.returnAggregate("Select Count(StudID) From StudentsData where DelMark=0").ToString();

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "GetCount", ex.Message.ToString());
            return;

        }
    }

}