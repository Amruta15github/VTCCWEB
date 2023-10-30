using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class verify_student_certificate : System.Web.UI.Page
{
    iClass c = new iClass();
    public string pgTitle, certificateNum;
    public string[] ordCertData = new string[30];
    protected void Page_Load(object sender, EventArgs e)
    {
        pgTitle = "Verify Students Certificate";

        table.Visible = false;
    }

    public void GetData()
    {
        try
        {
            using (DataTable dtcertificate = c.GetDataTable("Select * from CertificateData where CertNumber='" + txtcertificateNo.Text + "'"))
            {
                if (dtcertificate.Rows.Count > 0)
                {
                    DataRow row = dtcertificate.Rows[0];
                    ordCertData[0] = row["CertNumber"] != DBNull.Value && row["CertNumber"] != null && row["CertNumber"].ToString() != "" ? row["CertNumber"].ToString() : "NA";

                    ordCertData[1] = row["CertStudentName"] != DBNull.Value && row["CertStudentName"] != null && row["CertStudentName"].ToString() != "" ? row["CertStudentName"].ToString() : "NA";

                    ordCertData[2] = row["CertCourseName"] != DBNull.Value && row["CertCourseName"] != null && row["CertCourseName"].ToString() != "" ? row["CertCourseName"].ToString() : "NA";

                    ordCertData[3] = row["CertCenterName"] != DBNull.Value && row["CertCenterName"] != null && row["CertCenterName"].ToString() != "" ? row["CertCenterName"].ToString() : "NA";
                    table.Visible = true;
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Certificate number will be updated shortly on the server and is in the process. For emergency verification, please email us with your certificate copy.');", true);
                    return;
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


    protected void btnverify_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtcertificateNo.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * Fields are mandatory');", true);
                return;
            }
            //else
            //{
            //    GetData();
            //}

            if (c.IsRecordExist("Select CertID From CertificateData Where CertNumber='" + txtcertificateNo.Text + "' "))
            {
                GetData();
                table.Visible = true;
            }

            //else if (c.IsRecordExist("Select stdId From Studentsdata Where certificateNum='" + txtcertificateNo.Text + "'"))
            //{
            //    GetOldCertificates(Convert.(certificateNum));
            //    table.Visible = true;
            //}

            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Certificate number will be updated shortly on the server and is in the process. For emergency verification, please email us with your certificate copy.');", true);
                return;
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnverify_Click", ex.Message.ToString());
            return;
        }
    }


}