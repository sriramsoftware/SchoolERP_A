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
using TM.Connect;
using System.Data.SqlClient;

/// <summary>
/// Summary description for VendorMngmt
/// </summary>
public class VendorMngmt
{
    SqlConnection Connection = null;

	public VendorMngmt()
	{
        ConnectionManager conmgr = new ConnectionManager();
        Connection = conmgr.Getconnection();
	}

    public static string GetPhysicalPath(string virtualPath)
    {
        string filepath = "";
        if (virtualPath.IndexOf("localhost:") >= 0)
        {
            string path = virtualPath.Replace(HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Host, "");
            if (path.IndexOf(":") >= 0)
            {
                int lenindex = path.IndexOf('/');
                path = path.Remove(0, lenindex);
            }
            filepath = HttpContext.Current.Server.MapPath(path.Replace(HttpContext.Current.Request.Url.Scheme + "://www." + HttpContext.Current.Request.Url.Host, ""));
        }
        else
        {
            string path = virtualPath.Replace(HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Host, "");
            filepath = HttpContext.Current.Server.MapPath(path.Replace(HttpContext.Current.Request.Url.Scheme + "://www." + HttpContext.Current.Request.Url.Host, ""));
        }
        return filepath;
    }


    public DataSet GetVendorDetailsByLogin(int UserId)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("TMS_GetLoginVendorDetails", Connection);

        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.AddWithValue("@UserId", UserId);

        da.Fill(ds, "Vendor");
        return ds;
    }

    public DataSet GetLoginVendorDetails(int VendorId)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("TMS_GetLoginVendorAllDetails", Connection);

        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.AddWithValue("@VendorId", VendorId);

        da.Fill(ds, "VendorAll");
        return ds;
    }

    public bool UploadVendorPhoto(int VendorId, string virtualpath2)
    {
        bool Isupdate = false;

        Connection.Open();
        SqlCommand cmd = new SqlCommand("TMS_UploadVendorPhoto", Connection);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@VendorId", VendorId);
        cmd.Parameters.AddWithValue("@virtualpath2", virtualpath2);

        Isupdate = Convert.ToBoolean(cmd.ExecuteNonQuery());

        Connection.Close();

        return Isupdate;

    }

    public DataSet GetUserType()
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("TMS_GetUserType", Connection);

        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds, "UserType");
        return ds;
    }

    public DataSet GetAllVendorDetailsByLogin(int VendorId)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("TMS_GetVendorDetailsForViewAndEdit", Connection);

        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@VendorId", VendorId);
        da.Fill(ds, "VendorDetails");

        return ds;
    }

    public DataSet GetUserIdByLoginId(int UserId)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("TMS_GetUserIdByLoginId", Connection);

        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserId", UserId);
        da.Fill(ds, "VendorID");

        return ds;
    }
}
