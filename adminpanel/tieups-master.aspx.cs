using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_tieups_master : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, tieuplogo, rootPath, tieupcerti;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add TieUps" : "Edit TieUps";
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
                        btnRemove.Visible = false;
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

        //txtintro.Attributes.Add("maxlength", "200");
    }

    private void FillGrid()
    {
        try
        {
            using (DataTable dttieup = c.GetDataTable("Select TieUpID, TieUpTitle from TieUpData Where DelMark=0  Order By TieUpID DESC"))
            {
                gvtieups.DataSource = dttieup;
                gvtieups.DataBind();

                if (dttieup.Rows.Count > 0)
                {
                    gvtieups.UseAccessibleHeader = true;
                    gvtieups.HeaderRow.TableSection = TableRowSection.TableHeader;
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
    protected void gvtieups_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"tieups-master.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvtieups_RowDataBound", ex.Message.ToString());
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

    public void GetData(int TieupiIdx)
    {
        try
        {
            using (DataTable dttesti = c.GetDataTable("select * from TieUpData where TieUpID=" + TieupiIdx))
            {
                if (dttesti.Rows.Count > 0)
                {
                    DataRow row = dttesti.Rows[0];
                    lblId.Text = TieupiIdx.ToString();

                    txttieuptitle.Text = row["TieUpTitle"].ToString();
                    txtintro.Text = row["TieUpIntro"].ToString();

                    if (row["TieUpLogo"] != DBNull.Value && row["TieUpLogo"] != null && row["TieUpLogo"].ToString() != "" && row["TieUpLogo"].ToString() != "no-photo.png")
                    {
                        tieuplogo = "<img src=\"" + Master.rootPath + "upload/tieuplogo/" + row["TieUpLogo"].ToString() + "\" width=\"200\" />";
                       
                    }
                                      
                    //viewcerti
                    if (row["TieUpCertificate"] != DBNull.Value && row["TieUpCertificate"] != null && row["TieUpCertificate"].ToString() != "" && row["TieUpCertificate"].ToString() != "no-photo.png")
                    {

                        tieupcerti = "<a href=\"" + Master.rootPath + "upload/tieupcerti/" + row["TieUpCertificate"].ToString() + "\"width=\"200\" \" target=\"_blank\">View Document</a>";
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

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            GetAllControls(this.Controls);
            //Empty Validations
            if (txttieuptitle.Text == "" || txtintro.Text == ""  )
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * marked fields are mandatory');", true);
                return;
            }

            int maxId = lblId.Text == "[New]" ? c.NextId("TieUpData", "TieUpID") : Convert.ToInt32(lblId.Text);

            string tieuplogo = "";
            if (fulogo.HasFile)
            {
                string fExt = Path.GetExtension(fulogo.FileName).ToString().ToLower();

                if (fExt == ".jpeg" || fExt == ".png" || fExt == ".jpg")
                {
                    tieuplogo = "tieup-logo-" + maxId + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                   
                    fulogo.SaveAs(Server.MapPath("~/upload/tieuplogo/") + tieuplogo);
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

            string tieupcerti = "";
            if (fucertificate.HasFile)
            {
                string fExt = Path.GetExtension(fucertificate.FileName).ToString().ToLower();

                if (fExt == ".jpeg" || fExt == ".pdf")
                {
                    tieupcerti = "tieup-certi-" + maxId + DateTime.Now.ToString("ddMMyyyyHHmmss") + fExt;
                   
                    fucertificate.SaveAs(Server.MapPath("~/upload/tieupcerti/") + tieupcerti);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only  .jpeg .pdf files are allowed');", true);
                    return;

                }
            }

            //Insert Update data
            if (lblId.Text == "[New]")
            {
                c.ExecuteQuery("Insert into TieUpData (TieUpID, TieUpTitle, TieUpIntro, TieUpLogo, TieUpCertificate, delMark)Values(" + maxId + ",'" + txttieuptitle.Text + "', '" + txtintro.Text + "', '" + tieuplogo + "', '" + tieupcerti + "',0)");

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Tie-Ups  Added');", true);
            }
            else
            {
                c.ExecuteQuery("Update TieUpData set  TieUpTitle='" + txttieuptitle.Text + "', TieUpIntro='" + txtintro.Text + "' where TieUpID=" + maxId);

                if (fulogo.HasFile)
                {
                    c.ExecuteQuery("Update TieUpData Set TieUpLogo='" + tieuplogo + "' where TieUpID=" + maxId + "");
                }

                if (fucertificate.HasFile)
                {
                    c.ExecuteQuery("Update TieUpData Set TieUpCertificate='" + tieupcerti + "' where TieUpID=" + maxId + "");
                }

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Tie-Ups  Updated');", true);
            }

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('tieups-master.aspx', 2000);", true);

           

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
            c.ExecuteQuery("update TieUpData set DelMark=1 where TieUpID=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Tie-Ups Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('tieups-master.aspx', 2000);", true);
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
        Response.Redirect("tieups-master.aspx");
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        try
        {
            c.ExecuteQuery("Update TieUpData set TieUpCertificate='no-photo.png' where TieUpID=" + Request.QueryString["id"]);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Certificate Removed');", true);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('tieups-master.aspx', 2000);", true);
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnRemove_Click", ex.Message.ToString());
            return;
        }
    }
}