using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSUnitTestDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? utdUnitTestId, System.Int64? utdSchoolCatId, System.Int64? utdSchoolSubCatId, System.String utdTitle, System.String utdDescription, System.String utdStartPeriod, System.String utdEndPeriod, System.DateTime? utdStartDate, System.DateTime? utdEndDate, System.String utdAddedBy, System.DateTime? utdDate, System.Int32? utdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSUnitTestDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, utdUnitTestId, utdSchoolCatId, utdSchoolSubCatId, utdTitle, utdDescription, utdStartPeriod, utdEndPeriod, utdStartDate, utdEndDate, utdAddedBy, utdDate, utdStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSUnitTestDetails searchObject)
    {
        return GetSearch(searchObject.UTDUnitTestId, searchObject.UTDSchoolCatId, searchObject.UTDSchoolSubCatId, searchObject.UTDTitle, searchObject.UTDDescription, searchObject.UTDStartPeriod, searchObject.UTDEndPeriod, searchObject.UTDStartDate, searchObject.UTDEndDate, searchObject.UTDAddedBy, searchObject.UTDDate, searchObject.UTDStatus);
    }

    /// <summary>
    /// Returns all TMSUnitTestDetails objects.
    /// </summary>
    /// <returns>List of all TMSUnitTestDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null);
    }
    public static DataSet GetUnitestdata(System.String Title, System.Int64? standardId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMsGetUnittestdata";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Title, standardId);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    #endregion
}

