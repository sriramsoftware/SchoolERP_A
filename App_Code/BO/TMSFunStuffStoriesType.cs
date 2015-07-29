
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSFunStuffStoriesType
{
    #region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static DataSet  GetSearch(System.Int64? fsstTypeId, System.String fsstStoriesTypeName, System.DateTime? fsstDate, System.Int32? fsstStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffStoriesType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsstTypeId, fsstStoriesTypeName, fsstDate, fsstStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		return ds;
	}
	
	
	public static DataSet  GetSearch(TMSFunStuffStoriesType searchObject)
	{
		return GetSearch ( searchObject.FSSTTypeId, searchObject.FSSTStoriesTypeName, searchObject.FSSTDate, searchObject.FSSTStatus);
	}
	
	/// <summary>
	/// Returns all TMSFunStuffStoriesType objects.
	/// </summary>
	/// <returns>List of all TMSFunStuffStoriesType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static DataSet  GetSearch()
	{
		return GetSearch ( null, null, null, null);
	}
	
	#endregion
}

