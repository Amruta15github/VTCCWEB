using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class tie_ups : System.Web.UI.Page
{
    iClass c = new iClass();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Gettieup();
        }
    }

    public string Gettieup()
    {
        try
        {
            StringBuilder strMarkup = new StringBuilder();
            using (DataTable dtnws = c.GetDataTable("Select * From TieUpData Where DelMark=0"))
            {
                if (dtnws.Rows.Count > 0)
                {
                    strMarkup.Append("<span class=\"space30\"></span>");
                    strMarkup.Append("<div class=\"row\">");

                    foreach (DataRow row in dtnws.Rows)
                    {
                       
                        strMarkup.Append("<div class=\"col-md-6 \">");
                        if (row["TieUpLogo"] != DBNull.Value && row["TieUpLogo"].ToString() != "" && row["TieUpLogo"].ToString() != "no-photo.png" && row["TieUpLogo"] != null)
                        {
                            strMarkup.Append("<div class=\"tieup-logo\">");

                            strMarkup.Append("<img src=\"" + Master.rootPath + "upload/tieuplogo/" + row["TieUpLogo"].ToString() + "\" alt=\"" + row["TieUpLogo"].ToString() + "\" class=\"width100\" />");

                            strMarkup.Append("</div>");
                           
                        }

                        string nUrl = Master.rootPath + "tie-ups/" + c.UrlGenerator(row["TieUpTitle"].ToString().ToLower() + "-" + row["TieUpID"].ToString());

                        string tieupTitle = row["TieUpTitle"].ToString().Length >= 17 ? row["TieUpTitle"].ToString().Substring(0, 17) + "..." : row["TieUpTitle"].ToString();
                        strMarkup.Append("<a href=\"" + nUrl + "\" class=\"news-Tag mrg_B_10 fontRegular\">" + tieupTitle + "</a>");
                       

                        string tieupDesc = row["TieUpIntro"].ToString().Length >= 154 ? row["TieUpIntro"].ToString().Substring(0, 154) + "..." : row["TieUpIntro"].ToString();

                        strMarkup.Append("<p class=\"fontRegular line-ht-5 regular mrg_B_15\">" + tieupDesc + "</p>");

                        //strMarkup.Append("<a href=\"" + nUrl + "\" class=\"Readmore fontRegular\">Read More</a>");
                        strMarkup.Append("<span class=\"space10\"></span>");

                        //certificate
                        //if (row["newsPhoto"] != DBNull.Value && row["newsPhoto"].ToString() != "" && row["newsPhoto"].ToString() != "no-photo.png")
                         strMarkup.Append("</div>");//row
                        strMarkup.Append("<div class=\"float_clear\"></div>");

                    }
                  
                    strMarkup.Append("<div class=\"float_clear\"></div>");
                    return  strMarkup.ToString();
                }
                else
                {
                    return  "<span class=\"infoClr\">Nothing to display come back later.....</span>";
                }
            }
        }
        catch (Exception ex)
        {
            //nwsstr = c.ErrNotification(3, ex.Message.ToString());
            return ex.Message.ToString();
        }
    }
}
