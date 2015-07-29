
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSFunStuffNewsType
{	
    #region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static DataSet  GetSearch(System.Int64? fsntTypeId, System.String fsntNewsTypeName, System.DateTime? fsntDate, System.Int32? fsntStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffNewsType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsntTypeId, fsntNewsTypeName, fsntDate, fsntStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		
		return 	ds;
	}
	
	
	public static DataSet  GetSearch(TMSFunStuffNewsType searchObject)
	{
		return GetSearch ( searchObject.FSNTTypeId, searchObject.FSNTNewsTypeName, searchObject.FSNTDate, searchObject.FSNTStatus);
	}
	
	/// <summary>
	/// Returns all TMSFunStuffNewsType objects.
	/// </summary>
	/// <returns>List of all TMSFunStuffNewsType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static DataSet  GetSearch()
	{
		return GetSearch ( null, null, null, null);
	}
	
	#endregion
}

