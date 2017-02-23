using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sourav
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DBoperation db = new DBoperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                grid_student();
               
            }
        }
        protected void grid_student()
        {
            string _query = @"SELECT [id]
                                  ,[name]
                                  ,[phone]
                                  ,[address]
                              FROM [dbo].[Student_info]";
            GridView_student.DataSource = db.GetDataTable(_query);
            GridView_student.DataBind();
        }

        protected void GridView_student_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_student.PageIndex = e.NewPageIndex;
            grid_student();
        }

        protected void GridView_student_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView_student.EditIndex = -1;
            grid_student();

        }

        protected void GridView_student_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label LabelID= (Label)GridView_student.Rows[e.RowIndex].FindControl("Label_id");
            string strQuery = @"DELETE FROM [dbo].[Student_info]
                               WHERE id="+ LabelID.Text;
            if (db.ExecuteQuery(strQuery) == 1)
            {
                grid_student();
                Response.Redirect("~/WebForm1.aspx");
            }
        }

        protected void GridView_student_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView_student.EditIndex = e.NewEditIndex;
            grid_student();

        }

        protected void GridView_student_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label LabelID = (Label)GridView_student.Rows[e.RowIndex].FindControl("Label_id");
            TextBox txtName = (TextBox)GridView_student.Rows[e.RowIndex].FindControl("TextBox_name");
            TextBox txtPhone = (TextBox)GridView_student.Rows[e.RowIndex].FindControl("TextBox_phone");
            TextBox txtAddress = (TextBox)GridView_student.Rows[e.RowIndex].FindControl("TextBox_address");



            string strQuery = @"UPDATE [dbo].[Student_info]
            SET [name] ='"+txtName.Text+ "',[phone] ='"+txtPhone.Text+"',[address] ='"+txtAddress.Text+"' WHERE id="+LabelID.Text;
            if (db.ExecuteQuery(strQuery) == 1)
            {
                GridView_student.EditIndex = -1;
                grid_student();
                Response.Redirect("~/WebForm1.aspx");
            }
           

        }
    }
}