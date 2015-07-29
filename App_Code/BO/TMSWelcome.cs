
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSWelcome
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet  GetSearch(System.Int64? wdId, System.String wdDescriptipon, System.DateTime? wdDate, System.String wdVideoPath, System.String wdThumb, System.String wdTitle, System.Int32? wdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSWelcome_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, wdId, wdDescriptipon, wdDate, wdVideoPath, wdThumb, wdTitle, wdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        
        return ds;
    }


    public static DataSet GetSearch(TMSWelcome searchObject)
    {
        return GetSearch(searchObject.WdId, searchObject.WDDescriptipon, searchObject.WDDate, searchObject.WDVideoPath, searchObject.WDThumb, searchObject.WDTitle, searchObject.WDStatus);
    }

    /// <summary>
    /// Returns all TMSWelcome objects.
    /// </summary>
    /// <returns>List of all TMSWelcome objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null);
    }

    #endregion
}

