using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;  

public partial class _Default : System.Web.UI.Page
{
    iClass c = new iClass(); 
    public string rootPath, nwsstr;
    protected void Page_Load(object sender, EventArgs e)
    {
        rootPath = c.ReturnHttp();
        GetNews();

        if (!IsPostBack)
        {
            if (Request.QueryString["act"] != null)
            {
                if (Request.QueryString["act"] == "logout")
                {
                    Session["adminMaster"] = null;

                    Response.Redirect(rootPath, false);
                }

                if (Request.QueryString["act"] == "centerlogout")
                {
                    Session["centerMaster"] = null;

                    Response.Redirect(rootPath, false);
                }
            }
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {

    }

    public void GetNews()
    {
        try
        {
            
            if (c.IsRecordExist("Select newsId from NewsData Where delMark=0"))
            {
                StringBuilder strMarkup = new StringBuilder();
                using (DataTable dtnws = c.GetDataTable("Select * From NewsData Where delMark=0"))
                {
                    string className = "";

                    int i = 0;

                    if (dtnws.Rows.Count > 0)
                    {
                        
                        strMarkup.Append("<span class=\"space30\"></span>");
                        strMarkup.Append("<div class=\"container\">");
                        strMarkup.Append("<div class=\"row d-flex justify-content-center\">");
                        strMarkup.Append("<div class=\"menu-content pb-50 col-lg-8\">");
                        strMarkup.Append("<div class=\"title text-center\">");
                        strMarkup.Append("<h3 class=\"xx-large themeClrPrime\">Latest News</h3>");
                        strMarkup.Append("<span class=\"space10\"></span>");
                        strMarkup.Append("</div>");//title
                        strMarkup.Append("</div>");//menu-content
                        strMarkup.Append("</div>");//row d-flex


                        strMarkup.Append("<div id=\"carouselExample\" class=\"carousel slide\">");
                        strMarkup.Append("<div class=\"carousel-inner\">");
                        foreach (DataRow row in dtnws.Rows)
                        {
                            i++;

                            if (i == 1)
                            {
                                className = "active";

                            }
                            else
                            {
                                className = "";
                            }
                            strMarkup.Append("<div class=\"carousel-item " + className + "\">");
                          
                            strMarkup.Append("<div class=\"row featurette d-flex justify-content-center align-items-center\">");
                            strMarkup.Append("<div class=\"col-md-7\">");
                            DateTime nDate = Convert.ToDateTime(row["newsDate"]);
                            strMarkup.Append("<p class=\"meta\">" + nDate.ToString("dd MMM yyyy") + " | Admin </p>");

                            string nUrl = rootPath + "news/" + c.UrlGenerator(row["newsTitle"].ToString().ToLower() + "-" + row["newsId"].ToString());
                            string nwsTitle = row["newsTitle"].ToString().Length >= 17 ? row["newsTitle"].ToString().Substring(0, 17) + "..." : row["newsTitle"].ToString();
                            strMarkup.Append("<a href=\"" + nUrl + "\" >");
                            strMarkup.Append("<h5 class=\"featurette-heading fw-normal lh-1 medium themeClrThr\">" + nwsTitle + "</h5>");
                            strMarkup.Append("</a>");
                            string nwsDesc = row["newsDesc"].ToString().Length >= 154 ? row["newsDesc"].ToString().Substring(0, 154) + "..." : row["newsDesc"].ToString();
                            strMarkup.Append("<span class=\"space10\"></span>");
                            strMarkup.Append("<p>" + nwsDesc + "</p>");
                            strMarkup.Append("</div>");//col-md-7


                            //photo
                            strMarkup.Append("<div class=\"col-md-5\">");

                            if (row["newsPhoto"] != DBNull.Value && row["newsPhoto"].ToString() != "" && row["newsPhoto"].ToString() != "no-photo.png" && row["newsPhoto"] != null)
                            {
                                strMarkup.Append("<img src=\"" + rootPath + "upload/news/thumb/" + row["newsPhoto"].ToString() + "\" alt=\"" + row["newsPhoto"].ToString() + "\" class=\"img-fluid\" />");

                               
                            }
                            else
                                {
                                    //strMarkup.Append("<img src=\"" + rootPath + "upload/news/news-image.png\" class=\"width100\" />");
                                }

                            strMarkup.Append("</div>");//col-md-5
                            strMarkup.Append("</div>");//row featurette                         
                            strMarkup.Append("</div>");//carousel-item active
                           
                            
                        }

                        strMarkup.Append("</div>");//innner
                        strMarkup.Append("</div>");//id

                        //buttons
                        strMarkup.Append("<a class=\"\" type\"button\" data-bs-target=\"#carouselExample\"  data-bs-slide=\"prev\">");
                        strMarkup.Append("<img src=\"images/icons/prev2.png\" />");
                        strMarkup.Append("<span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>");
                        //strMarkup.Append("<span class=\"visually-hidden\">Previous</span>");
                        strMarkup.Append("</a>");

                        strMarkup.Append("<a class=\"\" type\"button\" data-bs-target=\"#carouselExample\" data-bs-slide=\"next\">");
                        strMarkup.Append("<img src=\"images/icons/next3.png\" />");
                        strMarkup.Append("<span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>");
                        //strMarkup.Append("<span class=\"visually-hidden\">Next</span>");
                        strMarkup.Append("</a>");


                        strMarkup.Append("<div class=\"text-center pt-40\">");
                        strMarkup.Append("<span class=\"space30\"></span>");
                        strMarkup.Append("<a href=\"news\" class=\"primary-btn text-uppercase letter-sp-2\">More News</a>");
                         

                        strMarkup.Append("</div>");//pt-40 
                        strMarkup.Append("</div>"); //container
                       

                        strMarkup.Append("<div class=\"float_clear\"></div>");
                        nwsstr = strMarkup.ToString();
                    }
                    

                    else
                    {
                        nwsstr = "<span class=\"infoClr\">Nothing to display come back later.....</span>";
                    }
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