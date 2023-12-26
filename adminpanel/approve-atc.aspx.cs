using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class adminpanel_approve_atc : System.Web.UI.Page
{
    iClass c = new iClass();
    public string rootPath, centerlogo, centerphoto, centeridproof, centereducerti, centerprofcourse;
    public string[] arrData = new string[30];
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           
           
            if (!IsPostBack)
            {
                GetData(Convert.ToInt32(Request.QueryString["id"]));

                if (Request.QueryString["action"] != null)
                {
                    editinfo.Visible = true;
                    viewinfo.Visible = false;

                    //if (Request.QueryString["action"] == "new")
                    //{
                    //    btnSave.Text = "Save Info";
                    //    btnDelete.Visible = false;
                    //    txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                    //}
                    //else
                    //{
                    //    btnSave.Text = "Modify Info";
                    //    btnDelete.Visible = true;
                    //    GetData(Convert.ToInt32(Request.QueryString["id"]));
                    //}
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

    protected void gvapprove_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Literal litAnch = (Literal)e.Row.FindControl("litAnch");
                litAnch.Text = "<a href=\"approve-atc.aspx?action=edit&id=" + e.Row.Cells[0].Text + "\"class=\"gView\" title=\"View/Edit\"></a>";

                //approveflag
                object status = c.GetReqData("CentersData", "CenterStatus", "CenterID=" + e.Row.Cells[0].Text);

                Literal litStatus = (Literal)e.Row.FindControl("litstatus");
                switch (status.ToString())
                {
                    case "0":
                        litStatus.Text = "<div class=\"ordNew\">Pending</div>";
                        break;
                    case "1":
                        litStatus.Text = "<div class=\"ordDelivered\">Approved</div>";
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "gvapprove_RowDataBound", ex.Message.ToString());
            return;
        }
    }

    private void FillGrid()
    {
        try
        {
            using (DataTable dtreg = c.GetDataTable("Select CenterID, Convert(varchar(20), CenterRegDate, 103) as CenterRegDate, CenterName, CenterOwnerName, CenterCity, CenterMobile, CenterEmailId From CentersData Where DelMark=0 AND CenterStatus = '1' ORDER BY CenterID DESC"))
            {
                gvapprove.DataSource = dtreg;
                gvapprove.DataBind();

                if (dtreg.Rows.Count > 0)
                {
                    gvapprove.UseAccessibleHeader = true;
                    gvapprove.HeaderRow.TableSection = TableRowSection.TableHeader;
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

    public DataTable GetData(int CentIdx)
    {
        DataTable dtatc = new DataTable(); // Create a new DataTable

        try
        {
            dtatc = c.GetDataTable("Select * from CentersData Where CenterID=" + CentIdx);
            {

                if (dtatc.Rows.Count > 0)
                {
                    DataRow row = dtatc.Rows[0];

                    arrData[0] = Convert.ToDateTime(row["CenterRegDate"]).ToString("dd/MM/yyyy");
                    arrData[1] = Convert.ToDateTime(row["CenterRenewDate"]).ToString("dd/MM/yyyy");


                    arrData[2] = row["CenterRegNo"].ToString();

                    arrData[3] = row["CenterName"].ToString();

                    arrData[4] = Getorgtype(Convert.ToInt32(row["FK_CenterTypeID"]));

                    arrData[5] = Getstate(Convert.ToInt32(row["CenterState"]));


                    arrData[6] = Getdist(Convert.ToInt32(row["CenterDistrict"]));

                    arrData[7] = row["CenterTaluka"].ToString();

                    arrData[8] = row["CenterCity"].ToString();

                    arrData[9] = row["CenterEmailId"].ToString();

                    arrData[10] = row["CenterMobile"].ToString();

                    arrData[11] = row["CenterPincode"].ToString();

                    arrData[12] = row["CenterOwnerName"].ToString();

                    arrData[13] = Getgender(Convert.ToInt32(row["CenterOwnerGender"]));

                    arrData[14] = Convert.ToDateTime(row["CenterOwnerBdate"]).ToString("dd/MM/yyyy");

                    arrData[15] = row["CenterOwnerPhoto"].ToString();

                    arrData[16] = row["CenterOwnerRole"].ToString();

                    arrData[17] = row["CenterUsername"].ToString();
                    arrData[18] = row["CenterUserPwd"].ToString();
                    arrData[19] = row["CenterLogo"].ToString();
                    arrData[20] = row["CenterProfCourse"].ToString();
                    arrData[21] = row["CenterEduCertificate"].ToString();
                    arrData[22] = row["CenterIDProof"].ToString();

                    if (row["CenterLogo"] != DBNull.Value && row["CenterLogo"] != null && row["CenterLogo"].ToString() != "" && row["CenterLogo"].ToString() != "no-photo.png")
                    {

                        centerlogo = "<img src=\"" + Master.rootPath + "upload/centerlogo/" + row["CenterLogo"].ToString() + "\"width=\"200\" >";
                      
                    }
                   

                    if (row["CenterOwnerPhoto"] != DBNull.Value && row["CenterOwnerPhoto"] != null && row["CenterOwnerPhoto"].ToString() != "" && row["CenterOwnerPhoto"].ToString() != "no-photo.png")
                    {

                        centerphoto = "<img src=\"" + Master.rootPath + "upload/centerownerphoto/" + row["CenterOwnerPhoto"].ToString() + "\"width=\"200\" >";

                    }

                    if (row["CenterIDProof"] != DBNull.Value && row["CenterIDProof"] != null && row["CenterIDProof"].ToString() != "" && row["CenterIDProof"].ToString() != "no-photo.png")
                    {

                        centeridproof = "<img src=\"" + Master.rootPath + "upload/centeridproof/" + row["CenterIDProof"].ToString() + "\"width=\"200\" >";

                    }

                    if (row["CenterEduCertificate"] != DBNull.Value && row["CenterEduCertificate"] != null && row["CenterEduCertificate"].ToString() != "" && row["CenterEduCertificate"].ToString() != "no-photo.png")
                    {

                        centereducerti = "<img src=\"" + Master.rootPath + "upload/centereducerti/" + row["CenterEduCertificate"].ToString() + "\"width=\"200\" >";

                    }
                    if (row["CenterProfCourse"] != DBNull.Value && row["CenterProfCourse"] != null && row["CenterProfCourse"].ToString() != "" && row["CenterProfCourse"].ToString() != "no-photo.png")
                    {

                        centerprofcourse = "<img src=\"" + Master.rootPath + "upload/centerprofcourse/" + row["CenterProfCourse"].ToString() + "\"width=\"200\" >";

                    }
                }

            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "GetData", ex.Message.ToString());
            return dtatc;
        }
        return dtatc;

    }

    private string Getstate(int stateId)
    {
        using (DataTable dtind = c.GetDataTable("select stateName from Statedata where stateId =" + stateId))
        {
            if (dtind.Rows.Count > 0)
            {
                return dtind.Rows[0]["stateName"].ToString();
            }
            else
            {
                return "Unknown state";
            }
        }

    }

    private string Getdist(int distId)
    {
        using (DataTable dtind = c.GetDataTable("select distName from Districtdata where distId =" + distId))
        {
            if (dtind.Rows.Count > 0)
            {
                return dtind.Rows[0]["distName"].ToString();
            }
            else
            {
                return "Unknown distract";
            }
        }

    }

    private string Getorgtype(int orgtypeId)
    {
        using (DataTable dtind = c.GetDataTable("select orgName from Orgtype where orgId =" + orgtypeId))
        {
            if (dtind.Rows.Count > 0)
            {
                return dtind.Rows[0]["orgName"].ToString();
            }
            else
            {
                return "Unknown orgtype";
            }
        }

    }

    private string Getgender(int gender)
    {
        switch (gender)
        {
            case 1:
                return "Male";
            case 2:
                return "Female";

            default:
                return "Unknown";
        }
    }
}