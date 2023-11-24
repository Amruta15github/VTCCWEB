using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_bulkcontacts_master : System.Web.UI.Page
{

    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        btngetdata.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btngetdata, null) + ";");
    }

    public DataTable GetData()
    {
        DataTable dtbulk = new DataTable();

        try
        {
            dtbulk = c.GetDataTable("Select * from CentersData where CenterMobile='" + txtmobileno.Text + "' AND CenterEmailId='" + txtemail.Text + "' AND DelMark=0");
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occurred While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "GetData", ex.Message.ToString());
        }

        return dtbulk;
    }

    protected void btngetdata_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtfromdate.Text == "" || txttodate.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }

           
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occurred While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSearch_Click", ex.Message.ToString());
        }
    }
}