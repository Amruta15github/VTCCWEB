using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class centers_doc_upload : System.Web.UI.Page
{
    iClass c = new iClass();
    public string rootPath, centerlogo;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //pgTitle = Request.QueryString["action"] == "new" ? "Add TieUps" : "Edit TieUps";
            //btnSave.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");
            //btnDelete.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnDelete, null) + ";");
            //btnCancel.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnCancel, null) + ";");

            if (!IsPostBack)
            {
                if (Request.QueryString["action"] != null)
                {
                    //editinfo.Visible = true;
                    //viewinfo.Visible = false;

                    if (Request.QueryString["action"] == "new")
                    {
                        //btnSave.Text = "Save Info";
                        //btnDelete.Visible = false;
                        //btnRemove.Visible = false;
                    }
                    else
                    {
                        //btnSave.Text = "Modify Info";
                        //btnDelete.Visible = true;
                        GetData(Convert.ToInt32(Request.QueryString["id"]));
                    }
                }
                else
                {
                    //editinfo.Visible = false;
                    //viewinfo.Visible = true;
                    //FillGrid();
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

    public void GetData(int TieupiIdx)
    {
        try
        {
            using (DataTable dtcenter = c.GetDataTable("select * from CentersData where CenterID=" + TieupiIdx))
            {
                if (dtcenter.Rows.Count > 0)
                {
                    DataRow row = dtcenter.Rows[0];
                    lblId.Text = TieupiIdx.ToString();

                    if (row["CenterLogo"] != DBNull.Value && row["CenterLogo"] != null && row["CenterLogo"].ToString() != "" && row["CenterLogo"].ToString() != "no-photo.png")
                    {
                        centerlogo = "<a href=\"" + Master.rootPath + "upload/centerlogo/thumb/" + row["CenterLogo"].ToString() + "\" width=\"200\"target=\"_blank/>View logo</a>";

                    }

                    ////viewcerti
                    //if (row["TieUpCertificate"] != DBNull.Value && row["TieUpCertificate"] != null && row["TieUpCertificate"].ToString() != "" && row["TieUpCertificate"].ToString() != "no-photo.png")
                    //{

                    //    tieupcerti = "<a href=\"" + Master.rootPath + "upload/tieupcerti/" + row["TieUpCertificate"].ToString() + "\"width=\"200\" \" target=\"_blank\">View Document</a>";
                    //    //btnRemove.Visible = true;
                    //}
                    //else
                    //{
                    //    //btnRemove.Visible = false;
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

    private void ImageUploadProcess(string centerlogo)
    {
        try
        {

            string origImgPath = "~/upload/centerlogo/original/";
            string thumbImgPath = "~/upload/centerlogo/thumb/";
            string normalImgPath = "~/upload/centerlogo/";

            fulogo.SaveAs(Server.MapPath(origImgPath) + centerlogo);
            c.ImageOptimizer(centerlogo, origImgPath, normalImgPath, 800, true);
            c.ImageOptimizer(centerlogo, normalImgPath, thumbImgPath, 480, true);


            //Delete row image from server
            File.Delete(Server.MapPath(origImgPath) + centerlogo);

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "ImageUploadProcess", ex.Message.ToString());
            return;
        }
    }

    //protected void btnSave_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        int maxId = lblId.Text == "[New]" ? c.NextId("CentersData", "CenterID") : Convert.ToInt32(lblId.Text);

    //        string centerlogo = "";
    //        if (fulogo.HasFile)
    //        {
    //            string fExt = Path.GetExtension(fulogo.FileName).ToString().ToLower();

    //            if (fExt == ".jpeg" || fExt == ".png")
    //            {
    //                centerlogo = "center-logo-" + maxId + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
    //                ImageUploadProcess(centerlogo);

    //                fulogo.SaveAs(Server.MapPath("~/upload/centerlogo/") + centerlogo);

    //            }
    //            else
    //            {
    //                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .png files are allowed');", true);
    //                return;

    //            }
    //        }

    //        else if (lblId.Text == "[New]")
    //        {

    //            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Select Logo to upload');", true);
    //            return;

    //        }

    //        //string tieupcerti = "";
    //        //if (fucertificate.HasFile)
    //        //{
    //        //    string fExt = Path.GetExtension(fucertificate.FileName).ToString().ToLower();

    //        //    if (fExt == ".jpeg" || fExt == ".pdf")
    //        //    {
    //        //        tieupcerti = "tieup-certi-" + maxId + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;

    //        //        fucertificate.SaveAs(Server.MapPath("~/upload/tieupcerti/") + tieupcerti);
    //        //    }
    //        //    else
    //        //    {
    //        //        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .pdf files are allowed');", true);
    //        //        return;

    //        //    }
    //        //}

    //        //Insert Update data
    //        if (lblId.Text == "[New]")
    //        {
    //            c.ExecuteQuery("Insert into CentersData (CenterID, CenterLogo, delMark) Values (" + maxId + ",'" + centerlogo + "',0)");

    //            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Document  Added');", true);
    //        }
    //        //else
    //        //{
    //            //c.ExecuteQuery("Update TieUpData set  TieUpTitle='" + txttieuptitle.Text + "', TieUpIntro='" + txtintro.Text + "' where TieUpID=" + maxId);

    //           else if (fulogo.HasFile)
    //            {
    //                c.ExecuteQuery("Update CentersData Set CenterLogo='" + centerlogo + "' where CenterID=" + maxId + "");
    //            }

    //            //if (fucertificate.HasFile)
    //            //{
    //            //    c.ExecuteQuery("Update TieUpData Set TieUpCertificate='" + tieupcerti + "' where TieUpID=" + maxId + "");
    //            //}

    //            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Document  Updated');", true);
    //        //}

    //        ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('doc-upload.aspx', 2000);", true);



    //    }
    //    catch (Exception ex)
    //    {
    //        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
    //        c.ErrorLogHandler(this.ToString(), "btnSave_Click", ex.Message.ToString());
    //        return;
    //    }
    //}

    //protected void btnDelete_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        c.ExecuteQuery("update CentersData set DelMark=1 where CenterID=" + Request.QueryString["id"]);
    //        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Document Deleted');", true);
    //        ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('doc-upload.aspx', 2000);", true);
    //    }
    //    catch (Exception ex)
    //    {
    //        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
    //        c.ErrorLogHandler(this.ToString(), "btnDelete_Click", ex.Message.ToString());
    //        return;
    //    }
    //}

    //protected void btnCancel_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("doc-upload.aspx");
    //}



    protected void btnsavelogo_Click(object sender, EventArgs e)
    {
        try
        {
            int maxId = lblId.Text == "[New]" ? c.NextId("CentersData", "CenterID") : Convert.ToInt32(lblId.Text);

            string centerlogo = "";
            if (fulogo.HasFile)
            {
                string fExt = Path.GetExtension(fulogo.FileName).ToString().ToLower();

                if (fExt == ".jpeg" || fExt == ".png")
                {
                    centerlogo = "center-logo-" + maxId + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                    ImageUploadProcess(centerlogo);

                    fulogo.SaveAs(Server.MapPath("~/upload/centerlogo/") + centerlogo);

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .png files are allowed');", true);
                    return;

                }
            }

            else if (lblId.Text == "[New]")
            {

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Select Logo to upload');", true);
                return;

            }

            //Insert Update data
            if (lblId.Text == "[New]")
            {
                c.ExecuteQuery("Insert into CentersData (CenterID, CenterLogo, delMark) Values (" + maxId + ",'" + centerlogo + "',0)");

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Center Logo Added');", true);
            }
           
            else if (fulogo.HasFile)
            {
                c.ExecuteQuery("Update CentersData Set CenterLogo='" + centerlogo + "' where CenterID=" + maxId + "");
            }

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Center Logo  Updated');", true);
           
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), " btnsavelogo_Click", ex.Message.ToString());
            return;
        }
    }
}