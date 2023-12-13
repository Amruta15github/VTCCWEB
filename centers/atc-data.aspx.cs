using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;


public partial class centers_atc_data : System.Web.UI.Page
{
    iClass c = new iClass();
    public string[] arrData = new string[30];

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lblId.Text = Convert.ToString(Session["centerMaster"]);

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


                    arrData[0] = row["CenterName"].ToString();

                    arrData[1] = Getorgtype(Convert.ToInt32(row["FK_CenterTypeID"]));

                    arrData[2] = Getstate(Convert.ToInt32(row["CenterState"]));
                   

                    arrData[3] = Getdist(Convert.ToInt32(row["CenterDistrict"]));

                    arrData[4] = row["CenterTaluka"].ToString();

                    arrData[5] = row["CenterCity"].ToString();

                    arrData[6] = row["CenterOwnerName"].ToString();

                    arrData[7] = Getgender(Convert.ToInt32(row["CenterOwnerGender"]));
                   // arrData[7] = row["CenterOwnerGender"].ToString();

                    //gender code
                    //string gender = "";
                    //string genderValue = arrData[7];
                    //if (genderValue == "1")
                    //{
                    //    gender = "Male";
                    //}

                    //else if(genderValue == "2")
                    //{
                    //    gender = "Female";
                    //}


                    arrData[8] = Convert.ToDateTime(row["CenterOwnerBdate"]).ToString("dd/MM/yyyy");

                    arrData[9] = row["CenterOwnerRole"].ToString();

                    arrData[10] = row["CenterEmailId"].ToString();

                    arrData[11] = row["CenterMobile"].ToString();

                    arrData[12] = row["CenterPincode"].ToString();

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




    






