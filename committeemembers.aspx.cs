using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class committeemembers : System.Web.UI.Page
{
    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSubmit.Attributes.Add("onclick", "this.disabled=true; this.value='Processing...';" + ClientScript.GetPostBackEventReference(btnSubmit, null) + ";");

        if (!IsPostBack)
        {
            c.FillComboBox("stateName", "stateId", "Statedata", "", "stateName", 0, ddlstate);
           
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            txtName.Text = txtName.Text.Trim().Replace("'", "");
            txtemail.Text = txtemail.Text.Trim().Replace("'", "");
            txtmobileno.Text = txtmobileno.Text.Trim().Replace("'", "");
            txtcity.Text = txtcity.Text.Trim().Replace("'", "");


            if (txtName.Text == "" || txtemail.Text == "" || txtmobileno.Text == "" || txtcity.Text == "" || ddlstate.SelectedValue == "" || ddldistrict.SelectedValue == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * marked fields are mandatory');", true);
                return;
            }
            else if (c.ValidateMobile(txtmobileno.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid Mobile No');", true);
                return;
            }

            else if (c.EmailAddressCheck(txtemail.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid Email Address');", true);
                return;
            }
            else if (c.IsRecordExist("Select ComMemberId From CommitteeMembers Where ComMemberMobile = '" + txtmobileno.Text + "'"))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Mobile No is already registered with us');", true);
                return;
            }
            else if (c.IsRecordExist("Select ComMemberId From CommitteeMembers Where ComMemberEmail='" + txtemail.Text + "' "))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Email Address is already registered with us');", true);
                return;
            }
           

            int maxId = c.NextId("CommitteeMembers", "ComMemberId");

            c.ExecuteQuery("Insert Into CommitteeMembers (ComMemberId, ComMemberDate, ComMemberName, ComMemberEmail, ComMemberMobile, ComMemberState, ComMemberDistrict, ComMemberCity, ComMemberstatus) Values (" + maxId + ", '" + DateTime.Now + "', '" + txtName.Text + "', '" + txtemail.Text + "','" + txtmobileno.Text + "', " + ddlstate.SelectedValue + ", " + ddldistrict.SelectedValue + ",  '" + txtcity.Text + "',' Pending')");

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Committee Member request has been submited successfully');", true);

            //clear all
            txtName.Text = txtemail.Text = txtmobileno.Text = txtcity.Text ="";
            ddldistrict.SelectedIndex = ddlstate.SelectedIndex  = 0;
            
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSubmit_Click", ex.Message.ToString());
            return;
        }
    }

        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlstate.SelectedIndex != 0)
            {
                c.FillComboBox("distName", "distId", "Districtdata", "stateId=" + ddlstate.SelectedValue, "distName", 0, ddldistrict);
            }
        }
        catch (Exception)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Please Select District');", true);
            return;
        }
    }
}