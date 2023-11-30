using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class atc_renewal : System.Web.UI.Page
{
    iClass c = new iClass();
    public string[] arrAtc = new string[30];
    public string[] arrPkg = new string[40];
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            btnSubmit.Attributes.Add("onclick", "this.disabled=true; this.value='Processing...';" + ClientScript.GetPostBackEventReference(btnSubmit, null) + ";");
           

            if (!IsPostBack)
            {
                string whereCon = "";
                if (rdoAtc.Checked == true)
                {
                  
                    whereCon = "CenterRegNo='" + txtsearchbx.Text + "'";
                }
                else if (rdoEmail.Checked == true)
                {
                 

                    whereCon = "CenterEmailId='" + txtsearchbx.Text + "'";

                }
                object centrId = c.GetReqData("CentersData", "CenterID", whereCon);
                if (centrId != DBNull.Value && centrId != null && centrId.ToString() != "")
                {
                    viewtable.Visible = true;
                    GetData(Convert.ToInt32(centrId));
                }
                viewtable.Visible = false;
            }
           
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "Page_Load", ex.Message.ToString());
            return;
        }
    }

    public DataTable GetData(int CentIdx)
    {
        DataTable dtatc = new DataTable(); // Create a new DataTable

        try
        {
            dtatc = c.GetDataTable("Select * from CentersData Where CenterID=" + CentIdx);
            {

                if (dtatc.Rows.Count > 0)
                {
                    DataRow row = dtatc.Rows[0];

                    arrAtc[0] = row["CenterName"] != DBNull.Value && row["CenterName"] != null && row["CenterName"].ToString() != "" ? row["CenterName"].ToString() : "NA";

                    arrAtc[1] = row["CenterRegDate"] != DBNull.Value && row["CenterRegDate"] != null && row["CenterRegDate"].ToString() != "" ? Convert.ToDateTime(row["CenterRegDate"]).ToString("dd/MM/yyyy") : "NA";

                    arrAtc[2] = row["CenterRenewDate"] != DBNull.Value && row["CenterRenewDate"] != null && row["CenterRenewDate"].ToString() != "" ? Convert.ToDateTime(row["CenterRenewDate"]).ToString("dd/MM/yyyy") : "NA";

                    arrAtc[3] = "payment-method.aspx?atcId=" + CentIdx + "";
                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "GetData", ex.Message.ToString());
            return dtatc;
        }
        return dtatc;

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {    
            if (rdoAtc.Checked == false && rdoEmail.Checked == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Select Search Type');", true);
                return;
            }

            if (txtsearchbx.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Please Enter Act Code Or Email Id to search');", true);
                return;
            }


            if (rdoAtc.Checked == true)
            {
                if (c.IsRecordExist("Select CenterID From CentersData Where CenterRegNo='" + txtsearchbx.Text + "'"))
                {
                    object atcId = c.GetReqData("CentersData", "CenterID", "CenterRegNo='" + txtsearchbx.Text + "'");



                    if (atcId != DBNull.Value && atcId != null && atcId.ToString() != "")
                    {
                        GetData(Convert.ToInt32(atcId));
                        viewtable.Visible = true;

                    }
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Invalid Atc Code Entered!');", true);
                    return;
                }
            }
            else if (rdoEmail.Checked == true)
            {
                if (c.IsRecordExist("Select CenterID From CentersData Where CenterEmailId='" + txtsearchbx.Text + "'"))
                {
                    object atcId = c.GetReqData("CentersData", "CenterID", "CenterEmailId='" + txtsearchbx.Text + "'");

                  
                    if (atcId != DBNull.Value && atcId != null && atcId.ToString() != "")
                    {

                        GetData(Convert.ToInt32(atcId));
                        viewtable.Visible = true;
                       
                    }                   
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Invalid EmailId Entered!');", true);
                    return;
                }

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'ATC Not Found!');", true);
                return;
            }

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSubmit_Click", ex.Message.ToString());
            return;
        }

    }
}