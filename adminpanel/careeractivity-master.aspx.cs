using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_careeractivity : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, rootPath;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add CareerActivities" : "Edit CareerActivities";
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
                        //btnRemove.Visible = false;
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

                //c.FillComboBox("EventCategory", "EventCatId", "EventsGalleryCategory", "DelMark=0", "EventCategory", 0, ddrevntcat);
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
            using (DataTable dtNws = c.GetDataTable("Select CarActId, Convert(varchar(20), CarActDate, 103) as CarActDate, CarActTitle, ViewsCount From CareerActivity Order By CarActDate DESC"))
            {
                gvcareer.DataSource = dtNws;
                gvcareer.DataBind();

                if (dtNws.Rows.Count > 0)
                {
                    gvcareer.UseAccessibleHeader = true;
                    gvcareer.HeaderRow.TableSection = TableRowSection.TableHeader;
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
            using (DataTable dtcar = c.GetDataTable("select * from CareerActivity where CarActId=" + caractIdx))
            {
                if (dtcar.Rows.Count > 0)
                {
                    DataRow row = dtcar.Rows[0];
                    lblId.Text = caractIdx.ToString();

                    txtcaractTitle.Text = row["CarActTitle"].ToString();
                    txtcaractDesc.Text = row["CarActDescription"].ToString();
                    //ddrevntcat.SelectedValue = row["FK_EventCatId"].ToString();

                    txtDate.Text = Convert.ToDateTime(row["CarActDate"]).ToString("dd/MM/yyyy");

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
            if (txtcaractTitle.Text == "" || txtcaractDesc.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }

            //Insert Update data
            int maxId = lblId.Text == "[New]" ? c.NextId("CareerActivity", "CarActId") : Convert.ToInt32(lblId.Text);

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


            if (lblId.Text == "[New]")
            {
                c.ExecuteQuery("Insert into CareerActivity (CarActId, CarActDate,FK_CenterID, CarActTitle, CarActDescription, ViewsCount) Values (" + maxId + ",  '" + appDate + "', '" + Session["centerMaster"] + "','" + txtcaractTitle.Text + "', '" + txtcaractDesc.Text + "',0)");

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Career Activity Added');", true);
            }
            else
            {
                c.ExecuteQuery("Update CareerActivity set CarActId=" + maxId + ", CarActDate = '" + appDate + "', FK_CenterId='" + Session["centerMaster"] + "', CarActTitle='" + txtcaractTitle.Text + "', CarActDescription='" + txtcaractDesc.Text + "' where CarActId=" + maxId);

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Career Activity Updated');", true);
            }

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('careeractivity-master.aspx', 2000);", true);

            //clear all
            txtcaractTitle.Text = txtcaractDesc.Text = "";
            

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
            c.ExecuteQuery("Delete CareerActivity where CarActId=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Careeractivity Data Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('careeractivity-master.aspx', 2000);", true);
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
        Response.Redirect("careeractivity-master.aspx");
    }


    protected void gvcareer_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"careeractivity-master.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";


                Literal litAnchphto = new Literal();
                litAnchphto = (Literal)e.Row.FindControl("litAnchphto");
                litAnchphto.Text = "<a href=\"add-career-photo.aspx?albumId=" + e.Row.Cells[0].Text + "\" class=\"addPhoto\" title=\"Add Photos \"></a>";

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvcareer_RowDataBound", ex.Message.ToString());
            return;
        }
    }
}