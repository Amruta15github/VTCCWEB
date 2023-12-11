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
    public string rootPath, centerlogo, centerphoto;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
          
            btnsavelogo.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnsavelogo, null) + ";");
           
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
                        centerlogo = "<a href=\"" + Master.rootPath + "upload/centerlogo/" + row["CenterLogo"].ToString() + "\" width=\"200\"target=\"_blank/>View logo</a>";

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
}