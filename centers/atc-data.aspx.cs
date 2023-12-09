using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.SqlClient;

public partial class centers_atc_data : System.Web.UI.Page
{
    iClass c = new iClass();

    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    //int centerId = 0; // Default value

    //    if (!IsPostBack)
    //    {

    //        if (Request.QueryString["action"] != null)
    //        {
    //           // GetData(Convert.ToInt32(Request.QueryString["id"]));
    //        }

    //        GetData(Convert.ToInt32(Request.QueryString["id"]));
    //        lblId.Visible = false;
    //    }
    //}


    //public void GetData(int centerIdx)
    //{
    //    try
    //    {
    //        using (DataTable dt = c.GetDataTable("select * from CentersData where CenterID =" + centerIdx))
    //        {
    //            if (dt.Rows.Count > 0)
    //            {
    //                DataRow row = dt.Rows[0];

    //                lblId.Text = centerIdx.ToString();
    //                txtorgname.Text = row["CenterName"].ToString();
    //                ddltypeoforg.SelectedValue = row["FK_CenterTypeID"].ToString();
    //                ddrState.SelectedValue = row["CenterState"].ToString();
    //                ddrDistrict.SelectedValue = row["CenterDistrict"].ToString();
    //                txttaluka.Text = row["CenterTaluka"].ToString();
    //                txtCity.Text = row["CenterCity"].ToString();
    //                txtOwner.Text = row["CenterOwnerName"].ToString();
    //                txtbday.Text = Convert.ToDateTime(row["CenterOwnerBdate"]).ToString("dd/MM/yyyy");
    //                ddlrole.SelectedValue = row["CenterOwnerRole"].ToString();
    //                txtEmail.Text = row["CenterEmailId"].ToString();
    //                txtMobNo.Text = row["CenterMobile"].ToString();                 
    //                txtpin.Text = row["CenterPincode"].ToString();

    //                //gender
    //                if (row["CenterOwnerGender"] != DBNull.Value && row["CenterOwnerGender"] != null && row["CenterOwnerGender"].ToString() != "")
    //                {
    //                    if (row["CenterOwnerGender"].ToString() == "1")
    //                    {
    //                        Radiomale.Checked = true;
    //                    }
    //                    else if (row["CenterOwnerGender"].ToString() == "2")
    //                    {
    //                        if (row["CenterOwnerGender"].ToString() == "2")
    //                        {
    //                            Radiofemale.Checked = true;
    //                        }
    //                    }
    //                    else if (row["CenterOwnerGender"].ToString() == "3")
    //                    {
    //                        if (row["CenterOwnerGender"].ToString() == "3")
    //                        {
    //                            Radiotransgender.Checked = true;
    //                        }
    //                    }

    //                }



    //            }

    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
    //        c.ErrorLogHandler(this.ToString(), "GetData", ex.Message.ToString());
    //        return;
    //    }
    //}


    //uses chat gpt 
    

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        // Assume you have some authentication mechanism to get the current center's ID
        //        int centerId = GetLoggedInCenterId(); // Implement this method to retrieve the center's ID

        //        // Fetch data from the database based on the center's ID
        //        DataTable dt = GetCenterDataFromDB(centerId); // Implement this method to fetch data from the database

        //        // Display data in labels
        //        if (dt != null && dt.Rows.Count > 0)
        //        {
        //            lblnamecenter.Text = "Name of Organization/Center : ";
        //            lblData1.Text = dt.Rows[0]["CenterName"].ToString(); // Replace "FieldName1" with the actual column name from your database

        //            lbltypeorg.Text = "Type of Organization: ";
        //            lblData2.Text = dt.Rows[0]["FK_CenterTypeID"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lblstate.Text = "Select State: ";
        //            lblData3.Text = dt.Rows[0]["CenterState"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lbldist.Text = "Select District: ";
        //            lblData4.Text = dt.Rows[0]["CenterDistrict"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lbltaluka.Text = "Taluka: ";
        //            lblData5.Text = dt.Rows[0]["CenterTaluka"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lblCity.Text = "City: ";
        //            lblData6.Text = dt.Rows[0]["CenterCity"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lblOwner.Text = "Owner Name: ";
        //            lblData7.Text = dt.Rows[0]["CenterOwnerName"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lblgender.Text = "Gender: ";
        //            lblData8.Text = dt.Rows[0]["CenterOwnerGender"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lblbday.Text = "Birth Date: ";
        //            lblData9.Text = dt.Rows[0]["CenterOwnerBdate"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lblrole.Text = "Role: ";
        //            lblData10.Text = dt.Rows[0]["CenterOwnerRole"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lblEmail.Text = "Email: ";
        //            lblData11.Text = dt.Rows[0]["CenterEmailId"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lblMobNo.Text = "Mobile No: ";
        //            lblData12.Text = dt.Rows[0]["CenterMobile"].ToString(); // Replace "FieldName2" with the actual column name from your database

        //            lblpincode.Text = "Pincode: ";
        //            lblData13.Text = dt.Rows[0]["CenterPincode"].ToString(); // Replace "FieldName2" with the actual column name from your database

                // Add more labels and corresponding data as needed for other fields
        //    }
        //}
        //    lblId.Visible = false;
        //}


    //// Method to retrieve the logged-in center's ID (simulate this method)
    //private int GetLoggedInCenterId()
    //{
    //// Simulated center ID (replace this with your actual implementation)
    //return 123; // Example center ID
    //}

    //private int GetLoggedInCenterId()
    //{
        // Assuming you store the center ID in a session variable named "LoggedInCenterId"
        //if (HttpContext.Current.Session["LoggedInCenterId"] != null)
        //{
        //    // Retrieve the center ID from the session
        //    return Convert.ToInt32(HttpContext.Current.Session["LoggedInCenterId"]);
        //}
        //else
        //{
            // If the session variable is not set, return a default or handle accordingly
            // You might want to throw an exception or return a default ID
          
    //        ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Center ID not found in session');", true);
    //    }
    //}

    // Method to fetch data from the database based on center ID (simulate this method)
    //private DataTable GetCenterDataFromDB(int centerId)
    //{
       
    //     DataTable dt = new DataTable();
       
    //    //string query = "Select CenterID, FK_CenterTypeID, CenterState, CenterDistrict, CenterTaluka, CenterCity, CenterOwnerName, CenterOwnerGender, CenterOwnerBdate, CenterOwnerRole, CenterEmailId, CenterMobile, CenterPincode From CentersData where CenterID = centerId";
    //    using (DataTable dt1 = c.GetDataTable("select CenterID, FK_CenterTypeID, CenterState, CenterDistrict, CenterTaluka, CenterCity, CenterOwnerName, CenterOwnerGender, CenterOwnerBdate, CenterOwnerRole, CenterEmailId, CenterMobile, CenterPincode from CentersData where CenterID=" + centerId))
    //    return dt;
        

       
       

    //}

}




