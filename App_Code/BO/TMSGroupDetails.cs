using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSGroupDetails
{
    #region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static DataSet  GetSearch(System.Int64? gdGroupId, System.Int64? gdSchoolID, System.String gdGroupName, System.String gdGroupDescription, System.String gdGroupTeacherId, System.DateTime? gdDate, System.Int32? gdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSGroupDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, gdGroupId, gdSchoolID, gdGroupName, gdGroupDescription, gdGroupTeacherId, gdDate, gdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		
		return  ds;
	}
	
	
	public static DataSet  GetSearch(TMSGroupDetails searchObject)
	{
		return GetSearch ( searchObject.GDGroupId, searchObject.GDSchoolID, searchObject.GDGroupName, searchObject.GDGroupDescription, searchObject.GDGroupTeacherId, searchObject.GDDate, searchObject.GDStatus);
	}
	
	/// <summary>
	/// Returns all TMSGroupDetails objects.
	/// </summary>
	/// <returns>List of all TMSGroupDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static DataSet  GetSearch()
	{
		return GetSearch ( null, null, null, null, null, null, null);
	}
	
	#endregion


    public static DataSet GetAllTeacherDetails_FromGroups(System.String teacherGroupId, System.Int64? groupId, System.String groupTitle)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_SearchGroupMemberDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, teacherGroupId, groupId, groupTitle);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

