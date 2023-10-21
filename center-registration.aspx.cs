using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class center_registration : System.Web.UI.Page
{
    iClass c = new iClass();
    public string errMsg;
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSubmit.Attributes.Add("onclick", "this.disabled=true; this.value='Processing...';" + ClientScript.GetPostBackEventReference(btnSubmit, null) + ";");
        

        if (!IsPostBack)
        {
            c.FillComboBox("stateName", "stateId", "Statedata", "", "stateName", 0, ddrState);
            c.FillComboBox("orgName", "orgId", "Orgtype", "", "orgName", 0, ddltypeoforg);
        }
    }

    //protected void UpdatePanel1_Load(object sender, EventArgs e)
    //{
    //    ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "grecaptcha.render('recaptcha', {'sitekey': '6LcNBIUUAAAAADbX-_n6UhdJhtAxQDgiypcyZqSN'});", true);
    //}

    protected void ddrState_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddrState.SelectedIndex != 0)
            {
                c.FillComboBox("distName", "distId", "Districtdata", "stateId=" + ddrState.SelectedValue, "distName", 0, ddrDistrict);
            }
        }
        catch (Exception)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Please Select District');", true);
            return;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            txtCity.Text = txtCity.Text.Trim().Replace("'", "");
            txttaluka.Text = txttaluka.Text.Trim().Replace("'", "");
            txtrole.Text = txtrole.Text.Trim().Replace("'", "");
            txtEmail.Text = txtEmail.Text.Trim().Replace("'", "");
            txtbday.Text = txtbday.Text.Trim().Replace("'", "");
            txtorgname.Text = txtorgname.Text.Trim().Replace("'", "");
            txtMobNo.Text = txtMobNo.Text.Trim().Replace("'", "");
            txtOwner.Text = txtOwner.Text.Trim().Replace("'", "");

            if (txtCity.Text == "" || txtEmail.Text == "" || txtbday.Text == "" || txtorgname.Text == "" || txtMobNo.Text == "" || txttaluka.Text == "" || txtOwner.Text == "" || txtrole.Text == "" || ddltypeoforg.SelectedValue=="" || ddrState.SelectedValue=="" || ddrDistrict.SelectedValue=="")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * marked fields are mandatory');", true);
                return;
            }
            else if (c.ValidateMobile(txtMobNo.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid Mobile No');", true);
                return;
            }
           
            else if (c.EmailAddressCheck(txtEmail.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid Email Address');", true);
                return;
            }
            else if (c.IsRecordExist("Select CenterID From CentersData Where CenterMobile = '" + txtMobNo.Text + "'"))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Mobile No is already registered with us');", true);
                return;
            }
            else if (c.IsRecordExist("Select CenterID From Centersdata Where CenterEmailId='" + txtEmail.Text + "' "))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Email Address is already registered with us');", true);
                return;
            }
          

            //Insert Update data
            //int maxId = lblId.Text == "[New]" ? c.NextId("NewsData", "newsId") : Convert.ToInt32(lblId.Text);

            DateTime appDate = DateTime.Now;
            string[] arrDate = txtbday.Text.Split('/');
            if (c.IsDate(arrDate[1] + "/" + arrDate[0] + "/" + arrDate[2]) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter Valid Date');", true);
                return;
            }
            else
            {
                appDate = Convert.ToDateTime(arrDate[1] + "/" + arrDate[0] + "/" + arrDate[2]);
            }

            DateTime cDate = DateTime.Now;
            string currentDate = cDate.ToString("yyyy-MM-dd HH:mm:ss.fff");



            //gender code
            string gender = "";
            if (Radiomale.Checked == true)
            {
                gender = "1";
            }

            if (Radiofemale.Checked == true)
            {
                gender = "2";
            }

            if (Radiotransgender.Checked == true)
            {
                gender = "3";
            }

            //checkbox

            if (Chkagree.Checked == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Please agree to the terms before submitting the form.');", true);
                return;
            }

            int maxId = c.NextId("CentersData", "CenterID");
            //int wishReg = 0;
            //if (compcourse.Checked == true)
            //{
            //    wishReg = 1;
            //}
            //else if (compcourse.Checked == false)
            //{
            //    wishReg = 0;
            //}
            c.ExecuteQuery("Insert Into CentersData (CenterID, CenterRegDate, CenterName, FK_CenterTypeID, CenterState, CenterDistrict, CenterTaluka, CenterCity, CenterOwnerName, CenterOwnerGender, CenterOwnerBdate, CenterOwnerRole, CenterMobile, CenterEmailId, CenterStatus, DelMark) Values (" + maxId + ", '" + DateTime.Now + "', '" + txtorgname.Text + "', " + ddltypeoforg.SelectedValue + ", " + ddrState.SelectedValue + ", " + ddrDistrict.SelectedValue + ",  '" + txtCity.Text + "','" + txttaluka.Text + "','" + txtOwner.Text + "', '" + gender + "', '" + appDate + "','" + txtrole.Text + "','" + txtMobNo.Text + "', '" + txtEmail.Text + "',' Pending  ', 0)");

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Registration request has been submited successfully');", true);

            //clear all
            txtCity.Text = txtOwner.Text= txtorgname.Text = txtEmail.Text = txttaluka.Text  = txtbday.Text = txtrole.Text = txtMobNo.Text =  "";
            ddrDistrict.SelectedIndex = ddrState.SelectedIndex = ddltypeoforg.SelectedIndex = 0;
            Radiomale.Checked = Radiofemale.Checked = Radiotransgender.Checked = false;
            Chkagree.Checked = false ;
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSubmit_Click", ex.Message.ToString());
            return;
        }
    }
}
