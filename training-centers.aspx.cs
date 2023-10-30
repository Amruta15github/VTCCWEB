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


                //viewtable.Visible = false;

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

    public void GetData(int centerIdx)
    {
        try
        {
            using (DataTable dtcenter = c.GetDataTable("select CenterName,CenterPincode,CenterMobile,CenterEmailId from CentersData where CenterID=" + centerIdx))
            {
                if (dtcenter.Rows.Count > 0)
                {
                    DataRow row = dtcenter.Rows[0];
                    lblId.Text = centerIdx.ToString();
                    ddlstate.SelectedValue = row["CenterState"].ToString();
                    ddldist.SelectedValue = row["CenterDistrict"].ToString();
                    txtpin.Text = row["CenterPincode"].ToString();
                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'No centers found matching the criteria.');", true);
            c.ErrorLogHandler(this.ToString(), "GetData", ex.Message.ToString());
            return;
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        

        c.ExecuteQuery("Select CenterName, CenterPincode, CenterMobile, CenterEmailId from CentersData");
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'No centers found matching the criteria.');", true);

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

   
}