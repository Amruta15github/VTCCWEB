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
    public string rootPath, centerlogo, centerphoto,centeridproof, centereducerti, centerprofcourse;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
          
            btnsavelogo.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnsavelogo, null) + ";");
            btnownerphoto.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnownerphoto, null) + ";");
            btnidproof.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnidproof, null) + ";");
            btneducerti.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btneducerti, null) + ";");
            btnprofcourses.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnprofcourses, null) + ";");


            if (!IsPostBack)
            {

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

    public void GetData(int centerIdx)
    {
        try
        {
            using (DataTable dtcenter = c.GetDataTable("select * from CentersData where CenterID=" + centerIdx))
            {
                if (dtcenter.Rows.Count > 0)
                {
                    DataRow row = dtcenter.Rows[0];
                    lblId.Text = centerIdx.ToString();

                    if (row["CenterLogo"] != DBNull.Value && row["CenterLogo"] != null && row["CenterLogo"].ToString() != "" && row["CenterLogo"].ToString() != "no-photo.png")
                    {

                        centerlogo = "<a href=\"" + Master.rootPath + "upload/centerlogo/" + row["CenterLogo"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View logo </a>";
                       

                    }

                    if (row["CenterOwnerPhoto"] != DBNull.Value && row["CenterOwnerPhoto"] != null && row["CenterOwnerPhoto"].ToString() != "" && row["CenterOwnerPhoto"].ToString() != "no-photo.png")
                    {

                        centerphoto = "<a href=\"" + Master.rootPath + "upload/centerownerphoto/" + row["CenterOwnerPhoto"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View Owner Photo </a>";


                    }

                    if (row["CenterIDProof"] != DBNull.Value && row["CenterIDProof"] != null && row["CenterIDProof"].ToString() != "" && row["CenterIDProof"].ToString() != "no-photo.png")
                    {

                        centeridproof = "<a href=\"" + Master.rootPath + "upload/centeridproof/" + row["CenterIDProof"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View ID Proof </a>";


                    }

                    if (row["CenterEduCertificate"] != DBNull.Value && row["CenterEduCertificate"] != null && row["CenterEduCertificate"].ToString() != "" && row["CenterEduCertificate"].ToString() != "no-photo.png")
                    {

                        centereducerti = "<a href=\"" + Master.rootPath + "upload/centereducerti/" + row["CenterEduCertificate"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View Education Certificate </a>";


                    }

                    if (row["CenterProfCourse"] != DBNull.Value && row["CenterProfCourse"] != null && row["CenterProfCourse"].ToString() != "" && row["CenterProfCourse"].ToString() != "no-photo.png")
                    {

                        centerprofcourse = "<a href=\"" + Master.rootPath + "upload/centerprofcourse/" + row["CenterProfCourse"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View Professional Courses </a>";


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

   
    
    protected void btnsavelogo_Click(object sender, EventArgs e)
    {
        try
        {
          
            if (Session["centerMaster"] != null)
            {
                int centerID = Convert.ToInt32(Session["centerMaster"]);

                string centerlogo = "";
                if (fulogo.HasFile)
                {
                    string fExt = Path.GetExtension(fulogo.FileName).ToString().ToLower();

                    if (fExt == ".jpeg" || fExt == ".png" || fExt == ".pdf")
                    {
                        centerlogo = "center-logo-" + Session["centerMaster"].ToString() + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                        fulogo.SaveAs(Server.MapPath("~/upload/centerlogo/") + centerlogo);

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .png files are allowed');", true);
                        return;

                    }
                }

                else if (fulogo.HasFile == false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'please Select Logo Before Hitting Save Button');", true);
                    return;
                }

                c.ExecuteQuery("Update CentersData Set CenterLogo='" + centerlogo + "' where CenterID=" + Session["centerMaster"] );
                
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Center Logo  Updated');", true);

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), " btnsavelogo_Click", ex.Message.ToString());
            return;
        }
    }

    protected void btnownerphoto_Click(object sender, EventArgs e)
    {
        try
        {

            if (Session["centerMaster"] != null)
            {
                int centerID = Convert.ToInt32(Session["centerMaster"]);

                string centerphoto = "";
                if (fuownerphoto.HasFile)
                {
                    string fExt = Path.GetExtension(fuownerphoto.FileName).ToString().ToLower();

                    if (fExt == ".jpg" || fExt == ".jpeg" || fExt == ".png" || fExt == ".pdf")
                    {
                        centerphoto = "center-photo-" + Session["centerMaster"].ToString() + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                        fuownerphoto.SaveAs(Server.MapPath("~/upload/centerownerphoto/") + centerphoto);

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .jpg .pdf .png files are allowed');", true);
                        return;

                    }
                }

                else if (fuownerphoto.HasFile == false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'please Select OwnerPhoto Before Hitting Save Button');", true);
                    return;
                }

                c.ExecuteQuery("Update CentersData Set CenterOwnerPhoto='" + centerphoto + "' where CenterID=" + Session["centerMaster"]);

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Owner Photo  Updated');", true);

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), " btnownerphoto_Click", ex.Message.ToString());
            return;
        }
    }

    protected void btnidproof_Click(object sender, EventArgs e)
    {
        try
        {

            if (Session["centerMaster"] != null)
            {
                int centerID = Convert.ToInt32(Session["centerMaster"]);

                string centeridproof = "";
                if (fuid.HasFile)
                {
                    string fExt = Path.GetExtension(fuid.FileName).ToString().ToLower();

                    if (fExt == ".jpg" || fExt == ".jpeg" || fExt == ".png" || fExt == ".pdf")
                    {
                        centeridproof = "center-ID-" + Session["centerMaster"].ToString() + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                        fuid.SaveAs(Server.MapPath("~/upload/centeridproof/") + centeridproof);

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .jpg .pdf .png files are allowed');", true);
                        return;

                    }
                }

                else if (fuid.HasFile == false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'please Select IDproof Before Hitting Save Button');", true);
                    return;
                }

                c.ExecuteQuery("Update CentersData Set CenterIDProof='" + centeridproof + "' where CenterID=" + Session["centerMaster"]);

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'IDproof  Updated');", true);

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "  btnidproof_Click", ex.Message.ToString());
            return;
        }
    }

    protected void btneducerti_Click(object sender, EventArgs e)
    {
        try
        {

            if (Session["centerMaster"] != null)
            {
                int centerID = Convert.ToInt32(Session["centerMaster"]);

                string centereducerti = "";
                if (fueducerti.HasFile)
                {
                    string fExt = Path.GetExtension(fueducerti.FileName).ToString().ToLower();

                    if (fExt == ".jpg" || fExt == ".jpeg" || fExt == ".png" || fExt == ".pdf")
                    {
                        centereducerti = "center-certi-" + Session["centerMaster"].ToString() + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                        fueducerti.SaveAs(Server.MapPath("~/upload/centereducerti/") + centereducerti);

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .jpg .pdf .png files are allowed');", true);
                        return;

                    }
                }

                else if (fueducerti.HasFile == false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'please Select Education Certificate Before Hitting Save Button');", true);
                    return;
                }

                c.ExecuteQuery("Update CentersData Set CenterEduCertificate='" + centereducerti + "' where CenterID=" + Session["centerMaster"]);

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Education Certificate Updated');", true);

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), " btneducerti_Click", ex.Message.ToString());
            return;
        }
    }

    protected void btnprofcourses_Click(object sender, EventArgs e)
    {
        try
        {

            if (Session["centerMaster"] != null)
            {
                int centerID = Convert.ToInt32(Session["centerMaster"]);

                string centerprofcourse = "";
                if (fuprofcourses.HasFile)
                {
                    string fExt = Path.GetExtension(fuprofcourses.FileName).ToString().ToLower();

                    if (fExt == ".jpg" || fExt == ".jpeg" || fExt == ".png" || fExt == ".pdf")
                    {
                        centerprofcourse = "center-certi-" + Session["centerMaster"].ToString() + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                        fuprofcourses.SaveAs(Server.MapPath("~/upload/centerprofcourse/") + centerprofcourse);

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .jpg .pdf .png files are allowed');", true);
                        return;

                    }
                }

                else if (fuprofcourses.HasFile == false)
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'please Select Professional Course Before Hitting Save Button');", true);
                    return;
                }

                c.ExecuteQuery("Update CentersData Set CenterProfCourse='" + centerprofcourse + "' where CenterID=" + Session["centerMaster"]);

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Professional Course Updated');", true);

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), " btnprofcourses_Click", ex.Message.ToString());
            return;
        }
    }
}