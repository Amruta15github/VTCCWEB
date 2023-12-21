using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class centers_add_centerphotos : System.Web.UI.Page
{
    iClass c = new iClass();
    public string rootPath;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            btnSave.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");
           

            if (!IsPostBack)
            {

                //GetData(Convert.ToInt32(Session["centerMaster"]));


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

    public void GetData(int centerIdx)
    {
        try
        {
            using (DataTable dtcenter = c.GetDataTable("select * from CentersData where CenterID=" + centerIdx))
            {
                if (dtcenter.Rows.Count > 0)
                {
                    DataRow row = dtcenter.Rows[0];
                    lblId.Text = centerIdx.ToString();

                    if (row["CenterLogo"] != DBNull.Value && row["CenterLogo"] != null && row["CenterLogo"].ToString() != "" && row["CenterLogo"].ToString() != "no-photo.png")
                    {

                        centerlogo = "<a href=\"" + Master.rootPath + "upload/centerlogo/" + row["CenterLogo"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View logo </a>";


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
}