using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_center_registrationMaster : System.Web.UI.Page
{
    iClass c = new iClass();
    public string rootPath, pgTitle;
    protected void Page_Load(object sender, EventArgs e)
    {
        
         try
            {
                pgTitle = "editreg";
                btnApprove.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnApprove, null) + ";");
                btnUpdate.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnUpdate, null) + ";");
                btnDelete.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnDelete, null) + ";");
                btnBack.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnBack, null) + ";");

            if (!IsPostBack)
                {
                   c.FillComboBox("stateName", "stateId", "Statedata", "", "stateName", 0, ddrstate);
                   c.FillComboBox("orgName", "orgId", "Orgtype", "", "orgName", 0, ddltypeoforg);

                if (Request.QueryString["action"] != null)
                    {
                        editreg.Visible = true; //form/textbox
                        viewreg.Visible = false; //gridview

                    //    if (Request.QueryString["action"] == "new")
                    //    {
                    //        //btnSave.Text = "Save Info";
                    //        //btnDelete.Visible = false;
                    //        //txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    //        //btnRemove.Visible = false;
                    //    }
                    //    else
                    //    {
                    //        //btnSave.Text = "Modify Info";
                    //        //btnDelete.Visible = true;
                    //        //GetNewsData(Convert.ToInt32(Request.QueryString["id"]));
                    //    }
                    }
                    else
                    {
                    editreg.Visible = false;
                    viewreg.Visible = true;
                    FillGrid();
                   
                }

                GetData(Convert.ToInt32(Request.QueryString["id"]));
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
            using (DataTable dtreg = c.GetDataTable("Select CenterID, Convert(varchar(20), CenterRegDate, 103) as CenterRegDate, CenterName, CenterOwnerName, CenterCity, CenterMobile, CenterEmailId From CentersData Where DelMark=0 Order By CenterID DESC"))
            {
                gvreg.DataSource = dtreg;
                gvreg.DataBind();

                if (dtreg.Rows.Count > 0)
                {
                    gvreg.UseAccessibleHeader = true;
                    gvreg.HeaderRow.TableSection = TableRowSection.TableHeader;
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
    protected void gvreg_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
               litAnch.Text = "<a href=\"center-registrationMaster.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gView\" title=\"View/Edit\"></a>";

                //approveflag
                object status = c.GetReqData("CentersData", "CenterStatus", "CenterID=" + e.Row.Cells[0].Text);

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
            c.ErrorLogHandler(this.ToString(), "gvreg_RowDataBound", ex.Message.ToString());
            return;
        }
    }
    //edit
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
                    ddrstate.SelectedValue = row["CenterState"].ToString();
                    ddrdist.SelectedValue = row["CenterDistrict"].ToString();
                    txttaluka.Text = row["CenterTaluka"].ToString();
                    txtcity.Text = row["CenterCity"].ToString();
                    txtowner.Text = row["CenterOwnerName"].ToString();             
                    txtbday.Text = Convert.ToDateTime(row["CenterOwnerBdate"]).ToString("dd/MM/yyyy");
                    txtrole.Text = row["CenterOwnerRole"].ToString();
                    txtemail.Text = row["CenterEmailId"].ToString();
                    txtMobNo.Text = row["CenterMobile"].ToString();
                    txtactregno.Text = row["CenterRegNo"].ToString();
                    txtusername.Text = row["CenterEmailId"].ToString();
                    

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

                    c.FillComboBox("distName", "distId", "Districtdata", "stateId=" + ddrstate.SelectedValue + "", "distName", 0, ddrdist);
                    ddrdist.SelectedValue = row["CenterDistrict"].ToString();


                    ////photo
                    //if (row["photo"] != DBNull.Value && row["photo"] != null && row["photo"].ToString() != "" && row["photo"].ToString() != "no-photo.png")
                    //{
                    //    photo = "<img src=\"" + Master.rootPath + "uploads/" + row["photo"].ToString() + "\" width=\"200\" />";

                    //}

                    object ApproveFlg = c.GetReqData("CentersData", "CenterStatus", "CenterID=" + Request.QueryString["id"]);

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
            c.ExecuteQuery("Update CentersData set CenterStatus=1 where CenterID=" + Request.QueryString["id"]);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'CenterRegistration Approved Sucessfully');", true);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('center-registrationMaster.aspx', 2000);", true);
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
            txtorgname.Text = txtorgname.Text.Trim().Replace("'", ""); 
            txttaluka.Text = txttaluka.Text.Trim().Replace("'", "");
            txtcity.Text = txtcity.Text.Trim().Replace("'", "");
            txtowner.Text = txtowner.Text.Trim().Replace("'", "");
            txtbday.Text = txtbday.Text.Trim().Replace("'", "");
            txtrole.Text = txtrole.Text.Trim().Replace("'", "");
            txtemail.Text = txtemail.Text.Trim().Replace("'", "");
            txtMobNo.Text = txtMobNo.Text.Trim().Replace("'", "");
          
            if (txtcity.Text == "" || txtemail.Text == "" || txtbday.Text == "" || txtorgname.Text == "" || txtMobNo.Text == "" || txttaluka.Text == "" || txtowner.Text == "" || txtrole.Text == "" || ddltypeoforg.SelectedValue == "" || ddrstate.SelectedValue == "" || ddrdist.SelectedValue == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * marked fields are mandatory');", true);
                return;
            }
            if (c.ValidateMobile(txtMobNo.Text) == false)
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
            // int maxId = lblId.Text == "[New]" ? c.NextId("NewsData", "newsId") : Convert.ToInt32(lblId.Text);

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

            if (c.IsRecordExist("Select CenterID from CentersData where CenterRegNo='" + txtactregno.Text + "'  And CenterID!=" + Request.QueryString["id"] + " And DelMark=0"))
            {

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'ATCRegistration is already exist');", true);
                return;
            }

            c.ExecuteQuery("Update CentersData Set CenterRegDate='" + DateTime.Now + "', CenterName='" + txtorgname.Text + "', FK_CenterTypeID='" + ddltypeoforg.SelectedValue + "', CenterState=" + ddrstate.SelectedValue + ", CenterDistrict= " + ddrdist.SelectedValue + ", CenterTaluka='" + txttaluka.Text + "', CenterCity='" + txtcity.Text + "', CenterOwnerName='" + txtowner.Text + "', CenterOwnerGender='" + gender + "', CenterOwnerBdate= '" + appDate + "', CenterOwnerRole='" + txtrole.Text + "', CenterMobile='" + txtMobNo.Text + "', CenterEmailId='" + txtemail.Text + "', CenterRegNo='" + txtactregno.Text + "' , CenterUsername='" + txtusername.Text + "', CenterUserPwd='123456'  Where CenterID=" + Request.QueryString["id"]);

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'CenterRegistration Updated Sucessfully');", true);

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('center-registrationMaster.aspx', 2000);", true);
           
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
        Response.Redirect("center-registrationMaster.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("update CentersData set DelMark=1 where CenterID=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('center-registrationMaster.aspx', 2000);", true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnDelete_Click", ex.Message.ToString());
            return;
        }
    }

    protected void ddrState_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddrstate.SelectedIndex != 0)
            {
                c.FillComboBox("distName", "distId", "Districtdata", "stateId=" + ddrstate.SelectedValue, "distName", 0, ddrdist);
            }
        }
        catch (Exception)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Please Select District');", true);
            return;
        }
    }
}