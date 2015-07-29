using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSTeacherCourceSyllabus
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? tcTeacherSyllabusID, System.Int64? tcTeacherID, System.Int64? tcSyllabusID, System.String tcDescription, System.DateTime? tcStartDate, System.DateTime? tcEndDate, System.String tcpcpStatus, System.Int32? tcStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTeacherCourceSyllabus_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, tcTeacherSyllabusID, tcTeacherID, tcSyllabusID, tcDescription, tcStartDate, tcEndDate, tcpcpStatus, tcStatus);

        ds = db.ExecuteDataSet(dbCommand);
      
        return ds;
    }


    public static DataSet GetSearch(TMSTeacherCourceSyllabus searchObject)
    {
        return GetSearch(searchObject.TCTeacherSyllabusID, searchObject.TCTeacherID, searchObject.TCSyllabusID, searchObject.TCDescription, searchObject.TCStartDate, searchObject.TCEndDate, searchObject.TCPCPStatus, searchObject.TCStatus);
    }

    /// <summary>
    /// Returns all TMSTeacherCourceSyllabus objects.
    /// </summary>
    /// <returns>List of all TMSTeacherCourceSyllabus objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null);
    }

    #endregion
}

