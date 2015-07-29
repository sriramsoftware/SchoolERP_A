using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSLibrarianAttendanceDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ladAttendancedId, System.Int64? ladLibraryManagerId, System.Int64? ladLibrarianId, System.String ladMonth, System.String ladYear, System.String ladOneDate, System.String ladTwoDate, System.String ladThreeDate, System.String ladFourDate, System.String ladFiveDate, System.String ladSixDate, System.String ladSevenDate, System.String ladEightDate, System.String ladNineDate, System.String ladTenDate, System.String ladElevenDate, System.String ladTewelDate, System.String ladThirteenDate, System.String ladFourteenDate, System.String ladFifteenDate, System.String ladSixteenDate, System.String ladSeventeenDate, System.String ladEighteenDate, System.String ladNineteenDate, System.String ladTwentyDate, System.String ladTwentyOneDate, System.String ladTwentyTwoDate, System.String ladTwentyThreeDate, System.String ladTwentyFourDate, System.String ladTwentyFiveDate, System.String ladTwentySixDate, System.String ladTwentySevenDate, System.String ladTwentyEightDate, System.String ladTwentyNineDate, System.String ladThirtyDate, System.String ladThirtyOneDate, System.String ladAttendanceRemark, System.Int64? ladAttendanceBy, System.DateTime? ladDate, System.Int32? ladStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLibrarianAttendanceDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ladAttendancedId, ladLibraryManagerId, ladLibrarianId, ladMonth, ladYear, ladOneDate, ladTwoDate, ladThreeDate, ladFourDate, ladFiveDate, ladSixDate, ladSevenDate, ladEightDate, ladNineDate, ladTenDate, ladElevenDate, ladTewelDate, ladThirteenDate, ladFourteenDate, ladFifteenDate, ladSixteenDate, ladSeventeenDate, ladEighteenDate, ladNineteenDate, ladTwentyDate, ladTwentyOneDate, ladTwentyTwoDate, ladTwentyThreeDate, ladTwentyFourDate, ladTwentyFiveDate, ladTwentySixDate, ladTwentySevenDate, ladTwentyEightDate, ladTwentyNineDate, ladThirtyDate, ladThirtyOneDate, ladAttendanceRemark, ladAttendanceBy, ladDate, ladStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSLibrarianAttendanceDetails searchObject)
    {
        return GetSearch(searchObject.LADAttendancedId, searchObject.LADLibraryManagerId, searchObject.LADLibrarianId, searchObject.LADMonth, searchObject.LADYear, searchObject.LADOneDate, searchObject.LADTwoDate, searchObject.LADThreeDate, searchObject.LADFourDate, searchObject.LADFiveDate, searchObject.LADSixDate, searchObject.LADSevenDate, searchObject.LADEightDate, searchObject.LADNineDate, searchObject.LADTenDate, searchObject.LADElevenDate, searchObject.LADTewelDate, searchObject.LADThirteenDate, searchObject.LADFourteenDate, searchObject.LADFifteenDate, searchObject.LADSixteenDate, searchObject.LADSeventeenDate, searchObject.LADEighteenDate, searchObject.LADNineteenDate, searchObject.LADTwentyDate, searchObject.LADTwentyOneDate, searchObject.LADTwentyTwoDate, searchObject.LADTwentyThreeDate, searchObject.LADTwentyFourDate, searchObject.LADTwentyFiveDate, searchObject.LADTwentySixDate, searchObject.LADTwentySevenDate, searchObject.LADTwentyEightDate, searchObject.LADTwentyNineDate, searchObject.LADThirtyDate, searchObject.LADThirtyOneDate, searchObject.LADAttendanceRemark, searchObject.LADAttendanceBy, searchObject.LADDate, searchObject.LADStatus);
    }

    /// <summary>
    /// Returns all TMSLibrarianAttendanceDetails objects.
    /// </summary>
    /// <returns>List of all TMSLibrarianAttendanceDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    #region Librarian Time-Table
    public static DataSet GetSearchLibrarianAttendance(System.String Day, System.String Month, System.String Year, System.Int64? LibraryId, System.Int64? LibraryManagerId, System.String AttendanceType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchLibrarianMonthlyTimeTable]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Day, Month, Year, LibraryId,LibraryManagerId, AttendanceType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
    #region Insert Attendance
    public static int GetSearchInsertLibrarianAttendance(System.Int64? LibraryId, System.Int64? LibraryManagerId, System.String attendanceRemarks, System.String sadMonth, System.String sadYear, System.Int32? day, System.String attendanceStatus)
    {
        int i;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchInsertLibrarianAttendanceRecord]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LibraryId, LibraryManagerId,attendanceRemarks, sadMonth, sadYear, day, attendanceStatus);

        i = Convert.ToInt32(db.ExecuteScalar(dbCommand));
        return i;
    }
    #endregion
    #region Transport Time-Table
    public static DataSet GetSearchTransportAttendance(System.String Day, System.String Month, System.String Year, System.Int64? LibraryId, System.Int64? LibraryManagerId, System.String AttendanceType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchTransportMonthlyTimeTable]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Day, Month, Year, LibraryId, LibraryManagerId, AttendanceType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}

