using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

public partial class document_download : System.Web.UI.Page
{
    iClass c = new iClass();
    public string documentstr, bCrumbStr;
    protected void Page_Load(object sender, EventArgs e)
    {
        GetDocuments();
       

       //GetDetails(Convert.ToInt32(Request.QueryString["id"]));
            
    }
    public string GetDocuments()
    {

        try
        {

            StringBuilder strMarkup = new StringBuilder();
            using (DataTable dtdocdata = c.GetDataTable("Select * From Downloads"))
            {
               

                if (dtdocdata.Rows.Count > 0)
                {
                    //c.ExecuteQuery("Update Downloads Set DownCount=DownCount+1 Where DocId=" + row["DocId"].ToString());
                    foreach (DataRow row in dtdocdata.Rows)
                    {
                       
                        strMarkup.Append("<div class=\"col-sm-4\">");

                       
                        strMarkup.Append("<a href=\"" + Master.rootPath + "downloads/" + row["DocLink"].ToString()+ "?docfile=" + row["DocId"].ToString()+ "\" class=\"news-Tag fontRegular regular\" target=\"_blank\">" + row["DocName"].ToString() + "</a>");
                       
                        strMarkup.Append("<span class=\"space10\"></span>");

                        strMarkup.Append("<a href=\"" + Master.rootPath + "downloads/" + row["DocLink"].ToString() + " \" class=\"pdfAnch\" target=\"_blank\"> Download &#10230;</a>");
                        strMarkup.Append("<span class=\"space30\"></span>");
                        strMarkup.Append("</div>");


                    }
                    return strMarkup.ToString();
                }
                else
                {
                    return "<div class=\"\"><div class=\"pad_10\"><span class=\" semiMedium fontRegular\">No Documents to display..</span></div></div>";
                }
            }
        }
        catch (Exception ex)
        {
            return ex.Message.ToString();
        }
    }

    //private void GetDetails(int docIdx)
    //{
    //    try
    //    {
    //        using (DataTable dtNws = c.GetDataTable("Select * From Downloads Where DocId=" + docIdx))
    //        {
    //            if (dtNws.Rows.Count > 0)
    //            {
    //                DataRow row = dtNws.Rows[0];
    //                StringBuilder strMarkup = new StringBuilder();

                    
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        documentstr = c.ErrNotification(3, ex.Message.ToString());
    //        return;

    //    }
    //}
}