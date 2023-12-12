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
                    arrData[1] = row["FK_CenterTypeID"].ToString();
                   
                    arrData[2] = row["CenterState"].ToString();
                   
                    arrData[3] = row["CenterDistrict"].ToString();
                   
                    arrData[4] = row["CenterTaluka"].ToString();
                  
                    arrData[5] = row["CenterCity"].ToString();
                   
                    arrData[6] = row["CenterOwnerName"].ToString();
          
                    arrData[7] = row["CenterOwnerGender"].ToString();
                 
                    arrData[8] = Convert.ToDateTime(row["CenterOwnerBdate"]).ToString("dd/MM/yyyy");
                    //ordData[1] = Convert.ToDateTime(bRow["OrderDate"]).ToString("dd/MM/yyyy");

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

    
}




    






