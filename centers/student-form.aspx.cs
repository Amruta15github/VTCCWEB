using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
public partial class centers_student_form : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, rootPath, studphoto, studsign;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add Student Admission" : "Edit Student Admission";
            btnSave.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");
            btnDelete.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnDelete, null) + ";");
            btnCancel.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnCancel, null) + ";");

            if (!IsPostBack)
            {
                c.FillComboBox("stateName", "stateId", "Statedata", "", "stateName", 0, ddlstate);

                if (Request.QueryString["action"] != null)
                {
                    editinfo.Visible = true;
                    viewinfo.Visible = false;

                    if (Request.QueryString["action"] == "new")
                    {
                        btnSave.Text = "Save Info";
                        btnDelete.Visible = false;
                        //txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                    }
                    else
                    {
                        btnSave.Text = "Modify Info";
                        btnDelete.Visible = true;
                        GetData(Convert.ToInt32(Request.QueryString["id"]));
                        //GetData(Convert.ToInt32(Session["centerMaster"]));
                    }
                }
                else
                {
                    editinfo.Visible = false;
                    viewinfo.Visible = true;
                    FillGrid();
                }
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
            using (DataTable dtstud = c.GetDataTable("Select StudID, StudRegNo, StudFirstName, StudLastName, StudEmailId, StudCity, StudCourseName From StudentsData  where FK_CenterId= " + Session["centerMaster"] + " Order By StudID DESC"))
            {
                gvstudform.DataSource = dtstud;
                gvstudform.DataBind();

                if (dtstud.Rows.Count > 0)
                {
                    gvstudform.UseAccessibleHeader = true;
                    gvstudform.HeaderRow.TableSection = TableRowSection.TableHeader;
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

    public void GetAllControls(ControlCollection ctrs)
    {
        foreach (Control c in ctrs)
        {
            if (c is System.Web.UI.WebControls.TextBox)
            {
                TextBox tt = c as TextBox;
                tt.Text = tt.Text.Trim().Replace("'", "");
            }
            if (c.HasControls())
            {
                GetAllControls(c.Controls);
            }
        }
    }

    protected void gvstudform_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"student-form.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvstudform_RowDataBound", ex.Message.ToString());
            return;
        }
    }


    public void GetData(int studIdx)
    {
        try
        {
            using (DataTable dtjob = c.GetDataTable("select * from StudentsData where StudID=" + studIdx))
            {
                if (dtjob.Rows.Count > 0)
                {
                    DataRow row = dtjob.Rows[0];
                    lblId.Text = studIdx.ToString();
                    //txtDate.Text = Convert.ToDateTime(row["JobDate"]).ToString("dd/MM/yyyy");
                    txtregno.Text = row["StudRegNo"].ToString();
                    txtfirstname.Text = row["StudFirstName"].ToString();
                    txtmiddlename.Text = row["StudMidName"].ToString();
                    txtlastname.Text = row["StudLastName"].ToString();
                    txtmobile.Text = row["StudMobile"].ToString();
                    txtemail.Text = row["StudEmailId"].ToString();
                    txtwhatsapp.Text = row["StudWhatsApp"].ToString();
                    txteduc.Text = row["StudEducation"].ToString();
                    ddlstate.SelectedValue = row["FK_StateId"].ToString();
                    ddldist.SelectedValue = row["FK_DistrictId"].ToString();
                    txtcity.Text = row["StudCity"].ToString();
                    txtaddress.Text = row["StudAddress"].ToString();
                    txtbirthdate.Text = row["StudBirthDate"].ToString();
                    txtcoursename.Text = row["StudCourseName"].ToString();

                    if (row["StudPhoto"] != DBNull.Value && row["StudPhoto"] != null && row["StudPhoto"].ToString() != "" && row["StudPhoto"].ToString() != "no-photo.png")
                    {
                        studphoto = "<img src=\"" + Master.rootPath + "upload/studadmphoto/thumb/" + row["StudPhoto"].ToString() + "\" width=\"200\" />";

                    }

                    if (row["StudSignPhoto"] != DBNull.Value && row["StudSignPhoto"] != null && row["StudSignPhoto"].ToString() != "" && row["StudSignPhoto"].ToString() != "no-photo.png")
                    {
                        studsign = "<img src=\"" + Master.rootPath + "upload/studsign/" + row["StudSignPhoto"].ToString() + "\" width=\"200\" />";

                    }
                    c.FillComboBox("distName", "distId", "Districtdata", "stateId=" + ddlstate.SelectedValue + "", "distName", 0, ddldist);
                    ddldist.SelectedValue = row["FK_DistrictId"].ToString();
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

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            // Concatenating first name, middle name, and last name to create full name
            string fullName = txtfirstname.Text.Trim() + " " + txtmiddlename.Text.Trim() + " " + txtlastname.Text.Trim();

            GetAllControls(this.Controls);
            //Empty Validations
            if (txtfirstname.Text == "" || txtmiddlename.Text == "" || txtlastname.Text == "" || txtmobile.Text == "" || txtemail.Text == "" || txtcoursename.Text == "" || ddlstate.SelectedValue == "" || ddldist.SelectedValue == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }
            else if (c.ValidateMobile(txtmobile.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid Mobile No');", true);
                return;
            }

            else if (c.EmailAddressCheck(txtemail.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid Email Address');", true);
                return;
            }
            else if (c.IsRecordExist("Select CenterID From CentersData Where CenterMobile = '" + txtmobile.Text + "'"))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Mobile No is already registered with us');", true);
                return;
            }
            else if (c.IsRecordExist("Select CenterID From Centersdata Where CenterEmailId='" + txtemail.Text + "' "))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Email Address is already registered with us');", true);
                return;
            }

            //Insert Update data
            int maxId = lblId.Text == "[New]" ? c.NextId("StudentsData", "StudID") : Convert.ToInt32(lblId.Text);

            string studphoto = "";
            if (fustudImage.HasFile)
            {
                string fExt = Path.GetExtension(fustudImage.FileName).ToString().ToLower();

                if (fExt == ".jpeg" || fExt == ".png" || fExt == ".jpg")
                {
                    studphoto = "stud-photo-" + maxId + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;

                    fustudImage.SaveAs(Server.MapPath("~/upload/studadmphoto/thumb/") + studphoto);
                    ImageUploadProcess(studphoto);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only .jpeg .png .jpg files are allowed');", true);
                    return;

                }
            }

            string studsign = "";
            if (fusignImage.HasFile)
            {
                string fExt = Path.GetExtension(fusignImage.FileName).ToString().ToLower();

                if (fExt == ".jpeg" || fExt == ".png" || fExt == ".jpg")
                {
                    studsign = "stud-sign-" + maxId + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;

                    fusignImage.SaveAs(Server.MapPath("~/upload/studsign/") + studsign);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only .jpeg .png .jpg files are allowed');", true);
                    return;

                }
            }

            if (c.IsRecordExist("Select StudID from StudentsData where StudRegNo='" + txtregno.Text + "'  And DelMark=0"))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Student Registration Number is already exist');", true);
                return;

                // Record already exists, perform an UPDATE
                c.ExecuteQuery("Update StudentsData set StudID=" + maxId + ",  FK_CenterId='" + Session["centerMaster"] + "', StudRegNo = '" + txtregno.Text + "',  StudFirstName='" + txtfirstname.Text + "', StudMidName='" + txtmiddlename.Text + "', StudLastName='" + txtlastname.Text + "', StudMobile='" + txtmobile.Text + "', StudEmailId='" + txtemail.Text + "', StudWhatsApp='" + txtwhatsapp.Text + "', StudEducation='" + txteduc.Text + "', FK_StateId= " + ddlstate.SelectedValue + ", FK_DistrictId= " + ddldist.SelectedValue + ", StudCity= '" + txtcity.Text + "', StudAddress= '" + txtaddress.Text + "', StudBirthDate='" + txtbirthdate.Text + "' , StudCourseName='" + txtcoursename.Text + "', StudFullName='" + fullName + "' where StudID=" + maxId);

                // Additional update operations for images if needed

                if (fustudImage.HasFile)
                {
                    c.ExecuteQuery("Update StudentsData Set StudPhoto='" + studphoto + "' where StudID=" + maxId + "");
                }

                if (fusignImage.HasFile)
                {
                    c.ExecuteQuery("Update StudentsData Set StudSignPhoto='" + studsign + "' where StudID=" + maxId + "");
                }
        
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Student Form Updated');", true);
          
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('student-form.aspx', 2000);", true);
            }
            else
            {
                // Record doesn't exist, perform an INSERT
                c.ExecuteQuery("Insert into StudentsData (StudID, FK_CenterId, StudRegNo, StudFirstName, StudMidName, StudLastName, StudFullName, StudMobile, StudWhatsApp, StudEmailId, StudEducation, FK_StateId, FK_DistrictId,StudCity,StudAddress, StudBirthDate, StudCourseName, StudPhoto, StudSignPhoto,DelMark) Values (" + maxId + ",'" + Session["centerMaster"] + "', '" + txtregno.Text + "', '" + txtfirstname.Text + "','" + txtmiddlename.Text + "','" + txtlastname.Text + "','" + fullName + "','" + txtmobile.Text + "','" + txtwhatsapp.Text + "','" + txtemail.Text + "','" + txteduc.Text + "'," + ddlstate.SelectedValue + "," + ddldist.SelectedValue + ",'" + txtcity.Text + "','" + txtaddress.Text + "','" + txtbirthdate.Text + "','" + txtcoursename.Text + "','" + studphoto + "','" + studsign + "', 0)"); // Your insert SQL statement

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Student Form Added');", true);
            }

            // Clear form fields and perform other necessary operations

            txtregno.Text = txtfirstname.Text = txtmiddlename.Text = txtlastname.Text = txtmobile.Text = txtemail.Text = txtwhatsapp.Text = txteduc.Text = txtcity.Text = txtaddress.Text = txtbirthdate.Text = txtcoursename.Text = "";
            ddlstate.SelectedIndex = ddldist.SelectedIndex = 0;

        }

        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSave_Click", ex.Message.ToString());
            return;
        }
    }

    private void ImageUploadProcess(string studphoto)
    {
        try
        {
            string origImgPath = "~/upload/studadmphoto/original/";
            string thumbImgPath = "~/upload/studadmphoto/thumb/";
            string normalImgPath = "~/upload/studadmphoto/";

            fustudImage.SaveAs(Server.MapPath(origImgPath) + studphoto);
            c.ImageOptimizer(studphoto, origImgPath, normalImgPath, 800, true);
            c.ImageOptimizer(studphoto, normalImgPath, thumbImgPath, 480, true);

            //Delete rew image from server
            File.Delete(Server.MapPath(origImgPath) + studphoto);

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "ImageUploadProcess", ex.Message.ToString());
            return;
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("Delete StudentsData set DelMark=1 where StudID=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('student-form.aspx', 2000);", true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnDelete_Click", ex.Message.ToString());
            return;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("student-form.aspx");
    }

    protected void ddlstate_SelectedIndexChanged1(object sender, EventArgs e)
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
