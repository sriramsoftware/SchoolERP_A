/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/26/2012 12:54:19 PM                                    */
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
public partial class TMSFunStuffStoriesType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FunStuffStoriesType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _fsstTypeId;
	private System.String _fsstStoriesTypeName;
	private System.DateTime? _fsstDate;
	private System.Int32? _fsstStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FSSTTypeId
	{
		get
		{
			return _fsstTypeId;
		}
		set
		{
			_fsstTypeId = value;
		}
	}
	
	public System.String FSSTStoriesTypeName
	{
		get
		{
			return _fsstStoriesTypeName;
		}
		set
		{
			_fsstStoriesTypeName = value;
		}
	}
	
	public System.DateTime? FSSTDate
	{
		get
		{
			return _fsstDate;
		}
		set
		{
			_fsstDate = value;
		}
	}
	
	public System.Int32? FSSTStatus
	{
		get
		{
			return _fsstStatus;
		}
		set
		{
			_fsstStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FSST_TypeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FSST_StoriesTypeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSST_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FSST_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FSSTTypeId == null)
		dr["FSST_TypeId"] = DBNull.Value;
		else
		dr["FSST_TypeId"] = FSSTTypeId;
		
		if (FSSTStoriesTypeName == null)
		dr["FSST_StoriesTypeName"] = DBNull.Value;
		else
		dr["FSST_StoriesTypeName"] = FSSTStoriesTypeName;
		
		if (FSSTDate == null)
		dr["FSST_Date"] = DBNull.Value;
		else
		dr["FSST_Date"] = FSSTDate;
		
		if (FSSTStatus == null)
		dr["FSST_Status"] = DBNull.Value;
		else
		dr["FSST_Status"] = FSSTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FSSTTypeId = dr["FSST_TypeId"] != DBNull.Value ? Convert.ToInt64(dr["FSST_TypeId"]) : FSSTTypeId = null;
		FSSTStoriesTypeName = dr["FSST_StoriesTypeName"] != DBNull.Value ? Convert.ToString(dr["FSST_StoriesTypeName"]) : FSSTStoriesTypeName = null;
		FSSTDate = dr["FSST_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FSST_Date"]) : FSSTDate = null;
		FSSTStatus = dr["FSST_Status"] != DBNull.Value ? Convert.ToInt32(dr["FSST_Status"]) : FSSTStatus = null;
	}
	
	public static TMSFunStuffStoriesType[] MapFrom(DataSet ds)
	{
		List<TMSFunStuffStoriesType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFunStuffStoriesType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FunStuffStoriesType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FunStuffStoriesType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFunStuffStoriesType instance = new TMSFunStuffStoriesType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFunStuffStoriesType Get(System.Int64 fsstTypeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFunStuffStoriesType instance;
		
		
		instance = new TMSFunStuffStoriesType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffStoriesType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsstTypeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFunStuffStoriesType ID:" + fsstTypeId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String fsstStoriesTypeName, System.DateTime? fsstDate, System.Int32? fsstStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffStoriesType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsstStoriesTypeName, fsstDate, fsstStatus);
		
		if (transaction == null)
		this.FSSTTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FSSTTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String fsstStoriesTypeName, System.DateTime? fsstDate, System.Int32? fsstStatus)
	{
		Insert(fsstStoriesTypeName, fsstDate, fsstStatus, null);
	}
	/// <summary>
	/// Insert current TMSFunStuffStoriesType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FSSTStoriesTypeName, FSSTDate, FSSTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFunStuffStoriesType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? fsstTypeId, System.String fsstStoriesTypeName, System.DateTime? fsstDate, System.Int32? fsstStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffStoriesType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fsstTypeId"].Value = fsstTypeId;
		dbCommand.Parameters["@fsstStoriesTypeName"].Value = fsstStoriesTypeName;
		dbCommand.Parameters["@fsstDate"].Value = fsstDate;
		dbCommand.Parameters["@fsstStatus"].Value = fsstStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? fsstTypeId, System.String fsstStoriesTypeName, System.DateTime? fsstDate, System.Int32? fsstStatus)
	{
		Update(fsstTypeId, fsstStoriesTypeName, fsstDate, fsstStatus, null);
	}
	
	public static void Update(TMSFunStuffStoriesType tMSFunStuffStoriesType)
	{
		tMSFunStuffStoriesType.Update();
	}
	
	public static void Update(TMSFunStuffStoriesType tMSFunStuffStoriesType, DbTransaction transaction)
	{
		tMSFunStuffStoriesType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFunStuffStoriesType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fsstTypeId"].SourceColumn = "FSST_TypeId";
		dbCommand.Parameters["@fsstStoriesTypeName"].SourceColumn = "FSST_StoriesTypeName";
		dbCommand.Parameters["@fsstDate"].SourceColumn = "FSST_Date";
		dbCommand.Parameters["@fsstStatus"].SourceColumn = "FSST_Status";
		
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
	public static void Delete(System.Int64? fsstTypeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffStoriesType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsstTypeId);
		
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
	public static void Delete(System.Int64? fsstTypeId)
	{
		Delete(
		fsstTypeId);
	}
	
	/// <summary>
	/// Delete current TMSFunStuffStoriesType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffStoriesType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FSSTTypeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FSSTTypeId = null;
	}
	
	/// <summary>
	/// Delete current TMSFunStuffStoriesType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFunStuffStoriesType[] Search(System.Int64? fsstTypeId, System.String fsstStoriesTypeName, System.DateTime? fsstDate, System.Int32? fsstStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffStoriesType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsstTypeId, fsstStoriesTypeName, fsstDate, fsstStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFunStuffStoriesType.MapFrom(ds);
	}
	
	
	public static TMSFunStuffStoriesType[] Search(TMSFunStuffStoriesType searchObject)
	{
		return Search ( searchObject.FSSTTypeId, searchObject.FSSTStoriesTypeName, searchObject.FSSTDate, searchObject.FSSTStatus);
	}
	
	/// <summary>
	/// Returns all TMSFunStuffStoriesType objects.
	/// </summary>
	/// <returns>List of all TMSFunStuffStoriesType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFunStuffStoriesType[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

