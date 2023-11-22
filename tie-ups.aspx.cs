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

                            strMarkup.Append("<img src=\"" + Master.rootPath + "upload/tieuplogo/" + row["TieUpLogo"].ToString() + "\" alt=\"" + row["TieUpLogo"].ToString() + "\" class=\"tieup-item\" />");

                            strMarkup.Append("</div>");
                           
                        }
                        strMarkup.Append("<span class=\"space20\"></span>");
                      
                        strMarkup.Append("<div class=\" clrBlack semiBold semiMedium  mb-2\">" + row["TieUpTitle"].ToString() + "</div>");

                        strMarkup.Append("<div class=\"fontRegular line-ht-5 regular mrg_B_15\">" + row["TieUpIntro"].ToString() + "</div>");

                        //certificate
                        if (row["TieUpCertificate"] != DBNull.Value && row["TieUpCertificate"].ToString() != "" && row["TieUpCertificate"].ToString() != "no-photo.png")
                        {
                            
                                strMarkup.Append("<div class=\"tieup-certi\">");

                                strMarkup.Append("<a href=\"" + Master.rootPath + "upload/tieupcerti/" + row["TieUpCertificate"].ToString() + "\" alt=\"" + row["TieUpCertificate"].ToString() + "\"target=\"_blank\" />View Document</a> ");

                                strMarkup.Append("</div>");

                        }
                       
                            strMarkup.Append("<span class=\"space20\"></span>");
                          

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
            return ex.Message.ToString();
        }
    }
}
