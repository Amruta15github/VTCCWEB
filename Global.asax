<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        RegisterRoutes(System.Web.Routing.RouteTable.Routes);

    }
    void RegisterRoutes(System.Web.Routing.RouteCollection routes)
    {
        routes.MapPageRoute("prod-route", "products/{pageId}", "~/products.aspx", false, new System.Web.Routing.RouteValueDictionary { { "pageId", string.Empty } });

        routes.MapPageRoute("news-route", "news/{newsId}", "~/news.aspx", false, new System.Web.Routing.RouteValueDictionary { { "newsId", string.Empty } });
        routes.MapPageRoute("jobs-route", "job-openings/{JobId}", "~/job-openings.aspx", false, new System.Web.Routing.RouteValueDictionary { { "JobId", string.Empty } });
        routes.MapPageRoute("career-activities-route", "career-activities/{CarActId}", "~/career-activities.aspx", false, new System.Web.Routing.RouteValueDictionary { { "CarActId", string.Empty } });

        routes.MapPageRoute("abt-route", "about-us", "~/about-us.aspx");
        routes.MapPageRoute("course-route", "courses", "~/courses.aspx");
        routes.MapPageRoute("contact-route", "contact-us", "~/contact-us.aspx");
        routes.MapPageRoute("learning-route", "learning-center", "~/learning-center.aspx");
        routes.MapPageRoute("tie-up-route", "tie-ups", "~/tie-ups.aspx");
        routes.MapPageRoute("training-center-route", "training-centers", "~/training-centers.aspx");
        routes.MapPageRoute("center-reg-route", "center-registration", "~/center-registration.aspx");
        routes.MapPageRoute("atc-renewal-route", "atc-renewal", "~/atc-renewal.aspx");
        routes.MapPageRoute("doc-download-route", "document-download", "~/document-download.aspx");
        routes.MapPageRoute("sam-certificates-route", "sample-certificates", "~/sample-certificates.aspx");
        routes.MapPageRoute("download-proposal-route", "download-proposal", "~/download-proposal.aspx");
        //routes.MapPageRoute("job-openings-route", "job-openings", "~/job-openings.aspx");
       //routes.MapPageRoute("career-activities-route", "career-activities", "~/career-activities.aspx");
        routes.MapPageRoute("placed-students-route", "placed-students", "~/placed-students.aspx");
        routes.MapPageRoute("faq-route", "faq", "~/faq.aspx");
        routes.MapPageRoute("disclaimer-route", "disclaimer", "~/disclaimer.aspx");
        routes.MapPageRoute("privacy-policy-route", "privacy-policy", "~/privacy-policy.aspx");
        routes.MapPageRoute("terms-services-route", "terms-services", "~/terms-of-services.aspx");
        routes.MapPageRoute("terms-conditions-route", "terms-conditions", "~/terms-conditions.aspx");
        routes.MapPageRoute("other-products-route", "other-products", "~/other-products.aspx");
        routes.MapPageRoute("online-payment-route", "online-payment", "~/online-payment.aspx");
        routes.MapPageRoute("affiliation-centers-route", "affiliation-centers", "~/affiliation-centers.aspx");
    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

    protected void Application_BeginRequest(Object sender, EventArgs e)
    {
        //if (!Request.IsSecureConnection)
        //{
        //    string path = string.Format("https{0}", Request.Url.AbsoluteUri.Substring(4));
        //    Response.Redirect(path);
        //}
    }

</script>
