/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/16/2012 12:26:46 PM                                    */
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
public partial class TMSExamType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ExamType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _etExamTypeId;
	private System.String _etExamTypeName;
	private System.DateTime? _etDate;
	private System.Int32? _etStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ETExamTypeId
	{
		get
		{
			return _etExamTypeId;
		}
		set
		{
			_etExamTypeId = value;
		}
	}
	
	public System.String ETExamTypeName
	{
		get
		{
			return _etExamTypeName;
		}
		set
		{
			_etExamTypeName = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ET_ExamTypeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ET_ExamTypeName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ET_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ET_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ETExamTypeId == null)
		dr["ET_ExamTypeId"] = DBNull.Value;
		else
		dr["ET_ExamTypeId"] = ETExamTypeId;
		
		if (ETExamTypeName == null)
		dr["ET_ExamTypeName"] = DBNull.Value;
		else
		dr["ET_ExamTypeName"] = ETExamTypeName;
		
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
		ETExamTypeId = dr["ET_ExamTypeId"] != DBNull.Value ? Convert.ToInt64(dr["ET_ExamTypeId"]) : ETExamTypeId = null;
		ETExamTypeName = dr["ET_ExamTypeName"] != DBNull.Value ? Convert.ToString(dr["ET_ExamTypeName"]) : ETExamTypeName = null;
		ETDate = dr["ET_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ET_Date"]) : ETDate = null;
		ETStatus = dr["ET_Status"] != DBNull.Value ? Convert.ToInt32(dr["ET_Status"]) : ETStatus = null;
	}
	
	public static TMSExamType[] MapFrom(DataSet ds)
	{
		List<TMSExamType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSExamType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ExamType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ExamType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSExamType instance = new TMSExamType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExamType Get(System.Int64 etExamTypeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSExamType instance;
		
		
		instance = new TMSExamType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etExamTypeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSExamType ID:" + etExamTypeId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String etExamTypeName, System.DateTime? etDate, System.Int32? etStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etExamTypeName, etDate, etStatus);
		
		if (transaction == null)
		this.ETExamTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ETExamTypeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String etExamTypeName, System.DateTime? etDate, System.Int32? etStatus)
	{
		Insert(etExamTypeName, etDate, etStatus, null);
	}
	/// <summary>
	/// Insert current TMSExamType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ETExamTypeName, ETDate, ETStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSExamType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? etExamTypeId, System.String etExamTypeName, System.DateTime? etDate, System.Int32? etStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@etExamTypeId"].Value = etExamTypeId;
		dbCommand.Parameters["@etExamTypeName"].Value = etExamTypeName;
		dbCommand.Parameters["@etDate"].Value = etDate;
		dbCommand.Parameters["@etStatus"].Value = etStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? etExamTypeId, System.String etExamTypeName, System.DateTime? etDate, System.Int32? etStatus)
	{
		Update(etExamTypeId, etExamTypeName, etDate, etStatus, null);
	}
	
	public static void Update(TMSExamType tMSExamType)
	{
		tMSExamType.Update();
	}
	
	public static void Update(TMSExamType tMSExamType, DbTransaction transaction)
	{
		tMSExamType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSExamType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@etExamTypeId"].SourceColumn = "ET_ExamTypeId";
		dbCommand.Parameters["@etExamTypeName"].SourceColumn = "ET_ExamTypeName";
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
	public static void Delete(System.Int64? etExamTypeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etExamTypeId);
		
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
	public static void Delete(System.Int64? etExamTypeId)
	{
		Delete(
		etExamTypeId);
	}
	
	/// <summary>
	/// Delete current TMSExamType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ETExamTypeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ETExamTypeId = null;
	}
	
	/// <summary>
	/// Delete current TMSExamType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSExamType[] Search(System.Int64? etExamTypeId, System.String etExamTypeName, System.DateTime? etDate, System.Int32? etStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSExamType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, etExamTypeId, etExamTypeName, etDate, etStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSExamType.MapFrom(ds);
	}
	
	
	public static TMSExamType[] Search(TMSExamType searchObject)
	{
		return Search ( searchObject.ETExamTypeId, searchObject.ETExamTypeName, searchObject.ETDate, searchObject.ETStatus);
	}
	
	/// <summary>
	/// Returns all TMSExamType objects.
	/// </summary>
	/// <returns>List of all TMSExamType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSExamType[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

