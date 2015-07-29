using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFunStuffType
{
    #region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static DataSet GetSearch(System.Int64? fstTypeId, System.String fstTypeName, System.DateTime? fstDate, System.Int32? fstStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fstTypeId, fstTypeName, fstDate, fstStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		
		return ds;
	}
	
	
	public static  DataSet GetSearch (TMSFunStuffType searchObject)
	{
		return GetSearch ( searchObject.FSTTypeId, searchObject.FSTTypeName, searchObject.FSTDate, searchObject.FSTStatus);
	}
	
	/// <summary>
	/// Returns all TMSFunStuffType objects.
	/// </summary>
	/// <returns>List of all TMSFunStuffType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static  DataSet GetSearch()
	{
		return GetSearch ( null, null, null, null);
	}
	
	#endregion
}

