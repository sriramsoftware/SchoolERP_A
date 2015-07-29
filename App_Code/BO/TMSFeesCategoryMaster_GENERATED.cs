/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 18/07/2015 01:46:19 PM                                    */
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
public partial class TMSFeesCategoryMaster
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FeesCategoryMaster]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _feeCategoryID;
	private System.String _feeCategoryName;
	private System.DateTime? _createdDate;
	private System.Boolean? _isDelete;
	
	#endregion
	
	
	#region Properties
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
	
	public System.String FeeCategoryName
	{
		get
		{
			return _feeCategoryName;
		}
		set
		{
			_feeCategoryName = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("FeeCategoryID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("FeeCategoryName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CreatedDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("IsDelete", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (FeeCategoryID == null)
		dr["FeeCategoryID"] = DBNull.Value;
		else
		dr["FeeCategoryID"] = FeeCategoryID;
		
		if (FeeCategoryName == null)
		dr["FeeCategoryName"] = DBNull.Value;
		else
		dr["FeeCategoryName"] = FeeCategoryName;
		
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
		FeeCategoryID = dr["FeeCategoryID"] != DBNull.Value ? Convert.ToInt32(dr["FeeCategoryID"]) : FeeCategoryID = null;
		FeeCategoryName = dr["FeeCategoryName"] != DBNull.Value ? Convert.ToString(dr["FeeCategoryName"]) : FeeCategoryName = null;
		CreatedDate = dr["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(dr["CreatedDate"]) : CreatedDate = null;
		IsDelete = dr["IsDelete"] != DBNull.Value ? Convert.ToBoolean(dr["IsDelete"]) : IsDelete = null;
	}
	
	public static TMSFeesCategoryMaster[] MapFrom(DataSet ds)
	{
		List<TMSFeesCategoryMaster> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFeesCategoryMaster>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FeesCategoryMaster] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FeesCategoryMaster] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFeesCategoryMaster instance = new TMSFeesCategoryMaster();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesCategoryMaster Get(System.Int32 feeCategoryID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFeesCategoryMaster instance;
		
		
		instance = new TMSFeesCategoryMaster();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesCategoryMaster_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeCategoryID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFeesCategoryMaster ID:" + feeCategoryID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String feeCategoryName, System.DateTime? createdDate, System.Boolean? isDelete, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesCategoryMaster_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeCategoryName, createdDate, isDelete);
		
		if (transaction == null)
		this.FeeCategoryID = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.FeeCategoryID = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String feeCategoryName, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		Insert(feeCategoryName, createdDate, isDelete, null);
	}
	/// <summary>
	/// Insert current TMSFeesCategoryMaster to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(FeeCategoryName, CreatedDate, IsDelete, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFeesCategoryMaster to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? feeCategoryID, System.String feeCategoryName, System.DateTime? createdDate, System.Boolean? isDelete, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesCategoryMaster_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feeCategoryID"].Value = feeCategoryID;
		dbCommand.Parameters["@feeCategoryName"].Value = feeCategoryName;
		dbCommand.Parameters["@createdDate"].Value = createdDate;
		dbCommand.Parameters["@isDelete"].Value = isDelete;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? feeCategoryID, System.String feeCategoryName, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		Update(feeCategoryID, feeCategoryName, createdDate, isDelete, null);
	}
	
	public static void Update(TMSFeesCategoryMaster tMSFeesCategoryMaster)
	{
		tMSFeesCategoryMaster.Update();
	}
	
	public static void Update(TMSFeesCategoryMaster tMSFeesCategoryMaster, DbTransaction transaction)
	{
		tMSFeesCategoryMaster.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSFeesCategoryMaster_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@feeCategoryID"].SourceColumn = "FeeCategoryID";
		dbCommand.Parameters["@feeCategoryName"].SourceColumn = "FeeCategoryName";
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
	public static void Delete(System.Int32? feeCategoryID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesCategoryMaster_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeCategoryID);
		
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
	public static void Delete(System.Int32? feeCategoryID)
	{
		Delete(
		feeCategoryID);
	}
	
	/// <summary>
	/// Delete current TMSFeesCategoryMaster from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesCategoryMaster_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, FeeCategoryID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.FeeCategoryID = null;
	}
	
	/// <summary>
	/// Delete current TMSFeesCategoryMaster from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesCategoryMaster[] Search(System.Int32? feeCategoryID, System.String feeCategoryName, System.DateTime? createdDate, System.Boolean? isDelete)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesCategoryMaster_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, feeCategoryID, feeCategoryName, createdDate, isDelete);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFeesCategoryMaster.MapFrom(ds);
	}
	
	
	public static TMSFeesCategoryMaster[] Search(TMSFeesCategoryMaster searchObject)
	{
		return Search ( searchObject.FeeCategoryID, searchObject.FeeCategoryName, searchObject.CreatedDate, searchObject.IsDelete);
	}
	
	/// <summary>
	/// Returns all TMSFeesCategoryMaster objects.
	/// </summary>
	/// <returns>List of all TMSFeesCategoryMaster objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFeesCategoryMaster[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

