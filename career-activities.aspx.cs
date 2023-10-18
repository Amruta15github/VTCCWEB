using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class career_activities : System.Web.UI.Page
{
    iClass c = new iClass();
    public string careerstr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetCareerActivity();
        }
    }

    public void GetCareerActivity()
    {
        try
        {
            StringBuilder strMarkup = new StringBuilder();
            //using (DataTable dtcareer = c.GetDataTable("Select a.caId, a.caTitle, a.caDate, a.caDesc, b.centName from CareerActData a Inner Join CentersData b On a.atcId=b.centId Order By a.caId Desc"))
            using (DataTable dtcareer = c.GetDataTable("Select CarActId, CarActDate, CarActTitle, CarActDescription from CareerActivity Order By CarActId Desc"))
            {
                if (dtcareer.Rows.Count > 0)
                {
                    int ncount = 1;
                    foreach (DataRow row in dtcareer.Rows)
                    {
                        strMarkup.Append("<span class=\"space30\"></span>");
                        strMarkup.Append("<span class=\"semiBold medium themeClrThr \">" + row["CarActTitle"].ToString() + "</span>");
                        strMarkup.Append("<span class=\"space10\"></span>");
                        DateTime nDate = Convert.ToDateTime(row["CarActDate"].ToString());
                        strMarkup.Append("<span class=\"fontRegular\">" + nDate.ToString("dd MMM yyyy") + "<span class=\"fontRegular\"></span></span>");  /*|  " + row["centName"].ToString() + " </span>");*/
                        strMarkup.Append("<span class=\"space30\"></span>");
                        //strMarkup.Append("<span class=\"semiMedium themeClrPrime fontregular\">Total Views : " + row["ViewsCount"].ToString() + "</span>");
                        //strMarkup.Append("<span class=\"space30\"></span>");
                        strMarkup.Append("<p class=\"fontRegular line-ht-5 regular clrDarkGrey\">" + row["CarActDescription"].ToString() + "</p>");
                        strMarkup.Append("<span class=\"space15\"></span>");
                        strMarkup.Append("<div class=\"row\">");

                        using (DataTable dtphotosdata = c.GetDataTable("Select CarActPhotoId, CarActPhotoName From CareerActivityPhotos Where FK_CarActId=" + row["CarActId"] + ""))
                        {
                            foreach (DataRow pow in dtphotosdata.Rows)
                            {
                                strMarkup.Append("<div class=\"col-md-4\">");
                                strMarkup.Append("<div class=\"\">");
                                strMarkup.Append("<div class=\"p-2 rounded\">");
                                if (pow["CarActPhotoName"] != DBNull.Value && pow["CarActPhotoName"].ToString() != "" && pow["CarActPhotoName"].ToString() != "no-photo.png" && pow["CarActPhotoName"] != null)
                                {
                                    strMarkup.Append("<a href=\"" + Master.rootPath + "upload/careeractivity/" + pow["CarActPhotoName"].ToString() + "\" data-fancybox=\"imggroup\"><img src=\"" + Master.rootPath + "upload/careeractivity/" + pow["CarActPhotoName"].ToString() + "\" alt=\"" + pow["CarActPhotoName"].ToString() + "\" class=\"img-fluid\" /></a>");
                                }
                                strMarkup.Append("</div>");
                                strMarkup.Append("</div>");
                                strMarkup.Append("</div>");
                                strMarkup.Append("<span class=\"space20\"></span>");
                            }

                        }

                        strMarkup.Append("</div>");
                        strMarkup.Append("<div class=\"float_clear\"></div>");

                        if (ncount < dtcareer.Rows.Count)
                        {
                            strMarkup.Append("<span class=\"greyLine\"></span>");
                        }
                        ncount++;

                    }
                    careerstr = strMarkup.ToString();
                }
                else
                {
                    careerstr = "<div class=\"\"><div class=\"pad_10\"><span class=\"semiMedium fontRegular\">No Career Activities to display.</span></div></div>";
                }

            }
        }

        catch (Exception ex)
        {
            careerstr = c.ErrNotification(3, ex.Message.ToString());
            return;
        }
    }
}