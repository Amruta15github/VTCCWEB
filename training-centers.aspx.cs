using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;


public partial class training_centers : System.Web.UI.Page
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

                c.FillComboBox("stateName", "stateId", "Statedata", "", "stateName", 0, ddlstate);

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
 

    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlstate.SelectedIndex != 0)
            {
                c.FillComboBox("distName", "distId", "Districtdata", "stateId=" + ddlstate.SelectedValue, "distName", 0, ddldist);
            }
        }
        catch (Exception)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Please Select District');", true);
            return;
        }
    }

    public DataTable GetData()
    {
        DataTable dtexam = new DataTable();

        try
        {
            dtexam = c.GetDataTable("Select * from CentersData where CenterState='" + ddlstate.SelectedValue + "' AND CenterDistrict='" + ddldist.SelectedValue + "' AND CenterPincode='" + txtpin.Text + "' AND DelMark=0");
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occurred While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "GetData", ex.Message.ToString());
        }

        return dtexam;
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtpin.Text == "" || ddlstate.SelectedValue == "" || ddldist.SelectedValue == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }

            DataTable matchingRecords = GetData();

            if (matchingRecords.Rows.Count > 0)
            {
                gvexam.DataSource = matchingRecords;
                gvexam.DataBind();
                viewtable.Visible = true;
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'No centers found matching the criteria.');", true);
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occurred While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSearch_Click", ex.Message.ToString());
        }
    }

}