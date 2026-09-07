using System;
using System.Web;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If the user is already logged in,
            // directly go to the Leave page.
            if (!IsPostBack)
            {
                if (Request.Cookies["EmployeeUser"] != null)
                {
                    Response.Redirect("Leave.aspx");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // For this student project, anyone can login
            // as long as Name and Password are entered.
            if (name == "" || password == "")
            {
                lblMessage.Text = "Please enter Name and Password.";
                return;
            }

            // Store username in Session
            Session["UserName"] = name;

            // Create Cookie
            HttpCookie userCookie = new HttpCookie("EmployeeUser");

            userCookie.Value = name;
            userCookie.Expires = DateTime.Now.AddMinutes(30);
            userCookie.HttpOnly = true;

            Response.Cookies.Add(userCookie);

            // Redirect to Leave Page
            Response.Redirect("Leave.aspx");
        }
    }
}
