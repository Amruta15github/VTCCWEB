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
            //Getjobs();
            GetStudentPlacements();
        }
    }

    //public string Getjobs()
    //{
    //    try
    //    {
    //        StringBuilder strMarkup = new StringBuilder();

    //        using (DataTable dtplacemntdata = c.GetDataTable("Select * From Centersdata"))
    //        //Select a.centId, a.centName, a.centMobile, a.centEmail From Centersdata a Inner Join PlacementData b On a.centId = b.centId
    //        {
    //            if (dtplacemntdata.Rows.Count > 0)
    //            {
    //                int ncount = 1;
    //                int bxcount = 0;
    //                foreach (DataRow row in dtplacemntdata.Rows)
    //                {
    //                    if (c.IsRecordExist("Select StudPlcId From StudentPlacement Where centId=" + row["centId"] + ""))
    //                    {
    //                        strMarkup.Append("<div class=\"fontRegular regular semiBold clrBlack text-center\">" + row["centName"].ToString() + "</br>");
    //                        strMarkup.Append("<span class=\"fontRegular regular clrBlack\">" + row["centEmail"].ToString() + "<span class=\"fontRegular regular small ml-3\">Contact: " + row["centMobile"].ToString() + "</span></span>");
    //                        strMarkup.Append("</div>");


    //                        //using (DataTable dtstudeninfo = c.GetDataTable("Select * From StudentPlacement Where centId=" + row["centId"] + ""))
    //                        using (DataTable dtstudeninfo = c.GetDataTable("SELECT * FROM StudentPlacement"))
    //                    {
    //                            strMarkup.Append("<span class=\"space20\"></span>");
    //                            strMarkup.Append("<div class=\"row\">");

    //                            foreach (DataRow placrow in dtstudeninfo.Rows)
    //                            {
    //                                strMarkup.Append("<div class=\"col-md-6\">");
    //                                strMarkup.Append("<div class=\"row\">");

    //                                if (placrow["StudPlcStudentPhoto"] != DBNull.Value && placrow["StudPlcStudentPhoto"].ToString() != "" && placrow["StudPlcStudentPhoto"].ToString() != "no-photo.png" && placrow["StudPlcStudentPhoto"] != null)
    //                                {
    //                                    strMarkup.Append("<div class=\"col-md-3 d-flex align-items-center justify-content-center\">");
    //                                    strMarkup.Append("<img src=\"" + Master.rootPath + "upload/studphoto/" + placrow["StudPlcStudentPhoto"].ToString() + "\" alt=\"" + placrow["StudPlcStudentPhoto"].ToString() + "\" class=\"img-fluid w-100\" />");
    //                                    strMarkup.Append("</div>");
    //                                }
    //                                strMarkup.Append("<span class=\"space10\"></span>");
    //                                strMarkup.Append("<div class=\"col-md-9\">");
    //                                strMarkup.Append("<div class=\"semiBold semiMedium themeClrPrime mb-2\">" + placrow["StudPlcStudentName"].ToString() + "</div>");
    //                                DateTime nDate = Convert.ToDateTime(placrow["StudPlcDate"]);
    //                                strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Date - <span class=\"fontRegular small line-ht-5\">" + nDate.ToString("dd MMM yyyy") + "</span></div>");
    //                                strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Course - <span class=\"fontRegular small line-ht-5\">" + placrow["StudPlcCourseName"].ToString() + "</span></div>");
    //                                strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Comapny - <span class=\"fontRegular small line-ht-5\">" + placrow["StudPlcCompanyName"].ToString() + "</span></div>");
    //                                strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Post - <span class=\"fontRegular small line-ht-5\">" + placrow["StudPlcJobPost"].ToString() + "</span></div>");
    //                                strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Country - <span class=\"fontRegular small line-ht-5\">" + placrow["StudPlcCountry"].ToString() + "</span></div>");
    //                                strMarkup.Append("</div>");

    //                                if (ncount < dtstudeninfo.Rows.Count)
    //                                {
    //                                    strMarkup.Append("<span class=\"greyLine\"></span>");
    //                                }
    //                                ncount++;
    //                                strMarkup.Append("</div>");
    //                                strMarkup.Append("</div>");


    //                            }
    //                            strMarkup.Append("</div>");
    //                            strMarkup.Append("<span class=\"space50\"></span>");
    //                            bxcount++;
    //                            if (bxcount % 2 == 0)
    //                            {
    //                                strMarkup.Append("<div class=\"float_clear\"></div>");
    //                            }
    //                        }
    //                    }

    //                }
    //                return strMarkup.ToString();
    //            }

    //            else
    //            {
    //                return "<div class=\"\"><div class=\"pad_10\"><span class=\" clrblack semiMedium fontRegular\">No Jobs to display.</span></div></div>";
    //            }
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        return ex.Message.ToString();
    //    }

    //}

    public string GetStudentPlacements()
    {
        try
        {
            StringBuilder strMarkup = new StringBuilder();

            using (DataTable dtstudeninfo = c.GetDataTable("SELECT * FROM StudentPlacement"))
            {
                if (dtstudeninfo.Rows.Count > 0)
                {
                    int ncount = 1;
                    int bxcount = 0;

                    strMarkup.Append("<span class=\"space20\"></span>");
                    strMarkup.Append("<div class=\"row\">");

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
                        strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Date - <span class=\"fontRegular small line-ht-5\">" + nDate.ToString("dd MMM yyyy") + "</span></div>");
                        strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Course - <span class=\"fontRegular small line-ht-5\">" + placrow["StudPlcCourseName"].ToString() + "</span></div>");
                        strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Company - <span class=\"fontRegular small line-ht-5\">" + placrow["StudPlcCompanyName"].ToString() + "</span></div>");
                        strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Post - <span class=\"fontRegular small line-ht-5\">" + placrow["StudPlcJobPost"].ToString() + "</span></div>");
                        strMarkup.Append("<div class=\"regular fontRegular semiBold mb-1\">Country - <span class=\"fontRegular small line-ht-5\">" + placrow["StudPlcCountry"].ToString() + "</span></div>");
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
                        strMarkup.Append("<span class=\"space50\"></span>");
                        

                        bxcount++;
                        if (bxcount % 2 == 0)
                        {
                            strMarkup.Append("<div class=\"float_clear\"></div>");
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