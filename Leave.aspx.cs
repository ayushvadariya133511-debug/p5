using System;

namespace WebApplication1
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check Cookie
                if (Request.Cookies["EmployeeUser"] == null)
                {
                    Response.Redirect("WebForm1.aspx");
                    return;
                }

                string userName = Request.Cookies["EmployeeUser"].Value;

                // Store cookie value in Session
                Session["UserName"] = userName;

                // Display username
                lblWelcome.Text = "Welcome, " + userName;
            }
            else
            {
                // Display username from Session
                if (Session["UserName"] != null)
                {
                    lblWelcome.Text =
                        "Welcome, " + Session["UserName"].ToString();
                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblSelectedDate.Text =
                "Selected Date: " +
                Calendar1.SelectedDate.ToString("dd-MM-yyyy");
        }

        protected void btnApplyLeave_Click(object sender, EventArgs e)
        {
            // Check Leave Type
            if (ddlLeaveType.SelectedValue == "")
            {
                lblResult.Text = "Please select a Leave Type.";
                return;
            }

            // Check Date
            if (Calendar1.SelectedDate == DateTime.MinValue)
            {
                lblResult.Text = "Please select a Leave Date.";
                return;
            }

            string userName = "";

            if (Session["UserName"] != null)
            {
                userName = Session["UserName"].ToString();
            }

            string leaveType = ddlLeaveType.SelectedValue;

            string leaveDate =
                Calendar1.SelectedDate.ToString("dd-MM-yyyy");

            lblResult.Text =
                "Leave Applied Successfully!<br/>" +
                "Employee Name: " + userName + "<br/>" +
                "Leave Type: " + leaveType + "<br/>" +
                "Leave Date: " + leaveDate;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear Session
            Session.Clear();
            Session.Abandon();

            // Delete Cookie
            if (Request.Cookies["EmployeeUser"] != null)
            {
                Response.Cookies["EmployeeUser"].Expires =
                    DateTime.Now.AddDays(-1);
            }

            // Go back to Login
            Response.Redirect("WebForm1.aspx");
        }
    }
}
