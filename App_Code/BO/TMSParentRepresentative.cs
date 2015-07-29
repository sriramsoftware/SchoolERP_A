using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSParentRepresentative
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? prId, System.Int64? prParentID, System.Int64? prStandard, System.Int64? prDivision, System.String prType, System.DateTime? prDate, System.Int32? prStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSParentRepresentative_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, prId, prParentID, prStandard, prDivision, prType, prDate, prStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSParentRepresentative searchObject)
    {
        return GetSearch(searchObject.PrId, searchObject.PRParentID, searchObject.PRStandard, searchObject.PRDivision, searchObject.PRType, searchObject.PRDate, searchObject.PRStatus);
    }

    /// <summary>
    /// Returns all TMSParentRepresentative objects.
    /// </summary>
    /// <returns>List of all TMSParentRepresentative objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null);
    }


    public static DataSet GetPerentNameList(System.Int64? prStandard, System.Int64? prDivision)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetPerentNameListAccordingtoStandard";
        dbCommand = db.GetStoredProcCommand(sqlCommand,  prStandard, prDivision);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetParentDetailslist()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetParentDetailslist";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }   

    public static DataSet FillPearentRepresentative(System.Int64? prStandard, System.Int64? prDivision)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMSrFillPearentRepresentative";
        dbCommand = db.GetStoredProcCommand(sqlCommand, prStandard, prDivision);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    #endregion

}

