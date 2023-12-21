using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class placed_students : System.Web.UI.Page
{
    iClass c = new iClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            GetStudentPlacements();
        }
    }

  

    public string GetStudentPlacements()
    {
        try
        {
            StringBuilder strMarkup = new StringBuilder();

           
            using (DataTable dtplacemntdata = c.GetDataTable("Select * From Centersdata"))
            {
                if (dtplacemntdata.Rows.Count > 0)
                {
                    //int ncount = 1;
                    int bxcount = 0;

                    strMarkup.Append("<span class=\"space20\"></span>");
                    strMarkup.Append("<div class=\"row\">");
                    
                    foreach (DataRow row in dtplacemntdata.Rows)
                    {
                        
                            if (c.IsRecordExist("Select StudPlcId From StudentPlacement Where FK_CenterID=" +row["CenterID"] +  ""))
                            {
                            strMarkup.Append("<div class=\"organization-name-style mrg_B_10\">" + row["CenterName"].ToString() + "</br>");
                            strMarkup.Append("<span class=\"space10\"></span>");
                            strMarkup.Append("<span class=\"fontRegular small\">Email ID: " + row["CenterEmailId"].ToString() + "<span class=\"fontRegular small ml-3\">Contact: " + row["CenterMobile"].ToString() + "</span></span>");
                            strMarkup.Append("</div>");
                                           
                            using (DataTable dtstudeninfo = c.GetDataTable("Select * From StudentPlacement Where FK_CenterID=" + row["CenterID"] + ""))
                            {
                                strMarkup.Append("<span class=\"space20\"></span>");
                                strMarkup.Append("<div class=\"row\">");
                                strMarkup.Append("<span class=\"space20\"></span>");
                               
                                foreach (DataRow placrow in dtstudeninfo.Rows)
                                {
                                   
                                    strMarkup.Append("<div class=\"col-md-6 mb-4\">");
                                    strMarkup.Append("<div class=\"p-3 border border-secondary\">");
                                    strMarkup.Append("<div class=\"p-2\">");
                                    strMarkup.Append("<div class=\"row\">");

                                    if (placrow["StudPlcStudentPhoto"] != DBNull.Value && placrow["StudPlcStudentPhoto"].ToString() != "" && placrow["StudPlcStudentPhoto"].ToString() != "no-photo.png" && placrow["StudPlcStudentPhoto"] != null)
                                    {
                                        strMarkup.Append("<div class=\"col-md-3 d-flex align-items-center justify-content-center\">");
                                        strMarkup.Append("<img src=\"" + Master.rootPath + "upload/studphoto/" + placrow["StudPlcStudentPhoto"].ToString() + "\" alt=\"" + placrow["StudPlcStudentPhoto"].ToString() + "\" class=\"img-fluid w-100\" />");
                                        strMarkup.Append("</div>");//d-flex
                                    }
                                    strMarkup.Append("<span class=\"space10\"></span>");
                                    strMarkup.Append("<div class=\"col-md-9\">");
                                    strMarkup.Append("<div class=\"semiBold semiMedium  mb-2\">" + placrow["StudPlcStudentName"].ToString() + "</div>");
                                    DateTime nDate = Convert.ToDateTime(placrow["StudPlcDate"]);
                                    strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Date - <span class=\"fontRegular Regular line-ht-5\">" + nDate.ToString("dd MMM yyyy") + "</span></div>");
                                    strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Course - <span class=\"fontRegular Regular line-ht-5\">" + placrow["StudPlcCourseName"].ToString() + "</span></div>");
                                    strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Company - <span class=\"fontRegular Regular line-ht-5\">" + placrow["StudPlcCompanyName"].ToString() + "</span></div>");
                                    strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Post - <span class=\"fontRegular Regular line-ht-5\">" + placrow["StudPlcJobPost"].ToString() + "</span></div>");
                                    strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Country - <span class=\"fontRegular Regular line-ht-5\">" + placrow["StudPlcCountry"].ToString() + "</span></div>");
                                    strMarkup.Append("</div>");//col-md-9

                                    strMarkup.Append("</div>");//row2
                                    strMarkup.Append("</div>");//p2
                                    strMarkup.Append("</div>");//box
                                    strMarkup.Append("</div>");//col-md-6

                                    //if (ncount < dtstudeninfo.Rows.Count)
                                    //{
                                    //    strMarkup.Append("<span class=\"greyLine\"></span>");
                                    //}
                                    //ncount++;
                                }
                                strMarkup.Append("</div>");//row1
                              

                                bxcount++;
                                if (bxcount % 2 == 0)
                                {
                                    strMarkup.Append("<div class=\"float_clear\"></div>");
                                }
                                strMarkup.Append("</div>");//row3
                            }
                        }
                    }
                   
                    return strMarkup.ToString();
                }
                else
                {
                    return "<div class=\"\"><div class=\"pad_10\"><span class=\" clrblack semiMedium fontRegular\">No Placed Students to display.</span></div></div>";
                }
            }
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
    }
}