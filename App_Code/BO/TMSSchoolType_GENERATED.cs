/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/14/2012 10:27:49 AM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSSchoolType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SchoolType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _stTypeId;
	private System.String _ststTypeName;
	private System.Int32? _stStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? STTypeId
	{
		get
		{
			return _stTypeId;
		}
		set
		{
			_stTypeId = value;
		}
	}
	
	public System.String STSTTypeName
	{
		get
		{
			return _ststTypeName;
		}
		set
		{
			_ststTypeName = value;
		}
	}
	
	public System.Int32? STStatus
	{
		get
		{
			return _stStatus;
		}
		set
		{
			_stStatus = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("ST_TypeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_ST_TypeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (STTypeId == null)
		dr["ST_TypeId"] = DBNull.Value;
		else
		dr["ST_TypeId"] = STTypeId;
		
		if (STSTTypeName == null)
		dr["ST_ST_TypeName"] = DBNull.Value;
		else
		dr["ST_ST_TypeName"] = STSTTypeName;
		
		if (STStatus == null)
		dr["ST_Status"] = DBNull.Value;
		else
		dr["ST_Status"] = STStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		STTypeId = dr["ST_TypeId"] != DBNull.Value ? Convert.ToInt64(dr["ST_TypeId"]) : STTypeId = null;
		STSTTypeName = dr["ST_ST_TypeName"] != DBNull.Value ? Convert.ToString(dr["ST_ST_TypeName"]) : STSTTypeName = null;
		STStatus = dr["ST_Status"] != DBNull.Value ? Convert.ToInt32(dr["ST_Status"]) : STStatus = null;
	}
	
	public static TMSSchoolType[] MapFrom(DataSet ds)
	{
		List<TMSSchoolType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSchoolType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SchoolType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SchoolType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSchoolType instance = new TMSSchoolType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSchoolType Get(System.Int64 stTypeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSchoolType instance;
		
		
		instance = new TMSSchoolType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stTypeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSSchoolType ID:" + stTypeId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String ststTypeName, System.Int32? stStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ststTypeName, stStatus);
		
		if (transaction == null)
		this.STTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.STTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String ststTypeName, System.Int32? stStatus)
	{
		Insert(ststTypeName, stStatus, null);
	}
	/// <summary>
	/// Insert current TMSSchoolType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(STSTTypeName, STStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSchoolType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? stTypeId, System.String ststTypeName, System.Int32? stStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@stTypeId"].Value = stTypeId;
		dbCommand.Parameters["@ststTypeName"].Value = ststTypeName;
		dbCommand.Parameters["@stStatus"].Value = stStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? stTypeId, System.String ststTypeName, System.Int32? stStatus)
	{
		Update(stTypeId, ststTypeName, stStatus, null);
	}
	
	public static void Update(TMSSchoolType tMSSchoolType)
	{
		tMSSchoolType.Update();
	}
	
	public static void Update(TMSSchoolType tMSSchoolType, DbTransaction transaction)
	{
		tMSSchoolType.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@stTypeId"].SourceColumn = "ST_TypeId";
		dbCommand.Parameters["@ststTypeName"].SourceColumn = "ST_ST_TypeName";
		dbCommand.Parameters["@stStatus"].SourceColumn = "ST_Status";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int64? stTypeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stTypeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int64? stTypeId)
	{
		Delete(
		stTypeId);
	}
	
	/// <summary>
	/// Delete current TMSSchoolType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, STTypeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.STTypeId = null;
	}
	
	/// <summary>
	/// Delete current TMSSchoolType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSchoolType[] Search(System.Int64? stTypeId, System.String ststTypeName, System.Int32? stStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stTypeId, ststTypeName, stStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSchoolType.MapFrom(ds);
	}
	
	
	public static TMSSchoolType[] Search(TMSSchoolType searchObject)
	{
		return Search ( searchObject.STTypeId, searchObject.STSTTypeName, searchObject.STStatus);
	}
	
	/// <summary>
	/// Returns all TMSSchoolType objects.
	/// </summary>
	/// <returns>List of all TMSSchoolType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSchoolType[] Search()
	{
		return Search ( null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

