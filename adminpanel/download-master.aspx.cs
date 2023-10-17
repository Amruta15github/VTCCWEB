using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_download_master : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, rootPath, docfile;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add Document" : "Edit Document";
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
            using (DataTable dtdoc = c.GetDataTable("Select DocId, DocName, DocLink, DocSize, DownCount From Downloads Order By DocId DESC"))
            {
                gvDocument.DataSource = dtdoc;
                gvDocument.DataBind();

                if (dtdoc.Rows.Count > 0)
                {
                    gvDocument.UseAccessibleHeader = true;
                    gvDocument.HeaderRow.TableSection = TableRowSection.TableHeader;


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

    public void GetData(int docIdx)
    {
        try
        {
            using (DataTable dtdoc = c.GetDataTable("select * from Downloads where DocId=" + docIdx))
            {
                if (dtdoc.Rows.Count > 0)
                {
                    DataRow row = dtdoc.Rows[0];
                    lblId.Text = docIdx.ToString();
                    txtdocname.Text = row["DocName"].ToString();
                    txtdocsize.Text = row["DocSize"].ToString();
                    ddldoctype.SelectedValue = row["DocType"].ToString();
                    txtdocDesc.Text = row["DocDescription"].ToString();

                    //doclink
                    if (row["DocLink"] != DBNull.Value && row["DocLink"] != null && row["DocLink"].ToString() != "" && row["DocLink"].ToString() != "no-doc.pdf")
                    {
                        docfile = "<a href=\"" + Master.rootPath + "downloads/" + row["DocLink"].ToString() + "\" width=\"200\" /></a>";
                        
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

    protected void gvDocument_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"download-master.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";

                Literal litanchdoc = (Literal)e.Row.FindControl("litanchdoc");

                DataRowView rowView = (DataRowView)e.Row.DataItem;
                if (rowView != null)
                {
                    string docLink = rowView["DocLink"].ToString();
                    string docId = e.Row.Cells[1].Text;
                   
                    litanchdoc.Text = "<a href=\"" + Master.rootPath + "downloads/" + rowView["DocLink"].ToString() + "\"width=\"200\" \"download-master.aspx?action=edit&id=" + e.Row.Cells[1].Text + "\" target=\"_blank\"class=\"pdfLink\" title=\"View/Pdf\"></a>";

                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvDocument_RowDataBound", ex.Message.ToString());
            return;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            GetAllControls(this.Controls);

            //Empty Validations
            if (txtdocname.Text == "" || txtdocsize.Text == "" || ddldoctype.SelectedValue=="")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All Fields are mandatory');", true);
                return;
            }

            int maxId = lblId.Text == "[New]" ? c.NextId("Downloads", "DocId") : Convert.ToInt32(lblId.Text);

            //fileuploadDoc

            string fileName = "";
            
            if (fileuploaddoc.HasFile)
            {
                string extension = System.IO.Path.GetExtension(fileuploaddoc.FileName);
                string fExt = Path.GetExtension(fileuploaddoc.FileName).ToString().ToLower();
                if (fExt == ".jpg" || fExt == ".png" || fExt == ".jpeg" || fExt == ".gif" || fExt ==".pdf")
                {
                    fileName = "document-file" + maxId + fExt;
                    //fileName = fileuploaddoc.FileName.ToString();
                    fileuploaddoc.SaveAs(Server.MapPath("~/downloads/") + fileName);

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Only .jpg, .png, .jpeg ,.gif and .pdf files are allowed');", true);
                    return;
                }
            }

            else
            {
                if (lblId.Text == "[New]")
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Select Document to upload');", true);
                    return;
                }
            }



            //Insert Update data
            if (lblId.Text == "[New]")
            {
                c.ExecuteQuery("Insert into Downloads(DocId, DocName, DocLink, DocSize, DocType, DocDescription, DownCount) Values (" + maxId + ",  '" + txtdocname.Text + "','" + fileName + "','" + txtdocsize.Text + "'," + ddldoctype.SelectedValue + ",'" + txtdocDesc.Text + "',0)");

               
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Document Added');", true);
            }
            else
            {
                c.ExecuteQuery("Update Downloads set DocId=" + maxId + ",  DocName='" + txtdocname.Text + "',  DocSize='" + txtdocsize.Text + "', DocType= " + ddldoctype.SelectedValue + ", DocDescription= '" + txtdocDesc.Text + "' where DocId=" + maxId);

                if (fileuploaddoc.HasFile)
                {
                    c.ExecuteQuery("Update Downloads Set DocLink='" + fileName + "' where DocId=" + maxId + "");
                }

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Document Updated');", true);
            }

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('download-master.aspx', 2000);", true);

            //clear all
            txtdocname.Text = txtdocsize.Text = txtdocDesc.Text = "";
            ddldoctype.SelectedIndex = 0;
            
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
            c.ExecuteQuery("Delete Downloads where DocId=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('download-master.aspx', 2000);", true);
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
        Response.Redirect("download-master.aspx");
    }
}