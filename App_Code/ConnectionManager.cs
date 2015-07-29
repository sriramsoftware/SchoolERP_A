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

/// <summary>
/// Summary description for ConnectionManager
/// </summary>
/// 
namespace TM.Connect
{
    public class ConnectionManager
    {
        public ConnectionManager()
        {

            //
            // TODO: Add constructor logic here
            //
        }

        public SqlConnection Getconnection()
        {
            SqlConnection SchoolErpConnection = null;
            try
            {

                string strConnection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                SchoolErpConnection = new SqlConnection(strConnection);
                return SchoolErpConnection;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}