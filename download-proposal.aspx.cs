using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class download_proposal : System.Web.UI.Page
{
    iClass c = new iClass();
    public string errMsg;
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSubmit.Attributes.Add("onclick", "this.disabled=true; this.value='Processing...';" + ClientScript.GetPostBackEventReference(btnSubmit, null) + ";");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            txtAdd.Text = txtAdd.Text.Trim().Replace("'", "");
            txtemail.Text = txtemail.Text.Trim().Replace("'", "");
            txtmobile.Text = txtmobile.Text.Trim().Replace("'", "");
            txtName.Text = txtName.Text.Trim().Replace("'", "");
            txtpincode.Text = txtpincode.Text.Trim().Replace("'", "");
            txtcenterNm.Text = txtcenterNm.Text.Trim().Replace("'", "");

            if (txtAdd.Text == "" || txtemail.Text == "" || txtmobile.Text == "" || txtName.Text == "" || txtpincode.Text == "" || txtcenterNm.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'All * marked fields are mandatory');", true);
                return;
            }
            else if (c.ValidateMobile(txtmobile.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid Mobile No');", true);
                return;
            }
            else if (c.EmailAddressCheck(txtemail.Text) == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'Enter  Valid Email Address');", true);
                return;
            }

            //else if (c.IsRecordExist("Select centId From Centersdata Where centMobile = '" + txtmobile.Text + "'"))
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Mobile No is already registered with us');", true);
            //    return;
            //}
            //else if (c.IsRecordExist("Select centId From Centersdata Where centEmail='" + txtemail.Text + "' "))
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('warning', 'This Email Address is already registered with us');", true);
            //    return;
            //}

            //string EncodedResponse = Request.Form["g-Recaptcha-Response"];
            //bool IsCaptchaValid = (ReCaptchaClass.Validate(EncodedResponse) == "True" ? true : false);

            //if (!IsCaptchaValid)
            //{
            //    //InValid Request
            //    ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Captcha Verification Failed');", true);
            //    return;
            //}

            StringBuilder strMail = new StringBuilder();

            strMail.Append("Dear Sir, <br/>");
            strMail.Append("You have a new feedback at vtccdelhi.org, <br/>");
            strMail.Append("Details are given below, <br/><br/>");
            strMail.Append("Traning Center Name : <b>" + txtcenterNm.Text + "</b> <br/>");
            strMail.Append("Name : <b>" + txtName.Text + "</b> <br/>");
            strMail.Append("Address : <b>" + txtAdd.Text + "</b> <br/>");
            strMail.Append("Email : <b>" + txtemail.Text + "</b> <br/>");
            strMail.Append("Mobile : <b>" + txtmobile.Text + "</b> <br/>");
            strMail.Append("Pin Code : <b>" + txtpincode.Text + "</b>");

            //c.SendMail("info@intellect-systems.com", "Eibenstock Positron", "amrutaajari@gmail.com", strMail.ToString(), "New Feedback at PositronSolutions", "", true, "", "");
            //c.SendMail("info@intellect-systems.com", "Eibenstock Positron", "customer.support@positronsolutions.com", strMail.ToString(), "New Feedback at PositronSolutions", "", true, "", "");

            c.SendMail("info@intellect-systems.com", "VTCC Education", "vtccdelhi@gmail.com", strMail.ToString(), "New Feedback at VTCC Education", "", true, "", "");
            //c.SendMail("info@mtsts.org", "VTCC Education", "amrutaajari@gmail.com", strMail.ToString(), "New Feedback at VTCC Education", "", true, "", "");

            
            //errMsg = c.ErrNotification(1, "Thank you for your Feedback..!! We'll get back to you soon..!!");

            

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('success', 'Thank you for your feedback. We will contact you soon.');", true);

            txtName.Text = txtemail.Text = txtmobile.Text = txtAdd.Text = "";

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "myScript", "TostTrigger('error', 'Error Occoured While Processing');", true);
            c.ErrorLogHandler(this.ToString(), "btnSubmit_Click", ex.Message.ToString());
            return;
        }
    }
}