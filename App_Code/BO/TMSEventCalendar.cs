using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSEventCalendar
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ecEventId, System.Int64? ecDepartmentId, System.Int64? ecFacultyId, System.Int64? ecSchoolCategoryId, System.Int64? ecSubSchoolCategoryId, System.String ecEventName, System.String ecEventDescriptionOne, System.String ecEventDescriptionTwo, System.String ecEventYear, System.String ecEventStartTime, System.String ecEventEndTime, System.DateTime? ecEventStartDate, System.DateTime? ecEventEndDate, System.String ecEventImageOne, System.String ecEventImageTwo, System.DateTime? ecEventAddDate, System.Int64? ecEventAddedby, System.Int32? ecStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEventCalendar_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ecEventId, ecDepartmentId, ecFacultyId, ecSchoolCategoryId, ecSubSchoolCategoryId, ecEventName, ecEventDescriptionOne, ecEventDescriptionTwo, ecEventYear, ecEventStartTime, ecEventEndTime, ecEventStartDate, ecEventEndDate, ecEventImageOne, ecEventImageTwo, ecEventAddDate, ecEventAddedby, ecStatus);

        return db.ExecuteDataSet(dbCommand);
       
    }



    public static DataSet GetSearch(TMSEventCalendar searchObject)
    {
        return GetSearch(searchObject.ECEventId, searchObject.ECDepartmentId, searchObject.ECFacultyId, searchObject.ECSchoolCategoryId, searchObject.ECSubSchoolCategoryId, searchObject.ECEventName, searchObject.ECEventDescriptionOne, searchObject.ECEventDescriptionTwo, searchObject.ECEventYear, searchObject.ECEventStartTime, searchObject.ECEventEndTime, searchObject.ECEventStartDate, searchObject.ECEventEndDate, searchObject.ECEventImageOne, searchObject.ECEventImageTwo, searchObject.ECEventAddDate, searchObject.ECEventAddedby, searchObject.ECStatus);
    }

    /// <summary>
    /// Returns all TMSEventCalendar objects.
    /// </summary>
    /// <returns>List of all TMSEventCalendar objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    public static DataSet GetEventCalender( )
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEventCalenderDetail";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        return db.ExecuteDataSet(dbCommand);

    }
    public static DataSet GetEventDetails(System.Int64? ecSchoolCategoryId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSEvent_Details";
        dbCommand = db.GetStoredProcCommand(sqlCommand,ecSchoolCategoryId);
        return db.ExecuteDataSet(dbCommand);

    }
    public static DataSet GetEventDetais1(System.Int64? ecEventId)
      {
          DataSet ds;
          Database db;
          string sqlCommand;
          DbCommand dbCommand;
          db = DatabaseFactory.CreateDatabase();
          sqlCommand = "[dbo].gspTMSEvent_Details1";
          dbCommand = db.GetStoredProcCommand(sqlCommand, ecEventId);
          return db.ExecuteDataSet(dbCommand);

      }
    public static DataSet GetEventDateWise(System.Int64? ecSchoolCategoryId,System.String sortType)
      {
          DataSet ds;
          Database db;
          string sqlCommand;
          DbCommand dbCommand;
          db = DatabaseFactory.CreateDatabase();
          sqlCommand = "[dbo].gspTMSEventDetails_DateWise";
          dbCommand = db.GetStoredProcCommand(sqlCommand,ecSchoolCategoryId, sortType);
          return db.ExecuteDataSet(dbCommand);
      }

    #endregion

      public static DataSet GetSearchSort(System.Int64? ecEventId, System.Int64? ecDepartmentId, System.Int64? ecFacultyId, System.Int64? ecSchoolCategoryId, System.Int64? ecSubSchoolCategoryId, System.String ecEventName, System.String ecEventDescriptionOne, System.String ecEventDescriptionTwo, System.String ecEventYear, System.String ecEventStartTime, System.String ecEventEndTime, System.DateTime? ecEventStartDate, System.DateTime? ecEventEndDate, System.String ecEventImageOne, System.String ecEventImageTwo, System.DateTime? ecEventAddDate, System.Int64? ecEventAddedby, System.Int32? ecStatus, System.String ecSortType)
      {
          DataSet ds;
          Database db;
          string sqlCommand;
          DbCommand dbCommand;
          db = DatabaseFactory.CreateDatabase();
          sqlCommand = "[dbo].gspTMSEventCalendar_GetDateWise";
          dbCommand = db.GetStoredProcCommand(sqlCommand, ecEventId, ecDepartmentId, ecFacultyId, ecSchoolCategoryId, ecSubSchoolCategoryId, ecEventName, ecEventDescriptionOne, ecEventDescriptionTwo, ecEventYear, ecEventStartTime, ecEventEndTime, ecEventStartDate, ecEventEndDate, ecEventImageOne, ecEventImageTwo, ecEventAddDate, ecEventAddedby, ecStatus, ecSortType);

          return db.ExecuteDataSet(dbCommand);
      }
      public static DataSet GetEventCalendarDetails(System.String ecSortType)
      {
          DataSet ds;
          Database db;
          string sqlCommand;
          DbCommand dbCommand;
          db = DatabaseFactory.CreateDatabase();
          sqlCommand = "[dbo].gspTMSSearchEventCalendarDetails";
          dbCommand = db.GetStoredProcCommand(sqlCommand, ecSortType);
          return db.ExecuteDataSet(dbCommand);
      }
}

