using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

public partial class job_openings : System.Web.UI.Page
{
    iClass c = new iClass();
    public string jobstr, bCrumbStr;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {


                if (String.IsNullOrEmpty(Page.RouteData.Values["JobId"].ToString()))
                {
                    GetJobs();

                }
                 else
                {
                    string[] arrLinks = Page.RouteData.Values["JobId"].ToString().Split('-');
                    GetjobsDetails(Convert.ToInt32(arrLinks[arrLinks.Length - 1]));

                }

                int jobTypeValue = 1; // Replace with the actual job type value
                string jobTypeDisplayName = GetJobTypeDisplayName(jobTypeValue);

            }
        }


        catch (Exception ex)
        {
            jobstr = c.ErrNotification(3, ex.Message.ToString());
            return;


        }
    }

    private string GetJobTypeDisplayName(int jobTypeValue)
    {
        switch (jobTypeValue)
        {
            case 1:
                return "Full Time";
            case 2:
                return "Part Time";
            // Add more cases as needed for other values
            default:
                return "Unknown";
        }
    }

    public void GetJobs()
    {
        try
        {
            StringBuilder strMarkup = new StringBuilder();
            using (DataTable dtjobs = c.GetDataTable("SELECT JobId, JobDate, JobTitle, JobInform, JobSkills, FK_JobIndId, JobExperience, JobType  FROM JobOpenings  Order By JobId Desc"))
            // using (DataTable dtjobs = c.GetDataTable("SELECT a.jobId, CONVERT(varchar(20), a.jobDate, 103) as jobDate, a.jobTitle, a.jobUrl,ISNULL( b.centName, 'MTSTS') as centName FROM OtherJobs a Inner Join Centersdata b On a.atcId=b.centId Order By a.jobId Desc"))
            {

                if (dtjobs.Rows.Count > 0)
                {

                    foreach (DataRow row in dtjobs.Rows)
                    {

                        strMarkup.Append("<div class=\"col-md-6 mb-4\">");
                        strMarkup.Append("<div class=\"p-3 border border-secondary\">");
                        strMarkup.Append("<div class=\"p-2\">");


                        string nUrl = Master.rootPath + "job-openings/" + c.UrlGenerator(row["JobTitle"].ToString().ToLower() + "-" + row["JobId"].ToString());

                        string jobsTitle = row["JobTitle"].ToString().Length >= 17 ? row["JobTitle"].ToString().Substring(0, 17) + "..." : row["JobTitle"].ToString();
                        strMarkup.Append("<a href=\"" + nUrl + "\"class=\" semiBold semiMedium themeClrThr\">" + jobsTitle + "</a>");

                        strMarkup.Append("<span class=\"shortLine themeBgPrime\"></span>");
                        strMarkup.Append("</div>"); //p-2

                        strMarkup.Append("<div class=\"p-2\">");
                      
                        DateTime nDate = Convert.ToDateTime(row["JobDate"]);                       
                        strMarkup.Append("<div class=\"regular fontRegular semiBold\">Posted On-<span class=\"fontRegular regular line-ht-5\">" + nDate.ToString("dd MMM yyyy") + "</span></div>");
                        strMarkup.Append("<span class=\"space10\"></span>");
                        strMarkup.Append("<div class=\"regular fontRegular semiBold\">Posted By-<span class=\"fontRegular regular line-ht-5\">" + row["JobTitle"].ToString() + "</span></div>");

                        strMarkup.Append("</div>");//p-2
                        strMarkup.Append("</div>");//col-md-6
                        strMarkup.Append("</div>");//boxShadow
                        
                    }
                    strMarkup.Append("<div class=\"float_clear\"></div>");
                    jobstr = strMarkup.ToString();
                }
                else
                {
                    jobstr = "<span class=\"infoClr\">Nothing to display come back later.....</span>";
                }
            }

        }
        catch (Exception ex)
        {
            jobstr = c.ErrNotification(3, ex.Message.ToString());
            return;

        }
    }

    private void GetjobsDetails(int jobIdx)
    {
        try
        {
            c.ExecuteQuery("Update JobOpenings Set JobViews=JobViews+1 Where JobId=" + jobIdx);
            using (DataTable dtjob = c.GetDataTable("Select * From JobOpenings Where JobId=" + jobIdx))
            {
                if (dtjob.Rows.Count > 0)
                {
                    DataRow row = dtjob.Rows[0];
                    StringBuilder strMarkup = new StringBuilder();

                    this.Title = row["JobTitle"].ToString() + "| JobOpenings, Events of VTCC Education.";

                    strMarkup.Append("<div class=\"container\">");
                    strMarkup.Append("<h2 class=\"pageH2 themeClrPrime mrg_B_5 \">" + row["JobTitle"].ToString() + "</h2>");
                    strMarkup.Append("<span class=\"space15\"></span>");

                    DateTime nDate = Convert.ToDateTime(row["JobDate"]);
                    strMarkup.Append("<span class=\"jobspost\"> VTCC Education | " + nDate.ToString("dd MMM yyyy") + "</span>");

                    strMarkup.Append("<span class=\"space15\"></span>");
                    strMarkup.Append("<span class=\"semiMedium themeClrThr fontregular\">Total Views : " + row["JobViews"].ToString() + "</span>");
                    strMarkup.Append("<span class=\"space20\"></span>");

                    strMarkup.Append("<span class=\"semiMedium fontregular\"> Job Skills : " + row["JobSkills"].ToString() + "</span>");
                    strMarkup.Append("<span class=\"space15\"></span>");
                    strMarkup.Append("<span class=\"semiMedium fontregular\"> Job Experience : " + row["JobExperience"].ToString() + "</span>");
                    strMarkup.Append("<span class=\"space15\"></span>");

                    //string jobtype = "";

                    //if (row["JobType"] == 1)
                    //{
                    //    string = "Full Time";
                    //}

                    //else (jobtype = 2)
                    //{
                    //    string = "Part Time";
                    //}

                    //strMarkup.Append("<span class=\"semiMedium fontregular\"> Job Type : " + row["JobType"].ToString() + "</span>");
                    strMarkup.Append("<span class=\"semiMedium fontregular\"> Job Type : " + GetJobTypeDisplayName(Convert.ToInt32(row["JobType"])) + "</span>");

                    strMarkup.Append("<span class=\"space15\"></span>");
                    strMarkup.Append("<p class=\" semiMedium fontregular\">Job Description : " + Regex.Replace(row["JobInform"].ToString(), @"\r\n?|\n", "<br />") + "</p>");
                    strMarkup.Append("</div>");//container

                    bCrumbStr = "<ul class=\"bCrumb\"><li><a href=\"" + Master.rootPath + "\">Home</a></li><li>&raquo;</li><li><a href=\"" + Master.rootPath + "job-openings\">Jobs Openings</a></li><li>&raquo;</li><li>" + row["JobTitle"].ToString() + "</li></ul>";
                    jobstr = strMarkup.ToString();
                }
            }
        }

        catch (Exception ex)
        {
            jobstr = c.ErrNotification(3, ex.Message.ToString());
            return;


        }
    }
}



