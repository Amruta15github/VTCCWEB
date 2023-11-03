using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_certificate_data_entry : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, rootPath;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pgTitle = Request.QueryString["action"] == "new" ? "Add Certificate Data" : "Edit Certificate Data";
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
            using (DataTable dtjob = c.GetDataTable("Select CertID, Convert(varchar(20), CertUploadDate, 103) as CertUploadDate, CertNumber, CertStudentName, CertCenterName From CertificateData Order By CertUploadDate DESC"))
            {
                gvcertdata.DataSource = dtjob;
                gvcertdata.DataBind();

                if (dtjob.Rows.Count > 0)
                {
                    gvcertdata.UseAccessibleHeader = true;
                    gvcertdata.HeaderRow.TableSection = TableRowSection.TableHeader;
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
    public void GetData(int certIdx)
    {
        try
        {
            using (DataTable dtcert = c.GetDataTable("select * from CertificateData where CertID=" + certIdx))
            {
                if (dtcert.Rows.Count > 0)
                {
                    DataRow row = dtcert.Rows[0];
                    lblId.Text = certIdx.ToString();
                  
                    txtcertnumber.Text = row["CertNumber"].ToString();
                    txtcoursename.Text = row["CertCourseName"].ToString();
                    txtduration.Text = row["CertDuration"].ToString();
                    txtavgmarks.Text = row["CertAvgMarks"].ToString();
                    txtgrade.Text = row["CertGrade"].ToString();
                    txtexammon.Text = Convert.ToDateTime(row["CertExamMonth"]).ToString("dd/MM/yyyy");
                    txtissuedate.Text = Convert.ToDateTime(row["CertIssueDate"]).ToString("dd/MM/yyyy");
                    txtstudname.Text = row["CertStudentName"].ToString();
                    txtcentername.Text = row["CertCenterName"].ToString();
                    txtfromdate.Text = Convert.ToDateTime(row["CertFromDate"]).ToString("dd/MM/yyyy");
                    txttodate.Text = Convert.ToDateTime(row["CertToDate"]).ToString("dd/MM/yyyy");
                    txtstudregdate.Text = Convert.ToDateTime(row["CertStudentRegDate"]).ToString("dd/MM/yyyy");
                    txtcertplace.Text = row["CertPlace"].ToString();
                    txtcenterno.Text = row["CertCenterNo"].ToString();

                    
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

    protected void gvcertdata_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"certificate-data-entry.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gAnch\" title=\"View/Edit\"></a>";

                
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvcertdata_RowDataBound", ex.Message.ToString());
            return;
        }
    }
   

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            GetAllControls(this.Controls);
            //Empty Validations
            if (txtcertnumber.Text == "" || txtcoursename.Text == "" || txtduration.Text == "" || txtavgmarks.Text == "" || txtgrade.Text == "" || txtexammon.Text == "" || txtissuedate.Text == "" || txtstudname.Text == "" || txtcentername.Text == "" || txtfromdate.Text == "" || txttodate.Text == "" || txtstudregdate.Text == "" || txtcertplace.Text == "" || txtcenterno.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }

            //Insert Update data
            int maxId = lblId.Text == "[New]" ? c.NextId("CertificateData", "CertID") : Convert.ToInt32(lblId.Text);

            DateTime appDate = DateTime.Now;
            string[] arrDate = txtexammon.Text.Split('/');
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

            //2
            DateTime appDate1 = DateTime.Now;
            string[] arrDate1 = txtissuedate.Text.Split('/');
            if (c.IsDate(arrDate1[1] + "/" + arrDate1[0] + "/" + arrDate1[2]) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter Valid Date');", true);
                return;
            }
            else
            {
                appDate1 = Convert.ToDateTime(arrDate1[1] + "/" + arrDate1[0] + "/" + arrDate1[2]);
            }
            DateTime cDate1 = DateTime.Now;
            string currentDate1 = cDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //3
            DateTime appDate2 = DateTime.Now;
            string[] arrDate2= txtfromdate.Text.Split('/');
            if (c.IsDate(arrDate2[1] + "/" + arrDate2[0] + "/" + arrDate2[2]) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter Valid Date');", true);
                return;
            }
            else
            {
                appDate2 = Convert.ToDateTime(arrDate2[1] + "/" + arrDate2[0] + "/" + arrDate2[2]);
            }
            DateTime cDate2 = DateTime.Now;
            string currentDate2 = cDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //4
            DateTime appDate3 = DateTime.Now;
            string[] arrDate3 = txttodate.Text.Split('/');
            if (c.IsDate(arrDate3[1] + "/" + arrDate3[0] + "/" + arrDate3[2]) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter Valid Date');", true);
                return;
            }
            else
            {
                appDate3 = Convert.ToDateTime(arrDate3[1] + "/" + arrDate3[0] + "/" + arrDate3[2]);
            }
            DateTime cDate3 = DateTime.Now;
            string currentDate3= cDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //5
            DateTime appDate4 = DateTime.Now;
            string[] arrDate4 = txtstudregdate.Text.Split('/');
            if (c.IsDate(arrDate4[1] + "/" + arrDate4[0] + "/" + arrDate4[2]) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter Valid Date');", true);
                return;
            }
            else
            {
                appDate4 = Convert.ToDateTime(arrDate4[1] + "/" + arrDate4[0] + "/" + arrDate4[2]);
            }
            DateTime cDate4 = DateTime.Now;
            string currentDate4 = cDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

         

            if (lblId.Text == "[New]")
            {
                c.ExecuteQuery("Insert into CertificateData (CertID, CertUploadDate, CertNumber, CertCourseName, CertDuration, CertAvgMarks, CertGrade, CertExamMonth, CertIssueDate, CertStudentName,CertCenterName,CertFromDate,CertToDate,CertStudentRegDate,CertPlace,CertCenterNo) Values (" + maxId + ",  '" + DateTime.Now + "', '" + txtcertnumber.Text + "', '" + txtcoursename.Text + "','" + txtduration.Text + "'," + txtavgmarks.Text + ",'" + txtgrade.Text + "','" + appDate + "','" + appDate1 + "','" + txtstudname.Text + "','" + txtcentername.Text + "','" + appDate2 + "','" + appDate3 + "','" + appDate4 + "','" + txtcertplace.Text + "','" + txtcenterno.Text + "')");

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Certificate Data Added');", true);
            }
            else
            {
                c.ExecuteQuery("Update CertificateData set CertID=" + maxId + ", CertUploadDate = '" + DateTime.Now + "', CertNumber='" + txtcertnumber.Text + "', CertCourseName='" + txtcoursename.Text + "', CertDuration='" + txtduration.Text + "', CertAvgMarks= " + txtavgmarks.Text + ", CertGrade= '" + txtgrade.Text + "', CertExamMonth= '" + appDate + "', CertIssueDate='" + appDate1 + "', CertStudentName='" + txtstudname.Text + "', CertCenterName='" + txtcentername.Text + "', CertFromDate='" + appDate2 + "',CertToDate='" + appDate3 + "',CertStudentRegDate='" + appDate4 + "',CertPlace='" + txtcertplace.Text + "',CertCenterNo='" + txtcenterno.Text + "' where CertID=" + maxId);

                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Certificate Data Updated');", true);
            }

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('certificate-data-entry.aspx', 2000);", true);

          

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
            c.ExecuteQuery("Delete CertificateData where CertID=" + Request.QueryString["id"]);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Record Deleted');", true);
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "CallMyFunction", "waitAndMove('certificate-data-entry.aspx', 2000);", true);
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
        Response.Redirect("certificate-data-entry.aspx");
    }
}