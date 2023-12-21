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

            btnsavephoto.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnsavephoto, null) + ";");
            btnroomphoto.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnroomphoto, null) + ";");
            btnlabphoto.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnlabphoto, null) + ";");
            btnuploadpdf.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnuploadpdf, null) + ";");
            btnoutdoorphoto.Attributes.Add("onclick", " this.disabled = true; this.value='Processing...'; " + ClientScript.GetPostBackEventReference(btnoutdoorphoto, null) + ";");


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

    //public void GetData(int centerIdx)
    //{
    //    try
    //    {
    //        using (DataTable dtcenter = c.GetDataTable("select * from CenterPhotos where CentPhotoId=" + centerIdx))
    //        {
    //            if (dtcenter.Rows.Count > 0)
    //            {
    //                DataRow row = dtcenter.Rows[0];
    //                lblId.Text = centerIdx.ToString();

    //                if (row["CenterLogo"] != DBNull.Value && row["CenterLogo"] != null && row["CenterLogo"].ToString() != "" && row["CenterLogo"].ToString() != "no-photo.png")
    //                {

    //                    centerlogo = "<a href=\"" + Master.rootPath + "upload/centerlogo/" + row["CenterLogo"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View logo </a>";


    //                }

    //                if (row["CenterOwnerPhoto"] != DBNull.Value && row["CenterOwnerPhoto"] != null && row["CenterOwnerPhoto"].ToString() != "" && row["CenterOwnerPhoto"].ToString() != "no-photo.png")
    //                {

    //                    centerphoto = "<a href=\"" + Master.rootPath + "upload/centerownerphoto/" + row["CenterOwnerPhoto"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View Owner Photo </a>";


    //                }

    //                if (row["CenterIDProof"] != DBNull.Value && row["CenterIDProof"] != null && row["CenterIDProof"].ToString() != "" && row["CenterIDProof"].ToString() != "no-photo.png")
    //                {

    //                    centeridproof = "<a href=\"" + Master.rootPath + "upload/centeridproof/" + row["CenterIDProof"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View ID Proof </a>";


    //                }

    //                if (row["CenterEduCertificate"] != DBNull.Value && row["CenterEduCertificate"] != null && row["CenterEduCertificate"].ToString() != "" && row["CenterEduCertificate"].ToString() != "no-photo.png")
    //                {

    //                    centereducerti = "<a href=\"" + Master.rootPath + "upload/centereducerti/" + row["CenterEduCertificate"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View Education Certificate </a>";


    //                }

    //                if (row["CenterProfCourse"] != DBNull.Value && row["CenterProfCourse"] != null && row["CenterProfCourse"].ToString() != "" && row["CenterProfCourse"].ToString() != "no-photo.png")
    //                {

    //                    centerprofcourse = "<a href=\"" + Master.rootPath + "upload/centerprofcourse/" + row["CenterProfCourse"].ToString() + "\"width=\"200\" \" target=\"_blank\"> View Professional Courses </a>";


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
    }


}