using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSVideos
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet  GetSearch(System.Int64? vdId, System.String vdVideoPath, System.Int32? vdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSVideos_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, vdId, vdVideoPath, vdStatus);

     return   ds = db.ExecuteDataSet(dbCommand);
       
    }


    public static DataSet GetSearch(TMSVideos searchObject)
    {
        return GetSearch(searchObject.VdId, searchObject.VDVideoPath, searchObject.VDStatus);
    }

    /// <summary>
    /// Returns all TMSVideos objects.
    /// </summary>
    /// <returns>List of all TMSVideos objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null);
    }

    #endregion
}

