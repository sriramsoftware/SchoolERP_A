using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSNoteDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ndNoticeId, System.Int64? ndFacultyId, System.Int64? ndFacultyLoginId, System.Int64? ndSchoolId, System.Int64? ndSchoolSubId, System.Int64? ndSubjectId, System.String ndTitle, System.String ndNoticeDescription, System.String ndDescription, System.DateTime? ndSelectDate, System.DateTime? ndDate, System.Int32? ndStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSNoteDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ndNoticeId, ndFacultyId, ndFacultyLoginId, ndSchoolId, ndSchoolSubId, ndSubjectId, ndTitle, ndNoticeDescription, ndDescription, ndSelectDate, ndDate, ndStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSNoteDetails searchObject)
    {
        return GetSearch(searchObject.NDNoticeId, searchObject.NDFacultyId, searchObject.NDFacultyLoginId, searchObject.NDSchoolId, searchObject.NDSchoolSubId, searchObject.NDSubjectId, searchObject.NDTitle, searchObject.NDNoticeDescription, searchObject.NDDescription, searchObject.NDSelectDate, searchObject.NDDate, searchObject.NDStatus);
    }

    /// <summary>
    /// Returns all TMSNoteDetails objects.
    /// </summary>
    /// <returns>List of all TMSNoteDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

