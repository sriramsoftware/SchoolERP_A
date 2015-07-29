/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 20/07/2015 10:36:51 PM                                    */
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
public partial class TMSFeesHeadMaster
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FeesHeadMaster]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _feeHeadID;
	private System.Int32? _feeCategoryID;
	private System.String _feeHeadName;
	private System.DateTime? _createdDate;
	private System.Boolean? _isDelete;
	
	#endregion
	
	
	#region Properties
	public System.Int32? FeeHeadID
	{
		get
		{
			return _feeHeadID;
		}
		set
		{
			_feeHeadID = value;
		}
	}
	
	public System.Int32? FeeCategoryID
	{
		get
		{
			return _feeCategoryID;
		}
		set
		{
			_feeCategoryID = value;
		}
	}
	
	public System.String FeeHeadName
	{
		get
		{
			return _feeHeadName;
		}
		set
		{
			_feeHeadName = value;
		}
	}
	
	public System.DateTime? CreatedDate
	{
		get
		{
			return _createdDate;
		}
		set
		{
			_createdDate = value;
		}
	}
	
	public System.Boolean? IsDelete
	{
		get
		{
			return _isDelete;
		}
		set
		{
			_isDelete = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FeeHeadID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("FeeCategoryID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("FeeHeadName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CreatedDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("IsDelete", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FeeHeadID == null)
		dr["FeeHeadID"] = DBNull.Value;
		else
		dr["FeeHeadID"] = FeeHeadID;
		
		if (FeeCategoryID == null)
		dr["FeeCategoryID"] = DBNull.Value;
		else
		dr["FeeCategoryID"] = FeeCategoryID;
		
		if (FeeHeadName == null)
		dr["FeeHeadName"] = DBNull.Value;
		else
		dr["FeeHeadName"] = FeeHeadName;
		
		if (CreatedDate == null)
		dr["CreatedDate"] = DBNull.Value;
		else
		dr["CreatedDate"] = CreatedDate;
		
		if (IsDelete == null)
		dr["IsDelete"] = DBNull.Value;
		else
		dr["IsDelete"] = IsDelete;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		FeeHeadID = dr["FeeHeadID"] != DBNull.Value ? Convert.ToInt32(dr["FeeHeadID"]) : FeeHeadID = null;
		FeeCategoryID = dr["FeeCategoryID"] != DBNull.Value ? Convert.ToInt32(dr["FeeCategoryID"]) : FeeCategoryID = null;
		FeeHeadName = dr["FeeHeadName"] != DBNull.Value ? Convert.ToString(dr["FeeHeadName"]) : FeeHeadName = null;
		CreatedDate = dr["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(dr["CreatedDate"]) : CreatedDate = null;
		IsDelete = dr["IsDelete"] != DBNull.Value ? Convert.ToBoolean(dr["IsDelete"]) : IsDelete = null;
	}
	
	public static TMSFeesHeadMaster[] MapFrom(DataSet ds)
	{
		List<TMSFeesHeadMaster> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFeesHeadMaster>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FeesHeadMaster] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FeesHeadMaster] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFeesHeadMaster instance = new TMSFeesHeadMaster();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesHeadMaster Get(System.Int32 feeHeadID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFeesHeadMaster instance;
		
		
		instance = new TMSFeesHeadMaster();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesHeadMaster_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeHeadID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFeesHeadMaster ID:" + feeHeadID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int32? feeCategoryID, System.String feeHeadName, System.DateTime? createdDate, System.Boolean? isDelete, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesHeadMaster_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeCategoryID, feeHeadName, createdDate, isDelete);
		
		if (transaction == null)
		this.FeeHeadID = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.FeeHeadID = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int32? feeCategoryID, System.String feeHeadName, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		Insert(feeCategoryID, feeHeadName, createdDate, isDelete, null);
	}
	/// <summary>
	/// Insert current TMSFeesHeadMaster to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FeeCategoryID, FeeHeadName, CreatedDate, IsDelete, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFeesHeadMaster to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? feeHeadID, System.Int32? feeCategoryID, System.String feeHeadName, System.DateTime? createdDate, System.Boolean? isDelete, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesHeadMaster_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feeHeadID"].Value = feeHeadID;
		dbCommand.Parameters["@feeCategoryID"].Value = feeCategoryID;
		dbCommand.Parameters["@feeHeadName"].Value = feeHeadName;
		dbCommand.Parameters["@createdDate"].Value = createdDate;
		dbCommand.Parameters["@isDelete"].Value = isDelete;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? feeHeadID, System.Int32? feeCategoryID, System.String feeHeadName, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		Update(feeHeadID, feeCategoryID, feeHeadName, createdDate, isDelete, null);
	}
	
	public static void Update(TMSFeesHeadMaster tMSFeesHeadMaster)
	{
		tMSFeesHeadMaster.Update();
	}
	
	public static void Update(TMSFeesHeadMaster tMSFeesHeadMaster, DbTransaction transaction)
	{
		tMSFeesHeadMaster.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFeesHeadMaster_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feeHeadID"].SourceColumn = "FeeHeadID";
		dbCommand.Parameters["@feeCategoryID"].SourceColumn = "FeeCategoryID";
		dbCommand.Parameters["@feeHeadName"].SourceColumn = "FeeHeadName";
		dbCommand.Parameters["@createdDate"].SourceColumn = "CreatedDate";
		dbCommand.Parameters["@isDelete"].SourceColumn = "IsDelete";
		
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
	public static void Delete(System.Int32? feeHeadID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesHeadMaster_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeHeadID);
		
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
	public static void Delete(System.Int32? feeHeadID)
	{
		Delete(
		feeHeadID);
	}
	
	/// <summary>
	/// Delete current TMSFeesHeadMaster from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesHeadMaster_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FeeHeadID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FeeHeadID = null;
	}
	
	/// <summary>
	/// Delete current TMSFeesHeadMaster from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesHeadMaster[] Search(System.Int32? feeHeadID, System.Int32? feeCategoryID, System.String feeHeadName, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesHeadMaster_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeHeadID, feeCategoryID, feeHeadName, createdDate, isDelete);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFeesHeadMaster.MapFrom(ds);
	}
	
	
	public static TMSFeesHeadMaster[] Search(TMSFeesHeadMaster searchObject)
	{
		return Search ( searchObject.FeeHeadID, searchObject.FeeCategoryID, searchObject.FeeHeadName, searchObject.CreatedDate, searchObject.IsDelete);
	}
	
	/// <summary>
	/// Returns all TMSFeesHeadMaster objects.
	/// </summary>
	/// <returns>List of all TMSFeesHeadMaster objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFeesHeadMaster[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

