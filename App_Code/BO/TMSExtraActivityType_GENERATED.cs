/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/4/2012 11:54:21 AM                                    */
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
public partial class TMSExtraActivityType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ExtraActivityType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _etActivityTypeID;
	private System.String _etActivityType;
	private System.DateTime? _etDate;
	private System.Int32? _etStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ETActivityTypeID
	{
		get
		{
			return _etActivityTypeID;
		}
		set
		{
			_etActivityTypeID = value;
		}
	}
	
	public System.String ETActivityType
	{
		get
		{
			return _etActivityType;
		}
		set
		{
			_etActivityType = value;
		}
	}
	
	public System.DateTime? ETDate
	{
		get
		{
			return _etDate;
		}
		set
		{
			_etDate = value;
		}
	}
	
	public System.Int32? ETStatus
	{
		get
		{
			return _etStatus;
		}
		set
		{
			_etStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ET_ActivityTypeID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ET_ActivityType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ET_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ET_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ETActivityTypeID == null)
		dr["ET_ActivityTypeID"] = DBNull.Value;
		else
		dr["ET_ActivityTypeID"] = ETActivityTypeID;
		
		if (ETActivityType == null)
		dr["ET_ActivityType"] = DBNull.Value;
		else
		dr["ET_ActivityType"] = ETActivityType;
		
		if (ETDate == null)
		dr["ET_Date"] = DBNull.Value;
		else
		dr["ET_Date"] = ETDate;
		
		if (ETStatus == null)
		dr["ET_Status"] = DBNull.Value;
		else
		dr["ET_Status"] = ETStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ETActivityTypeID = dr["ET_ActivityTypeID"] != DBNull.Value ? Convert.ToInt64(dr["ET_ActivityTypeID"]) : ETActivityTypeID = null;
		ETActivityType = dr["ET_ActivityType"] != DBNull.Value ? Convert.ToString(dr["ET_ActivityType"]) : ETActivityType = null;
		ETDate = dr["ET_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ET_Date"]) : ETDate = null;
		ETStatus = dr["ET_Status"] != DBNull.Value ? Convert.ToInt32(dr["ET_Status"]) : ETStatus = null;
	}
	
	public static TMSExtraActivityType[] MapFrom(DataSet ds)
	{
		List<TMSExtraActivityType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSExtraActivityType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ExtraActivityType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ExtraActivityType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSExtraActivityType instance = new TMSExtraActivityType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExtraActivityType Get(System.Int64 etActivityTypeID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSExtraActivityType instance;
		
		
		instance = new TMSExtraActivityType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etActivityTypeID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSExtraActivityType ID:" + etActivityTypeID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String etActivityType, System.DateTime? etDate, System.Int32? etStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etActivityType, etDate, etStatus);
		
		if (transaction == null)
		this.ETActivityTypeID = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ETActivityTypeID = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String etActivityType, System.DateTime? etDate, System.Int32? etStatus)
	{
		Insert(etActivityType, etDate, etStatus, null);
	}
	/// <summary>
	/// Insert current TMSExtraActivityType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ETActivityType, ETDate, ETStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSExtraActivityType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? etActivityTypeID, System.String etActivityType, System.DateTime? etDate, System.Int32? etStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@etActivityTypeID"].Value = etActivityTypeID;
		dbCommand.Parameters["@etActivityType"].Value = etActivityType;
		dbCommand.Parameters["@etDate"].Value = etDate;
		dbCommand.Parameters["@etStatus"].Value = etStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? etActivityTypeID, System.String etActivityType, System.DateTime? etDate, System.Int32? etStatus)
	{
		Update(etActivityTypeID, etActivityType, etDate, etStatus, null);
	}
	
	public static void Update(TMSExtraActivityType tMSExtraActivityType)
	{
		tMSExtraActivityType.Update();
	}
	
	public static void Update(TMSExtraActivityType tMSExtraActivityType, DbTransaction transaction)
	{
		tMSExtraActivityType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSExtraActivityType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@etActivityTypeID"].SourceColumn = "ET_ActivityTypeID";
		dbCommand.Parameters["@etActivityType"].SourceColumn = "ET_ActivityType";
		dbCommand.Parameters["@etDate"].SourceColumn = "ET_Date";
		dbCommand.Parameters["@etStatus"].SourceColumn = "ET_Status";
		
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
	public static void Delete(System.Int64? etActivityTypeID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etActivityTypeID);
		
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
	public static void Delete(System.Int64? etActivityTypeID)
	{
		Delete(
		etActivityTypeID);
	}
	
	/// <summary>
	/// Delete current TMSExtraActivityType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ETActivityTypeID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ETActivityTypeID = null;
	}
	
	/// <summary>
	/// Delete current TMSExtraActivityType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExtraActivityType[] Search(System.Int64? etActivityTypeID, System.String etActivityType, System.DateTime? etDate, System.Int32? etStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExtraActivityType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etActivityTypeID, etActivityType, etDate, etStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSExtraActivityType.MapFrom(ds);
	}
	
	
	public static TMSExtraActivityType[] Search(TMSExtraActivityType searchObject)
	{
		return Search ( searchObject.ETActivityTypeID, searchObject.ETActivityType, searchObject.ETDate, searchObject.ETStatus);
	}
	
	/// <summary>
	/// Returns all TMSExtraActivityType objects.
	/// </summary>
	/// <returns>List of all TMSExtraActivityType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSExtraActivityType[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

