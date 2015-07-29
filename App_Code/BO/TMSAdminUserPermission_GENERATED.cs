/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 2:53:46 PM                                    */
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
public partial class TMSAdminUserPermission
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AdminUserPermission]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _apId;
	private System.Int32? _apAdminId;
	private System.String _apPermission;
	
	#endregion
	
	
	#region Properties
	public System.Int32? APId
	{
		get
		{
			return _apId;
		}
		set
		{
			_apId = value;
		}
	}
	
	public System.Int32? APAdminId
	{
		get
		{
			return _apAdminId;
		}
		set
		{
			_apAdminId = value;
		}
	}
	
	public System.String APPermission
	{
		get
		{
			return _apPermission;
		}
		set
		{
			_apPermission = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AP_Id", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("AP_AdminId", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("AP_Permission", typeof(System.String) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (APId == null)
		dr["AP_Id"] = DBNull.Value;
		else
		dr["AP_Id"] = APId;
		
		if (APAdminId == null)
		dr["AP_AdminId"] = DBNull.Value;
		else
		dr["AP_AdminId"] = APAdminId;
		
		if (APPermission == null)
		dr["AP_Permission"] = DBNull.Value;
		else
		dr["AP_Permission"] = APPermission;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		APId = dr["AP_Id"] != DBNull.Value ? Convert.ToInt32(dr["AP_Id"]) : APId = null;
		APAdminId = dr["AP_AdminId"] != DBNull.Value ? Convert.ToInt32(dr["AP_AdminId"]) : APAdminId = null;
		APPermission = dr["AP_Permission"] != DBNull.Value ? Convert.ToString(dr["AP_Permission"]) : APPermission = null;
	}
	
	public static TMSAdminUserPermission[] MapFrom(DataSet ds)
	{
		List<TMSAdminUserPermission> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAdminUserPermission>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AdminUserPermission] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AdminUserPermission] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAdminUserPermission instance = new TMSAdminUserPermission();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdminUserPermission Get(System.Int32 apId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAdminUserPermission instance;
		
		
		instance = new TMSAdminUserPermission();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserPermission_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, apId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSAdminUserPermission ID:" + apId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int32? apAdminId, System.String apPermission, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserPermission_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, apAdminId, apPermission);
		
		if (transaction == null)
		this.APId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.APId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int32? apAdminId, System.String apPermission)
	{
		Insert(apAdminId, apPermission, null);
	}
	/// <summary>
	/// Insert current TMSAdminUserPermission to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(APAdminId, APPermission, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAdminUserPermission to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? apId, System.Int32? apAdminId, System.String apPermission, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserPermission_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@apId"].Value = apId;
		dbCommand.Parameters["@apAdminId"].Value = apAdminId;
		dbCommand.Parameters["@apPermission"].Value = apPermission;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? apId, System.Int32? apAdminId, System.String apPermission)
	{
		Update(apId, apAdminId, apPermission, null);
	}
	
	public static void Update(TMSAdminUserPermission tMSAdminUserPermission)
	{
		tMSAdminUserPermission.Update();
	}
	
	public static void Update(TMSAdminUserPermission tMSAdminUserPermission, DbTransaction transaction)
	{
		tMSAdminUserPermission.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSAdminUserPermission_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@apId"].SourceColumn = "AP_Id";
		dbCommand.Parameters["@apAdminId"].SourceColumn = "AP_AdminId";
		dbCommand.Parameters["@apPermission"].SourceColumn = "AP_Permission";
		
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
	public static void Delete(System.Int32? apId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserPermission_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, apId);
		
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
	public static void Delete(System.Int32? apId)
	{
		Delete(
		apId);
	}
	
	/// <summary>
	/// Delete current TMSAdminUserPermission from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserPermission_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, APId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.APId = null;
	}
	
	/// <summary>
	/// Delete current TMSAdminUserPermission from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdminUserPermission[] Search(System.Int32? apId, System.Int32? apAdminId, System.String apPermission)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminUserPermission_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, apId, apAdminId, apPermission);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAdminUserPermission.MapFrom(ds);
	}
	
	
	public static TMSAdminUserPermission[] Search(TMSAdminUserPermission searchObject)
	{
		return Search ( searchObject.APId, searchObject.APAdminId, searchObject.APPermission);
	}
	
	/// <summary>
	/// Returns all TMSAdminUserPermission objects.
	/// </summary>
	/// <returns>List of all TMSAdminUserPermission objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAdminUserPermission[] Search()
	{
		return Search ( null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

