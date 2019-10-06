using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;


public partial class Offer2 : System.Web.UI.Page
{
    SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocaldb;Initial Catalog=BafnaMktg;Integrated Security=true;");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            // to customer

            MailMessage Msg1 = new MailMessage();
            // Sender e-mail address.
            Msg1.From = new MailAddress("pamanedb@gmail.com", "Bafna Motors Pune (Marketing)");
            // Recipient e-mail address.
            Msg1.To.Add(txtEmail.Text.Trim());
            Msg1.CC.Add("rajesh.jadhav@bafnamotors.in");
            //Msg1.CC.Add("mahesh.parab@bafnamotors.in");
            Msg1.Bcc.Add("pamanedb@gmail.com");

            Msg1.Subject = "Welcome to Bafna Motors, Pune";


            Msg1.Body = "Dear " + txtName.Text.Trim() + "\r\n\r\n" +
                "Thank you for your intrest in our product..." + "\r\n" +
                "Our executive will be contact you shrotly..." + "\r\n\r\n" +
                "Regards," + "\r\n" +
                "Bafna Motors Pune," + "\r\n" +
                "Marketing Team";
            // your remote SMTP server IP.
            SmtpClient smtp1 = new SmtpClient();

            //smtp.Host = "smtp.mail.yahoo.com";
            //smtp.Port = 993;
            smtp1.Host = "smtp.gmail.com";
            smtp1.Port = 587;

            smtp1.Credentials = new System.Net.NetworkCredential("pamanedb@gmail.com", "Yash@2710");
            smtp1.EnableSsl = true;
            smtp1.Send(Msg1);

            Msg1 = null;

            //to dealer

            MailMessage Msg = new MailMessage();
            // Sender e-mail address.
            Msg.From = new MailAddress("pamanedb@gmail.com", "Bafna Motors Pune(Marketing)");
            // Recipient e-mail address.
            Msg.To.Add("rajesh.jadhav@bafnamotors.in");
            //Msg.CC.Add("rajesh.jadhav@bafnamotors.in");
            //Msg.CC.Add("mahesh.parab@bafnamotors.in");
            Msg.Bcc.Add("pamanedb@gmail.com");

            Msg.Subject = "Responce From : " + System.IO.Path.GetFileName(Request.Url.AbsolutePath);

            Msg.Body = "Dear Sir, \r\n\r\n" +
                "Please find customer details as given below....\r\n\r\n" +
                "Customer Name : " + txtName.Text.Trim() + "\r\n" +
                "Address \t    : " + txtAddress.Text.Trim() + "\r\n" +
                "Mobile No. \t : " + txtMobile.Text.Trim() + "\r\n" +
                "Email Id   \t : " + txtEmail.Text.Trim() + "\r\n" +
                "Comments   \t : " + txtComments.Text.Trim() + "\r\n\r\n" +
                "Regards,\r\n" +
                "www.bafnamarketing.in";

            SmtpClient smtp = new SmtpClient();

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            smtp.Credentials = new System.Net.NetworkCredential("pamanedb@gmail.com", "Yash@2710");
            smtp.EnableSsl = true;
            smtp.Send(Msg);

            Msg1 = null;
            lblSuccess.Text = "Thank You for your Interest, Our executive will contact you shortly...";
            // Page.RegisterStartupScript("UserMsg", "<script>alert('Mail sent thank you...');if(alert){ window.location='SendMail.aspx';}</script>");
        }
        catch (Exception ex)
        {
            //Response.Write("{0} Exception caught.", ex);
            lblError.Text = "Something is Wrong...";
            Response.Write("Could not send the e-mail - error: " + ex.Message);
        }

        if (sqlCon.State == ConnectionState.Closed)
            sqlCon.Open();
        SqlCommand sqlCmd = new SqlCommand("NewCustomer", sqlCon);
        sqlCmd.CommandType = CommandType.StoredProcedure;
        sqlCmd.Parameters.AddWithValue("@Srno", 1);
        sqlCmd.Parameters.AddWithValue("@Visit_Date", DateTime.Today);
        sqlCmd.Parameters.AddWithValue("@Visitor_Name", txtName.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@V_Address", txtAddress.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@Email_ID", txtEmail.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@Mobile_No", txtMobile.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@Existing", RadioButtonList1.SelectedIndex);
        sqlCmd.Parameters.AddWithValue("@Comments", txtComments.Text.Trim());

       // Response.Write(DateTime.Today.ToString());

        sqlCmd.ExecuteNonQuery();
        sqlCon.Close();

    }
}