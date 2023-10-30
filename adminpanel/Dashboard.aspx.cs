using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminpanel_Dashboard : System.Web.UI.Page
{
    iClass c = new iClass();
    public string[] arrCounts = new string[30];
    protected void Page_Load(object sender, EventArgs e)
    {
        GetCount();
    }

    protected void GetCount()
    {
        try
        {
            arrCounts[0] = c.returnAggregate("Select Count(newsId) From NewsData where delMark=0").ToString();

            arrCounts[1] = c.returnAggregate("Select Count(ProductId) From OtherProducts where DelMark=0").ToString();

            arrCounts[2] = c.returnAggregate("Select Count(TestId) From Testimonials where DelMark=0").ToString();

            arrCounts[3] = c.returnAggregate("Select Count(CenterID) From CentersData where DelMark=0").ToString();

            arrCounts[4] = c.returnAggregate("Select Count(DocId) From Downloads ").ToString();

            arrCounts[5] = c.returnAggregate("Select Count(JobId) From JobOpenings ").ToString();

            arrCounts[6] = c.returnAggregate("Select Count(StudPlcId) From StudentPlacement ").ToString();

            arrCounts[7] = c.returnAggregate("Select Count(CarActId) From CareerActivity ").ToString();

            arrCounts[8] = c.returnAggregate("Select Count(CertID) From CertificateData ").ToString();
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "GetCount", ex.Message.ToString());
            return;

        }
    }

}