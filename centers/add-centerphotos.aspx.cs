using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class centers_add_centerphotos : System.Web.UI.Page
{
    iClass c = new iClass();
    public string rootPath, pgTitle, centerphoto;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add Center Photos" : "Edit Center Photos";
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
                       
                        //btnRemove.Visible = false;
                    }
                    else
                    {
                        btnSave.Text = "Modify Info";
                        btnDelete.Visible = true;                     
                       
                    }
                }
                else
                {
                    editinfo.Visible = false;
                    viewinfo.Visible = true;
                    FillGrid();
                }

                GetData(Convert.ToInt32(Session["centerMaster"]));
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
            using (DataTable dtphoto = c.GetDataTable("Select CentPhotoId, CentPhotoTitle From CenterPhotos where FK_CenterID= " + Session["centerMaster"] +" Order By CentPhotoId DESC "))

            {
                gvphotos.DataSource = dtphoto;
                gvphotos.DataBind();

                if (dtphoto.Rows.Count > 0)
                {
                    gvphotos.UseAccessibleHeader = true;
                    gvphotos.HeaderRow.TableSection = TableRowSection.TableHeader;
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

    public void GetData(int caractIdx)
    {
        try
        {
            using (DataTable dtcar = c.GetDataTable("select * from CenterPhotos where CentPhotoId=" + caractIdx))
            {
                if (dtcar.Rows.Count > 0)
                {
                    DataRow row = dtcar.Rows[0];
                    lblId.Text = caractIdx.ToString();

                    txttitle.Text = row["CentPhotoTitle"].ToString();

                    if (row["CentPhotoFile"] != DBNull.Value && row["CentPhotoFile"] != null && row["CentPhotoFile"].ToString() != "" && row["CentPhotoFile"].ToString() != "no-photo.png")
                    {
                        string fileExtension = Path.GetExtension(row["CentPhotoFile"].ToString()).ToLower();

                        if (fileExtension == ".pdf")
                        {
                            centerphoto = "<a href=\"" + Master.rootPath + "upload/centerphotos/thumb/" + row["CentPhotoFile"].ToString() + "\" target=\"_blank\">View Document</a>";
                        }
                        else
                        {
                            centerphoto = "<img src=\"" + Master.rootPath + "upload/centerphotos/thumb/" + row["CentPhotoFile"].ToString() + "\" width=\"200\" />";
                        }
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
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {

            GetAllControls(this.Controls);
            //Empty Validations
            if (txttitle.Text == "" )
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }
            //Insert Update data
            int maxId = lblId.Text == "[New]" ? c.NextId("CenterPhotos", "CentPhotoId") : Convert.ToInt32(lblId.Text);

            if (Session["centerMaster"] != null)
            {
                int centerID = Convert.ToInt32(Session["centerMaster"]);

                string centerphoto = "";
                if (fuImage.HasFile)
                {
                    string fExt = Path.GetExtension(fuImage.FileName).ToString().ToLower();

                    if (fExt == ".jpeg" || fExt == ".png" || fExt == ".pdf" || fExt == ".jpg")
                    {
                        centerphoto = "center-photo-" + Session["centerMaster"].ToString() + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                        fuImage.SaveAs(Server.MapPath("~/upload/centerphotos/thumb/") + centerphoto);
                        ImageUploadProcess(centerphoto);

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .png .pdf .jpg files are allowed');", true);
                        return;

                    }

                }
                else
                {
                    if (lblId.Text == "[New]")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Select Photos to upload');", true);
                        return;
                    }
                }



                if (lblId.Text == "[New]")
                {
                    c.ExecuteQuery("Insert into CenterPhotos(CentPhotoId, FK_CenterID, CentPhotoTitle, CentPhotoFile ) Values (" + maxId + ",'" + Session["centerMaster"] + "', '" + txttitle.Text + "', '" + centerphoto + "')");
                   

                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Center Photo Added');", true);
                }

                else
                {
                    c.ExecuteQuery("Update CenterPhotos set  CentPhotoTitle='" + txttitle.Text + "'  where CentPhotoId=" + maxId);

                    if (fuImage.HasFile)
                    {
                        c.ExecuteQuery("Update CenterPhotos Set CentPhotoFile='" + centerphoto + "' where CentPhotoId=" + maxId + "");
                    }


                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Center Photo  Updated');", true);
                }
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('add-centerphotos.aspx', 2000);", true);

                txttitle.Text = ""; //clear


            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSave_Click", ex.Message.ToString());
            return;
        }
    }



    protected void gvphotos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"add-centerphotos.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";


                //Literal litAnchphto = new Literal();
                //litAnchphto = (Literal)e.Row.FindControl("litAnchphto");
                //litAnchphto.Text = "<a href=\"add-centerphotos.aspx?albumId=" + e.Row.Cells[0].Text + "\" class=\"addPhoto\" title=\"Add Photos \"></a>";

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvcareer_RowDataBound", ex.Message.ToString());
            return;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("Delete CenterPhotos where CentPhotoId=" + Session["centerMaster"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Center Photos Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('add-centerphotos.aspx', 2000);", true);
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
        Response.Redirect("add-centerphotos.aspx");
    }
    private void ImageUploadProcess(string centerphoto)
    {
        try
        {

            string origImgPath = "~/upload/centerphotos/original/";
            string thumbImgPath = "~/upload/centerphotos/thumb/";
            string normalImgPath = "~/upload/centerphotos/";

            fuImage.SaveAs(Server.MapPath(origImgPath) + centerphoto);
            c.ImageOptimizer(centerphoto, origImgPath, normalImgPath, 800, true);
            c.ImageOptimizer(centerphoto, normalImgPath, thumbImgPath, 480, true);


            //Delete rew image from server
            File.Delete(Server.MapPath(origImgPath) + centerphoto);

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "ImageUploadProcess", ex.Message.ToString());
            return;
        }
    }
}
