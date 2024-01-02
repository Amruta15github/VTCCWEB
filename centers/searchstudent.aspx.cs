using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class centers_searchstudent : System.Web.UI.Page
{
    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            btnSearch.Attributes.Add("onclick", "this.disabled=true; this.value='Processing...';" + ClientScript.GetPostBackEventReference(btnSearch, null) + ";");

            if (!IsPostBack)
            {
                viewtable.Visible = false;
            }
            lblId.Visible = false;
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "Page_Load", ex.Message.ToString());
            return;
        }
    }

        public DataTable GetData()
        {
            DataTable dtsearch = new DataTable();

            try
            {
                dtsearch = c.GetDataTable("Select * from StudentsData where StudMobile='" + txtmobnumber.Text + "' AND StudEmailId='" + txtemail.Text + "' AND DelMark=0");
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occurred While Processing');", true);
                c.ErrorLogHandler(this.ToString(), "GetData", ex.Message.ToString());
            }

            return dtsearch;
        }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtmobnumber.Text == "" || txtemail.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }

            DataTable matchingRecords = GetData();

            if (matchingRecords.Rows.Count > 0)
            {
                gvsearch.DataSource = matchingRecords;
                gvsearch.DataBind();
                viewtable.Visible = true;
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'No Adminssion form found matching the criteria.');", true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occurred While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSearch_Click", ex.Message.ToString());
        }
    }
}

