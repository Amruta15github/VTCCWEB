using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_committeemembers_master : System.Web.UI.Page
{
    iClass c = new iClass();
    public string rootPath;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           
            btnApprove.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnApprove, null) + ";");
            btnUpdate.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnUpdate, null) + ";");
            btnBack.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnBack, null) + ";");

            if (!IsPostBack)
            {
                c.FillComboBox("stateName", "stateId", "Statedata", "", "stateName", 0, ddlstate);
                

                if (Request.QueryString["action"] != null)
                {
                    editinfo.Visible = true; //form/textbox
                    viewinfo.Visible = false; //gridview

                    if (Request.QueryString["action"] == "new")
                    {

                        txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                    }
                    else
                    {
                        GetData(Convert.ToInt32(Request.QueryString["id"]));
                    }
                }
                else
                {
                    editinfo.Visible = false;
                    viewinfo.Visible = true;
                    FillGrid();

                }

                //GetData(Convert.ToInt32(Request.QueryString["id"]));
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

    private void FillGrid()
    {
        try
        {
            using (DataTable dtreg = c.GetDataTable("Select ComMemberId, Convert(varchar(20), ComMemberDate, 103) as ComMemberDate, ComMemberName, ComMemberEmail, ComMemberCity From CommitteeMembers  Order By ComMemberId DESC"))
            {
                gvcommitteemember.DataSource = dtreg;
                gvcommitteemember.DataBind();

                if (dtreg.Rows.Count > 0)
                {
                    gvcommitteemember.UseAccessibleHeader = true;
                    gvcommitteemember.HeaderRow.TableSection = TableRowSection.TableHeader;
                }
            }

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "FillGrid", ex.Message.ToString());
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

    protected void gvcommitteemember_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"committeemembers-master.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";

                //approveflag
                object status = c.GetReqData("CommitteeMembers", "ComMemberstatus", "ComMemberId=" + e.Row.Cells[0].Text);

                Literal litStatus = (Literal)e.Row.FindControl("litstatus");
                switch (status.ToString())
                {
                    case "0":
                        litStatus.Text = "<div class=\"ordNew\">Pending</div>";
                        break;
                    case "1":
                        litStatus.Text = "<div class=\"ordDelivered\">Approved</div>";
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvcommitteemember_RowDataBound", ex.Message.ToString());
            return;
        }
    }

    //edit
    public void GetData(int centerIdx)
    {
        try
        {
            using (DataTable dt = c.GetDataTable("select * from CommitteeMembers where ComMemberId =" + centerIdx))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    lblId.Text = centerIdx.ToString();
                    txtDate.Text = Convert.ToDateTime(row["ComMemberDate"]).ToString("dd/MM/yyyy");
                    txtName.Text = row["ComMemberName"].ToString();
                    txtemail.Text = row["ComMemberEmail"].ToString();
                    txtmobileno.Text = row["ComMemberMobile"].ToString();
                    ddlstate.SelectedValue = row["ComMemberState"].ToString();
                    ddldistrict.SelectedValue = row["ComMemberDistrict"].ToString();                
                    txtcity.Text = row["ComMemberCity"].ToString();
                    
                    c.FillComboBox("distName", "distId", "Districtdata", "stateId=" + ddlstate.SelectedValue + "", "distName", 0, ddldistrict);
                    //ddldistrict.SelectedValue = row["CenterDistrict"].ToString();

                    object ApproveFlg = c.GetReqData("CommitteeMembers", "ComMemberstatus", "ComMemberId=" + Request.QueryString["id"]);

                    if (ApproveFlg.ToString() == "1")
                    {
                        btnApprove.Enabled = false;
                    }
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

    protected void btnApprove_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("Update CommitteeMembers set ComMemberstatus=1 where ComMemberId=" + Request.QueryString["id"]);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Committee Member Approved Sucessfully');", true);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('committeemembers-master.aspx', 2000);", true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnApprove_Click", ex.Message.ToString());
            return;
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            txtName.Text = txtName.Text.Trim().Replace("'", ""); 
            txtcity.Text = txtcity.Text.Trim().Replace("'", "");
            txtemail.Text = txtemail.Text.Trim().Replace("'", "");
            txtmobileno.Text = txtmobileno.Text.Trim().Replace("'", "");
            txtcity.Text = txtcity.Text.Trim().Replace("'", "");

            if (txtcity.Text == "" || txtemail.Text == "" || txtName.Text == "" || txtmobileno.Text == "" || ddlstate.SelectedValue == "" || ddldistrict.SelectedValue == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * marked fields are mandatory');", true);
                return;
            }
            if (c.ValidateMobile(txtmobileno.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Please Enter Valid Mobile Number');", true);
                return;
            }

            if (c.EmailAddressCheck(txtemail.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Please Enter Valid Email Address');", true);
                return;
            }
            //date time
            //int maxId = lblId.Text == "[New]" ? c.NextId("NewsData", "newsId") : Convert.ToInt32(lblId.Text);

            DateTime appDate = DateTime.Now;
            string[] arrDate = txtDate.Text.Split('/');
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


            c.ExecuteQuery("Update CommitteeMembers Set ComMemberDate='" + appDate + "', ComMemberName='" + txtName.Text + "', ComMemberEmail='" + txtemail.Text + "', ComMemberMobile='" + txtmobileno.Text + "', ComMemberState=" + ddlstate.SelectedValue + ", ComMemberDistrict= " + ddldistrict.SelectedValue + ", ComMemberCity='" + txtcity.Text + "' Where ComMemberId=" + Request.QueryString["id"]);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Committee Member Updated Sucessfully');", true);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('committeemembers-master.aspx', 2000);", true);

        }

        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnUpdate_Click", ex.Message.ToString());
            return;
        }

    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("committeemembers-master.aspx");
    }
}