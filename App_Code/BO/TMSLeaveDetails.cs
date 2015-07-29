using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSLeaveDetails
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ldLeaveDetailsId, System.Int64? ldFacultyLoginId, System.String ldFacultyType, System.Int32? ldCasualLeave, System.Int32? ldEarnedLeave, System.Int32? ldPaidLeave, System.Int32? ldSickLeave, System.Int32? ldOtherLeave, System.Int32? ldMartialLeave, System.Int32? ldMartinityLeave, System.String ldExtra1, System.String ldExtra2, System.DateTime? ldDate, System.String ldYear, System.Int64? ldAddedById, System.String ldAddedByRemarks, System.String ldOtherRemark, System.Int32? ldStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLeaveDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ldLeaveDetailsId, ldFacultyLoginId, ldFacultyType, ldCasualLeave, ldEarnedLeave, ldPaidLeave, ldSickLeave, ldOtherLeave, ldMartialLeave, ldMartinityLeave, ldExtra1, ldExtra2, ldDate, ldYear, ldAddedById, ldAddedByRemarks, ldOtherRemark, ldStatus);

        ds = db.ExecuteDataSet(dbCommand);
   
        return ds;
    }


    public static DataSet GetSearch(TMSLeaveDetails searchObject)
    {
        return GetSearch(searchObject.LDLeaveDetailsId, searchObject.LDFacultyLoginId, searchObject.LDFacultyType, searchObject.LDCasualLeave, searchObject.LDEarnedLeave, searchObject.LDPaidLeave, searchObject.LDSickLeave, searchObject.LDOtherLeave, searchObject.LDMartialLeave, searchObject.LDMartinityLeave, searchObject.LDExtra1, searchObject.LDExtra2, searchObject.LDDate, searchObject.LDYear, searchObject.LDAddedById, searchObject.LDAddedByRemarks, searchObject.LDOtherRemark, searchObject.LDStatus);
    }

    /// <summary>
    /// Returns all TMSLeaveDetails objects.
    /// </summary>
    /// <returns>List of all TMSLeaveDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }


    public static DataSet GetLeaveDetailsBytype(System.Int64? ldFacultyLoginId, System.String ldFacultyType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetLeaveDetailsBytype";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ldFacultyLoginId, ldFacultyType);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    #endregion
}

