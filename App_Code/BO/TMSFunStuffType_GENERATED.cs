/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/26/2012 12:49:03 PM                                    */
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
public partial class TMSFunStuffType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FunStuffType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _fstTypeId;
	private System.String _fstTypeName;
	private System.DateTime? _fstDate;
	private System.Int32? _fstStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? FSTTypeId
	{
		get
		{
			return _fstTypeId;
		}
		set
		{
			_fstTypeId = value;
		}
	}
	
	public System.String FSTTypeName
	{
		get
		{
			return _fstTypeName;
		}
		set
		{
			_fstTypeName = value;
		}
	}
	
	public System.DateTime? FSTDate
	{
		get
		{
			return _fstDate;
		}
		set
		{
			_fstDate = value;
		}
	}
	
	public System.Int32? FSTStatus
	{
		get
		{
			return _fstStatus;
		}
		set
		{
			_fstStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FST_TypeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("FST_TypeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("FST_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("FST_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FSTTypeId == null)
		dr["FST_TypeId"] = DBNull.Value;
		else
		dr["FST_TypeId"] = FSTTypeId;
		
		if (FSTTypeName == null)
		dr["FST_TypeName"] = DBNull.Value;
		else
		dr["FST_TypeName"] = FSTTypeName;
		
		if (FSTDate == null)
		dr["FST_Date"] = DBNull.Value;
		else
		dr["FST_Date"] = FSTDate;
		
		if (FSTStatus == null)
		dr["FST_Status"] = DBNull.Value;
		else
		dr["FST_Status"] = FSTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FSTTypeId = dr["FST_TypeId"] != DBNull.Value ? Convert.ToInt64(dr["FST_TypeId"]) : FSTTypeId = null;
		FSTTypeName = dr["FST_TypeName"] != DBNull.Value ? Convert.ToString(dr["FST_TypeName"]) : FSTTypeName = null;
		FSTDate = dr["FST_Date"] != DBNull.Value ? Convert.ToDateTime(dr["FST_Date"]) : FSTDate = null;
		FSTStatus = dr["FST_Status"] != DBNull.Value ? Convert.ToInt32(dr["FST_Status"]) : FSTStatus = null;
	}
	
	public static TMSFunStuffType[] MapFrom(DataSet ds)
	{
		List<TMSFunStuffType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFunStuffType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FunStuffType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FunStuffType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFunStuffType instance = new TMSFunStuffType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFunStuffType Get(System.Int64 fstTypeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFunStuffType instance;
		
		
		instance = new TMSFunStuffType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fstTypeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFunStuffType ID:" + fstTypeId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String fstTypeName, System.DateTime? fstDate, System.Int32? fstStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fstTypeName, fstDate, fstStatus);
		
		if (transaction == null)
		this.FSTTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.FSTTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String fstTypeName, System.DateTime? fstDate, System.Int32? fstStatus)
	{
		Insert(fstTypeName, fstDate, fstStatus, null);
	}
	/// <summary>
	/// Insert current TMSFunStuffType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FSTTypeName, FSTDate, FSTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFunStuffType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? fstTypeId, System.String fstTypeName, System.DateTime? fstDate, System.Int32? fstStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fstTypeId"].Value = fstTypeId;
		dbCommand.Parameters["@fstTypeName"].Value = fstTypeName;
		dbCommand.Parameters["@fstDate"].Value = fstDate;
		dbCommand.Parameters["@fstStatus"].Value = fstStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? fstTypeId, System.String fstTypeName, System.DateTime? fstDate, System.Int32? fstStatus)
	{
		Update(fstTypeId, fstTypeName, fstDate, fstStatus, null);
	}
	
	public static void Update(TMSFunStuffType tMSFunStuffType)
	{
		tMSFunStuffType.Update();
	}
	
	public static void Update(TMSFunStuffType tMSFunStuffType, DbTransaction transaction)
	{
		tMSFunStuffType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFunStuffType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@fstTypeId"].SourceColumn = "FST_TypeId";
		dbCommand.Parameters["@fstTypeName"].SourceColumn = "FST_TypeName";
		dbCommand.Parameters["@fstDate"].SourceColumn = "FST_Date";
		dbCommand.Parameters["@fstStatus"].SourceColumn = "FST_Status";
		
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
	public static void Delete(System.Int64? fstTypeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fstTypeId);
		
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
	public static void Delete(System.Int64? fstTypeId)
	{
		Delete(
		fstTypeId);
	}
	
	/// <summary>
	/// Delete current TMSFunStuffType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FSTTypeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FSTTypeId = null;
	}
	
	/// <summary>
	/// Delete current TMSFunStuffType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFunStuffType[] Search(System.Int64? fstTypeId, System.String fstTypeName, System.DateTime? fstDate, System.Int32? fstStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFunStuffType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, fstTypeId, fstTypeName, fstDate, fstStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFunStuffType.MapFrom(ds);
	}
	
	
	public static TMSFunStuffType[] Search(TMSFunStuffType searchObject)
	{
		return Search ( searchObject.FSTTypeId, searchObject.FSTTypeName, searchObject.FSTDate, searchObject.FSTStatus);
	}
	
	/// <summary>
	/// Returns all TMSFunStuffType objects.
	/// </summary>
	/// <returns>List of all TMSFunStuffType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFunStuffType[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

