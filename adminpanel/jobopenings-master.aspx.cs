using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_jobopenings_master : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, rootPath;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add Jobopenings" : "Edit Jobopenings";
            btnSave.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");
            btnDelete.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnDelete, null) + ";");
            btnCancel.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnCancel, null) + ";");

            if (!IsPostBack)
            {
                c.FillComboBox("JobIndName", "JobIndId", "JobIndustries", "", "JobIndName", 0, ddljobind);

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
            using (DataTable dtjob = c.GetDataTable("Select JobId, Convert(varchar(20), JobDate, 103) as JobDate, JobTitle, JobExperience, JobViews From JobOpenings Order By JobDate DESC"))
            {
                gvjobopening.DataSource = dtjob;
                gvjobopening.DataBind();

                if (dtjob.Rows.Count > 0)
                {
                    gvjobopening.UseAccessibleHeader = true;
                    gvjobopening.HeaderRow.TableSection = TableRowSection.TableHeader;
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

    public void GetData(int jobIdx)
    {
        try
        {
            using (DataTable dtjob = c.GetDataTable("select * from JobOpenings where JobId=" + jobIdx))
            {
                if (dtjob.Rows.Count > 0)
                {
                    DataRow row = dtjob.Rows[0];
                    lblId.Text = jobIdx.ToString();
                    txtDate.Text = Convert.ToDateTime(row["JobDate"]).ToString("dd/MM/yyyy");
                    txtjobTitle.Text = row["JobTitle"].ToString();
                    txtjobinfo.Text = row["JobInform"].ToString();
                    txtskills.Text = row["JobSkills"].ToString();
                    ddljobind.SelectedValue = row["FK_JobIndId"].ToString();
                    txtexp.Text = row["JobExperience"].ToString();
                    ddljobtype.SelectedValue = row["JobType"].ToString();
                    txtjoburl.Text = row["JobUrl"].ToString();

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

    protected void gvjobopening_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"jobopenings-master.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvjobopening_RowDataBound", ex.Message.ToString());
            return;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            GetAllControls(this.Controls);
            //Empty Validations
            if ( txtjobTitle.Text == "" || txtjobinfo.Text == "" || txtskills.Text=="" || txtexp.Text=="" || ddljobind.SelectedValue=="")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }

            //Insert Update data
            int maxId = lblId.Text == "[New]" ? c.NextId("JobOpenings", "JobId") : Convert.ToInt32(lblId.Text);

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
                c.ExecuteQuery("Insert into JobOpenings (JobId, JobDate, JobTitle, JobInform, JobSkills, FK_JobIndId, JobExperience, JobType, JobViews, JobUrl) Values (" + maxId + ",  '" + appDate + "', '" + txtjobTitle.Text + "', '" + txtjobinfo.Text + "','" + txtskills.Text + "'," + ddljobind.SelectedValue + ",'" + txtexp.Text + "'," + ddljobtype.SelectedValue + ",0,'" + txtjoburl.Text + "')");

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Job Added');", true);
            }
            else
            {
                c.ExecuteQuery("Update JobOpenings set JobId=" + maxId + ", JobDate = '" + appDate + "', JobTitle='" + txtjobTitle.Text + "', JobInform='" + txtjobinfo.Text + "', JobSkills='" + txtskills.Text + "', FK_JobIndId= " + ddljobind.SelectedValue + ", JobExperience= '" + txtexp.Text + "', JobType= '" + ddljobtype.SelectedValue + "', JobUrl='" + txtjoburl.Text + "' where JobId=" + maxId);

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Job Updated');", true);
            }

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('jobopenings-master.aspx', 2000);", true);

            //clear all
            txtjobTitle.Text = txtjobinfo.Text = txtskills.Text = txtexp.Text = txtjoburl.Text= "";
            ddljobind.SelectedIndex = ddljobtype.SelectedIndex= 0;

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
            c.ExecuteQuery("Delete JobOpenings where JobId=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('jobopenings-master.aspx', 2000);", true);
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
        Response.Redirect("jobopenings-master.aspx");
    }
}