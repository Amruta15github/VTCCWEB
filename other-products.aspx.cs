using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class other_products : System.Web.UI.Page
{
    iClass c = new iClass();
    public string prodstr;
    protected void Page_Load(object sender, EventArgs e)
    {
        Products();
       
    }
    private void Products()
    {
        try
        {

            StringBuilder strMarkup = new StringBuilder();
            using (DataTable dtprod = c.GetDataTable("Select * From OtherProducts Where DelMark=0"))
            {
                if (dtprod.Rows.Count > 0)
                {
                    //int prodSerial = 1;
                    //string productid = "";

                    foreach (DataRow row in dtprod.Rows)
                    {
                        strMarkup.Append("<span class=\"space30\"></span>");
                        //strMarkup.Append("<div class=\"col-md-6\">");
                        // strMarkup.Append("<div class=\"col-md-2 d-flex align-items-sm-start\">");
                        strMarkup.Append("<a href=\"" + row["ProductLink"] + "\" class=\"other semiBold medium mrg_B_10 mt-4 clrBlack\" target=\"_blank\" <span class=\"tiny\"><i class=\"fa fa-circle\" aria-hidden=\"true\"></i></span> " + row["ProductTitle"] + " </a>");
                        strMarkup.Append("<span class=\"greyLine\"></span>");
                        //strMarkup.Append("<div class=\"prodlist flex-shrink-0\">" + "0" + row["ProductId"].ToString() + "</div>");
                        //strMarkup.Append("</div>");

                        //strMarkup.Append("<div class=\"col-md-10\">");
                        // strMarkup.Append("<div class=\"mrg_L_15\">");
                        //strMarkup.Append("<span class=\"semiBold large producttext\">" + row["ProductTitle"].ToString() + "</span>");
                        // strMarkup.Append("</div>");
                        //strMarkup.Append("</div>");
                        //strMarkup.Append("</a>");

                        // strMarkup.Append("</div>");

                        //    if (dtprod.Rows.Count < 10)
                        //    {
                        //        productid = "0" + prodSerial.ToString();
                        //    }
                        //    else
                        //    {
                        //        productid = prodSerial.ToString();
                        //    }
                        //    prodSerial = prodSerial + 1;

                        //    strMarkup.Append("<div class=\"col-md-6\">");
                        //    strMarkup.Append("<div class=\"p-3\">");
                        //strMarkup.Append("<a href=\"" + row["ProductLink"] + "\" class=\"txtDecNone\" target=\"_blank\"><span class=\"semiBold large producttext\">" + row["ProductTitle"].ToString() + "</span></a>");
                        //strMarkup.Append("</div>");
                        //strMarkup.Append("</div>");
                        //}

                    }
                    prodstr = strMarkup.ToString();
                }

                else
                {
                    prodstr = "No VTCC Other Products To Display";
                }

            }
        }
        catch (Exception ex)
        {
            prodstr = c.ErrNotification(3, ex.Message.ToString());
            return;
        }
    }
   
}