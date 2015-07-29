using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFiles
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? fileID, System.String fileName, System.String filePath, System.String fileDescription, System.Int32? fileStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFiles_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, fileID, fileName, filePath, fileDescription, fileStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSFiles searchObject)
    {
        return GetSearch(searchObject.FileID, searchObject.FileName, searchObject.FilePath, searchObject.FileDescription, searchObject.FileStatus);
    }

    /// <summary>
    /// Returns all TMSFiles objects.
    /// </summary>
    /// <returns>List of all TMSFiles objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null);
    }

    #endregion

}

