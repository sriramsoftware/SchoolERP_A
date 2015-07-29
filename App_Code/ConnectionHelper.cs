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
/// Summary description for ConnectionHelper
/// </summary>
public class ConnectionHelper
{
    string _connectionString;
    SqlConnection _connection;
    public ConnectionHelper()
    {
        _connectionString = Convert.ToString(ConfigurationManager.ConnectionStrings["Default"]);
        //
        // TODO: Add constructor logic here
        //
    }
    #region Connection
    public SqlConnection GetConnection()
    {
        if (_connection == null)
        {
            _connection = new SqlConnection(_connectionString);
        }
        try
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }
        catch (Exception ex)
        {
        }
        return _connection;
    }

    public void CloseConnection(SqlConnection connectionString)
    {
        try
        {
            if (connectionString.State == ConnectionState.Open)
                connectionString.Close();
        }
        catch (Exception ex)
        {
        }
    }
    #endregion

}
