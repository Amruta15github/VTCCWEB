using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

public partial class news : System.Web.UI.Page
{
    iClass c = new iClass();
    public string nwsstr, bCrumbStr;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                if (String.IsNullOrEmpty(Page.RouteData.Values["newsId"].ToString()))
                {
                    GetNews();

                }
                else
                {
                    string[] arrLinks = Page.RouteData.Values["newsId"].ToString().Split('-');
                    GetNewsDetails(Convert.ToInt32(arrLinks[arrLinks.Length - 1]));


                }
            }
        }
        catch (Exception ex)
        {
            nwsstr = c.ErrNotification(3, ex.Message.ToString());
            return;
        }
    }

        public void GetNews()
        {
            try
            {
                StringBuilder strMarkup = new StringBuilder();
                using (DataTable dtnws = c.GetDataTable("Select * From NewsData Where delMark=0"))
                {
                    if (dtnws.Rows.Count > 0)
                    {
                        int ncount = 1;
                        foreach (DataRow row in dtnws.Rows)
                        {
                           
                            if (row["newsPhoto"] != DBNull.Value && row["newsPhoto"].ToString() != "" && row["newsPhoto"].ToString() != "no-photo.png" && row["newsPhoto"] != null)
                            {
                                strMarkup.Append("<div class=\"news-img\">");

                                strMarkup.Append("<img src=\"" + Master.rootPath + "upload/news/thumb/" + row["newsPhoto"].ToString() + "\" alt=\"" + row["newsPhoto"].ToString() + "\" class=\"width100\" />");

                                strMarkup.Append("</div>");
                                strMarkup.Append("<div class=\"news-info\">");
                            }


                            string nUrl = Master.rootPath + "news/" + c.UrlGenerator(row["newsTitle"].ToString().ToLower() + "-" + row["newsId"].ToString());

                            string nwsTitle = row["newsTitle"].ToString().Length >= 17 ? row["newsTitle"].ToString().Substring(0, 17) + "..." : row["newsTitle"].ToString();
                            strMarkup.Append("<a href=\"" + nUrl + "\" class=\"news-Tag mrg_B_10 fontRegular\">" + nwsTitle + "</a>");
                            DateTime nDate = Convert.ToDateTime(row["newsDate"]);
                            strMarkup.Append("<span class=\"newspost\">Admin | " + nDate.ToString("dd MMM yyyy") + "</span>");

                            string nwsDesc = row["newsDesc"].ToString().Length >= 154 ? row["newsDesc"].ToString().Substring(0, 154) + "..." : row["newsDesc"].ToString();

                            strMarkup.Append("<p class=\"fontRegular line-ht-5 regular mrg_B_15\">" + nwsDesc + "</p>");

                            strMarkup.Append("<a href=\"" + nUrl + "\" class=\"Readmore fontRegular\">Read More</a>");
                            //strMarkup.Append("<span class=\"space10\"></span>");

                            if (row["newsPhoto"] != DBNull.Value && row["newsPhoto"].ToString() != "" && row["newsPhoto"].ToString() != "no-photo.png")
                            strMarkup.Append("</div>");
                            strMarkup.Append("<div class=\"float_clear\"></div>");

                            if (ncount < dtnws.Rows.Count)
                            {
                                strMarkup.Append("<span class=\"greyLine\"></span>");
                            }
                            ncount++;
                        }
                        strMarkup.Append("<div class=\"float_clear\"></div>");
                        nwsstr = strMarkup.ToString();
                    }
                    else
                    {
                        nwsstr = "<span class=\"infoClr\">Nothing to display come back later.....</span>";
                    }
                }
            }
            catch (Exception ex)
            {
                nwsstr = c.ErrNotification(3, ex.Message.ToString());
                return;
            }
        }
        private void GetNewsDetails(int NwsIdx)
        {
            try
            {
                c.ExecuteQuery("Update NewsData Set readCount=readCount+1 Where newsId=" + NwsIdx);
                using (DataTable dtNws = c.GetDataTable("Select * From NewsData Where newsId=" + NwsIdx))
                {
                    if (dtNws.Rows.Count > 0)
                    {
                        DataRow row = dtNws.Rows[0];
                        StringBuilder strMarkup = new StringBuilder();

                        this.Title = row["newsTitle"].ToString() + "| Latest News, Events of VTCC Education.";

                        strMarkup.Append("<h2 class=\"pageH2 themeClrPrime mrg_B_5 capitalize\">" + row["newsTitle"].ToString() + "</h2>");
                        DateTime nDate = Convert.ToDateTime(row["newsDate"]);
                        strMarkup.Append("<span class=\"newspost\"> VTCC Education | " + nDate.ToString("dd MMM yyyy") + "</span>");

                        strMarkup.Append("<span class=\"space15\"></span>");
                        strMarkup.Append("<span class=\"semiMedium themeClrSec fontRegular\">Total Views : " + row["readCount"].ToString() + "</span>");
                        strMarkup.Append("<span class=\"space20\"></span>");

                        //Sharing Options
                        strMarkup.Append("<div class=\"a2a_kit a2a_kit_size_24 a2a_default_style\" >");
                        strMarkup.Append("<a class=\"a2a_dd\" href=\"https://www.addtoany.com/share\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_facebook\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_twitter\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_google_plus\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_pinterest\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_email\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_linkedin\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_reddit\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_stumbleupon\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_digg\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_tumblr\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_whatsapp\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_blogger_post\"></a>");
                        strMarkup.Append("<a class=\"a2a_button_delicious\"></a>");
                        strMarkup.Append("</div>");
                        strMarkup.Append("<script async src=\"https://static.addtoany.com/menu/page.js\"></script>");

                        //Add Page sharing links code heres
                        strMarkup.Append("<div class=\"float_clear\"></div>");
                        strMarkup.Append("<div class=\"space20\"></div>");

                        //if (row["newsImage"] != DBNull.Value && row["newsImage"].ToString() != "" && row["newsImage"].ToString() != "no-image.jpg" && row["newsImage"] != null)

                        strMarkup.Append("<div class=\"col_800\">");
                        if (row["newsPhoto"] != DBNull.Value && row["newsPhoto"].ToString() != "" && row["newsPhoto"].ToString() != "no-photo.png" && row["newsPhoto"] != null)
                        {

                            strMarkup.Append("<img src=\"" + Master.rootPath + "upload/News/" + row["newsPhoto"].ToString() + "\" alt=\"" + row["newsTitle"].ToString() + "\" class=\"width100\" />");
                        }
                        else
                        {
                            // strMarkup.Append("<img src=\""+Master.rootPath+"upload/news/no-news-photo.jpg \" class=\"width100\"/>");
                            // strMarkup.Append("<img src=\""+Master.rootPath+ "upload/news/no-news-photo.jpg \" class=\"width100\"/>");
                        }
                        strMarkup.Append("</div>");
                        strMarkup.Append("<div class=\"float_clear\"></div>");
                        strMarkup.Append("<span class=\"space20\"></span>");
                        strMarkup.Append("<p class=\"fontregular line-ht-5\">" + Regex.Replace(row["newsDesc"].ToString(), @"\r\n?|\n", "<br />") + "</p>");
                        //strMarkup.Append("<p class=\"light fontregular line-ht-5\">"+row["newsData"].ToString()+"</p>");

                        bCrumbStr = "<ul class=\"bCrumb\"><li><a href=\"" + Master.rootPath + "\">Home</a></li><li>&raquo;</li><li><a href=\"" + Master.rootPath + "news\">Latest News</a></li><li>&raquo;</li><li>" + row["newsTitle"].ToString() + "</li></ul>";
                        nwsstr = strMarkup.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                nwsstr = c.ErrNotification(3, ex.Message.ToString());
                return;

            }
        }
    }
