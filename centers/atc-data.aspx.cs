using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class centers_atc_data : System.Web.UI.Page
{
    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData(Convert.ToInt32(Request.QueryString["id"]));
        }

            lblId.Visible = false;
    }

    
    public void GetData(int centerIdx)
    {
        try
        {
            using (DataTable dt = c.GetDataTable("select * from CentersData where CenterID =" + centerIdx))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    lblId.Text = centerIdx.ToString();
                    txtorgname.Text = row["CenterName"].ToString();
                    ddltypeoforg.SelectedValue = row["FK_CenterTypeID"].ToString();
                    ddrState.SelectedValue = row["CenterState"].ToString();
                    ddrDistrict.SelectedValue = row["CenterDistrict"].ToString();
                    txttaluka.Text = row["CenterTaluka"].ToString();
                    txtCity.Text = row["CenterCity"].ToString();
                    txtOwner.Text = row["CenterOwnerName"].ToString();
                    txtbday.Text = Convert.ToDateTime(row["CenterOwnerBdate"]).ToString("dd/MM/yyyy");
                    ddlrole.SelectedValue = row["CenterOwnerRole"].ToString();
                    txtEmail.Text = row["CenterEmailId"].ToString();
                    txtMobNo.Text = row["CenterMobile"].ToString();                 
                    txtpin.Text = row["CenterPincode"].ToString();

                    //gender
                    if (row["CenterOwnerGender"] != DBNull.Value && row["CenterOwnerGender"] != null && row["CenterOwnerGender"].ToString() != "")
                    {
                        if (row["CenterOwnerGender"].ToString() == "1")
                        {
                            Radiomale.Checked = true;
                        }
                        else if (row["CenterOwnerGender"].ToString() == "2")
                        {
                            if (row["CenterOwnerGender"].ToString() == "2")
                            {
                                Radiofemale.Checked = true;
                            }
                        }
                        else if (row["CenterOwnerGender"].ToString() == "3")
                        {
                            if (row["CenterOwnerGender"].ToString() == "3")
                            {
                                Radiotransgender.Checked = true;
                            }
                        }

                    }

                   

                    //object ApproveFlg = c.GetReqData("CentersData", "CenterStatus", "CenterID=" + Request.QueryString["id"]);

                    //if (ApproveFlg.ToString() == "1")
                    //{
                    //    btnApprove.Enabled = false;
                    //}
                }

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "GetData", ex.Message.ToString());
            return;
        }
    }

}