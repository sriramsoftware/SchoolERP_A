/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/12/2012 3:45:53 PM                                    */
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
public partial class TMSSchoolCategory
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SchoolCategory]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _scCategoryId;
	private System.String _scCategoryName;
	private System.String _scSchoolType;
	private System.DateTime? _scDate;
	private System.Int32? _scStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SCCategoryId
	{
		get
		{
			return _scCategoryId;
		}
		set
		{
			_scCategoryId = value;
		}
	}
	
	public System.String SCCategoryName
	{
		get
		{
			return _scCategoryName;
		}
		set
		{
			_scCategoryName = value;
		}
	}
	
	public System.String SCSchoolType
	{
		get
		{
			return _scSchoolType;
		}
		set
		{
			_scSchoolType = value;
		}
	}
	
	public System.DateTime? SCDate
	{
		get
		{
			return _scDate;
		}
		set
		{
			_scDate = value;
		}
	}
	
	public System.Int32? SCStatus
	{
		get
		{
			return _scStatus;
		}
		set
		{
			_scStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SC_CategoryId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SC_CategoryName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SC_SchoolType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SC_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SC_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SCCategoryId == null)
		dr["SC_CategoryId"] = DBNull.Value;
		else
		dr["SC_CategoryId"] = SCCategoryId;
		
		if (SCCategoryName == null)
		dr["SC_CategoryName"] = DBNull.Value;
		else
		dr["SC_CategoryName"] = SCCategoryName;
		
		if (SCSchoolType == null)
		dr["SC_SchoolType"] = DBNull.Value;
		else
		dr["SC_SchoolType"] = SCSchoolType;
		
		if (SCDate == null)
		dr["SC_Date"] = DBNull.Value;
		else
		dr["SC_Date"] = SCDate;
		
		if (SCStatus == null)
		dr["SC_Status"] = DBNull.Value;
		else
		dr["SC_Status"] = SCStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SCCategoryId = dr["SC_CategoryId"] != DBNull.Value ? Convert.ToInt64(dr["SC_CategoryId"]) : SCCategoryId = null;
		SCCategoryName = dr["SC_CategoryName"] != DBNull.Value ? Convert.ToString(dr["SC_CategoryName"]) : SCCategoryName = null;
		SCSchoolType = dr["SC_SchoolType"] != DBNull.Value ? Convert.ToString(dr["SC_SchoolType"]) : SCSchoolType = null;
		SCDate = dr["SC_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SC_Date"]) : SCDate = null;
		SCStatus = dr["SC_Status"] != DBNull.Value ? Convert.ToInt32(dr["SC_Status"]) : SCStatus = null;
	}
	
	public static TMSSchoolCategory[] MapFrom(DataSet ds)
	{
		List<TMSSchoolCategory> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSchoolCategory>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SchoolCategory] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SchoolCategory] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSchoolCategory instance = new TMSSchoolCategory();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSchoolCategory Get(System.Int64 scCategoryId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSchoolCategory instance;
		
		
		instance = new TMSSchoolCategory();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolCategory_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, scCategoryId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSSchoolCategory ID:" + scCategoryId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String scCategoryName, System.String scSchoolType, System.DateTime? scDate, System.Int32? scStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolCategory_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, scCategoryName, scSchoolType, scDate, scStatus);
		
		if (transaction == null)
		this.SCCategoryId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SCCategoryId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String scCategoryName, System.String scSchoolType, System.DateTime? scDate, System.Int32? scStatus)
	{
		Insert(scCategoryName, scSchoolType, scDate, scStatus, null);
	}
	/// <summary>
	/// Insert current TMSSchoolCategory to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SCCategoryName, SCSchoolType, SCDate, SCStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSchoolCategory to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? scCategoryId, System.String scCategoryName, System.String scSchoolType, System.DateTime? scDate, System.Int32? scStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolCategory_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@scCategoryId"].Value = scCategoryId;
		dbCommand.Parameters["@scCategoryName"].Value = scCategoryName;
		dbCommand.Parameters["@scSchoolType"].Value = scSchoolType;
		dbCommand.Parameters["@scDate"].Value = scDate;
		dbCommand.Parameters["@scStatus"].Value = scStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? scCategoryId, System.String scCategoryName, System.String scSchoolType, System.DateTime? scDate, System.Int32? scStatus)
	{
		Update(scCategoryId, scCategoryName, scSchoolType, scDate, scStatus, null);
	}
	
	public static void Update(TMSSchoolCategory tMSSchoolCategory)
	{
		tMSSchoolCategory.Update();
	}
	
	public static void Update(TMSSchoolCategory tMSSchoolCategory, DbTransaction transaction)
	{
		tMSSchoolCategory.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSchoolCategory_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@scCategoryId"].SourceColumn = "SC_CategoryId";
		dbCommand.Parameters["@scCategoryName"].SourceColumn = "SC_CategoryName";
		dbCommand.Parameters["@scSchoolType"].SourceColumn = "SC_SchoolType";
		dbCommand.Parameters["@scDate"].SourceColumn = "SC_Date";
		dbCommand.Parameters["@scStatus"].SourceColumn = "SC_Status";
		
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
	public static void Delete(System.Int64? scCategoryId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolCategory_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, scCategoryId);
		
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
	public static void Delete(System.Int64? scCategoryId)
	{
		Delete(
		scCategoryId);
	}
	
	/// <summary>
	/// Delete current TMSSchoolCategory from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolCategory_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SCCategoryId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SCCategoryId = null;
	}
	
	/// <summary>
	/// Delete current TMSSchoolCategory from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSchoolCategory[] Search(System.Int64? scCategoryId, System.String scCategoryName, System.String scSchoolType, System.DateTime? scDate, System.Int32? scStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSchoolCategory_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, scCategoryId, scCategoryName, scSchoolType, scDate, scStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSchoolCategory.MapFrom(ds);
	}
	
	
	public static TMSSchoolCategory[] Search(TMSSchoolCategory searchObject)
	{
		return Search ( searchObject.SCCategoryId, searchObject.SCCategoryName, searchObject.SCSchoolType, searchObject.SCDate, searchObject.SCStatus);
	}
	
	/// <summary>
	/// Returns all TMSSchoolCategory objects.
	/// </summary>
	/// <returns>List of all TMSSchoolCategory objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSchoolCategory[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

