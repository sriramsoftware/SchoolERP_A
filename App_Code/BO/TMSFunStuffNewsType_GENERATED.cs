/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/26/2012 1:04:05 PM                                    */
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
public partial class TMSFunStuffNewsType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FunStuffNewsType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _fsntTypeId;
	private System.String _fsntNewsTypeName;
	private System.DateTime? _fsntDate;
	private System.Int32? _fsntStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FSNTTypeId
	{
		get
		{
			return _fsntTypeId;
		}
		set
		{
			_fsntTypeId = value;
		}
	}
	
	public System.String FSNTNewsTypeName
	{
		get
		{
			return _fsntNewsTypeName;
		}
		set
		{
			_fsntNewsTypeName = value;
		}
	}
	
	public System.DateTime? FSNTDate
	{
		get
		{
			return _fsntDate;
		}
		set
		{
			_fsntDate = value;
		}
	}
	
	public System.Int32? FSNTStatus
	{
		get
		{
			return _fsntStatus;
		}
		set
		{
			_fsntStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FSNT_TypeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FSNT_NewsTypeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FSNT_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FSNT_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FSNTTypeId == null)
		dr["FSNT_TypeId"] = DBNull.Value;
		else
		dr["FSNT_TypeId"] = FSNTTypeId;
		
		if (FSNTNewsTypeName == null)
		dr["FSNT_NewsTypeName"] = DBNull.Value;
		else
		dr["FSNT_NewsTypeName"] = FSNTNewsTypeName;
		
		if (FSNTDate == null)
		dr["FSNT_Date"] = DBNull.Value;
		else
		dr["FSNT_Date"] = FSNTDate;
		
		if (FSNTStatus == null)
		dr["FSNT_Status"] = DBNull.Value;
		else
		dr["FSNT_Status"] = FSNTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FSNTTypeId = dr["FSNT_TypeId"] != DBNull.Value ? Convert.ToInt64(dr["FSNT_TypeId"]) : FSNTTypeId = null;
		FSNTNewsTypeName = dr["FSNT_NewsTypeName"] != DBNull.Value ? Convert.ToString(dr["FSNT_NewsTypeName"]) : FSNTNewsTypeName = null;
		FSNTDate = dr["FSNT_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FSNT_Date"]) : FSNTDate = null;
		FSNTStatus = dr["FSNT_Status"] != DBNull.Value ? Convert.ToInt32(dr["FSNT_Status"]) : FSNTStatus = null;
	}
	
	public static TMSFunStuffNewsType[] MapFrom(DataSet ds)
	{
		List<TMSFunStuffNewsType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFunStuffNewsType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FunStuffNewsType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FunStuffNewsType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFunStuffNewsType instance = new TMSFunStuffNewsType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFunStuffNewsType Get(System.Int64 fsntTypeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFunStuffNewsType instance;
		
		
		instance = new TMSFunStuffNewsType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffNewsType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsntTypeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFunStuffNewsType ID:" + fsntTypeId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String fsntNewsTypeName, System.DateTime? fsntDate, System.Int32? fsntStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffNewsType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsntNewsTypeName, fsntDate, fsntStatus);
		
		if (transaction == null)
		this.FSNTTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FSNTTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String fsntNewsTypeName, System.DateTime? fsntDate, System.Int32? fsntStatus)
	{
		Insert(fsntNewsTypeName, fsntDate, fsntStatus, null);
	}
	/// <summary>
	/// Insert current TMSFunStuffNewsType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FSNTNewsTypeName, FSNTDate, FSNTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFunStuffNewsType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? fsntTypeId, System.String fsntNewsTypeName, System.DateTime? fsntDate, System.Int32? fsntStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffNewsType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fsntTypeId"].Value = fsntTypeId;
		dbCommand.Parameters["@fsntNewsTypeName"].Value = fsntNewsTypeName;
		dbCommand.Parameters["@fsntDate"].Value = fsntDate;
		dbCommand.Parameters["@fsntStatus"].Value = fsntStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? fsntTypeId, System.String fsntNewsTypeName, System.DateTime? fsntDate, System.Int32? fsntStatus)
	{
		Update(fsntTypeId, fsntNewsTypeName, fsntDate, fsntStatus, null);
	}
	
	public static void Update(TMSFunStuffNewsType tMSFunStuffNewsType)
	{
		tMSFunStuffNewsType.Update();
	}
	
	public static void Update(TMSFunStuffNewsType tMSFunStuffNewsType, DbTransaction transaction)
	{
		tMSFunStuffNewsType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFunStuffNewsType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fsntTypeId"].SourceColumn = "FSNT_TypeId";
		dbCommand.Parameters["@fsntNewsTypeName"].SourceColumn = "FSNT_NewsTypeName";
		dbCommand.Parameters["@fsntDate"].SourceColumn = "FSNT_Date";
		dbCommand.Parameters["@fsntStatus"].SourceColumn = "FSNT_Status";
		
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
	public static void Delete(System.Int64? fsntTypeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffNewsType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsntTypeId);
		
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
	public static void Delete(System.Int64? fsntTypeId)
	{
		Delete(
		fsntTypeId);
	}
	
	/// <summary>
	/// Delete current TMSFunStuffNewsType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffNewsType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FSNTTypeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FSNTTypeId = null;
	}
	
	/// <summary>
	/// Delete current TMSFunStuffNewsType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFunStuffNewsType[] Search(System.Int64? fsntTypeId, System.String fsntNewsTypeName, System.DateTime? fsntDate, System.Int32? fsntStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffNewsType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fsntTypeId, fsntNewsTypeName, fsntDate, fsntStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFunStuffNewsType.MapFrom(ds);
	}
	
	
	public static TMSFunStuffNewsType[] Search(TMSFunStuffNewsType searchObject)
	{
		return Search ( searchObject.FSNTTypeId, searchObject.FSNTNewsTypeName, searchObject.FSNTDate, searchObject.FSNTStatus);
	}
	
	/// <summary>
	/// Returns all TMSFunStuffNewsType objects.
	/// </summary>
	/// <returns>List of all TMSFunStuffNewsType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFunStuffNewsType[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

