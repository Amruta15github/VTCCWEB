using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class training_centers : System.Web.UI.Page
{
    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSearch.Attributes.Add("onclick", "this.disabled=true; this.value='Processing...';" + ClientScript.GetPostBackEventReference(btnSearch, null) + ";");

        if (!IsPostBack)
        {
            c.FillComboBox("stateName", "stateId", "Statedata", "", "stateName", 0, ddlstate);

        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        
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