using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using TM.Connect;
/// <summary>
/// Summary description for Settings
/// </summary>
/// 

namespace Test
{

    public class Settings
    {
        SqlConnection Connection = null;
        public Settings()
        {
            ConnectionManager conmgr = new ConnectionManager();
            Connection = conmgr.Getconnection();
        }

        public DataSet GetHolidayDetails()
        {
            DataSet dsHoliday = new DataSet();
            SqlDataAdapter sqldaHoliday = new SqlDataAdapter("gspTMSHoliday_Get_HolidayDates", Connection);
            sqldaHoliday.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqldaHoliday.Fill(dsHoliday, "Holiday");
            return dsHoliday;
        }

        public bool DeleteProductCategory(int delcatid)
        {
            bool Isdelete = false;
            try
            {
                Connection.Open();
                SqlCommand sqlcmd = new SqlCommand("TMS_UpdateHolidayViewStatus", Connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    sqlcmd.Parameters.AddWithValue("@delcatid", delcatid);
                    Isdelete = Convert.ToBoolean(sqlcmd.ExecuteNonQuery());

                }
                catch (Exception ex) { }
                finally { Connection.Close(); }

            }
            catch (Exception ex) { }
            return Isdelete;
        }

        public bool InsertHolidayDetails(DateTime Hol_Date, string Hol_Reason, int Hol_Status)
        {
            bool isInserted = false;
            Connection.Open();
            SqlCommand sqlcmd = new SqlCommand("TMS_InsertHolidayDetails", Connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Hol_Date", Hol_Date);
            sqlcmd.Parameters.AddWithValue("@Hol_Reason", Hol_Reason);
            sqlcmd.Parameters.AddWithValue("@Hol_Status", Hol_Status);

            isInserted = Convert.ToBoolean(sqlcmd.ExecuteNonQuery());
            Connection.Close();
            return isInserted;
        }

        public bool UpdateHolidayDetails(int Hol_id, DateTime Hol_Date, string Hol_Reason, int Hol_Status)
        {
            bool IsUpdate = false;

            Connection.Open();
            SqlCommand sqlcmd = new SqlCommand("TMS_UpdateHolidayDetails", Connection);
            sqlcmd.CommandType = CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Hol_id", Hol_id);
            sqlcmd.Parameters.AddWithValue("@Hol_Date", Hol_Date);
            sqlcmd.Parameters.AddWithValue("@Hol_Reason", Hol_Reason);
            sqlcmd.Parameters.AddWithValue("@Hol_Status", Hol_Status);

            IsUpdate = Convert.ToBoolean(sqlcmd.ExecuteNonQuery());
            Connection.Close();

            return IsUpdate;
        }

        public DataSet GetSessionPrincipalDetails(int loginId)
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter("TMS_GetFacultyLoginDetails", Connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            // da.SelectCommand.Parameters.AddWithValue("@User_Type", User_Type);
            da.SelectCommand.Parameters.AddWithValue("@loginId", loginId);

            da.Fill(ds, "Principle");
            return ds;
        }

        public DataSet GetSessionParentDetails(int loginId)
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter("TMS_GetParentLoginDetails", Connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            //da.SelectCommand.Parameters.AddWithValue("@User_Type", User_Type);
            da.SelectCommand.Parameters.AddWithValue("@loginId", loginId);

            da.Fill(ds, "Parents");
            return ds;
        }

        public bool InsertContactUsDetails(string Name, string Email, string Phone, string Subject, string Comment)
        {
            bool IsInserted = false;

            Connection.Open();
            SqlCommand cmd = new SqlCommand("TMS_InsertContactUsDetails", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Subject", Subject);
            cmd.Parameters.AddWithValue("@Comment", Comment);

            IsInserted = Convert.ToBoolean(cmd.ExecuteNonQuery());
            Connection.Close();

            return IsInserted;
        }

        public DataSet GetContactDetails()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter("TMS_GetContactUsDetails", Connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(ds, "ContactUs");
            return ds;
        }

        public static string GetCheckedRow(GridView tempGrid, string Control)
        {
            CheckBox CheckBox;

            int KeyId;
            string Id = "";
            foreach (GridViewRow GridViewRow in tempGrid.Rows)
            {
                CheckBox = ((CheckBox)(GridViewRow.FindControl(Control)));
                if (CheckBox.Checked)
                {
                    //KeyId = ((int)(tempGrid.DataKeys.(GridViewRow.RowIndex).Value));
                    KeyId = System.Convert.ToInt32(tempGrid.DataKeys[GridViewRow.RowIndex].Value);
                    if (Id == "")
                    {
                        Id = KeyId.ToString();
                    }
                    else
                    {
                        Id = Id + "," + KeyId.ToString();
                    }
                }
            }
            return Id;
        }

        public bool DeleteContactUsDetails(int ContactId)
        {
            bool IsDelete = false;

            Connection.Open();

            SqlCommand cmd = new SqlCommand("TMS_DeleteContactUsDetails", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ContactId", ContactId);

            IsDelete = Convert.ToBoolean(cmd.ExecuteNonQuery());
            Connection.Close();

            return IsDelete;
        }

        public DataSet GetContactUsSelectedDetails(int ContatID)
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter("TMS_GetContactUsSelectedDetails", Connection);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ContatID", ContatID);

            da.Fill(ds, "ContactUsDtl");
            return ds;
        }
    }
}