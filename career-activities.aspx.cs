using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;


public partial class career_activities : System.Web.UI.Page
{
    iClass c = new iClass();
    public string careerstr, bCrumbStr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (String.IsNullOrEmpty(Page.RouteData.Values["CarActId"].ToString()))
            {
                GetCareerActivity();

            }
            else
            {
                string[] arrLinks = Page.RouteData.Values["CarActId"].ToString().Split('-');
                GetDetails(Convert.ToInt32(arrLinks[arrLinks.Length - 1]));

            }
        }
    }

   

    public void GetCareerActivity()
    {
        try
        {
            StringBuilder strMarkup = new StringBuilder();
           
                //using (DataTable dtcareer = c.GetDataTable("Select a.caId, a.caTitle, a.caDate, a.caDesc, b.centName from CareerActData a Inner Join CentersData b On a.atcId=b.centId Order By a.caId Desc"))
                using (DataTable dtcareer = c.GetDataTable("Select CarActId, CarActDate, CarActTitle, CarActDescription, FK_CenterID from CareerActivity Order By CarActId Desc"))
                {
                    if (dtcareer.Rows.Count > 0)
                    {
                        int ncount = 1;
                        foreach (DataRow row in dtcareer.Rows)
                        {
                    
                            strMarkup.Append("<span class=\"space30\"></span>");
                            string nUrl = Master.rootPath + "career-activities/" + c.UrlGenerator(row["CarActTitle"].ToString().ToLower() + "-" + row["CarActId"].ToString());

                            string caractTitle = row["CarActTitle"].ToString().Length >= 17 ? row["CarActTitle"].ToString().Substring(0, 17) + "..." : row["CarActTitle"].ToString();
                            strMarkup.Append("<a href=\"" + nUrl + "\" class=\" semiBold medium themeClrThr\">" + caractTitle + "</a>");

                            strMarkup.Append("<span class=\"space10\"></span>");

                            //date
                            DateTime nDate = Convert.ToDateTime(row["CarActDate"].ToString());
                            strMarkup.Append("<span class=\"fontRegular\">" + nDate.ToString("dd MMM yyyy") + "<span class=\"fontRegular\"></span> |  " + GetcenterName(Convert.ToInt32(row["FK_CenterID"])) + "</span>");
                            strMarkup.Append("<span class=\"space10\"></span>");

                            string carDesc = row["CarActDescription"].ToString().Length >= 154 ? row["CarActDescription"].ToString().Substring(0, 154) + "..." : row["CarActDescription"].ToString();

                            strMarkup.Append("<p class=\"fontRegular line-ht-5 regular mrg_B_15\">" + carDesc + "</p>");
                            strMarkup.Append("<span class=\"space10\"></span>");



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

    private string GetcenterName(int centerId)
    {
        using (DataTable dtind = c.GetDataTable("select CenterName from Centersdata where CenterID =" + centerId))
        {
            if (dtind.Rows.Count > 0)
            {
                return dtind.Rows[0]["CenterName"].ToString();
            }
            else
            {
                return "Unknown centername";
            }
        }

    }




    private void GetDetails(int NwsIdx)
    {
        try
        {
            c.ExecuteQuery("Update CareerActivity Set ViewsCount=ViewsCount+1 Where CarActId=" + NwsIdx);
            using (DataTable dtNws = c.GetDataTable("Select * From CareerActivity Where CarActId=" + NwsIdx))
            {
                if (dtNws.Rows.Count > 0)
                {
                    DataRow row = dtNws.Rows[0];
                    StringBuilder strMarkup = new StringBuilder();

                    this.Title = row["CarActTitle"].ToString() + "| Careeer Activity, Events of VTCC Education.";

                    strMarkup.Append("<span class=\"space15\"></span>");
                    strMarkup.Append("<h2 class=\"pageH2 themeClrPrime mrg_B_5\">" + row["CarActTitle"].ToString() + "</h2>");
                    DateTime nDate = Convert.ToDateTime(row["CarActDate"]);
                    strMarkup.Append("<span class=\"careerpost\">" + nDate.ToString("dd MMM yyyy") + "<span class=\"fontRegular\"></span> |  " + GetcenterName(Convert.ToInt32(row["FK_CenterID"])) + "</span>");
                    // strMarkup.Append("<span class=\"fontRegular\">" + nDate.ToString("dd MMM yyyy") + "<span class=\"fontRegular\"></span> |  " + GetcenterName(Convert.ToInt32(row["FK_CenterID"])) + "</span>");

                    strMarkup.Append("<span class=\"space15\"></span>");
                    strMarkup.Append("<span class=\"semiMedium themeClrThr fontRegular\">Total Views : " + row["ViewsCount"].ToString() + "</span>");
                    strMarkup.Append("<span class=\"space20\"></span>");

                   
                    strMarkup.Append("<p class=\"fontregular line-ht-5\">" + Regex.Replace(row["CarActDescription"].ToString(), @"\r\n?|\n", "<br />") + "</p>");
                    //photo
                    using (DataTable dtphotosdata = c.GetDataTable("Select CarActPhotoId, CarActPhotoName From CareerActivityPhotos Where FK_CarActId=" + row["CarActId"] + ""))
                    {
                        strMarkup.Append("<div class=\"row\">");
                        foreach (DataRow pow in dtphotosdata.Rows)
                        {

                            strMarkup.Append("<div class=\"col-md-4\">");
                            strMarkup.Append("<div class=\"p-2 rounded\">");

                            if (pow["CarActPhotoName"] != DBNull.Value && pow["CarActPhotoName"].ToString() != "" && pow["CarActPhotoName"].ToString() != "no-photo.png" && pow["CarActPhotoName"] != null)
                            {
                                strMarkup.Append("<a href=\"" + Master.rootPath + "upload/careeractivity/" + pow["CarActPhotoName"].ToString() + "\" data-fancybox=\"imggroup1\"><img src=\"" + Master.rootPath + "upload/careeractivity/" + pow["CarActPhotoName"].ToString() + "\" alt=\"" + pow["CarActPhotoName"].ToString() + "\" class=\"img-fluid image-container image-container img \" /></a>");
                            }
                            strMarkup.Append("</div>");//rounded
                            strMarkup.Append("</div>");//col-md-4                           
                            strMarkup.Append("<span class=\"space10\"></span>");
                        }

                    }
                    strMarkup.Append("</div>");//row
                    strMarkup.Append("<div class=\"float_clear\"></div>");
                    


                    bCrumbStr = "<ul class=\"bCrumb\"><li><a href=\"" + Master.rootPath + "\">Home</a></li><li>&raquo;</li><li><a href=\"" + Master.rootPath + "career-activities\">Career Activity</a></li><li>&raquo;</li><li>" + row["CarActTitle"].ToString() + "</li></ul>";
                    careerstr = strMarkup.ToString();

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