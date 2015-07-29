using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSUploadLectureDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ulLectureId, System.Int64? ulFacultyId, System.Int64? ulFacultyLoginId, System.Int64? ulSchoolId, System.Int64? ulSchoolSubId, System.String ulTitle, System.String ulDescription, System.String ulVideoName, System.String ulThumbnailName, System.String ulExtra, System.DateTime? ulLectureDate, System.DateTime? ulDate, System.Int32? ulStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSUploadLectureDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ulLectureId, ulFacultyId, ulFacultyLoginId, ulSchoolId, ulSchoolSubId, ulTitle, ulDescription, ulVideoName, ulThumbnailName, ulExtra, ulLectureDate, ulDate, ulStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSUploadLectureDetails searchObject)
    {
        return GetSearch(searchObject.ULLectureId, searchObject.ULFacultyId, searchObject.ULFacultyLoginId, searchObject.ULSchoolId, searchObject.ULSchoolSubId, searchObject.ULTitle, searchObject.ULDescription, searchObject.ULVideoName, searchObject.ULThumbnailName, searchObject.ULExtra, searchObject.ULLectureDate, searchObject.ULDate, searchObject.ULStatus);
    }

    /// <summary>
    /// Returns all TMSUploadLectureDetails objects.
    /// </summary>
    /// <returns>List of all TMSUploadLectureDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

