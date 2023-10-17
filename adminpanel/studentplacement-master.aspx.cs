using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_studentplacement : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, rootPath, placstudPhoto;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add studentplacement" : "Edit studentplacement";
            btnSave.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");
            btnDelete.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnDelete, null) + ";");
            btnCancel.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnCancel, null) + ";");

            if (!IsPostBack)
            {
                if (Request.QueryString["action"] != null)
                {
                    editinfo.Visible = true;
                    viewinfo.Visible = false;

                    if (Request.QueryString["action"] == "new")
                    {
                        btnSave.Text = "Save Info";
                        btnDelete.Visible = false;
                        txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        btnSave.Text = "Modify Info";
                        btnDelete.Visible = true;
                        GetData(Convert.ToInt32(Request.QueryString["id"]));
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
            using (DataTable dtdoc = c.GetDataTable("Select StudPlcId, Convert(varchar(20), StudPlcDate, 103) as StudPlcDate, StudPlcStudentName, StudPlcCompanyName, StudPlcJobPost From StudentPlacement Order By StudPlcId DESC"))
            {
                gvstudplacement.DataSource = dtdoc;
                gvstudplacement.DataBind();

                if (dtdoc.Rows.Count > 0)
                {
                    gvstudplacement.UseAccessibleHeader = true;
                    gvstudplacement.HeaderRow.TableSection = TableRowSection.TableHeader;


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

    public void GetData(int placIdx)
    {
        try
        {
            using (DataTable dtplac = c.GetDataTable("select * from StudentPlacement where StudPlcId=" + placIdx))
            {
                if (dtplac.Rows.Count > 0)
                {
                    DataRow row = dtplac.Rows[0];
                    lblId.Text = placIdx.ToString();
                    txtDate.Text = Convert.ToDateTime(row["StudPlcDate"]).ToString("dd/MM/yyyy");
                    txtstudplcname.Text = row["StudPlcStudentName"].ToString();
                    txtcoursename.Text = row["StudPlcCourseName"].ToString();
                    txtcompanyname.Text = row["StudPlcCompanyName"].ToString();
                    txtjobpost.Text = row["StudPlcJobPost"].ToString();
                    txtplccountry.Text = row["StudPlcCountry"].ToString();

                    if (row["StudPlcStudentPhoto"] != DBNull.Value && row["StudPlcStudentPhoto"] != null && row["StudPlcStudentPhoto"].ToString() != "" && row["StudPlcStudentPhoto"].ToString() != "no-photo.png")
                    {
                        placstudPhoto = "<img src=\"" + Master.rootPath + "upload/studphoto/" + row["StudPlcStudentPhoto"].ToString() + "\" width=\"200\" />";
                        btnRemove.Visible = true;
                    }
                    else
                    {
                        btnRemove.Visible = false;
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

    private void ImageUploadProcess(string placstudPhoto)
    {
        try
        {

            string origImgPath = "~/upload/studphoto/original/";
            //string thumbImgPath = "~/upload/news/thumb/";
            string normalImgPath = "~/upload/studphoto/";

            fileuploadphoto.SaveAs(Server.MapPath(origImgPath) + placstudPhoto);
            c.ImageOptimizer(placstudPhoto, origImgPath, normalImgPath, 800, true);
            //c.ImageOptimizer(nwsPhoto, normalImgPath, thumbImgPath, 480, true);


            //Delete rew image from server
            File.Delete(Server.MapPath(origImgPath) + placstudPhoto);

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "ImageUploadProcess", ex.Message.ToString());
            return;
        }
    }
    protected void gvstudplacement_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"studentplacement-master.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvstudplacement_RowDataBound", ex.Message.ToString());
            return;
        }
    }


    protected void btnRemove_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("Update StudentPlacement set StudPlcStudentPhoto='no-photo.png' where StudPlcId=" + Request.QueryString["id"]);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Photo Removed');", true);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('studentplacement-master.aspx', 2000);", true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnRemove_Click", ex.Message.ToString());
            return;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            GetAllControls(this.Controls);
            //Empty Validations
            if (txtDate.Text == "" || txtstudplcname.Text == "" || txtcoursename.Text == "" || txtcompanyname.Text == "" || txtjobpost.Text == "" || txtplccountry.Text == "" )
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }

            //Insert Update data
            int maxId = lblId.Text == "[New]" ? c.NextId("StudentPlacement", "StudPlcId") : Convert.ToInt32(lblId.Text);

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


            string placstudPhoto = "";
            if (fileuploadphoto.HasFile)
            {
                string fExt = Path.GetExtension(fileuploadphoto.FileName).ToString().ToLower();

                if (fExt == ".jpg" || fExt == ".jpeg" || fExt == ".png" || fExt == ".pdf")
                {
                    placstudPhoto = "stud-photo-" + maxId + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                    ImageUploadProcess(placstudPhoto);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only .jpg, .jpeg .png .pdf  or  files are allowed');", true);
                    return;

                }
            }

            if (lblId.Text == "[New]")
            {
                c.ExecuteQuery("Insert into StudentPlacement(StudPlcId, StudPlcDate, StudPlcStudentName, StudPlcCourseName, StudPlcCompanyName, StudPlcJobPost, StudPlcCountry) Values (" + maxId + ", '" + appDate + "','" + txtstudplcname.Text + "', '" + txtcoursename.Text + "','" + txtcompanyname.Text + "','" + txtjobpost.Text + "','" + txtplccountry.Text + "')");
                if (fileuploadphoto.HasFile)
                {
                    c.ExecuteQuery("Update StudentPlacement Set StudPlcStudentPhoto='" + placstudPhoto + "' where StudPlcId=" + maxId + "");
                }

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'StudentPlacement  Added');", true);
            }

            else
            {
                c.ExecuteQuery("Update StudentPlacement set StudPlcDate='" + appDate + "', StudPlcStudentName='" + txtstudplcname.Text + "', StudPlcCourseName='" + txtcoursename.Text + "',StudPlcCompanyName='" + txtcompanyname.Text + "',StudPlcJobPost='" + txtjobpost.Text + "',StudPlcCountry='" + txtplccountry.Text + "'  where StudPlcId=" + maxId);

                if (fileuploadphoto.HasFile)
                {
                    c.ExecuteQuery("Update StudentPlacement Set StudPlcStudentPhoto='" + placstudPhoto + "' where StudPlcId=" + maxId + "");
                }

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'StudentPlacement  Updated');", true);
            }
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('studentplacement-master.aspx', 2000);", true);

            txtDate.Text = txtstudplcname.Text = txtcoursename.Text = txtcompanyname.Text = txtjobpost.Text = txtplccountry.Text = "";
            fileuploadphoto.Visible = false;

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSave_Click", ex.Message.ToString());
            return;
        }
    
}

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("Delete StudentPlacement where StudPlcId=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('news-master.aspx', 2000);", true);
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
        Response.Redirect("studentplacement-master.aspx");
    }
}